using BroadWorksConnector.Ocip;
using BroadWorksConnector.Ocip.Models.C;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Validation;

namespace BroadWorksConnector
{
    public interface IOcipClient
    {
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
        Task<UserDetails> LoginAsync(string username, string password, CancellationToken cancellationToken = default);

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
        Task<UserDetails> LoginR22Async(string username, string password, CancellationToken cancellationToken = default);

        /// <summary>
        /// Executes a single OCI command
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ValidationException">Thrown when the given request fails local validation.</exception>
        /// <exception cref="BadResponseException">Thrown when server returns something that isn't expected.</exception>
        /// <exception cref="ErrorResponseException">Thrown when server returns an ErrorResponse object.</exception>
        Task<OCICommand> CallAsync(OCICommand command, CancellationToken cancellationToken = default);

        /// <summary>
        /// Executes multiple OCI commands in a single request
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ValidationException">Thrown when the given request fails local validation.</exception>
        /// <exception cref="BadResponseException">Thrown when server returns something that isn't expected.</exception>
        /// <exception cref="ErrorResponseException">Thrown when server returns an ErrorResponse object.</exception>
        Task<IEnumerable<OCICommand>> CallAllAsync(IEnumerable<OCICommand> commands, CancellationToken cancellationToken = default);
    }
}
