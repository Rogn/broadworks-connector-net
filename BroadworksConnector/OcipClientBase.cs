using BroadWorksConnector.Ocip;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;
using BroadWorksConnector.Ocip.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BroadWorksConnector
{
    public abstract class OcipClientBase : IOcipClient
    {
        public UserDetails UserDetails { get; protected set; }

        private string _sessionId;

        private readonly Serializer _serializer;

        public OcipClientBase()
        {
            _serializer = new Serializer(typeof(AccessDevice).Namespace);
        }

        /// <summary>
        /// Logs into OCI-P using the given credentials. This must be done before any other calls can be made.
        /// </summary>
        /// <remarks>If using BroadWorks R22 or greater, use LoginR22Async.</remarks>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="BadResponseException">Thrown when server returns something that isn't expected.</exception>
        /// <exception cref="ErrorResponseException">Thrown when server returns an ErrorResponse object.</exception>
        public async Task<UserDetails> LoginAsync(string username, string password, CancellationToken cancellationToken = default)
        {
            _sessionId = GenerateSessionId();

            // The legacy login method is a two-part process.
            // An authentication request is made by passing the username, it receives a nonce value back.
            // The nonce is appended to a SHA1 hash of the user's password, which is then MD5 hashed and sent back to the server.

            var authRequest = new AuthenticationRequest
            {
                UserId = username
            };

            var authResponse = (await ExecuteCommandAsync(authRequest, cancellationToken).ConfigureAwait(false)).First() as AuthenticationResponse;

            string signedPassword = null;

            if (authResponse.PasswordAlgorithm == DigitalSignatureAlgorithm.MD5)
            {
                signedPassword = Md5($"{authResponse.Nonce}:{Sha1(password)}");
            }
            else
            {
                throw new NotSupportedException("Only MD5 supported for signing");
            }

            // Release 14sp4 if the default login method unless R22 is specified
            var loginRequest = new LoginRequest14sp4
            {
                UserId = username,
                SignedPassword = signedPassword
            };

            var loginResponse = (await ExecuteCommandAsync(loginRequest, cancellationToken).ConfigureAwait(false)).First() as LoginResponse14sp4;

            UserDetails = new UserDetails
            {
                LoginType = loginResponse.LoginType.ToString(),
                Locale = loginResponse.Locale,
                Encoding = loginResponse.Encoding,
                GroupId = loginResponse.GroupId,
                ServiceProviderId = loginResponse.ServiceProviderId,
                IsEnterprise = loginResponse.IsEnterprise,
                PasswordExpiresDays = loginResponse.PasswordExpiresDays,
                UserDomain = loginResponse.UserDomain
            };

            return UserDetails;
        }

        /// <summary>
        /// Logs into OCI-P using the given credentials. This must be done before any other calls can be made.
        /// </summary>
        /// <remarks>Use this method if targeting BroadWorks R22 or greater.</remarks>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="BadResponseException">Thrown when server returns something that isn't expected.</exception>
        /// <exception cref="ErrorResponseException">Thrown when server returns an ErrorResponse object.</exception>
        public async Task<UserDetails> LoginR22Async(string username, string password, CancellationToken cancellationToken = default)
        {
            // Release 22 login will return reseller information if logging in as a reseller
            var loginRequest = new LoginRequest22V2
            {
                UserId = username,
                Password = password
            };

            var loginResponse = (await ExecuteCommandAsync(loginRequest, cancellationToken).ConfigureAwait(false)).First() as LoginResponse22V2;

            UserDetails = new UserDetails
            {
                LoginType = loginResponse.LoginType.ToString(),
                Locale = loginResponse.Locale,
                Encoding = loginResponse.Encoding,
                GroupId = loginResponse.GroupId,
                ServiceProviderId = loginResponse.ServiceProviderId,
                IsEnterprise = loginResponse.IsEnterprise,
                PasswordExpiresDays = loginResponse.PasswordExpiresDays,
                UserDomain = loginResponse.UserDomain,
                ResellerId = loginResponse.ResellerId
            };

            return UserDetails;
        }

        /// <summary>
        /// Executes a single OCI command
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ValidationException">Thrown when the given request fails local validation.</exception>
        /// <exception cref="BadResponseException">Thrown when server returns something that isn't expected.</exception>
        /// <exception cref="ErrorResponseException">Thrown when server returns an ErrorResponse object.</exception>
        public async Task<OCICommand> CallAsync(OCICommand command, CancellationToken cancellationToken = default)
        {
            var responses = await ExecuteCommandAsync(command, cancellationToken).ConfigureAwait(false);

            return responses.First();
        }

        /// <summary>
        /// Executes multiple OCI commands in a single request
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ValidationException">Thrown when the given request fails local validation.</exception>
        /// <exception cref="BadResponseException">Thrown when server returns something that isn't expected.</exception>
        /// <exception cref="ErrorResponseException">Thrown when server returns an ErrorResponse object.</exception>
        public async Task<IEnumerable<OCICommand>> CallAllAsync(IEnumerable<OCICommand> commands, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandsAsync(commands, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Serializes the given list of commands to XML
        /// </summary>
        /// <param name="commands"></param>
        /// <returns></returns>
        public string SerializeCommands(IEnumerable<OCICommand> commands)
        {
            // All requests are wrapped in a BroadsoftDocument 
            var broadsoftDocument = new BroadsoftDocument
            {
                SessionId = _sessionId,
                Protocol = "OCI",
                Command = commands.ToList()
            };

            return _serializer.Serialize(broadsoftDocument);
        }

        /// <summary>
        /// Execute a single command
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ValidationException">Thrown when the given request fails local validation.</exception>
        /// <exception cref="BadResponseException">Thrown when server returns something that isn't expected.</exception>
        /// <exception cref="ErrorResponseException">Thrown when server returns an ErrorResponse object.</exception>
        private Task<IEnumerable<OCICommand>> ExecuteCommandAsync(OCICommand command, CancellationToken cancellationToken = default)
        {
            return ExecuteCommandsAsync(new List<OCICommand> { command }, cancellationToken);
        }

        /// <summary>
        /// Executes multiple commands
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="ValidationException">Thrown when the given request fails local validation.</exception>
        /// <exception cref="BadResponseException">Thrown when server returns something that isn't expected.</exception>
        /// <exception cref="ErrorResponseException">Thrown when server returns an ErrorResponse object.</exception>
        /// <returns></returns>
        private async Task<IEnumerable<OCICommand>> ExecuteCommandsAsync(IEnumerable<OCICommand> commands, CancellationToken cancellationToken = default)
        {
            ValidateCommands(commands);

            var xml = SerializeCommands(commands);
            BroadsoftDocument response = null;

            var responseXml = await TransportSendAsync(xml, cancellationToken).ConfigureAwait(false);

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

        protected abstract Task<string> TransportSendAsync(string request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Validates a list of commands
        /// </summary>
        /// <param name="commands"></param>
        /// <exception cref="ValidationException">Thrown when any of the given commands fail local validation.</exception>
        private void ValidateCommands(IEnumerable<OCICommand> commands)
        {
            foreach (var command in commands)
            {
                var validationResult = Validator.Validate(command);

                if (!validationResult.Success)
                {
                    var message = validationResult.Errors.Count() == 1
                        ? validationResult.Errors.Single().Message
                        : "Multiple validation errors found";

                    throw new ValidationException(message, validationResult.Errors);
                }
            }
        }

        /// <summary>
        /// All sessions require a session ID to be generated. This is created once and used for all requests.
        /// </summary>
        /// <returns></returns>
        private string GenerateSessionId()
        {
            // Session ID will be a SHA2 hash using a GUID and the hashcode for this instance
            var sha256 = new SHA256Managed();
            var guid = Guid.NewGuid().ToString();
            var hashCode = GetHashCode();

            var input = $"{guid}:{hashCode}";
            var inputBytes = Encoding.ASCII.GetBytes(input);

            var computedHash = sha256.ComputeHash(inputBytes);

            return string.Concat(computedHash.Select(b => b.ToString("x2")));
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
    }
}
