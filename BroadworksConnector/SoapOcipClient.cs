using BroadWorksConnector.Ocip;
using BroadWorksConnector.Ocip.Soap;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BroadWorksConnector
{
    public class SoapOcipClient : OcipClientBase
    {
        private readonly BWProvisioningServiceClient _client;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        public SoapOcipClient(Uri uri)
        {
            _client = new BWProvisioningServiceClient(BWProvisioningServiceClient.EndpointConfiguration.ProvisioningService, uri.ToString());
        }

        protected override async Task<string> TransportSendAsync(string request, CancellationToken cancellationToken = default)
        {
            processOCIMessageResponse response = null;

            if (!cancellationToken.IsCancellationRequested)
            {
                using (var ctr = cancellationToken.Register(() =>
                {
                    _client.Abort();

                    cancellationToken.ThrowIfCancellationRequested();
                }))
                {
                    response = await _client.processOCIMessageAsync(request).ConfigureAwait(false);

                    if (response.Body?.processOCIMessageReturn == null)
                    {
                        throw new BadResponseException("No processOCIMessageReturn in SOAP response");
                    }

                }
            }
            else
            {
                cancellationToken.ThrowIfCancellationRequested();
            }

            return response?.Body?.processOCIMessageReturn;
        }
    }
}
