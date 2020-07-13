using BroadWorksConnector.Ocip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BroadWorksConnector
{
    public class TcpOcipClient : OcipClientBase
    {
        private string _host;

        private int _port;

        private bool _useTls;

        private TcpClient _tcpClient;

        private Stream _stream;

        /// <summary>
        /// Connects via a TCP socket. Defaults to using TLS.
        /// </summary>
        /// <param name="host">Host name to connect to</param>
        /// <param name="port">Port to connect to. Defaults to 2209 which is the default port for TLS</param>
        /// <param name="useTls">Use TLS for the connection. Defaults to true and is highly recommended.</param>
        public TcpOcipClient(string host, int port = 2209, bool useTls = true)
        {
            _host = host;
            _port = port;
            _useTls = useTls;
        }

        protected override async Task<string> TransportSendAsync(string request, CancellationToken cancellationToken = default)
        {
            var stream = await AttemptConnectAsync();

            var response = "";
            var requestData = Encoding.UTF8.GetBytes(request);

            var responseData = new List<byte>();
            var responseBuffer = new byte[1024];

            await _stream.WriteAsync(requestData, 0, requestData.Length, cancellationToken).ConfigureAwait(false);

            try
            {
                int bytesRead = -1;

                do
                {
                    // Clear out response buffer for each read so there's no hanging data from the previous read
                    bytesRead = await stream.ReadAsync(responseBuffer, 0, responseBuffer.Length, cancellationToken).ConfigureAwait(false);

                    // Append buffer contents to full response
                    responseData.AddRange(responseBuffer.Take(bytesRead));

                    // Read the full response as a UTF8 string

                    response = Encoding.UTF8.GetString(responseData.ToArray());

                    // Once the response contains the ending tag, return it
                    if (response.Contains("</BroadsoftDocument>\n"))
                    {
                        break;
                    }
                } while (bytesRead != 0);
            }
            catch (Exception e) when (!(e is OperationCanceledException))   // Allow exceptions caused by cancellationToken to fall through 
            {
                throw new BadResponseException("Unable to parse response", e);
            }

            return response;
        }

        private async Task<Stream> AttemptConnectAsync()
        {
            // Connect to host
            if (_tcpClient == null)
            {
                _tcpClient = new TcpClient(_host, _port);

                if (_useTls)
                {
                    _stream = new SslStream(_tcpClient.GetStream());
                    await(_stream as SslStream).AuthenticateAsClientAsync(_host).ConfigureAwait(false);
                }
                else
                {
                    _stream = _tcpClient.GetStream();
                }
            }

            return _stream;
        }
    }
}
