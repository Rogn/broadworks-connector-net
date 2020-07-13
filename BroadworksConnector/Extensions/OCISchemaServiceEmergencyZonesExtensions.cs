using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceEmergencyZonesExtensions
    {

        /// <summary>
        /// Add a list of home zones and/or home zone ranges to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesAddHomeZoneListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEmergencyZonesAddHomeZoneListRequest(this OcipClientBase client, GroupEmergencyZonesAddHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of home zones and/or home zone ranges to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEmergencyZonesAddHomeZoneListRequestAsync(this OcipClientBase client, GroupEmergencyZonesAddHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of home zones and/or home zone ranges to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesDeleteHomeZoneListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEmergencyZonesDeleteHomeZoneListRequest(this OcipClientBase client, GroupEmergencyZonesDeleteHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of home zones and/or home zone ranges to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEmergencyZonesDeleteHomeZoneListRequestAsync(this OcipClientBase client, GroupEmergencyZonesDeleteHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the group level data associated with Emergency Zones.
        /// The response is either a GroupEmergencyZonesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesGetHomeZoneListRequestAsync instead.")]
        public static async Task<GroupEmergencyZonesGetResponse> GroupEmergencyZonesGetHomeZoneListRequest(this OcipClientBase client, GroupEmergencyZonesGetHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEmergencyZonesGetResponse;
        }

        /// <summary>
        /// Request the group level data associated with Emergency Zones.
        /// The response is either a GroupEmergencyZonesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEmergencyZonesGetResponse> GroupEmergencyZonesGetHomeZoneListRequestAsync(this OcipClientBase client, GroupEmergencyZonesGetHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEmergencyZonesGetResponse;
        }
        /// <summary>
        /// Request the group level data associated with Emergency Zones.
        /// The response is either a GroupEmergencyZonesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesGetRequestAsync instead.")]
        public static async Task<GroupEmergencyZonesGetResponse> GroupEmergencyZonesGetRequest(this OcipClientBase client, GroupEmergencyZonesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEmergencyZonesGetResponse;
        }

        /// <summary>
        /// Request the group level data associated with Emergency Zones.
        /// The response is either a GroupEmergencyZonesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEmergencyZonesGetResponse> GroupEmergencyZonesGetRequestAsync(this OcipClientBase client, GroupEmergencyZonesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEmergencyZonesGetResponse;
        }
        /// <summary>
        /// Modify a list of home zones and/or home zone ranges.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesModifyHomeZoneListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEmergencyZonesModifyHomeZoneListRequest(this OcipClientBase client, GroupEmergencyZonesModifyHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a list of home zones and/or home zone ranges.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEmergencyZonesModifyHomeZoneListRequestAsync(this OcipClientBase client, GroupEmergencyZonesModifyHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the group level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEmergencyZonesModifyRequest(this OcipClientBase client, GroupEmergencyZonesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEmergencyZonesModifyRequestAsync(this OcipClientBase client, GroupEmergencyZonesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the reseller level data associated with Emergency Zones.
        /// The response is either a ResellerEmergencyZonesGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerEmergencyZonesGetRequestAsync instead.")]
        public static async Task<ResellerEmergencyZonesGetResponse> ResellerEmergencyZonesGetRequest(this OcipClientBase client, ResellerEmergencyZonesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerEmergencyZonesGetResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Emergency Zones.
        /// The response is either a ResellerEmergencyZonesGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ResellerEmergencyZonesGetResponse> ResellerEmergencyZonesGetRequestAsync(this OcipClientBase client, ResellerEmergencyZonesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerEmergencyZonesGetResponse;
        }
        /// <summary>
        /// Modify the reseller level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerEmergencyZonesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerEmergencyZonesModifyRequest(this OcipClientBase client, ResellerEmergencyZonesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerEmergencyZonesModifyRequestAsync(this OcipClientBase client, ResellerEmergencyZonesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Emergency Zones.
        /// The response is either a SystemEmergencyZonesGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyZonesGetRequestAsync instead.")]
        public static async Task<SystemEmergencyZonesGetResponse> SystemEmergencyZonesGetRequest(this OcipClientBase client, SystemEmergencyZonesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEmergencyZonesGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Emergency Zones.
        /// The response is either a SystemEmergencyZonesGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemEmergencyZonesGetResponse> SystemEmergencyZonesGetRequestAsync(this OcipClientBase client, SystemEmergencyZonesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEmergencyZonesGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyZonesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemEmergencyZonesModifyRequest(this OcipClientBase client, SystemEmergencyZonesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemEmergencyZonesModifyRequestAsync(this OcipClientBase client, SystemEmergencyZonesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
