using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSecurityClassificationExtensions
    {

        /// <summary>
        /// Get a trunk group's Security Classifications configuration.
        /// The response is either GroupTrunkGroupSecurityClassificationGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupSecurityClassificationGetRequestAsync instead.")]
        public static async Task<GroupTrunkGroupSecurityClassificationGetResponse> GroupTrunkGroupSecurityClassificationGetRequest(this OcipClientBase client, GroupTrunkGroupSecurityClassificationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupSecurityClassificationGetResponse;
        }

        /// <summary>
        /// Get a trunk group's Security Classifications configuration.
        /// The response is either GroupTrunkGroupSecurityClassificationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupSecurityClassificationGetResponse> GroupTrunkGroupSecurityClassificationGetRequestAsync(this OcipClientBase client, GroupTrunkGroupSecurityClassificationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupSecurityClassificationGetResponse;
        }
        /// <summary>
        /// Modify a trunk group's Security Classification configuration
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupSecurityClassificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupSecurityClassificationModifyRequest(this OcipClientBase client, GroupTrunkGroupSecurityClassificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a trunk group's Security Classification configuration
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupSecurityClassificationModifyRequestAsync(this OcipClientBase client, GroupTrunkGroupSecurityClassificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Security Classification
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSecurityClassificationAddClassificationRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSecurityClassificationAddClassificationRequest(this OcipClientBase client, SystemSecurityClassificationAddClassificationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Security Classification
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSecurityClassificationAddClassificationRequestAsync(this OcipClientBase client, SystemSecurityClassificationAddClassificationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a System Security Classification
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSecurityClassificationDeleteClassificationRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSecurityClassificationDeleteClassificationRequest(this OcipClientBase client, SystemSecurityClassificationDeleteClassificationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a System Security Classification
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSecurityClassificationDeleteClassificationRequestAsync(this OcipClientBase client, SystemSecurityClassificationDeleteClassificationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a system Security Classification.
        /// The response is either SystemSecurityClassificationGetClassificationResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSecurityClassificationGetClassificationRequestAsync instead.")]
        public static async Task<SystemSecurityClassificationGetClassificationResponse> SystemSecurityClassificationGetClassificationRequest(this OcipClientBase client, SystemSecurityClassificationGetClassificationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSecurityClassificationGetClassificationResponse;
        }

        /// <summary>
        /// Get a system Security Classification.
        /// The response is either SystemSecurityClassificationGetClassificationResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSecurityClassificationGetClassificationResponse> SystemSecurityClassificationGetClassificationRequestAsync(this OcipClientBase client, SystemSecurityClassificationGetClassificationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSecurityClassificationGetClassificationResponse;
        }
        /// <summary>
        /// Get a list of users that currently have the specified Security Classification assigned.
        /// The response is either SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSecurityClassificationGetClassificationTrunkGroupUsageListRequestAsync instead.")]
        public static async Task<SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse> SystemSecurityClassificationGetClassificationTrunkGroupUsageListRequest(this OcipClientBase client, SystemSecurityClassificationGetClassificationTrunkGroupUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse;
        }

        /// <summary>
        /// Get a list of users that currently have the specified Security Classification assigned.
        /// The response is either SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse> SystemSecurityClassificationGetClassificationTrunkGroupUsageListRequestAsync(this OcipClientBase client, SystemSecurityClassificationGetClassificationTrunkGroupUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse;
        }
        /// <summary>
        /// Get a list of users that currently have the specified Security Classification assigned.
        /// The response is either SystemSecurityClassificationGetClassificationUserUsageListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSecurityClassificationGetClassificationUserUsageListRequestAsync instead.")]
        public static async Task<SystemSecurityClassificationGetClassificationUserUsageListResponse> SystemSecurityClassificationGetClassificationUserUsageListRequest(this OcipClientBase client, SystemSecurityClassificationGetClassificationUserUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSecurityClassificationGetClassificationUserUsageListResponse;
        }

        /// <summary>
        /// Get a list of users that currently have the specified Security Classification assigned.
        /// The response is either SystemSecurityClassificationGetClassificationUserUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSecurityClassificationGetClassificationUserUsageListResponse> SystemSecurityClassificationGetClassificationUserUsageListRequestAsync(this OcipClientBase client, SystemSecurityClassificationGetClassificationUserUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSecurityClassificationGetClassificationUserUsageListResponse;
        }
        /// <summary>
        /// Get system Security Classifications parameters.
        /// The response is either SystemSecurityClassificationGetResponse21 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSecurityClassificationGetRequest21Async instead.")]
        public static async Task<SystemSecurityClassificationGetResponse21> SystemSecurityClassificationGetRequest21(this OcipClientBase client, SystemSecurityClassificationGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSecurityClassificationGetResponse21;
        }

        /// <summary>
        /// Get system Security Classifications parameters.
        /// The response is either SystemSecurityClassificationGetResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSecurityClassificationGetResponse21> SystemSecurityClassificationGetRequest21Async(this OcipClientBase client, SystemSecurityClassificationGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSecurityClassificationGetResponse21;
        }
        /// <summary>
        /// Modify a Security Classification
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSecurityClassificationModifyClassificationRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSecurityClassificationModifyClassificationRequest(this OcipClientBase client, SystemSecurityClassificationModifyClassificationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Security Classification
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSecurityClassificationModifyClassificationRequestAsync(this OcipClientBase client, SystemSecurityClassificationModifyClassificationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify security classification parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// NOTE: The security classifications must be specified in order of priority. The command fails if all the security classifications defined for the system are not provided.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSecurityClassificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSecurityClassificationModifyRequest(this OcipClientBase client, SystemSecurityClassificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify security classification parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// NOTE: The security classifications must be specified in order of priority. The command fails if all the security classifications defined for the system are not provided.
        /// </summary>
        public static async Task<SuccessResponse> SystemSecurityClassificationModifyRequestAsync(this OcipClientBase client, SystemSecurityClassificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a user's Security Classifications configuration.
        /// The response is either UserSecurityClassificationGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSecurityClassificationGetRequest22Async instead.")]
        public static async Task<UserSecurityClassificationGetResponse22> UserSecurityClassificationGetRequest22(this OcipClientBase client, UserSecurityClassificationGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSecurityClassificationGetResponse22;
        }

        /// <summary>
        /// Get a user's Security Classifications configuration.
        /// The response is either UserSecurityClassificationGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<UserSecurityClassificationGetResponse22> UserSecurityClassificationGetRequest22Async(this OcipClientBase client, UserSecurityClassificationGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSecurityClassificationGetResponse22;
        }
        /// <summary>
        /// Modify a user's Security Classification configuration
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSecurityClassificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSecurityClassificationModifyRequest(this OcipClientBase client, UserSecurityClassificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a user's Security Classification configuration
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSecurityClassificationModifyRequestAsync(this OcipClientBase client, UserSecurityClassificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
