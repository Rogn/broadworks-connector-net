using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceBusyLampFieldExtensions
    {

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse18 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBusyLampFieldGetRequest18Async instead.")]
        public static async Task<SystemBusyLampFieldGetResponse18> SystemBusyLampFieldGetRequest18(this OcipClientBase client, SystemBusyLampFieldGetRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBusyLampFieldGetResponse18;
        }

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse18 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemBusyLampFieldGetResponse18> SystemBusyLampFieldGetRequest18Async(this OcipClientBase client, SystemBusyLampFieldGetRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBusyLampFieldGetResponse18;
        }
        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse23 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBusyLampFieldGetRequest23Async instead.")]
        public static async Task<SystemBusyLampFieldGetResponse23> SystemBusyLampFieldGetRequest23(this OcipClientBase client, SystemBusyLampFieldGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBusyLampFieldGetResponse23;
        }

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse23 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemBusyLampFieldGetResponse23> SystemBusyLampFieldGetRequest23Async(this OcipClientBase client, SystemBusyLampFieldGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBusyLampFieldGetResponse23;
        }
        /// <summary>
        /// Modify the system level data associated with the Busy Lamp Field
        /// Service. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// forceUseOfTCP
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
        /// enableRedundancy
        /// redundancyTaskDelayMilliseconds
        /// redundancyTaskIntervalMilliseconds
        /// maxNumberOfSubscriptionsPerRedundancyTaskInterval
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBusyLampFieldModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBusyLampFieldModifyRequest(this OcipClientBase client, SystemBusyLampFieldModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with the Busy Lamp Field
        /// Service. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// forceUseOfTCP
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
        /// enableRedundancy
        /// redundancyTaskDelayMilliseconds
        /// redundancyTaskIntervalMilliseconds
        /// maxNumberOfSubscriptionsPerRedundancyTaskInterval
        /// </summary>
        public static async Task<SuccessResponse> SystemBusyLampFieldModifyRequestAsync(this OcipClientBase client, SystemBusyLampFieldModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of available users for the busy lamp field service.
        /// The response is either UserBusyLampFieldGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBusyLampFieldGetAvailableUserListRequestAsync instead.")]
        public static async Task<UserBusyLampFieldGetAvailableUserListResponse> UserBusyLampFieldGetAvailableUserListRequest(this OcipClientBase client, UserBusyLampFieldGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBusyLampFieldGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of available users for the busy lamp field service.
        /// The response is either UserBusyLampFieldGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserBusyLampFieldGetAvailableUserListResponse> UserBusyLampFieldGetAvailableUserListRequestAsync(this OcipClientBase client, UserBusyLampFieldGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBusyLampFieldGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request the settings for the busy lamp field service.
        /// The response is either a UserBusyLampFieldGetResponse16sp2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBusyLampFieldGetRequest16sp2Async instead.")]
        public static async Task<UserBusyLampFieldGetResponse16sp2> UserBusyLampFieldGetRequest16sp2(this OcipClientBase client, UserBusyLampFieldGetRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBusyLampFieldGetResponse16sp2;
        }

        /// <summary>
        /// Request the settings for the busy lamp field service.
        /// The response is either a UserBusyLampFieldGetResponse16sp2 or an ErrorResponse.
        /// </summary>
        public static async Task<UserBusyLampFieldGetResponse16sp2> UserBusyLampFieldGetRequest16sp2Async(this OcipClientBase client, UserBusyLampFieldGetRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBusyLampFieldGetResponse16sp2;
        }
        /// <summary>
        /// Modify the settings for the busy lamp field service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBusyLampFieldModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBusyLampFieldModifyRequest(this OcipClientBase client, UserBusyLampFieldModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the settings for the busy lamp field service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBusyLampFieldModifyRequestAsync(this OcipClientBase client, UserBusyLampFieldModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
