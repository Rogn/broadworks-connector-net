﻿using BroadWorksConnector.Ocip;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BroadWorksConnector
{
    /// <summary>
    /// Client for communicating with BroadWorks OCI-P
    /// </summary>
    public class OcipClient : IDisposable
    {
        private readonly string _username;

        private readonly string _password;

        private readonly string _sessionId;

        public ITransport Transport { get; private set; }

        private readonly Serializer _serializer;

        public UserDetails UserDetails { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public OcipClient(string url, string username, string password)
        {
            _username = username;
            _password = password;
            _sessionId = GenerateSessionId();
            _serializer = new Serializer();

            var uri = new Uri(url);

            switch (uri.Scheme)
            {
                case "http":
                case "https":
                    Transport = new SoapTransport(uri);
                    break;
                case "tcp":
                    Transport = new TcpTransport(uri.Host, uri.Port > -1 ? uri.Port : 2208);
                    break;
                case "ssl":
                case "sslv2":
                case "sslv3":
                case "tls":
                    Transport = new TcpTransport(uri.Host, uri.Port > -1 ? uri.Port : 2209, true);
                    break;
                default:
                    throw new ArgumentException("Unsupported protocol", nameof(url));
            }
        }

        /// <summary>
        /// Executes a single Request
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public async Task<OCICommand> Call(OCICommand command)
        {
            if (UserDetails == null)
            {
                await Login();
            }

            var responses = await ExecuteCommands(new List<OCICommand> { command });

            return responses.First();
        }

        /// <summary>
        /// Executes multiple commands in a single request
        /// </summary>
        /// <param name="commands"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OCICommand>> CallAll(IEnumerable<OCICommand> commands)
        {
            if (UserDetails == null)
            {
                await Login();
            }

            return await ExecuteCommands(commands);
        }

        /// <summary>
        /// All sessions require a session ID to be generated. This is created once and used for all requests.
        /// </summary>
        /// <returns></returns>
        private string GenerateSessionId()
        {
            var sha256 = new SHA256Managed();
            var ticks = DateTime.Now.Ticks.ToString();
            var bytes = Encoding.ASCII.GetBytes(ticks);

            return ticks.ToString();
        }

        /// <summary>
        /// Authenticates against OCI-P using the provided username and password
        /// </summary>
        /// <returns></returns>
        public async Task<UserDetails> Login()
        {
            if (UserDetails == null)
            {
                var authRequest = new AuthenticationRequest
                {
                    UserId = _username
                };

                try
                {
                    var authResponse = (await ExecuteCommands(new List<OCICommand>() { authRequest })).First() as AuthenticationResponse;
                    string signedPassword = null;

                    if (authResponse.PasswordAlgorithm == DigitalSignatureAlgorithm.MD5)
                    {
                        signedPassword = Md5($"{authResponse.Nonce}:{Sha1(_password)}");
                    }
                    else
                    {
                        throw new LoginException("Only MD5 supported for signing");
                    }

                    // TODO: R22 support
                    var loginRequest = new LoginRequest14sp4
                    {
                        UserId = _username,
                        SignedPassword = signedPassword
                    };

                    var loginResponse = (await ExecuteCommands(new List<OCICommand>() { loginRequest })).First() as LoginResponse14sp4;

                    // TODO: set R22 properties
                    UserDetails = new UserDetails
                    {
                        LoginType = loginResponse.LoginType,
                        Locale = loginResponse.Locale,
                        Encoding = loginResponse.Encoding,
                        GroupId = loginResponse.GroupId,
                        ServiceProviderId = loginResponse.ServiceProviderId,
                        IsEnterprise = loginResponse.IsEnterprise,
                        PasswordExpiresDays = loginResponse.PasswordExpiresDays,
                        UserDomain = loginResponse.UserDomain
                    };
                }
                catch (ErrorResponseException e)
                {
                    throw new LoginException(e.Message, e);
                }
            }

            return UserDetails;
        }

        /// <summary>
        /// Serializes the given list of commands to XML
        /// </summary>
        /// <param name="commands"></param>
        /// <returns></returns>
        public string SerializeCommands(IEnumerable<OCICommand> commands)
        {

            var broadsoftDocument = new BroadsoftDocument
            {
                SessionId = _sessionId,
                Protocol = "OCI",
                Command = commands.ToList()
            };

            return _serializer.Serialize(broadsoftDocument);
        }

        /// <summary>
        /// Executes multiple commands
        /// </summary>
        /// <param name="commands"></param>
        /// <exception cref="BadResponseException">Thrown when server returns something that isn't expected.</exception>
        /// <exception cref="ErrorResponseException">Thrown when server returns an ErrorResponse object.</exception>
        /// <returns></returns>
        private async Task<IEnumerable<OCICommand>> ExecuteCommands(IEnumerable<OCICommand> commands)
        {
            // TODO: validate commands

            var xml = SerializeCommands(commands);
            BroadsoftDocument response = null;

            var responseXml = await Transport.Send(xml);

            try
            {
                response = _serializer.Deserialize(responseXml);
            }
            catch (Exception e)
            {
                throw new BadResponseException("Unable to deserialize response.", e);
            }

            if (!(response is BroadsoftDocument))
            {
                throw new BadResponseException("Response did not include a BroadsoftDocument element.");
            }

            if (response.Command.Count == 0)
            {
                throw new BadResponseException("Response does not include any commands.");
            }

            foreach (var command in response.Command)
            {
                if (command is ErrorResponse)
                {
                    throw new ErrorResponseException(command as ErrorResponse);
                }
            }

            return response.Command;
        }


        /// <summary>
        /// Calculates the MD5 hash of a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string Md5(string input)
        {
            MD5 md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

        /// <summary>
        /// Calculates the SHA1 hash of a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string Sha1(string input)
        {
            SHA1Managed sha1 = new SHA1Managed();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));

            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

        public void Dispose()
        {
            if (Transport != null)
            {
                Transport.Dispose();
            }
        }
    }
}
