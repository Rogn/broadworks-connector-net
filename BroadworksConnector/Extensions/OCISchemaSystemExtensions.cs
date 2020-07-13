using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaSystemExtensions
    {

        /// <summary>
        /// Request to add a system-level access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceAddRequest(this OcipClientBase client, SystemAccessDeviceAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system-level access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceAddRequestAsync(this OcipClientBase client, SystemAccessDeviceAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a static configuration tag for a system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceCustomTagAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagAddRequest(this OcipClientBase client, SystemAccessDeviceCustomTagAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag for a system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagAddRequestAsync(this OcipClientBase client, SystemAccessDeviceCustomTagAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete static configuration tags for a system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceCustomTagDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagDeleteListRequest(this OcipClientBase client, SystemAccessDeviceCustomTagDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete static configuration tags for a system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagDeleteListRequestAsync(this OcipClientBase client, SystemAccessDeviceCustomTagDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either SystemAccessDeviceCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceCustomTagGetListRequestAsync instead.")]
        public static async Task<SystemAccessDeviceCustomTagGetListResponse> SystemAccessDeviceCustomTagGetListRequest(this OcipClientBase client, SystemAccessDeviceCustomTagGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceCustomTagGetListResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either SystemAccessDeviceCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceCustomTagGetListResponse> SystemAccessDeviceCustomTagGetListRequestAsync(this OcipClientBase client, SystemAccessDeviceCustomTagGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceCustomTagGetListResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag for a system access device.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceCustomTagModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagModifyRequest(this OcipClientBase client, SystemAccessDeviceCustomTagModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag for a system access device.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagModifyRequestAsync(this OcipClientBase client, SystemAccessDeviceCustomTagModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a specified system access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceDeleteRequest(this OcipClientBase client, SystemAccessDeviceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a specified system access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceDeleteRequestAsync(this OcipClientBase client, SystemAccessDeviceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile basis.
        /// The response is either SystemAccessDeviceFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceFileGetListRequest14sp8Async instead.")]
        public static async Task<SystemAccessDeviceFileGetListResponse14sp8> SystemAccessDeviceFileGetListRequest14sp8(this OcipClientBase client, SystemAccessDeviceFileGetListRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceFileGetListResponse14sp8;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile basis.
        /// The response is either SystemAccessDeviceFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceFileGetListResponse14sp8> SystemAccessDeviceFileGetListRequest14sp8Async(this OcipClientBase client, SystemAccessDeviceFileGetListRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceFileGetListResponse14sp8;
        }
        /// <summary>
        /// Request to get a device profile file.
        /// The response is either SystemAccessDeviceFileGetResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceFileGetRequest20Async instead.")]
        public static async Task<SystemAccessDeviceFileGetResponse20> SystemAccessDeviceFileGetRequest20(this OcipClientBase client, SystemAccessDeviceFileGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceFileGetResponse20;
        }

        /// <summary>
        /// Request to get a device profile file.
        /// The response is either SystemAccessDeviceFileGetResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceFileGetResponse20> SystemAccessDeviceFileGetRequest20Async(this OcipClientBase client, SystemAccessDeviceFileGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceFileGetResponse20;
        }
        /// <summary>
        /// Request to modify a specified system access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceFileModifyRequest14sp8Async instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceFileModifyRequest14sp8(this OcipClientBase client, SystemAccessDeviceFileModifyRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified system access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceFileModifyRequest14sp8Async(this OcipClientBase client, SystemAccessDeviceFileModifyRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of all access devices in the entire system.
        /// Prior to release 14, this functionality was provided with the SystemAccessDeviceGetListRequest14.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the device
        /// profiles in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemAccessDeviceGetAllResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetAllRequestAsync instead.")]
        public static async Task<SystemAccessDeviceGetAllResponse> SystemAccessDeviceGetAllRequest(this OcipClientBase client, SystemAccessDeviceGetAllRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetAllResponse;
        }

        /// <summary>
        /// Requests the list of all access devices in the entire system.
        /// Prior to release 14, this functionality was provided with the SystemAccessDeviceGetListRequest14.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the device
        /// profiles in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemAccessDeviceGetAllResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<SystemAccessDeviceGetAllResponse> SystemAccessDeviceGetAllRequestAsync(this OcipClientBase client, SystemAccessDeviceGetAllRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetAllResponse;
        }
        /// <summary>
        /// Requests the list of access devices defined at the System-level.
        /// Prior to release 14, this command requested a list of all devices in the entire system. That
        /// functionality is now moved to the SystemAccessDeviceGetAllRequest.
        /// The response is either SystemAccessDeviceGetListResponse14 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetListRequest14Async instead.")]
        public static async Task<SystemAccessDeviceGetListResponse14> SystemAccessDeviceGetListRequest14(this OcipClientBase client, SystemAccessDeviceGetListRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetListResponse14;
        }

        /// <summary>
        /// Requests the list of access devices defined at the System-level.
        /// Prior to release 14, this command requested a list of all devices in the entire system. That
        /// functionality is now moved to the SystemAccessDeviceGetAllRequest.
        /// The response is either SystemAccessDeviceGetListResponse14 or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceGetListResponse14> SystemAccessDeviceGetListRequest14Async(this OcipClientBase client, SystemAccessDeviceGetListRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetListResponse14;
        }
        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetRequest18sp1Async instead.")]
        public static async Task<SystemAccessDeviceGetResponse18sp1> SystemAccessDeviceGetRequest18sp1(this OcipClientBase client, SystemAccessDeviceGetRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetResponse18sp1;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse18sp1> SystemAccessDeviceGetRequest18sp1Async(this OcipClientBase client, SystemAccessDeviceGetRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetResponse18sp1;
        }
        /// <summary>
        /// Requests the users associated with a specified system access device.
        /// The response is either SystemAccessDeviceGetUserListResponse21sp1 or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetUserListRequest21sp1Async instead.")]
        public static async Task<SystemAccessDeviceGetUserListResponse21sp1> SystemAccessDeviceGetUserListRequest21sp1(this OcipClientBase client, SystemAccessDeviceGetUserListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetUserListResponse21sp1;
        }

        /// <summary>
        /// Requests the users associated with a specified system access device.
        /// The response is either SystemAccessDeviceGetUserListResponse21sp1 or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// </summary>
        public static async Task<SystemAccessDeviceGetUserListResponse21sp1> SystemAccessDeviceGetUserListRequest21sp1Async(this OcipClientBase client, SystemAccessDeviceGetUserListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetUserListResponse21sp1;
        }
        /// <summary>
        /// Request to modify a specified system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceModifyRequest(this OcipClientBase client, SystemAccessDeviceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceModifyRequestAsync(this OcipClientBase client, SystemAccessDeviceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify attributes for line/ports assigned on the system device profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// privateIdentity
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceModifyUserRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceModifyUserRequest(this OcipClientBase client, SystemAccessDeviceModifyUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify attributes for line/ports assigned on the system device profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// privateIdentity
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceModifyUserRequestAsync(this OcipClientBase client, SystemAccessDeviceModifyUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a device type to be monitored.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceMonitorAddDeviceTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorAddDeviceTypeRequest(this OcipClientBase client, SystemAccessDeviceMonitorAddDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a device type to be monitored.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorAddDeviceTypeRequestAsync(this OcipClientBase client, SystemAccessDeviceMonitorAddDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Remove a device type to be monitored.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceMonitorDeleteDeviceTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorDeleteDeviceTypeRequest(this OcipClientBase client, SystemAccessDeviceMonitorDeleteDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Remove a device type to be monitored.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorDeleteDeviceTypeRequestAsync(this OcipClientBase client, SystemAccessDeviceMonitorDeleteDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of monitored device types.
        /// The response is either a SystemAccessDeviceMonitorGetDeviceTypeListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceMonitorGetDeviceTypeListRequestAsync instead.")]
        public static async Task<SystemAccessDeviceMonitorGetDeviceTypeListResponse> SystemAccessDeviceMonitorGetDeviceTypeListRequest(this OcipClientBase client, SystemAccessDeviceMonitorGetDeviceTypeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceMonitorGetDeviceTypeListResponse;
        }

        /// <summary>
        /// Get a list of monitored device types.
        /// The response is either a SystemAccessDeviceMonitorGetDeviceTypeListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceMonitorGetDeviceTypeListResponse> SystemAccessDeviceMonitorGetDeviceTypeListRequestAsync(this OcipClientBase client, SystemAccessDeviceMonitorGetDeviceTypeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceMonitorGetDeviceTypeListResponse;
        }
        /// <summary>
        /// Request to get the list of Access Device Monitor system parameters.
        /// The response is either SystemAccessDeviceMonitorParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceMonitorParametersGetRequestAsync instead.")]
        public static async Task<SystemAccessDeviceMonitorParametersGetResponse> SystemAccessDeviceMonitorParametersGetRequest(this OcipClientBase client, SystemAccessDeviceMonitorParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceMonitorParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of Access Device Monitor system parameters.
        /// The response is either SystemAccessDeviceMonitorParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceMonitorParametersGetResponse> SystemAccessDeviceMonitorParametersGetRequestAsync(this OcipClientBase client, SystemAccessDeviceMonitorParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceMonitorParametersGetResponse;
        }
        /// <summary>
        /// Request to modify Access Device Monitor system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceMonitorParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorParametersModifyRequest(this OcipClientBase client, SystemAccessDeviceMonitorParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Access Device Monitor system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorParametersModifyRequestAsync(this OcipClientBase client, SystemAccessDeviceMonitorParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset a specific system SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceResetRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceResetRequest(this OcipClientBase client, SystemAccessDeviceResetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific system SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceResetRequestAsync(this OcipClientBase client, SystemAccessDeviceResetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the custom configuration tag set defined at the access device.
        /// The response is either SystemAccessDeviceTagSetGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceTagSetGetRequestAsync instead.")]
        public static async Task<SystemAccessDeviceTagSetGetResponse> SystemAccessDeviceTagSetGetRequest(this OcipClientBase client, SystemAccessDeviceTagSetGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceTagSetGetResponse;
        }

        /// <summary>
        /// Request to get the custom configuration tag set defined at the access device.
        /// The response is either SystemAccessDeviceTagSetGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceTagSetGetResponse> SystemAccessDeviceTagSetGetRequestAsync(this OcipClientBase client, SystemAccessDeviceTagSetGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceTagSetGetResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceTagSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceTagSetModifyRequest(this OcipClientBase client, SystemAccessDeviceTagSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceTagSetModifyRequestAsync(this OcipClientBase client, SystemAccessDeviceTagSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of device types supporting enhanced configuration.
        /// The response is either SystemAccessDeviceTypeGetEnhancedConfigurableListResponse
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceTypeGetEnhancedConfigurableListRequestAsync instead.")]
        public static async Task<SystemAccessDeviceTypeGetEnhancedConfigurableListResponse> SystemAccessDeviceTypeGetEnhancedConfigurableListRequest(this OcipClientBase client, SystemAccessDeviceTypeGetEnhancedConfigurableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceTypeGetEnhancedConfigurableListResponse;
        }

        /// <summary>
        /// Requests the list of device types supporting enhanced configuration.
        /// The response is either SystemAccessDeviceTypeGetEnhancedConfigurableListResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceTypeGetEnhancedConfigurableListResponse> SystemAccessDeviceTypeGetEnhancedConfigurableListRequestAsync(this OcipClientBase client, SystemAccessDeviceTypeGetEnhancedConfigurableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceTypeGetEnhancedConfigurableListResponse;
        }
        /// <summary>
        /// Requests the list of access device types.
        /// The response is either SystemAccessDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceTypeGetListRequestAsync instead.")]
        public static async Task<SystemAccessDeviceTypeGetListResponse> SystemAccessDeviceTypeGetListRequest(this OcipClientBase client, SystemAccessDeviceTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceTypeGetListResponse;
        }

        /// <summary>
        /// Requests the list of access device types.
        /// The response is either SystemAccessDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceTypeGetListResponse> SystemAccessDeviceTypeGetListRequestAsync(this OcipClientBase client, SystemAccessDeviceTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceTypeGetListResponse;
        }
        /// <summary>
        /// Request to add a ChargingFunctionElement Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingAddChargingFunctionElementServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingAddChargingFunctionElementServerRequest(this OcipClientBase client, SystemAccountingAddChargingFunctionElementServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a ChargingFunctionElement Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingAddChargingFunctionElementServerRequestAsync(this OcipClientBase client, SystemAccountingAddChargingFunctionElementServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Radius Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingAddRadiusServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingAddRadiusServerRequest(this OcipClientBase client, SystemAccountingAddRadiusServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Radius Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingAddRadiusServerRequestAsync(this OcipClientBase client, SystemAccountingAddRadiusServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a ChargingFunctionElementServer from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingDeleteChargingFunctionElementServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingDeleteChargingFunctionElementServerRequest(this OcipClientBase client, SystemAccountingDeleteChargingFunctionElementServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a ChargingFunctionElementServer from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingDeleteChargingFunctionElementServerRequestAsync(this OcipClientBase client, SystemAccountingDeleteChargingFunctionElementServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Radius Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingDeleteRadiusServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingDeleteRadiusServerRequest(this OcipClientBase client, SystemAccountingDeleteRadiusServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Radius Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingDeleteRadiusServerRequestAsync(this OcipClientBase client, SystemAccountingDeleteRadiusServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of ChargingFunctionElementServers defined in the system.
        /// The response is either a SystemAccountingGetChargingFunctionElementServerListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingGetChargingFunctionElementServerListRequestAsync instead.")]
        public static async Task<SystemAccountingGetChargingFunctionElementServerListResponse> SystemAccountingGetChargingFunctionElementServerListRequest(this OcipClientBase client, SystemAccountingGetChargingFunctionElementServerListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccountingGetChargingFunctionElementServerListResponse;
        }

        /// <summary>
        /// Request to get a list of ChargingFunctionElementServers defined in the system.
        /// The response is either a SystemAccountingGetChargingFunctionElementServerListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAccountingGetChargingFunctionElementServerListResponse> SystemAccountingGetChargingFunctionElementServerListRequestAsync(this OcipClientBase client, SystemAccountingGetChargingFunctionElementServerListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccountingGetChargingFunctionElementServerListResponse;
        }
        /// <summary>
        /// Request to get a list of Radius Servers defined in the system.
        /// The response is either a SystemAccountingGetRadiusServerListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingGetRadiusServerListRequestAsync instead.")]
        public static async Task<SystemAccountingGetRadiusServerListResponse> SystemAccountingGetRadiusServerListRequest(this OcipClientBase client, SystemAccountingGetRadiusServerListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccountingGetRadiusServerListResponse;
        }

        /// <summary>
        /// Request to get a list of Radius Servers defined in the system.
        /// The response is either a SystemAccountingGetRadiusServerListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAccountingGetRadiusServerListResponse> SystemAccountingGetRadiusServerListRequestAsync(this OcipClientBase client, SystemAccountingGetRadiusServerListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccountingGetRadiusServerListResponse;
        }
        /// <summary>
        /// Add an Attribute Value Pair (AVP) combination to disable. The AVP
        /// combination includes a diameter AVP and a vendor ID. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingInhibitedAttributeValuePairCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingInhibitedAttributeValuePairCodeAddRequest(this OcipClientBase client, SystemAccountingInhibitedAttributeValuePairCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an Attribute Value Pair (AVP) combination to disable. The AVP
        /// combination includes a diameter AVP and a vendor ID. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingInhibitedAttributeValuePairCodeAddRequestAsync(this OcipClientBase client, SystemAccountingInhibitedAttributeValuePairCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Remove an Attribute Value Pair (AVP) combination from the list of disabled AVP
        /// codes. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingInhibitedAttributeValuePairCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingInhibitedAttributeValuePairCodeDeleteRequest(this OcipClientBase client, SystemAccountingInhibitedAttributeValuePairCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Remove an Attribute Value Pair (AVP) combination from the list of disabled AVP
        /// codes. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingInhibitedAttributeValuePairCodeDeleteRequestAsync(this OcipClientBase client, SystemAccountingInhibitedAttributeValuePairCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Attribute Value Pair (AVP) combinations that are
        /// disabled. The response is either a SystemAccountingInhibitedAttributeValuePairCodeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingInhibitedAttributeValuePairCodeGetListRequestAsync instead.")]
        public static async Task<SystemAccountingInhibitedAttributeValuePairCodeGetListResponse> SystemAccountingInhibitedAttributeValuePairCodeGetListRequest(this OcipClientBase client, SystemAccountingInhibitedAttributeValuePairCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccountingInhibitedAttributeValuePairCodeGetListResponse;
        }

        /// <summary>
        /// Get a list of Attribute Value Pair (AVP) combinations that are
        /// disabled. The response is either a SystemAccountingInhibitedAttributeValuePairCodeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAccountingInhibitedAttributeValuePairCodeGetListResponse> SystemAccountingInhibitedAttributeValuePairCodeGetListRequestAsync(this OcipClientBase client, SystemAccountingInhibitedAttributeValuePairCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccountingInhibitedAttributeValuePairCodeGetListResponse;
        }
        /// <summary>
        /// Request to modify a ChargingFunctionElementServer in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingModifyChargingFunctionElementServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingModifyChargingFunctionElementServerRequest(this OcipClientBase client, SystemAccountingModifyChargingFunctionElementServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a ChargingFunctionElementServer in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingModifyChargingFunctionElementServerRequestAsync(this OcipClientBase client, SystemAccountingModifyChargingFunctionElementServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a Radius Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingModifyRadiusServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingModifyRadiusServerRequest(this OcipClientBase client, SystemAccountingModifyRadiusServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Radius Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingModifyRadiusServerRequestAsync(this OcipClientBase client, SystemAccountingModifyRadiusServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reorder the charging function element servers. You can not add or delete addresses,
        /// only re-ordering the list is allowed. The ordered list of addresses can be obtained
        /// with the SystemAccountingGetChargingFunctionElementServerListRequest command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingReorderChargingFunctionElementServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingReorderChargingFunctionElementServerRequest(this OcipClientBase client, SystemAccountingReorderChargingFunctionElementServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reorder the charging function element servers. You can not add or delete addresses,
        /// only re-ordering the list is allowed. The ordered list of addresses can be obtained
        /// with the SystemAccountingGetChargingFunctionElementServerListRequest command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingReorderChargingFunctionElementServerRequestAsync(this OcipClientBase client, SystemAccountingReorderChargingFunctionElementServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system or provisioning administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdminAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAdminAddRequest(this OcipClientBase client, SystemAdminAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system or provisioning administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdminAddRequestAsync(this OcipClientBase client, SystemAdminAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system or provisioning administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdminDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAdminDeleteRequest(this OcipClientBase client, SystemAdminDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system or provisioning administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdminDeleteRequestAsync(this OcipClientBase client, SystemAdminDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of system administrators.
        /// The response is either a SystemAdminGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdminGetListRequestAsync instead.")]
        public static async Task<SystemAdminGetResponse> SystemAdminGetListRequest(this OcipClientBase client, SystemAdminGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAdminGetResponse;
        }

        /// <summary>
        /// Get a list of system administrators.
        /// The response is either a SystemAdminGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAdminGetResponse> SystemAdminGetListRequestAsync(this OcipClientBase client, SystemAdminGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAdminGetResponse;
        }
        /// <summary>
        /// Get a system or provisioning administrators profile.
        /// The response is either a SystemAdminGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdminGetRequestAsync instead.")]
        public static async Task<SystemAdminGetResponse> SystemAdminGetRequest(this OcipClientBase client, SystemAdminGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAdminGetResponse;
        }

        /// <summary>
        /// Get a system or provisioning administrators profile.
        /// The response is either a SystemAdminGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAdminGetResponse> SystemAdminGetRequestAsync(this OcipClientBase client, SystemAdminGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAdminGetResponse;
        }
        /// <summary>
        /// Modify a system or provisioning administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdminModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAdminModifyRequest(this OcipClientBase client, SystemAdminModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a system or provisioning administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdminModifyRequestAsync(this OcipClientBase client, SystemAdminModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system-level Application Server alias to the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAliasAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAliasAddRequest(this OcipClientBase client, SystemAliasAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system-level Application Server alias to the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAliasAddRequestAsync(this OcipClientBase client, SystemAliasAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system-level Application Server alias from the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAliasDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAliasDeleteRequest(this OcipClientBase client, SystemAliasDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system-level Application Server alias from the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAliasDeleteRequestAsync(this OcipClientBase client, SystemAliasDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of all system-level Application Server aliases.
        /// The response is either SystemAliasGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAliasGetListRequestAsync instead.")]
        public static async Task<SystemAliasGetListResponse> SystemAliasGetListRequest(this OcipClientBase client, SystemAliasGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAliasGetListResponse;
        }

        /// <summary>
        /// Requests the list of all system-level Application Server aliases.
        /// The response is either SystemAliasGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAliasGetListResponse> SystemAliasGetListRequestAsync(this OcipClientBase client, SystemAliasGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAliasGetListResponse;
        }
        /// <summary>
        /// Request to get the list of alternate user ids.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the alternate
        /// user ids in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemAlternateUserIdGetListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAlternateUserIdGetListRequestAsync instead.")]
        public static async Task<SystemAlternateUserIdGetListResponse> SystemAlternateUserIdGetListRequest(this OcipClientBase client, SystemAlternateUserIdGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAlternateUserIdGetListResponse;
        }

        /// <summary>
        /// Request to get the list of alternate user ids.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the alternate
        /// user ids in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemAlternateUserIdGetListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<SystemAlternateUserIdGetListResponse> SystemAlternateUserIdGetListRequestAsync(this OcipClientBase client, SystemAlternateUserIdGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAlternateUserIdGetListResponse;
        }
        /// <summary>
        /// Add an application controller, which is a server where remote
        /// application resides and controls the Route Point.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemApplicationControllerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemApplicationControllerAddRequest(this OcipClientBase client, SystemApplicationControllerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an application controller, which is a server where remote
        /// application resides and controls the Route Point.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemApplicationControllerAddRequestAsync(this OcipClientBase client, SystemApplicationControllerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an application controller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemApplicationControllerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemApplicationControllerDeleteRequest(this OcipClientBase client, SystemApplicationControllerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an application controller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemApplicationControllerDeleteRequestAsync(this OcipClientBase client, SystemApplicationControllerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of application controllers that are configured for the system.
        /// The response is either SystemApplicationControllerGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemApplicationControllerGetListRequestAsync instead.")]
        public static async Task<SystemApplicationControllerGetListResponse> SystemApplicationControllerGetListRequest(this OcipClientBase client, SystemApplicationControllerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemApplicationControllerGetListResponse;
        }

        /// <summary>
        /// Get a list of application controllers that are configured for the system.
        /// The response is either SystemApplicationControllerGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemApplicationControllerGetListResponse> SystemApplicationControllerGetListRequestAsync(this OcipClientBase client, SystemApplicationControllerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemApplicationControllerGetListResponse;
        }
        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse14sp7 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemASRParametersGetRequest14sp7Async instead.")]
        public static async Task<SystemASRParametersGetResponse14sp7> SystemASRParametersGetRequest14sp7(this OcipClientBase client, SystemASRParametersGetRequest14sp7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemASRParametersGetResponse14sp7;
        }

        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse14sp7 or ErrorResponse.
        /// </summary>
        public static async Task<SystemASRParametersGetResponse14sp7> SystemASRParametersGetRequest14sp7Async(this OcipClientBase client, SystemASRParametersGetRequest14sp7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemASRParametersGetResponse14sp7;
        }
        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse23 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemASRParametersGetRequest23Async instead.")]
        public static async Task<SystemASRParametersGetResponse23> SystemASRParametersGetRequest23(this OcipClientBase client, SystemASRParametersGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemASRParametersGetResponse23;
        }

        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse23 or ErrorResponse.
        /// </summary>
        public static async Task<SystemASRParametersGetResponse23> SystemASRParametersGetRequest23Async(this OcipClientBase client, SystemASRParametersGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemASRParametersGetResponse23;
        }
        /// <summary>
        /// Request to modify Application Server Registration system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableCustomMessageControl
        /// customNumberOfUsersPerMessage
        /// customMessageIntervalMilliseconds
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemASRParametersModifyRequest14sp7Async instead.")]
        public static async Task<SuccessResponse> SystemASRParametersModifyRequest14sp7(this OcipClientBase client, SystemASRParametersModifyRequest14sp7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Application Server Registration system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableCustomMessageControl
        /// customNumberOfUsersPerMessage
        /// customMessageIntervalMilliseconds
        /// </summary>
        public static async Task<SuccessResponse> SystemASRParametersModifyRequest14sp7Async(this OcipClientBase client, SystemASRParametersModifyRequest14sp7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to export system wide authentication lockout data to a file. All locked out device profiles, sip endpoints, and sip trunk groups are returned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAuthenticationLockoutExportDataGetRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAuthenticationLockoutExportDataGetRequest(this OcipClientBase client, SystemAuthenticationLockoutExportDataGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to export system wide authentication lockout data to a file. All locked out device profiles, sip endpoints, and sip trunk groups are returned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAuthenticationLockoutExportDataGetRequestAsync(this OcipClientBase client, SystemAuthenticationLockoutExportDataGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the authentication lockout settings in the system.
        /// The response is either a SystemAuthenticationLockoutSettingsGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAuthenticationLockoutSettingsGetRequestAsync instead.")]
        public static async Task<SystemAuthenticationLockoutSettingsGetResponse> SystemAuthenticationLockoutSettingsGetRequest(this OcipClientBase client, SystemAuthenticationLockoutSettingsGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAuthenticationLockoutSettingsGetResponse;
        }

        /// <summary>
        /// Request to get the authentication lockout settings in the system.
        /// The response is either a SystemAuthenticationLockoutSettingsGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAuthenticationLockoutSettingsGetResponse> SystemAuthenticationLockoutSettingsGetRequestAsync(this OcipClientBase client, SystemAuthenticationLockoutSettingsGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAuthenticationLockoutSettingsGetResponse;
        }
        /// <summary>
        /// Request to modify the system level device password lockout settings
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAuthenticationLockoutSettingsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAuthenticationLockoutSettingsModifyRequest(this OcipClientBase client, SystemAuthenticationLockoutSettingsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system level device password lockout settings
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAuthenticationLockoutSettingsModifyRequestAsync(this OcipClientBase client, SystemAuthenticationLockoutSettingsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system interface attributes for Messaging Server/BroadCloud.
        /// The response is either SystemBroadCloudGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadCloudGetRequestAsync instead.")]
        public static async Task<SystemBroadCloudGetResponse> SystemBroadCloudGetRequest(this OcipClientBase client, SystemBroadCloudGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBroadCloudGetResponse;
        }

        /// <summary>
        /// Get the system interface attributes for Messaging Server/BroadCloud.
        /// The response is either SystemBroadCloudGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadCloudGetResponse> SystemBroadCloudGetRequestAsync(this OcipClientBase client, SystemBroadCloudGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBroadCloudGetResponse;
        }
        /// <summary>
        /// Modify the system interface attributes for Messaging Server/BroadCloud.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadCloudModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBroadCloudModifyRequest(this OcipClientBase client, SystemBroadCloudModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system interface attributes for Messaging Server/BroadCloud.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadCloudModifyRequestAsync(this OcipClientBase client, SystemBroadCloudModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the BroadWorks Mobile Manager service system settings.
        /// The response is either SystemBroadWorksMobileManagerGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadWorksMobileManagerGetRequestAsync instead.")]
        public static async Task<SystemBroadWorksMobileManagerGetResponse> SystemBroadWorksMobileManagerGetRequest(this OcipClientBase client, SystemBroadWorksMobileManagerGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBroadWorksMobileManagerGetResponse;
        }

        /// <summary>
        /// Get the BroadWorks Mobile Manager service system settings.
        /// The response is either SystemBroadWorksMobileManagerGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksMobileManagerGetResponse> SystemBroadWorksMobileManagerGetRequestAsync(this OcipClientBase client, SystemBroadWorksMobileManagerGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBroadWorksMobileManagerGetResponse;
        }
        /// <summary>
        /// Modify the BroadWorks Mobile Manager service system settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadWorksMobileManagerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBroadWorksMobileManagerModifyRequest(this OcipClientBase client, SystemBroadWorksMobileManagerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the BroadWorks Mobile Manager service system settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobileManagerModifyRequestAsync(this OcipClientBase client, SystemBroadWorksMobileManagerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of System Diameter base parameters.
        /// The response is either SystemBwDiameterBaseDataGetResponse17sp3 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterBaseDataGetRequest17sp3Async instead.")]
        public static async Task<SystemBwDiameterBaseDataGetResponse17sp3> SystemBwDiameterBaseDataGetRequest17sp3(this OcipClientBase client, SystemBwDiameterBaseDataGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBwDiameterBaseDataGetResponse17sp3;
        }

        /// <summary>
        /// Requests the list of System Diameter base parameters.
        /// The response is either SystemBwDiameterBaseDataGetResponse17sp3 or ErrorResponse.
        /// </summary>
        public static async Task<SystemBwDiameterBaseDataGetResponse17sp3> SystemBwDiameterBaseDataGetRequest17sp3Async(this OcipClientBase client, SystemBwDiameterBaseDataGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBwDiameterBaseDataGetResponse17sp3;
        }
        /// <summary>
        /// Requests the list of System Diameter base parameters.
        /// The response is either SystemBwDiameterBaseDataGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterBaseDataGetRequest22Async instead.")]
        public static async Task<SystemBwDiameterBaseDataGetResponse22> SystemBwDiameterBaseDataGetRequest22(this OcipClientBase client, SystemBwDiameterBaseDataGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBwDiameterBaseDataGetResponse22;
        }

        /// <summary>
        /// Requests the list of System Diameter base parameters.
        /// The response is either SystemBwDiameterBaseDataGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemBwDiameterBaseDataGetResponse22> SystemBwDiameterBaseDataGetRequest22Async(this OcipClientBase client, SystemBwDiameterBaseDataGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBwDiameterBaseDataGetResponse22;
        }
        /// <summary>
        /// Modifies the System Diameter base parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterBaseDataModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterBaseDataModifyRequest(this OcipClientBase client, SystemBwDiameterBaseDataModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the System Diameter base parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterBaseDataModifyRequestAsync(this OcipClientBase client, SystemBwDiameterBaseDataModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a static entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterPeerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterPeerAddRequest(this OcipClientBase client, SystemBwDiameterPeerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a static entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterPeerAddRequestAsync(this OcipClientBase client, SystemBwDiameterPeerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a static entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterPeerAddRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterPeerAddRequest22(this OcipClientBase client, SystemBwDiameterPeerAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a static entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterPeerAddRequest22Async(this OcipClientBase client, SystemBwDiameterPeerAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Remove a Diameter peer.  A peer cannot be removed if is referenced by a Realm Routing Table entry.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterPeerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterPeerDeleteRequest(this OcipClientBase client, SystemBwDiameterPeerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Remove a Diameter peer.  A peer cannot be removed if is referenced by a Realm Routing Table entry.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterPeerDeleteRequestAsync(this OcipClientBase client, SystemBwDiameterPeerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of Diameter peers.
        /// The response is either SystemBwDiameterPeerGetListResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterPeerGetListRequestAsync instead.")]
        public static async Task<SystemBwDiameterPeerGetListResponse> SystemBwDiameterPeerGetListRequest(this OcipClientBase client, SystemBwDiameterPeerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBwDiameterPeerGetListResponse;
        }

        /// <summary>
        /// Requests the list of Diameter peers.
        /// The response is either SystemBwDiameterPeerGetListResponse or ErrorResponse
        /// </summary>
        public static async Task<SystemBwDiameterPeerGetListResponse> SystemBwDiameterPeerGetListRequestAsync(this OcipClientBase client, SystemBwDiameterPeerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBwDiameterPeerGetListResponse;
        }
        /// <summary>
        /// Modifies the attributes of an entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterPeerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterPeerModifyRequest(this OcipClientBase client, SystemBwDiameterPeerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the attributes of an entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterPeerModifyRequestAsync(this OcipClientBase client, SystemBwDiameterPeerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Diameter routing peer.  The realm must refer to a Diameter routing realm whose action is relay.  The destinationPeerIdentity must refer to an existing Diameter peer whose mode is active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingPeerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerAddRequest(this OcipClientBase client, SystemBwDiameterRoutingPeerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Diameter routing peer.  The realm must refer to a Diameter routing realm whose action is relay.  The destinationPeerIdentity must refer to an existing Diameter peer whose mode is active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerAddRequestAsync(this OcipClientBase client, SystemBwDiameterRoutingPeerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Remove a Diameter routing peer.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingPeerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerDeleteRequest(this OcipClientBase client, SystemBwDiameterRoutingPeerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Remove a Diameter routing peer.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerDeleteRequestAsync(this OcipClientBase client, SystemBwDiameterRoutingPeerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of Diameter routing peers associated with the specified realm. The response is either SystemBwDiameterRoutingPeerGetListResponse or  ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingPeerGetListRequestAsync instead.")]
        public static async Task<SystemBwDiameterRoutingPeerGetListResponse> SystemBwDiameterRoutingPeerGetListRequest(this OcipClientBase client, SystemBwDiameterRoutingPeerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBwDiameterRoutingPeerGetListResponse;
        }

        /// <summary>
        /// Requests the list of Diameter routing peers associated with the specified realm. The response is either SystemBwDiameterRoutingPeerGetListResponse or  ErrorResponse.
        /// </summary>
        public static async Task<SystemBwDiameterRoutingPeerGetListResponse> SystemBwDiameterRoutingPeerGetListRequestAsync(this OcipClientBase client, SystemBwDiameterRoutingPeerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBwDiameterRoutingPeerGetListResponse;
        }
        /// <summary>
        /// Modify a Diameter routing peer.  The realm must refer to a Diameter routing realm whose action is relay.  The destinationPeerIdentity must refer to an existing Diameter peer whose mode is active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingPeerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerModifyRequest(this OcipClientBase client, SystemBwDiameterRoutingPeerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Diameter routing peer.  The realm must refer to a Diameter routing realm whose action is relay.  The destinationPeerIdentity must refer to an existing Diameter peer whose mode is active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerModifyRequestAsync(this OcipClientBase client, SystemBwDiameterRoutingPeerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingRealmAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmAddRequest(this OcipClientBase client, SystemBwDiameterRoutingRealmAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmAddRequestAsync(this OcipClientBase client, SystemBwDiameterRoutingRealmAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingRealmDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmDeleteRequest(this OcipClientBase client, SystemBwDiameterRoutingRealmDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmDeleteRequestAsync(this OcipClientBase client, SystemBwDiameterRoutingRealmDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of Diameter routing realms.
        /// The response is either SystemBwDiameterRoutingRealmGetListResponse or  ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingRealmGetListRequestAsync instead.")]
        public static async Task<SystemBwDiameterRoutingRealmGetListResponse> SystemBwDiameterRoutingRealmGetListRequest(this OcipClientBase client, SystemBwDiameterRoutingRealmGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBwDiameterRoutingRealmGetListResponse;
        }

        /// <summary>
        /// Requests the list of Diameter routing realms.
        /// The response is either SystemBwDiameterRoutingRealmGetListResponse or  ErrorResponse.
        /// </summary>
        public static async Task<SystemBwDiameterRoutingRealmGetListResponse> SystemBwDiameterRoutingRealmGetListRequestAsync(this OcipClientBase client, SystemBwDiameterRoutingRealmGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBwDiameterRoutingRealmGetListResponse;
        }
        /// <summary>
        /// Modify a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingRealmModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmModifyRequest(this OcipClientBase client, SystemBwDiameterRoutingRealmModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmModifyRequestAsync(this OcipClientBase client, SystemBwDiameterRoutingRealmModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse23 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingGetPolicyRequest23Async instead.")]
        public static async Task<SystemCallProcessingGetPolicyResponse23> SystemCallProcessingGetPolicyRequest23(this OcipClientBase client, SystemCallProcessingGetPolicyRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse23;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse23 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse23> SystemCallProcessingGetPolicyRequest23Async(this OcipClientBase client, SystemCallProcessingGetPolicyRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse23;
        }
        /// <summary>
        /// Modify the system level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// enterpriseCallsCLIDPolicy
        /// enterpriseGroupCallsCLIDPolicy
        /// serviceProviderGroupCallsCLIDPolicy
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// maxConferenceParties
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// delayTimerToRemoveCancelledCallsInSeconds
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// useUserPhoneNumberForGroupCallsWhenInternalClidUnavailable
        /// useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable
        /// allowMobileDNForRedirectingIdentity
        /// conferenceDisableClampTones
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingModifyPolicyRequest15Async instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingModifyPolicyRequest15(this OcipClientBase client, SystemCallProcessingModifyPolicyRequest15 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// enterpriseCallsCLIDPolicy
        /// enterpriseGroupCallsCLIDPolicy
        /// serviceProviderGroupCallsCLIDPolicy
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// maxConferenceParties
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// delayTimerToRemoveCancelledCallsInSeconds
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// useUserPhoneNumberForGroupCallsWhenInternalClidUnavailable
        /// useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable
        /// allowMobileDNForRedirectingIdentity
        /// conferenceDisableClampTones
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingModifyPolicyRequest15Async(this OcipClientBase client, SystemCallProcessingModifyPolicyRequest15 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a call processing policy profile to system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileAddRequest21Async instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileAddRequest21(this OcipClientBase client, SystemCallProcessingPolicyProfileAddRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a call processing policy profile to system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileAddRequest21Async(this OcipClientBase client, SystemCallProcessingPolicyProfileAddRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Auto Attendant subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22 or an
        /// ErrorResponse.
        /// The response contains the call processing policy profile setting for Auto Attendant.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22> SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Auto Attendant subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22 or an
        /// ErrorResponse.
        /// The response contains the call processing policy profile setting for Auto Attendant.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22> SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse and ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileAutoAttendantProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileAutoAttendantProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileAutoAttendantProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse and ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileAutoAttendantProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileAutoAttendantProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile BroadWorks Anywhere subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22> SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile BroadWorks Anywhere subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22> SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22;
        }
        /// <summary>
        /// The response is either a SuccessResponse or an ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either a SuccessResponse or an ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Call Center subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22> SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Call Center subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22> SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22;
        }
        /// <summary>
        /// The response is either a SuccessResponse or an ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileCallCenterProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileCallCenterProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileCallCenterProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either a SuccessResponse or an ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileCallCenterProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileCallCenterProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Collaborate subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22> SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Collaborate subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22> SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22;
        }
        /// <summary>
        /// Request to get to modify the call processing policy profile collaborate subscriber type profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileCollaborateProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileCollaborateProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileCollaborateProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to get to modify the call processing policy profile collaborate subscriber type profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileCollaborateProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileCollaborateProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a call processing policy profile from system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileDeleteRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a call processing policy profile from system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileDeleteRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Find-me/Follow-me subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22> SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Find-me/Follow-me subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22> SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileFindMeFollowMeProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileFindMeFollowMeProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileFindMeFollowMeProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileFindMeFollowMeProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileFindMeFollowMeProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Flexible Seating Host subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse> SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Flexible Seating Host subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse> SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of NCOSs that have a given CallP Policy Profile assigned.
        /// The response is either a SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileGetAssignedNCOSListRequestAsync instead.")]
        public static async Task<SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse> SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse;
        }

        /// <summary>
        /// Request a list of NCOSs that have a given CallP Policy Profile assigned.
        /// The response is either a SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse> SystemCallProcessingPolicyProfileGetAssignedNCOSListRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse;
        }
        /// <summary>
        /// Get the list of all Call Processing Policy Profiles.
        /// The response is either a SystemCallProcessingPolicyProfileGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileGetListRequestAsync instead.")]
        public static async Task<SystemCallProcessingPolicyProfileGetListResponse> SystemCallProcessingPolicyProfileGetListRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetListResponse;
        }

        /// <summary>
        /// Get the list of all Call Processing Policy Profiles.
        /// The response is either a SystemCallProcessingPolicyProfileGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGetListResponse> SystemCallProcessingPolicyProfileGetListRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetListResponse;
        }
        /// <summary>
        /// Request to get a call processing policy profile in system.
        /// The response is either a SystemCallProcessingPolicyProfileGetResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileGetRequest21Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileGetResponse21> SystemCallProcessingPolicyProfileGetRequest21(this OcipClientBase client, SystemCallProcessingPolicyProfileGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetResponse21;
        }

        /// <summary>
        /// Request to get a call processing policy profile in system.
        /// The response is either a SystemCallProcessingPolicyProfileGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGetResponse21> SystemCallProcessingPolicyProfileGetRequest21Async(this OcipClientBase client, SystemCallProcessingPolicyProfileGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetResponse21;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Group Paging subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22> SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Group Paging subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22> SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileGroupPagingProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileGroupPagingProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileGroupPagingProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileGroupPagingProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileGroupPagingProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Hunt Group subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22> SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Hunt Group subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22> SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileHuntGroupProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileHuntGroupProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileHuntGroupProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileHuntGroupProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileHuntGroupProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Instant Group Call subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22> SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Instant Group Call subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22> SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileInstantGroupCallProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileInstantGroupCallProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileInstantGroupCallProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileInstantGroupCallProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileInstantGroupCallProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Meet-Me Conferencing subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22> SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Meet-Me Conferencing subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22> SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileMeetMeConferencingProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileMeetMeConferencingProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileMeetMeConferencingProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileMeetMeConferencingProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileMeetMeConferencingProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a call processing policy profile in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileModifyRequest21Async instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileModifyRequest21(this OcipClientBase client, SystemCallProcessingPolicyProfileModifyRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call processing policy profile in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileModifyRequest21Async(this OcipClientBase client, SystemCallProcessingPolicyProfileModifyRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Route Point subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22> SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Route Point subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22> SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileRoutePointProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileRoutePointProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileRoutePointProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileRoutePointProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileRoutePointProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Trunk Group Pilot user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Trunk Group Pilot user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Trunk Group Pilot user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22V2Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22V2(this OcipClientBase client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Trunk Group Pilot user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22V2Async(this OcipClientBase client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileTrunkGroupPilotProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileUserProfileGetResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileUserProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileUserProfileGetResponse22> SystemCallProcessingPolicyProfileUserProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileUserProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileUserProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileUserProfileGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileUserProfileGetResponse22> SystemCallProcessingPolicyProfileUserProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileUserProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileUserProfileGetResponse22;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileUserProfileGetResponse22V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileUserProfileGetRequest22V2Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileUserProfileGetResponse22V2> SystemCallProcessingPolicyProfileUserProfileGetRequest22V2(this OcipClientBase client, SystemCallProcessingPolicyProfileUserProfileGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileUserProfileGetResponse22V2;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileUserProfileGetResponse22V2 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileUserProfileGetResponse22V2> SystemCallProcessingPolicyProfileUserProfileGetRequest22V2Async(this OcipClientBase client, SystemCallProcessingPolicyProfileUserProfileGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileUserProfileGetResponse22V2;
        }
        /// <summary>
        /// Modify a call processing policy profile user subscriber type profile in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileUserProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileUserProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileUserProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call processing policy profile user subscriber type profile in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileUserProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileUserProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Voice Portal subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22> SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Voice Portal subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22> SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile VoiceXML subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22> SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22(this OcipClientBase client, SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile VoiceXML subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22> SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22Async(this OcipClientBase client, SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequest(this OcipClientBase client, SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequestAsync(this OcipClientBase client, SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallTypeAddMappingRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallTypeAddMappingRequest(this OcipClientBase client, SystemCallTypeAddMappingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallTypeAddMappingRequestAsync(this OcipClientBase client, SystemCallTypeAddMappingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallTypeDeleteMappingRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallTypeDeleteMappingRequest(this OcipClientBase client, SystemCallTypeDeleteMappingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallTypeDeleteMappingRequestAsync(this OcipClientBase client, SystemCallTypeDeleteMappingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of system call types.
        /// The response is either SystemCallTypeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallTypeGetListRequestAsync instead.")]
        public static async Task<SystemCallTypeGetListResponse> SystemCallTypeGetListRequest(this OcipClientBase client, SystemCallTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallTypeGetListResponse;
        }

        /// <summary>
        /// Get a list of system call types.
        /// The response is either SystemCallTypeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemCallTypeGetListResponse> SystemCallTypeGetListRequestAsync(this OcipClientBase client, SystemCallTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallTypeGetListResponse;
        }
        /// <summary>
        /// Get a list of system call type mappings.
        /// The response is either SystemCallTypeGetMappingListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallTypeGetMappingListRequestAsync instead.")]
        public static async Task<SystemCallTypeGetMappingListResponse> SystemCallTypeGetMappingListRequest(this OcipClientBase client, SystemCallTypeGetMappingListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallTypeGetMappingListResponse;
        }

        /// <summary>
        /// Get a list of system call type mappings.
        /// The response is either SystemCallTypeGetMappingListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemCallTypeGetMappingListResponse> SystemCallTypeGetMappingListRequestAsync(this OcipClientBase client, SystemCallTypeGetMappingListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallTypeGetMappingListResponse;
        }
        /// <summary>
        /// Request to add one or more prefixes to the list of prefixes to be matched.
        /// Matched prefixes will result in CLID delivery for Korea.
        /// Prefix 00X must be sent using uppercase X.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCLIDDeliveryPrefixAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCLIDDeliveryPrefixAddListRequest(this OcipClientBase client, SystemCLIDDeliveryPrefixAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add one or more prefixes to the list of prefixes to be matched.
        /// Matched prefixes will result in CLID delivery for Korea.
        /// Prefix 00X must be sent using uppercase X.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCLIDDeliveryPrefixAddListRequestAsync(this OcipClientBase client, SystemCLIDDeliveryPrefixAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete one or more prefixes from the system.
        /// Prefix 00X must be sent using uppercase X.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCLIDDeliveryPrefixDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCLIDDeliveryPrefixDeleteListRequest(this OcipClientBase client, SystemCLIDDeliveryPrefixDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete one or more prefixes from the system.
        /// Prefix 00X must be sent using uppercase X.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCLIDDeliveryPrefixDeleteListRequestAsync(this OcipClientBase client, SystemCLIDDeliveryPrefixDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of provisioned prefixes in the system.
        /// The response is either a SystemCLIDDeliveryPrefixGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCLIDDeliveryPrefixGetListRequestAsync instead.")]
        public static async Task<SystemCLIDDeliveryPrefixGetListResponse> SystemCLIDDeliveryPrefixGetListRequest(this OcipClientBase client, SystemCLIDDeliveryPrefixGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCLIDDeliveryPrefixGetListResponse;
        }

        /// <summary>
        /// Request to get the list of provisioned prefixes in the system.
        /// The response is either a SystemCLIDDeliveryPrefixGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCLIDDeliveryPrefixGetListResponse> SystemCLIDDeliveryPrefixGetListRequestAsync(this OcipClientBase client, SystemCLIDDeliveryPrefixGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCLIDDeliveryPrefixGetListResponse;
        }
        /// <summary>
        /// Request to add a client identity entry to the list of client identities in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClientIdentityAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemClientIdentityAddRequest(this OcipClientBase client, SystemClientIdentityAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a client identity entry to the list of client identities in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemClientIdentityAddRequestAsync(this OcipClientBase client, SystemClientIdentityAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a client identity.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClientIdentityDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemClientIdentityDeleteRequest(this OcipClientBase client, SystemClientIdentityDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a client identity.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemClientIdentityDeleteRequestAsync(this OcipClientBase client, SystemClientIdentityDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of client identities.
        /// The response is either a SystemClientIdentityGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClientIdentityGetListRequestAsync instead.")]
        public static async Task<SystemClientIdentityGetListResponse> SystemClientIdentityGetListRequest(this OcipClientBase client, SystemClientIdentityGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemClientIdentityGetListResponse;
        }

        /// <summary>
        /// Request to get a list of client identities.
        /// The response is either a SystemClientIdentityGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemClientIdentityGetListResponse> SystemClientIdentityGetListRequestAsync(this OcipClientBase client, SystemClientIdentityGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemClientIdentityGetListResponse;
        }
        /// <summary>
        /// Request to get the list of Client Session (web and CLI) system parameters.
        /// The response is either SystemClientSessionParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClientSessionParametersGetRequestAsync instead.")]
        public static async Task<SystemClientSessionParametersGetResponse> SystemClientSessionParametersGetRequest(this OcipClientBase client, SystemClientSessionParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemClientSessionParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of Client Session (web and CLI) system parameters.
        /// The response is either SystemClientSessionParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemClientSessionParametersGetResponse> SystemClientSessionParametersGetRequestAsync(this OcipClientBase client, SystemClientSessionParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemClientSessionParametersGetResponse;
        }
        /// <summary>
        /// Request to modify Client Session (web and CLI) system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClientSessionParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemClientSessionParametersModifyRequest(this OcipClientBase client, SystemClientSessionParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Client Session (web and CLI) system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemClientSessionParametersModifyRequestAsync(this OcipClientBase client, SystemClientSessionParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a codec to the ordered list of codecs supported by the system.
        /// The ordered list of codecs is sent to MGCP devices when creating connections.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCodecAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCodecAddRequest(this OcipClientBase client, SystemCodecAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a codec to the ordered list of codecs supported by the system.
        /// The ordered list of codecs is sent to MGCP devices when creating connections.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCodecAddRequestAsync(this OcipClientBase client, SystemCodecAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a supported codec from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCodecDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCodecDeleteRequest(this OcipClientBase client, SystemCodecDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a supported codec from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCodecDeleteRequestAsync(this OcipClientBase client, SystemCodecDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the ordered list of supported codecs in the system.
        /// The ordered list of codecs is sent to MGCP devices when creating connections.
        /// The response is either a SystemCodecGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCodecGetListRequestAsync instead.")]
        public static async Task<SystemCodecGetListResponse> SystemCodecGetListRequest(this OcipClientBase client, SystemCodecGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCodecGetListResponse;
        }

        /// <summary>
        /// Request to get the ordered list of supported codecs in the system.
        /// The ordered list of codecs is sent to MGCP devices when creating connections.
        /// The response is either a SystemCodecGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCodecGetListResponse> SystemCodecGetListRequestAsync(this OcipClientBase client, SystemCodecGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCodecGetListResponse;
        }
        /// <summary>
        /// Add a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringAlternateCallIndicatorAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorAddRequest(this OcipClientBase client, SystemCommunicationBarringAlternateCallIndicatorAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorAddRequestAsync(this OcipClientBase client, SystemCommunicationBarringAlternateCallIndicatorAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringAlternateCallIndicatorDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorDeleteRequest(this OcipClientBase client, SystemCommunicationBarringAlternateCallIndicatorDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorDeleteRequestAsync(this OcipClientBase client, SystemCommunicationBarringAlternateCallIndicatorDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get all the Communication Barring Alternate Call Indicator defined
        /// in the system. The response is either a SystemCommunicationBarringAlternateCallIndicatorGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringAlternateCallIndicatorGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringAlternateCallIndicatorGetListResponse> SystemCommunicationBarringAlternateCallIndicatorGetListRequest(this OcipClientBase client, SystemCommunicationBarringAlternateCallIndicatorGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringAlternateCallIndicatorGetListResponse;
        }

        /// <summary>
        /// Get all the Communication Barring Alternate Call Indicator defined
        /// in the system. The response is either a SystemCommunicationBarringAlternateCallIndicatorGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringAlternateCallIndicatorGetListResponse> SystemCommunicationBarringAlternateCallIndicatorGetListRequestAsync(this OcipClientBase client, SystemCommunicationBarringAlternateCallIndicatorGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringAlternateCallIndicatorGetListResponse;
        }
        /// <summary>
        /// Modify a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringAlternateCallIndicatorModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorModifyRequest(this OcipClientBase client, SystemCommunicationBarringAlternateCallIndicatorModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorModifyRequestAsync(this OcipClientBase client, SystemCommunicationBarringAlternateCallIndicatorModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCallTypeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeAddRequest(this OcipClientBase client, SystemCommunicationBarringCallTypeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeAddRequestAsync(this OcipClientBase client, SystemCommunicationBarringCallTypeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCallTypeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeDeleteRequest(this OcipClientBase client, SystemCommunicationBarringCallTypeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeDeleteRequestAsync(this OcipClientBase client, SystemCommunicationBarringCallTypeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get all the Communication Barring Call Types defined in the system.
        /// The response is either a SystemCommunicationBarringCallTypeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCallTypeGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringCallTypeGetListResponse> SystemCommunicationBarringCallTypeGetListRequest(this OcipClientBase client, SystemCommunicationBarringCallTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringCallTypeGetListResponse;
        }

        /// <summary>
        /// Get all the Communication Barring Call Types defined in the system.
        /// The response is either a SystemCommunicationBarringCallTypeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringCallTypeGetListResponse> SystemCommunicationBarringCallTypeGetListRequestAsync(this OcipClientBase client, SystemCommunicationBarringCallTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringCallTypeGetListResponse;
        }
        /// <summary>
        /// Modify a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCallTypeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeModifyRequest(this OcipClientBase client, SystemCommunicationBarringCallTypeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeModifyRequestAsync(this OcipClientBase client, SystemCommunicationBarringCallTypeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Criteria.
        /// The following elements are only used in AS data mode:
        /// matchNumberPortabilityStatus
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCriteriaAddRequest17Async instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaAddRequest17(this OcipClientBase client, SystemCommunicationBarringCriteriaAddRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Criteria.
        /// The following elements are only used in AS data mode:
        /// matchNumberPortabilityStatus
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaAddRequest17Async(this OcipClientBase client, SystemCommunicationBarringCriteriaAddRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Communication Barring Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaDeleteRequest(this OcipClientBase client, SystemCommunicationBarringCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Communication Barring Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaDeleteRequestAsync(this OcipClientBase client, SystemCommunicationBarringCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCriteriaGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringCriteriaGetListResponse> SystemCommunicationBarringCriteriaGetListRequest(this OcipClientBase client, SystemCommunicationBarringCriteriaGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringCriteriaGetListResponse;
        }

        /// <summary>
        /// Get the list of all Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringCriteriaGetListResponse> SystemCommunicationBarringCriteriaGetListRequestAsync(this OcipClientBase client, SystemCommunicationBarringCriteriaGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringCriteriaGetListResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringCriteriaGetResponse19sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCriteriaGetRequest19sp1Async instead.")]
        public static async Task<SystemCommunicationBarringCriteriaGetResponse19sp1> SystemCommunicationBarringCriteriaGetRequest19sp1(this OcipClientBase client, SystemCommunicationBarringCriteriaGetRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringCriteriaGetResponse19sp1;
        }

        /// <summary>
        /// Get an existing Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringCriteriaGetResponse19sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringCriteriaGetResponse19sp1> SystemCommunicationBarringCriteriaGetRequest19sp1Async(this OcipClientBase client, SystemCommunicationBarringCriteriaGetRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringCriteriaGetResponse19sp1;
        }
        /// <summary>
        /// Modify an existing Communication Barring Criteria.
        /// The following elements are only used in AS data mode:
        /// matchNumberPortabilityStatus
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// matchOtherGETS
        /// matchNotGETS
        /// matchGETSAN
        /// matchGETSNT
        /// matchGETSFC
        /// matchGETSFCAN
        /// matchGETSFCNT
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaModifyRequest(this OcipClientBase client, SystemCommunicationBarringCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Criteria.
        /// The following elements are only used in AS data mode:
        /// matchNumberPortabilityStatus
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// matchOtherGETS
        /// matchNotGETS
        /// matchGETSAN
        /// matchGETSNT
        /// matchGETSFC
        /// matchGETSFCAN
        /// matchGETSFCNT
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaModifyRequestAsync(this OcipClientBase client, SystemCommunicationBarringCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaAddRequest(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaAddRequestAsync(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaDeleteRequest(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaDeleteRequestAsync(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Digit Pattern Criteria defined at the system level.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetListResponse> SystemCommunicationBarringDigitPatternCriteriaGetListRequest(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetListResponse;
        }

        /// <summary>
        /// Get the list of all Digit Pattern Criteria defined at the system level.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetListResponse> SystemCommunicationBarringDigitPatternCriteriaGetListRequestAsync(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetListResponse;
        }
        /// <summary>
        /// Get an existing Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse> SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequest(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse;
        }

        /// <summary>
        /// Get an existing Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse> SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequestAsync(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaGetRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetResponse> SystemCommunicationBarringDigitPatternCriteriaGetRequest(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetResponse> SystemCommunicationBarringDigitPatternCriteriaGetRequestAsync(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetResponse;
        }
        /// <summary>
        /// Modify an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaModifyRequest(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaModifyRequestAsync(this OcipClientBase client, SystemCommunicationBarringDigitPatternCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Communication Barring.
        /// The response is either a SystemCommunicationBarringGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringGetRequest21sp1Async instead.")]
        public static async Task<SystemCommunicationBarringGetResponse21sp1> SystemCommunicationBarringGetRequest21sp1(this OcipClientBase client, SystemCommunicationBarringGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringGetResponse21sp1;
        }

        /// <summary>
        /// Request the system level data associated with Communication Barring.
        /// The response is either a SystemCommunicationBarringGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringGetResponse21sp1> SystemCommunicationBarringGetRequest21sp1Async(this OcipClientBase client, SystemCommunicationBarringGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringGetResponse21sp1;
        }
        /// <summary>
        /// Add a new Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaAddRequest(this OcipClientBase client, SystemCommunicationBarringIncomingCriteriaAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaAddRequestAsync(this OcipClientBase client, SystemCommunicationBarringIncomingCriteriaAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaDeleteRequest(this OcipClientBase client, SystemCommunicationBarringIncomingCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaDeleteRequestAsync(this OcipClientBase client, SystemCommunicationBarringIncomingCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringIncomingCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringIncomingCriteriaGetListResponse> SystemCommunicationBarringIncomingCriteriaGetListRequest(this OcipClientBase client, SystemCommunicationBarringIncomingCriteriaGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringIncomingCriteriaGetListResponse;
        }

        /// <summary>
        /// Get the list of all Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringIncomingCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringIncomingCriteriaGetListResponse> SystemCommunicationBarringIncomingCriteriaGetListRequestAsync(this OcipClientBase client, SystemCommunicationBarringIncomingCriteriaGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringIncomingCriteriaGetListResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringIncomingCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaGetRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringIncomingCriteriaGetResponse> SystemCommunicationBarringIncomingCriteriaGetRequest(this OcipClientBase client, SystemCommunicationBarringIncomingCriteriaGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringIncomingCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringIncomingCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringIncomingCriteriaGetResponse> SystemCommunicationBarringIncomingCriteriaGetRequestAsync(this OcipClientBase client, SystemCommunicationBarringIncomingCriteriaGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringIncomingCriteriaGetResponse;
        }
        /// <summary>
        /// Modify an existing Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaModifyRequest(this OcipClientBase client, SystemCommunicationBarringIncomingCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaModifyRequestAsync(this OcipClientBase client, SystemCommunicationBarringIncomingCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Communication Barring.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// vmCallbackScreening
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringModifyRequest(this OcipClientBase client, SystemCommunicationBarringModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Communication Barring.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// vmCallbackScreening
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringModifyRequestAsync(this OcipClientBase client, SystemCommunicationBarringModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers, use value "false" in XS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileAddRequest19sp1Async instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileAddRequest19sp1(this OcipClientBase client, SystemCommunicationBarringProfileAddRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers, use value "false" in XS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileAddRequest19sp1Async(this OcipClientBase client, SystemCommunicationBarringProfileAddRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Communication Barring Profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileDeleteRequest(this OcipClientBase client, SystemCommunicationBarringProfileDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Communication Barring Profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileDeleteRequestAsync(this OcipClientBase client, SystemCommunicationBarringProfileDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Communication Barring Proifles that uses a specific
        /// Communication Barring criteria.
        /// The response is either a SystemCommunicationBarringProfileGetCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetCriteriaUsageListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringProfileGetCriteriaUsageListResponse> SystemCommunicationBarringProfileGetCriteriaUsageListRequest(this OcipClientBase client, SystemCommunicationBarringProfileGetCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Communication Barring Proifles that uses a specific
        /// Communication Barring criteria.
        /// The response is either a SystemCommunicationBarringProfileGetCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetCriteriaUsageListResponse> SystemCommunicationBarringProfileGetCriteriaUsageListRequestAsync(this OcipClientBase client, SystemCommunicationBarringProfileGetCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get the list of Profiles that use a specific Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse> SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest(this OcipClientBase client, SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Profiles that use a specific Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse> SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequestAsync(this OcipClientBase client, SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get the list of Communication Barring Proifles that uses a specific
        /// Communication Barring Incoming criteria.
        /// The response is either a SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetIncomingCriteriaUsageListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse> SystemCommunicationBarringProfileGetIncomingCriteriaUsageListRequest(this OcipClientBase client, SystemCommunicationBarringProfileGetIncomingCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Communication Barring Proifles that uses a specific
        /// Communication Barring Incoming criteria.
        /// The response is either a SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse> SystemCommunicationBarringProfileGetIncomingCriteriaUsageListRequestAsync(this OcipClientBase client, SystemCommunicationBarringProfileGetIncomingCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get the list of all Communication Barring Profiles.
        /// The response is either a SystemCommunicationBarringProfileGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringProfileGetListResponse> SystemCommunicationBarringProfileGetListRequest(this OcipClientBase client, SystemCommunicationBarringProfileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetListResponse;
        }

        /// <summary>
        /// Get the list of all Communication Barring Profiles.
        /// The response is either a SystemCommunicationBarringProfileGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetListResponse> SystemCommunicationBarringProfileGetListRequestAsync(this OcipClientBase client, SystemCommunicationBarringProfileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetListResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse19sp1V2
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetRequest19sp1V2Async instead.")]
        public static async Task<SystemCommunicationBarringProfileGetResponse19sp1V2> SystemCommunicationBarringProfileGetRequest19sp1V2(this OcipClientBase client, SystemCommunicationBarringProfileGetRequest19sp1V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse19sp1V2;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse19sp1V2
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetResponse19sp1V2> SystemCommunicationBarringProfileGetRequest19sp1V2Async(this OcipClientBase client, SystemCommunicationBarringProfileGetRequest19sp1V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse19sp1V2;
        }
        /// <summary>
        /// Modify an existing Communication Barring Profile.
        /// When the originatingDefaultAction is not Treatment, originatingDefaultTreatmentId
        /// will be automatically cleared. Also when the action of originatingRule is not Treatment,
        /// treatmentId will be automatically cleared for the rule.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the modify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileModifyRequest(this OcipClientBase client, SystemCommunicationBarringProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Profile.
        /// When the originatingDefaultAction is not Treatment, originatingDefaultTreatmentId
        /// will be automatically cleared. Also when the action of originatingRule is not Treatment,
        /// treatmentId will be automatically cleared for the rule.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the modify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileModifyRequestAsync(this OcipClientBase client, SystemCommunicationBarringProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Service Providers that use a specific
        /// Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse> SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequest(this OcipClientBase client, SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Service Providers that use a specific
        /// Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse> SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequestAsync(this OcipClientBase client, SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get the list of Service Providers that use a specific
        /// Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse> SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListRequest(this OcipClientBase client, SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Service Providers that use a specific
        /// Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse> SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListRequestAsync(this OcipClientBase client, SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse;
        }
        /// <summary>
        /// Request to get the File System parameters.
        /// change of behavior is that CLI System/MediaFileSystem/get will no longer show the password
        /// The response is either SystemConfigurableFileSystemGetResponse23 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableFileSystemGetRequest23Async instead.")]
        public static async Task<SystemConfigurableFileSystemGetResponse23> SystemConfigurableFileSystemGetRequest23(this OcipClientBase client, SystemConfigurableFileSystemGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse23;
        }

        /// <summary>
        /// Request to get the File System parameters.
        /// change of behavior is that CLI System/MediaFileSystem/get will no longer show the password
        /// The response is either SystemConfigurableFileSystemGetResponse23 or ErrorResponse.
        /// </summary>
        public static async Task<SystemConfigurableFileSystemGetResponse23> SystemConfigurableFileSystemGetRequest23Async(this OcipClientBase client, SystemConfigurableFileSystemGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse23;
        }
        /// <summary>
        /// Request to modify File System parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableFileSystemModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemConfigurableFileSystemModifyRequest(this OcipClientBase client, SystemConfigurableFileSystemModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify File System parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemConfigurableFileSystemModifyRequestAsync(this OcipClientBase client, SystemConfigurableFileSystemModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableTreatmentAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemConfigurableTreatmentAddRequest(this OcipClientBase client, SystemConfigurableTreatmentAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemConfigurableTreatmentAddRequestAsync(this OcipClientBase client, SystemConfigurableTreatmentAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableTreatmentDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemConfigurableTreatmentDeleteRequest(this OcipClientBase client, SystemConfigurableTreatmentDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemConfigurableTreatmentDeleteRequestAsync(this OcipClientBase client, SystemConfigurableTreatmentDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of configurable treatments.
        /// The response is either a SystemConfigurableTreatmentGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableTreatmentGetListRequestAsync instead.")]
        public static async Task<SystemConfigurableTreatmentGetListResponse> SystemConfigurableTreatmentGetListRequest(this OcipClientBase client, SystemConfigurableTreatmentGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConfigurableTreatmentGetListResponse;
        }

        /// <summary>
        /// Get a list of configurable treatments.
        /// The response is either a SystemConfigurableTreatmentGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemConfigurableTreatmentGetListResponse> SystemConfigurableTreatmentGetListRequestAsync(this OcipClientBase client, SystemConfigurableTreatmentGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConfigurableTreatmentGetListResponse;
        }
        /// <summary>
        /// Get all the attributes of a configurable treatment.
        /// The response is either a SystemConfigurableTreatmentGetResponse16 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableTreatmentGetRequest16Async instead.")]
        public static async Task<SystemConfigurableTreatmentGetResponse16> SystemConfigurableTreatmentGetRequest16(this OcipClientBase client, SystemConfigurableTreatmentGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConfigurableTreatmentGetResponse16;
        }

        /// <summary>
        /// Get all the attributes of a configurable treatment.
        /// The response is either a SystemConfigurableTreatmentGetResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemConfigurableTreatmentGetResponse16> SystemConfigurableTreatmentGetRequest16Async(this OcipClientBase client, SystemConfigurableTreatmentGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConfigurableTreatmentGetResponse16;
        }
        /// <summary>
        /// Modify the fields for a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableTreatmentModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemConfigurableTreatmentModifyRequest(this OcipClientBase client, SystemConfigurableTreatmentModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemConfigurableTreatmentModifyRequestAsync(this OcipClientBase client, SystemConfigurableTreatmentModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a country code to the system.
        /// If ringPeriodMilliseconds is not specified, a default of 6000 milliseconds is assumed.
        /// If offHookWarningTimerSeconds is not specified, a default of 30 seconds is assumed.
        /// If enableNationalPrefix is not specified, a default of false is assumed.
        /// If nationalPrefix is not specified, a default of null string is assumed.
        /// If disableNationalPrefixForOffNetCalls is not specified, a default of false is assumed.
        /// The following elements are only used in AS data mode:
        /// disableNationalPrefixForOffNetCalls.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCountryCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCountryCodeAddRequest(this OcipClientBase client, SystemCountryCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a country code to the system.
        /// If ringPeriodMilliseconds is not specified, a default of 6000 milliseconds is assumed.
        /// If offHookWarningTimerSeconds is not specified, a default of 30 seconds is assumed.
        /// If enableNationalPrefix is not specified, a default of false is assumed.
        /// If nationalPrefix is not specified, a default of null string is assumed.
        /// If disableNationalPrefixForOffNetCalls is not specified, a default of false is assumed.
        /// The following elements are only used in AS data mode:
        /// disableNationalPrefixForOffNetCalls.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCountryCodeAddRequestAsync(this OcipClientBase client, SystemCountryCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a country code from the system.
        /// A country code cannot be deleted if it is the default country code or
        /// if any carriers or call type mappings are defined against it.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCountryCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCountryCodeDeleteRequest(this OcipClientBase client, SystemCountryCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a country code from the system.
        /// A country code cannot be deleted if it is the default country code or
        /// if any carriers or call type mappings are defined against it.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCountryCodeDeleteRequestAsync(this OcipClientBase client, SystemCountryCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request data for all country codes.
        /// The response is either a SystemCountryCodeGetListResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCountryCodeGetListRequestAsync instead.")]
        public static async Task<SystemCountryCodeGetListResponse> SystemCountryCodeGetListRequest(this OcipClientBase client, SystemCountryCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCountryCodeGetListResponse;
        }

        /// <summary>
        /// Request data for all country codes.
        /// The response is either a SystemCountryCodeGetListResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCountryCodeGetListResponse> SystemCountryCodeGetListRequestAsync(this OcipClientBase client, SystemCountryCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCountryCodeGetListResponse;
        }
        /// <summary>
        /// Modify the attributes of a country code.
        /// If becomeDefaultCountryCode is true, the country code
        /// in this request becomes the default country code for the system.
        /// The following elements are only used in AS data mode:
        /// disableNationalPrefixForOffNetCalls
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCountryCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCountryCodeModifyRequest(this OcipClientBase client, SystemCountryCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the attributes of a country code.
        /// If becomeDefaultCountryCode is true, the country code
        /// in this request becomes the default country code for the system.
        /// The following elements are only used in AS data mode:
        /// disableNationalPrefixForOffNetCalls
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCountryCodeModifyRequestAsync(this OcipClientBase client, SystemCountryCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a device CPE config file server.
        /// The following elements are only used in AS data mode:
        /// extendedCaptureFileRepositoryName
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigAddFileServerRequest14sp6Async instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigAddFileServerRequest14sp6(this OcipClientBase client, SystemCPEConfigAddFileServerRequest14sp6 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a device CPE config file server.
        /// The following elements are only used in AS data mode:
        /// extendedCaptureFileRepositoryName
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigAddFileServerRequest14sp6Async(this OcipClientBase client, SystemCPEConfigAddFileServerRequest14sp6 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a device CPE config file server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigDeleteFileServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigDeleteFileServerRequest(this OcipClientBase client, SystemCPEConfigDeleteFileServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a device CPE config file server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigDeleteFileServerRequestAsync(this OcipClientBase client, SystemCPEConfigDeleteFileServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of device CPE config file servers.
        /// The response is either SystemCPEConfigGetFileServerListResponse14sp6 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigGetFileServerListRequest14sp6Async instead.")]
        public static async Task<SystemCPEConfigGetFileServerListResponse14sp6> SystemCPEConfigGetFileServerListRequest14sp6(this OcipClientBase client, SystemCPEConfigGetFileServerListRequest14sp6 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCPEConfigGetFileServerListResponse14sp6;
        }

        /// <summary>
        /// Requests the list of device CPE config file servers.
        /// The response is either SystemCPEConfigGetFileServerListResponse14sp6 or ErrorResponse.
        /// </summary>
        public static async Task<SystemCPEConfigGetFileServerListResponse14sp6> SystemCPEConfigGetFileServerListRequest14sp6Async(this OcipClientBase client, SystemCPEConfigGetFileServerListRequest14sp6 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCPEConfigGetFileServerListResponse14sp6;
        }
        /// <summary>
        /// Modify a device CPE config file server.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigModifyFileServerRequest14sp6Async instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigModifyFileServerRequest14sp6(this OcipClientBase client, SystemCPEConfigModifyFileServerRequest14sp6 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a device CPE config file server.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigModifyFileServerRequest14sp6Async(this OcipClientBase client, SystemCPEConfigModifyFileServerRequest14sp6 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of CPE Config system parameters.
        /// The response is either SystemCPEConfigParametersGetResponse21 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigParametersGetRequest21Async instead.")]
        public static async Task<SystemCPEConfigParametersGetResponse21> SystemCPEConfigParametersGetRequest21(this OcipClientBase client, SystemCPEConfigParametersGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCPEConfigParametersGetResponse21;
        }

        /// <summary>
        /// Request to get the list of CPE Config system parameters.
        /// The response is either SystemCPEConfigParametersGetResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<SystemCPEConfigParametersGetResponse21> SystemCPEConfigParametersGetRequest21Async(this OcipClientBase client, SystemCPEConfigParametersGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCPEConfigParametersGetResponse21;
        }
        /// <summary>
        /// Request to modify CPE Config system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in the AS data mode and ignored in the XS data mode:
        /// allowDeviceCredentialsRetrieval
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigParametersModifyRequest21Async instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigParametersModifyRequest21(this OcipClientBase client, SystemCPEConfigParametersModifyRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify CPE Config system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in the AS data mode and ignored in the XS data mode:
        /// allowDeviceCredentialsRetrieval
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigParametersModifyRequest21Async(this OcipClientBase client, SystemCPEConfigParametersModifyRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Rebuild the system default config file for the specified device type.
        /// If the device type is not specified, all files for all device types in the system are rebuilt.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigRebuildConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigRebuildConfigFileRequest(this OcipClientBase client, SystemCPEConfigRebuildConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Rebuild the system default config file for the specified device type.
        /// If the device type is not specified, all files for all device types in the system are rebuilt.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigRebuildConfigFileRequestAsync(this OcipClientBase client, SystemCPEConfigRebuildConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Rebuild the config file for a specified device.
        /// The following elements are only used in AS data mode:
        /// force
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigRebuildDeviceConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigRebuildDeviceConfigFileRequest(this OcipClientBase client, SystemCPEConfigRebuildDeviceConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Rebuild the config file for a specified device.
        /// The following elements are only used in AS data mode:
        /// force
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigRebuildDeviceConfigFileRequestAsync(this OcipClientBase client, SystemCPEConfigRebuildDeviceConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reorder the lines of a System device. You can not add or delete line ports, only
        /// re-ordering the list is allowed. The ordered list of line ports can be obtained
        /// with the SystemAccessDeviceGetRequest16 command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigReorderDeviceLinePortsRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigReorderDeviceLinePortsRequest(this OcipClientBase client, SystemCPEConfigReorderDeviceLinePortsRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reorder the lines of a System device. You can not add or delete line ports, only
        /// re-ordering the list is allowed. The ordered list of line ports can be obtained
        /// with the SystemAccessDeviceGetRequest16 command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigReorderDeviceLinePortsRequestAsync(this OcipClientBase client, SystemCPEConfigReorderDeviceLinePortsRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset a specific system device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigResetDeviceRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigResetDeviceRequest(this OcipClientBase client, SystemCPEConfigResetDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific system device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigResetDeviceRequestAsync(this OcipClientBase client, SystemCPEConfigResetDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset all the devices of the specified device type in the system.
        /// If the device type is not specified, all device in the system are reset.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigResetDeviceTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigResetDeviceTypeRequest(this OcipClientBase client, SystemCPEConfigResetDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset all the devices of the specified device type in the system.
        /// If the device type is not specified, all device in the system are reset.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigResetDeviceTypeRequestAsync(this OcipClientBase client, SystemCPEConfigResetDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to set a new system default configuration file for a device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigSetConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigSetConfigFileRequest(this OcipClientBase client, SystemCPEConfigSetConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set a new system default configuration file for a device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigSetConfigFileRequestAsync(this OcipClientBase client, SystemCPEConfigSetConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets the system level attributes of the Cr Interface.
        /// The response is either a SystemCrInterfaceGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCrInterfaceGetRequest22Async instead.")]
        public static async Task<SystemCrInterfaceGetResponse> SystemCrInterfaceGetRequest22(this OcipClientBase client, SystemCrInterfaceGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCrInterfaceGetResponse;
        }

        /// <summary>
        /// Gets the system level attributes of the Cr Interface.
        /// The response is either a SystemCrInterfaceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCrInterfaceGetResponse> SystemCrInterfaceGetRequest22Async(this OcipClientBase client, SystemCrInterfaceGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCrInterfaceGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Cr Interface.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCrInterfaceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCrInterfaceModifyRequest(this OcipClientBase client, SystemCrInterfaceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Cr Interface.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCrInterfaceModifyRequestAsync(this OcipClientBase client, SystemCrInterfaceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of OCI request prefixes including if they trigger DM
        /// automatic rebuild event or not.
        /// The response is either a SystemDeviceManagementAutoRebuildConfigGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementAutoRebuildConfigGetListRequestAsync instead.")]
        public static async Task<SystemDeviceManagementAutoRebuildConfigGetListResponse> SystemDeviceManagementAutoRebuildConfigGetListRequest(this OcipClientBase client, SystemDeviceManagementAutoRebuildConfigGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementAutoRebuildConfigGetListResponse;
        }

        /// <summary>
        /// Request the list of OCI request prefixes including if they trigger DM
        /// automatic rebuild event or not.
        /// The response is either a SystemDeviceManagementAutoRebuildConfigGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementAutoRebuildConfigGetListResponse> SystemDeviceManagementAutoRebuildConfigGetListRequestAsync(this OcipClientBase client, SystemDeviceManagementAutoRebuildConfigGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementAutoRebuildConfigGetListResponse;
        }
        /// <summary>
        /// Request to enable or disable automatic trigger of DM events for
        /// OCI request prefixes, regardless of the request's
        /// version.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementAutoRebuildConfigModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementAutoRebuildConfigModifyListRequest(this OcipClientBase client, SystemDeviceManagementAutoRebuildConfigModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to enable or disable automatic trigger of DM events for
        /// OCI request prefixes, regardless of the request's
        /// version.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementAutoRebuildConfigModifyListRequestAsync(this OcipClientBase client, SystemDeviceManagementAutoRebuildConfigModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a SystemDeviceManagementEventGetListResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementEventGetListRequest22Async instead.")]
        public static async Task<SystemDeviceManagementEventGetListResponse22> SystemDeviceManagementEventGetListRequest22(this OcipClientBase client, SystemDeviceManagementEventGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementEventGetListResponse22;
        }

        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a SystemDeviceManagementEventGetListResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementEventGetListResponse22> SystemDeviceManagementEventGetListRequest22Async(this OcipClientBase client, SystemDeviceManagementEventGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementEventGetListResponse22;
        }
        /// <summary>
        /// Request the number of access device of a particular device type or all
        /// device types if deviceType is not specified.
        /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
        /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
        /// An error is returned if deviceType is specified but does not support device management.
        /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
        /// The response is either SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequestAsync instead.")]
        public static async Task<SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse> SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest(this OcipClientBase client, SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse;
        }

        /// <summary>
        /// Request the number of access device of a particular device type or all
        /// device types if deviceType is not specified.
        /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
        /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
        /// An error is returned if deviceType is specified but does not support device management.
        /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
        /// The response is either SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse> SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequestAsync(this OcipClientBase client, SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse;
        }
        /// <summary>
        /// Request a summary table of the number of events in state 'Pending',
        /// 'Queued Internally', and 'Completed' in the system per action.
        /// One row is returned per action.
        /// Actions are as per the DeviceManagementEventActionType (ex: Delete, Download, Rebuild, Reset, Upload).
        /// The state 'Queued Internally' includes total for events with status
        /// equal to 'Queued' and 'In Progress' as per DeviceManagementEventStatus.
        /// The response is either SystemDeviceManagementGetEventStatusSummaryCountResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementGetEventStatusSummaryCountRequestAsync instead.")]
        public static async Task<SystemDeviceManagementGetEventStatusSummaryCountResponse> SystemDeviceManagementGetEventStatusSummaryCountRequest(this OcipClientBase client, SystemDeviceManagementGetEventStatusSummaryCountRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementGetEventStatusSummaryCountResponse;
        }

        /// <summary>
        /// Request a summary table of the number of events in state 'Pending',
        /// 'Queued Internally', and 'Completed' in the system per action.
        /// One row is returned per action.
        /// Actions are as per the DeviceManagementEventActionType (ex: Delete, Download, Rebuild, Reset, Upload).
        /// The state 'Queued Internally' includes total for events with status
        /// equal to 'Queued' and 'In Progress' as per DeviceManagementEventStatus.
        /// The response is either SystemDeviceManagementGetEventStatusSummaryCountResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementGetEventStatusSummaryCountResponse> SystemDeviceManagementGetEventStatusSummaryCountRequestAsync(this OcipClientBase client, SystemDeviceManagementGetEventStatusSummaryCountRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementGetEventStatusSummaryCountResponse;
        }
        /// <summary>
        /// Cancel pending and in progress events.  Either all events, multiple
        /// events, or a list of specified events can be canceled.
        /// When specifying multiple events, an event must meet all specified
        /// criteria to be canceled.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementInProgressAndPendingEventCancelRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementInProgressAndPendingEventCancelRequest(this OcipClientBase client, SystemDeviceManagementInProgressAndPendingEventCancelRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Cancel pending and in progress events.  Either all events, multiple
        /// events, or a list of specified events can be canceled.
        /// When specifying multiple events, an event must meet all specified
        /// criteria to be canceled.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementInProgressAndPendingEventCancelRequestAsync(this OcipClientBase client, SystemDeviceManagementInProgressAndPendingEventCancelRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Switch the device type for a specified device.
        /// To switch a system level device profile, serviceProviderId and groupId should not be present.
        /// To switch a service provider level device profile, only serviceProviderId should be specified.
        /// To switch a group level device profile, serviceProviderId and groupId should specified.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementSwitchDeviceTypeDeviceRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementSwitchDeviceTypeDeviceRequest(this OcipClientBase client, SystemDeviceManagementSwitchDeviceTypeDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Switch the device type for a specified device.
        /// To switch a system level device profile, serviceProviderId and groupId should not be present.
        /// To switch a service provider level device profile, only serviceProviderId should be specified.
        /// To switch a group level device profile, serviceProviderId and groupId should specified.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementSwitchDeviceTypeDeviceRequestAsync(this OcipClientBase client, SystemDeviceManagementSwitchDeviceTypeDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Switch the device type for all devices at the specified scope for a device type.
        /// To switch all the device type's device profiles for the system, neither the serviceProviderId and groupId should be present.
        /// To switch all the device type's device profiles for a service provider, only serviceProviderId should be specified.
        /// To switch all the device type's device profiles for a group, serviceProviderId and groupId should specified.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementSwitchDeviceTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementSwitchDeviceTypeRequest(this OcipClientBase client, SystemDeviceManagementSwitchDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Switch the device type for all devices at the specified scope for a device type.
        /// To switch all the device type's device profiles for the system, neither the serviceProviderId and groupId should be present.
        /// To switch all the device type's device profiles for a service provider, only serviceProviderId should be specified.
        /// To switch all the device type's device profiles for a group, serviceProviderId and groupId should specified.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementSwitchDeviceTypeRequestAsync(this OcipClientBase client, SystemDeviceManagementSwitchDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a static configuration tag.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// isTagValueEncrypted
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagAddRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagAddRequest22(this OcipClientBase client, SystemDeviceManagementTagAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// isTagValueEncrypted
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagAddRequest22Async(this OcipClientBase client, SystemDeviceManagementTagAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete static configuration tags.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagDeleteListRequest(this OcipClientBase client, SystemDeviceManagementTagDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete static configuration tags.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagDeleteListRequestAsync(this OcipClientBase client, SystemDeviceManagementTagDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System.
        /// The response is either SystemDeviceManagementTagGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagGetListRequestAsync instead.")]
        public static async Task<SystemDeviceManagementTagGetListResponse> SystemDeviceManagementTagGetListRequest(this OcipClientBase client, SystemDeviceManagementTagGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementTagGetListResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System.
        /// The response is either SystemDeviceManagementTagGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementTagGetListResponse> SystemDeviceManagementTagGetListRequestAsync(this OcipClientBase client, SystemDeviceManagementTagGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementTagGetListResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagModifyRequest(this OcipClientBase client, SystemDeviceManagementTagModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagModifyRequestAsync(this OcipClientBase client, SystemDeviceManagementTagModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a static configuration tag set.
        /// When the optional element resellerId is specified, the tag set created is at reseller level. Tag set name
        /// should be unique through out the system including all the reseller level tag sets.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagSetAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetAddRequest(this OcipClientBase client, SystemDeviceManagementTagSetAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag set.
        /// When the optional element resellerId is specified, the tag set created is at reseller level. Tag set name
        /// should be unique through out the system including all the reseller level tag sets.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetAddRequestAsync(this OcipClientBase client, SystemDeviceManagementTagSetAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagSetDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetDeleteRequest(this OcipClientBase client, SystemDeviceManagementTagSetDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetDeleteRequestAsync(this OcipClientBase client, SystemDeviceManagementTagSetDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tag sets managed by the Device Management System.
        /// If excludeReseller is set, only system level tag sets are returned.
        /// If resellerId is specified, all system level tag sets and the tag sets in the reseller are returned.
        /// If reseller administrator sends the request, resellerId is not specified, the administrator's resellerId is used.
        /// If neither excludeReseller nor resellerId is specified, all system level and reseller level tag sets are returned.
        /// 
        /// The response is either SystemDeviceManagementTagSetGetListResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagSetGetListRequest22Async instead.")]
        public static async Task<SystemDeviceManagementTagSetGetListResponse22> SystemDeviceManagementTagSetGetListRequest22(this OcipClientBase client, SystemDeviceManagementTagSetGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementTagSetGetListResponse22;
        }

        /// <summary>
        /// Request to get the list of custom configuration tag sets managed by the Device Management System.
        /// If excludeReseller is set, only system level tag sets are returned.
        /// If resellerId is specified, all system level tag sets and the tag sets in the reseller are returned.
        /// If reseller administrator sends the request, resellerId is not specified, the administrator's resellerId is used.
        /// If neither excludeReseller nor resellerId is specified, all system level and reseller level tag sets are returned.
        /// 
        /// The response is either SystemDeviceManagementTagSetGetListResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementTagSetGetListResponse22> SystemDeviceManagementTagSetGetListRequest22Async(this OcipClientBase client, SystemDeviceManagementTagSetGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementTagSetGetListResponse22;
        }
        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetModifyRequest(this OcipClientBase client, SystemDeviceManagementTagSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetModifyRequestAsync(this OcipClientBase client, SystemDeviceManagementTagSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to clear all device password authentication lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceProfileAuthenticationLockoutClearAllRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationLockoutClearAllRequest(this OcipClientBase client, SystemDeviceProfileAuthenticationLockoutClearAllRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to clear all device password authentication lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationLockoutClearAllRequestAsync(this OcipClientBase client, SystemDeviceProfileAuthenticationLockoutClearAllRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to clear device profile authentication lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceProfileAuthenticationLockoutClearRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationLockoutClearRequest(this OcipClientBase client, SystemDeviceProfileAuthenticationLockoutClearRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to clear device profile authentication lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationLockoutClearRequestAsync(this OcipClientBase client, SystemDeviceProfileAuthenticationLockoutClearRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get device password authentication lockout data in the system.
        /// The response is either a SystemDeviceProfileAuthenticationLockoutGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceProfileAuthenticationLockoutGetRequestAsync instead.")]
        public static async Task<SystemDeviceProfileAuthenticationLockoutGetResponse> SystemDeviceProfileAuthenticationLockoutGetRequest(this OcipClientBase client, SystemDeviceProfileAuthenticationLockoutGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceProfileAuthenticationLockoutGetResponse;
        }

        /// <summary>
        /// Request to get device password authentication lockout data in the system.
        /// The response is either a SystemDeviceProfileAuthenticationLockoutGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceProfileAuthenticationLockoutGetResponse> SystemDeviceProfileAuthenticationLockoutGetRequestAsync(this OcipClientBase client, SystemDeviceProfileAuthenticationLockoutGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceProfileAuthenticationLockoutGetResponse;
        }
        /// <summary>
        /// Request to get the system level device profile authentication password rule settings.
        /// The response is either a SystemDeviceProfileAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceProfileAuthenticationPasswordRulesGetRequestAsync instead.")]
        public static async Task<SystemDeviceProfileAuthenticationPasswordRulesGetResponse> SystemDeviceProfileAuthenticationPasswordRulesGetRequest(this OcipClientBase client, SystemDeviceProfileAuthenticationPasswordRulesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceProfileAuthenticationPasswordRulesGetResponse;
        }

        /// <summary>
        /// Request to get the system level device profile authentication password rule settings.
        /// The response is either a SystemDeviceProfileAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceProfileAuthenticationPasswordRulesGetResponse> SystemDeviceProfileAuthenticationPasswordRulesGetRequestAsync(this OcipClientBase client, SystemDeviceProfileAuthenticationPasswordRulesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceProfileAuthenticationPasswordRulesGetResponse;
        }
        /// <summary>
        /// Request to modify the system level device profile authentication password rule settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceProfileAuthenticationPasswordRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationPasswordRulesModifyRequest(this OcipClientBase client, SystemDeviceProfileAuthenticationPasswordRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system level device profile authentication password rule settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationPasswordRulesModifyRequestAsync(this OcipClientBase client, SystemDeviceProfileAuthenticationPasswordRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to export an existing Device Type to a Device Type Archive File (DTAF).
        /// The response is either a SystemDeviceTypeExportResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeExportRequestAsync instead.")]
        public static async Task<SystemDeviceTypeExportResponse> SystemDeviceTypeExportRequest(this OcipClientBase client, SystemDeviceTypeExportRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeExportResponse;
        }

        /// <summary>
        /// Request to export an existing Device Type to a Device Type Archive File (DTAF).
        /// The response is either a SystemDeviceTypeExportResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceTypeExportResponse> SystemDeviceTypeExportRequestAsync(this OcipClientBase client, SystemDeviceTypeExportRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeExportResponse;
        }
        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system and resellers. It is possible
        /// to get either all conference device types or all non-conference types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// If excludeReseller is specified, only system level available device types are returned.
        /// If resellerId is specified, all the system level available device types and the device types in the given reseller are returned.
        /// If reseller administrator sends the request, resellerId is not specified, the administrator's resellerId is used.
        /// If neither excludeReseller nor resellerId is specified, all the system level and reseller level available device types are returned.
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// resellerId
        /// 
        /// The response is either SystemDeviceTypeGetAvailableListResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetAvailableListRequest22Async instead.")]
        public static async Task<SystemDeviceTypeGetAvailableListResponse22> SystemDeviceTypeGetAvailableListRequest22(this OcipClientBase client, SystemDeviceTypeGetAvailableListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetAvailableListResponse22;
        }

        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system and resellers. It is possible
        /// to get either all conference device types or all non-conference types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// If excludeReseller is specified, only system level available device types are returned.
        /// If resellerId is specified, all the system level available device types and the device types in the given reseller are returned.
        /// If reseller administrator sends the request, resellerId is not specified, the administrator's resellerId is used.
        /// If neither excludeReseller nor resellerId is specified, all the system level and reseller level available device types are returned.
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// resellerId
        /// 
        /// The response is either SystemDeviceTypeGetAvailableListResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceTypeGetAvailableListResponse22> SystemDeviceTypeGetAvailableListRequest22Async(this OcipClientBase client, SystemDeviceTypeGetAvailableListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetAvailableListResponse22;
        }
        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetRequest22Async instead.")]
        public static async Task<SystemDeviceTypeGetResponse22> SystemDeviceTypeGetRequest22(this OcipClientBase client, SystemDeviceTypeGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetResponse22;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse22> SystemDeviceTypeGetRequest22Async(this OcipClientBase client, SystemDeviceTypeGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetResponse22;
        }
        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22V2 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetRequest22V2Async instead.")]
        public static async Task<SystemDeviceTypeGetResponse22V2> SystemDeviceTypeGetRequest22V2(this OcipClientBase client, SystemDeviceTypeGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetResponse22V2;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22V2 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse22V2> SystemDeviceTypeGetRequest22V2Async(this OcipClientBase client, SystemDeviceTypeGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetResponse22V2;
        }
        /// <summary>
        /// Request to import a Device Type Archive File (DTAF) as a new Device Type.  The URL supports the HTTP and the FILE protocols.
        /// When the optional element resellerId is specified, the device type created is at reseller level.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode and ignored in XS data mode:
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeImportRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceTypeImportRequest(this OcipClientBase client, SystemDeviceTypeImportRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to import a Device Type Archive File (DTAF) as a new Device Type.  The URL supports the HTTP and the FILE protocols.
        /// When the optional element resellerId is specified, the device type created is at reseller level.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode and ignored in XS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceTypeImportRequestAsync(this OcipClientBase client, SystemDeviceTypeImportRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Dialable Caller ID Criteria. Criteria are added at the bottom of the list with the lowest priority. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDCriteriaAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaAddRequest(this OcipClientBase client, SystemDialableCallerIDCriteriaAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Dialable Caller ID Criteria. Criteria are added at the bottom of the list with the lowest priority. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaAddRequestAsync(this OcipClientBase client, SystemDialableCallerIDCriteriaAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaDeleteRequest(this OcipClientBase client, SystemDialableCallerIDCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaDeleteRequestAsync(this OcipClientBase client, SystemDialableCallerIDCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get an existing Dialable Caller ID Criteria.
        /// The response is either a SystemDialableCallerIDCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDCriteriaGetRequestAsync instead.")]
        public static async Task<SystemDialableCallerIDCriteriaGetResponse> SystemDialableCallerIDCriteriaGetRequest(this OcipClientBase client, SystemDialableCallerIDCriteriaGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialableCallerIDCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Dialable Caller ID Criteria.
        /// The response is either a SystemDialableCallerIDCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDialableCallerIDCriteriaGetResponse> SystemDialableCallerIDCriteriaGetRequestAsync(this OcipClientBase client, SystemDialableCallerIDCriteriaGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialableCallerIDCriteriaGetResponse;
        }
        /// <summary>
        /// Modify a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaModifyRequest(this OcipClientBase client, SystemDialableCallerIDCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaModifyRequestAsync(this OcipClientBase client, SystemDialableCallerIDCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system level Dialable Caller ID criteria list.
        /// The response is either a SystemDialableCallerIDGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDGetRequestAsync instead.")]
        public static async Task<SystemDialableCallerIDGetResponse> SystemDialableCallerIDGetRequest(this OcipClientBase client, SystemDialableCallerIDGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialableCallerIDGetResponse;
        }

        /// <summary>
        /// Get the system level Dialable Caller ID criteria list.
        /// The response is either a SystemDialableCallerIDGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDialableCallerIDGetResponse> SystemDialableCallerIDGetRequestAsync(this OcipClientBase client, SystemDialableCallerIDGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialableCallerIDGetResponse;
        }
        /// <summary>
        /// Modify the system level Dialable Caller ID criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialableCallerIDModifyRequest(this OcipClientBase client, SystemDialableCallerIDModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level Dialable Caller ID criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialableCallerIDModifyRequestAsync(this OcipClientBase client, SystemDialableCallerIDModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a system-level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyAddAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialPlanPolicyAddAccessCodeRequest(this OcipClientBase client, SystemDialPlanPolicyAddAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system-level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialPlanPolicyAddAccessCodeRequestAsync(this OcipClientBase client, SystemDialPlanPolicyAddAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a system-level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyDeleteAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialPlanPolicyDeleteAccessCodeRequest(this OcipClientBase client, SystemDialPlanPolicyDeleteAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a system-level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialPlanPolicyDeleteAccessCodeRequestAsync(this OcipClientBase client, SystemDialPlanPolicyDeleteAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level Access Codes data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetAccessCodeListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyGetAccessCodeListRequestAsync instead.")]
        public static async Task<SystemDialPlanPolicyGetAccessCodeListResponse> SystemDialPlanPolicyGetAccessCodeListRequest(this OcipClientBase client, SystemDialPlanPolicyGetAccessCodeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialPlanPolicyGetAccessCodeListResponse;
        }

        /// <summary>
        /// Request the system level Access Codes data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetAccessCodeListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDialPlanPolicyGetAccessCodeListResponse> SystemDialPlanPolicyGetAccessCodeListRequestAsync(this OcipClientBase client, SystemDialPlanPolicyGetAccessCodeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialPlanPolicyGetAccessCodeListResponse;
        }
        /// <summary>
        /// Request access code data associated with system level Dial Plan Policy access codes.
        /// The response is either a SystemDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyGetAccessCodeRequestAsync instead.")]
        public static async Task<SystemDialPlanPolicyGetAccessCodeResponse> SystemDialPlanPolicyGetAccessCodeRequest(this OcipClientBase client, SystemDialPlanPolicyGetAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialPlanPolicyGetAccessCodeResponse;
        }

        /// <summary>
        /// Request access code data associated with system level Dial Plan Policy access codes.
        /// The response is either a SystemDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDialPlanPolicyGetAccessCodeResponse> SystemDialPlanPolicyGetAccessCodeRequestAsync(this OcipClientBase client, SystemDialPlanPolicyGetAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialPlanPolicyGetAccessCodeResponse;
        }
        /// <summary>
        /// Request the system level data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetResponse17 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyGetRequest17Async instead.")]
        public static async Task<SystemDialPlanPolicyGetResponse17> SystemDialPlanPolicyGetRequest17(this OcipClientBase client, SystemDialPlanPolicyGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialPlanPolicyGetResponse17;
        }

        /// <summary>
        /// Request the system level data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetResponse17 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemDialPlanPolicyGetResponse17> SystemDialPlanPolicyGetRequest17Async(this OcipClientBase client, SystemDialPlanPolicyGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialPlanPolicyGetResponse17;
        }
        /// <summary>
        /// Request to modify a system-level Dial Plan Access Code and its attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyModifyAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialPlanPolicyModifyAccessCodeRequest(this OcipClientBase client, SystemDialPlanPolicyModifyAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a system-level Dial Plan Access Code and its attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialPlanPolicyModifyAccessCodeRequestAsync(this OcipClientBase client, SystemDialPlanPolicyModifyAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Dial Plan Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialPlanPolicyModifyRequest(this OcipClientBase client, SystemDialPlanPolicyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Dial Plan Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialPlanPolicyModifyRequestAsync(this OcipClientBase client, SystemDialPlanPolicyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system's digit collection attributes.
        /// The response is either a SystemDigitCollectionGetResponse13mp4 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDigitCollectionGetRequest13mp4Async instead.")]
        public static async Task<SystemDigitCollectionGetResponse13mp4> SystemDigitCollectionGetRequest13mp4(this OcipClientBase client, SystemDigitCollectionGetRequest13mp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDigitCollectionGetResponse13mp4;
        }

        /// <summary>
        /// Request the system's digit collection attributes.
        /// The response is either a SystemDigitCollectionGetResponse13mp4 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDigitCollectionGetResponse13mp4> SystemDigitCollectionGetRequest13mp4Async(this OcipClientBase client, SystemDigitCollectionGetRequest13mp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDigitCollectionGetResponse13mp4;
        }
        /// <summary>
        /// Modifies the system's digit collection attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDigitCollectionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDigitCollectionModifyRequest(this OcipClientBase client, SystemDigitCollectionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's digit collection attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDigitCollectionModifyRequestAsync(this OcipClientBase client, SystemDigitCollectionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a summary table of all DNs in the system. If resellerId is specified,
        /// the DNs assigned to the enterprises/service providers within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// The search can be done using multiple criteria. Only results matching all the search criteria are included in the results.
        /// 
        /// The response is either SystemDnGetSummaryListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaDn, searchCriteriaServiceProviderId, searchCriteriaExactOrganizationType
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDnGetSummaryListRequestAsync instead.")]
        public static async Task<SystemDnGetSummaryListResponse> SystemDnGetSummaryListRequest(this OcipClientBase client, SystemDnGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDnGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all DNs in the system. If resellerId is specified,
        /// the DNs assigned to the enterprises/service providers within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// The search can be done using multiple criteria. Only results matching all the search criteria are included in the results.
        /// 
        /// The response is either SystemDnGetSummaryListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaDn, searchCriteriaServiceProviderId, searchCriteriaExactOrganizationType
        /// </summary>
        public static async Task<SystemDnGetSummaryListResponse> SystemDnGetSummaryListRequestAsync(this OcipClientBase client, SystemDnGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDnGetSummaryListResponse;
        }
        /// <summary>
        /// Request a list of DN utilizations by service providers. If resellerId is specified,
        /// the DNs assigned to the enterprises/service providers within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDnGetUtilizationListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDnGetUtilizationListRequestAsync instead.")]
        public static async Task<SystemDnGetUtilizationListResponse> SystemDnGetUtilizationListRequest(this OcipClientBase client, SystemDnGetUtilizationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDnGetUtilizationListResponse;
        }

        /// <summary>
        /// Request a list of DN utilizations by service providers. If resellerId is specified,
        /// the DNs assigned to the enterprises/service providers within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDnGetUtilizationListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SystemDnGetUtilizationListResponse> SystemDnGetUtilizationListRequestAsync(this OcipClientBase client, SystemDnGetUtilizationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDnGetUtilizationListResponse;
        }
        /// <summary>
        /// Get the utilization of a single DN.
        /// The response is either SystemDnGetUtilizationResponse14sp3 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDnGetUtilizationRequest14sp3Async instead.")]
        public static async Task<SystemDnGetUtilizationResponse14sp3> SystemDnGetUtilizationRequest14sp3(this OcipClientBase client, SystemDnGetUtilizationRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDnGetUtilizationResponse14sp3;
        }

        /// <summary>
        /// Get the utilization of a single DN.
        /// The response is either SystemDnGetUtilizationResponse14sp3 or ErrorResponse.
        /// </summary>
        public static async Task<SystemDnGetUtilizationResponse14sp3> SystemDnGetUtilizationRequest14sp3Async(this OcipClientBase client, SystemDnGetUtilizationRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDnGetUtilizationResponse14sp3;
        }
        /// <summary>
        /// Add a system or reseller domain to the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDomainAddRequest(this OcipClientBase client, SystemDomainAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system or reseller domain to the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDomainAddRequestAsync(this OcipClientBase client, SystemDomainAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system domain from the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDomainDeleteRequest(this OcipClientBase client, SystemDomainDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system domain from the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDomainDeleteRequestAsync(this OcipClientBase client, SystemDomainDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of service providers that have a given domain assigned.
        /// If resellerId is specified, only the service providers within the reseller should be returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetAssignedServiceProviderListResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainGetAssignedServiceProviderListRequestAsync instead.")]
        public static async Task<SystemDomainGetAssignedServiceProviderListResponse> SystemDomainGetAssignedServiceProviderListRequest(this OcipClientBase client, SystemDomainGetAssignedServiceProviderListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDomainGetAssignedServiceProviderListResponse;
        }

        /// <summary>
        /// Request a list of service providers that have a given domain assigned.
        /// If resellerId is specified, only the service providers within the reseller should be returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetAssignedServiceProviderListResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SystemDomainGetAssignedServiceProviderListResponse> SystemDomainGetAssignedServiceProviderListRequestAsync(this OcipClientBase client, SystemDomainGetAssignedServiceProviderListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDomainGetAssignedServiceProviderListResponse;
        }
        /// <summary>
        /// Requests the list of all system-level domains and all reseller level domains.
        /// If excludeReseller is specified, returns all the system-level domain names only.
        /// If resellerId is specified, returns all the system-level domain names and the given reseller's domains.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetListResponse22 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// includeReseller
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainGetListRequest22Async instead.")]
        public static async Task<SystemDomainGetListResponse22> SystemDomainGetListRequest22(this OcipClientBase client, SystemDomainGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDomainGetListResponse22;
        }

        /// <summary>
        /// Requests the list of all system-level domains and all reseller level domains.
        /// If excludeReseller is specified, returns all the system-level domain names only.
        /// If resellerId is specified, returns all the system-level domain names and the given reseller's domains.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetListResponse22 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// includeReseller
        /// resellerId
        /// </summary>
        public static async Task<SystemDomainGetListResponse22> SystemDomainGetListRequest22Async(this OcipClientBase client, SystemDomainGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDomainGetListResponse22;
        }
        /// <summary>
        /// Requests the list of all matching system-level domains and all matching reseller level domains.
        /// If excludeReseller is specified, returns all matching system-level domain names only.
        /// If resellerId is specified, returns all matching system-level domain names and the given reseller's domains.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetListResponse22V2 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and will be ignored in XS data mode:
        /// includeReseller
        /// resellerId
        /// responseSizeLimit
        /// searchCriteriaDomainName
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainGetListRequest22V2Async instead.")]
        public static async Task<SystemDomainGetListResponse22V2> SystemDomainGetListRequest22V2(this OcipClientBase client, SystemDomainGetListRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDomainGetListResponse22V2;
        }

        /// <summary>
        /// Requests the list of all matching system-level domains and all matching reseller level domains.
        /// If excludeReseller is specified, returns all matching system-level domain names only.
        /// If resellerId is specified, returns all matching system-level domain names and the given reseller's domains.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetListResponse22V2 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and will be ignored in XS data mode:
        /// includeReseller
        /// resellerId
        /// responseSizeLimit
        /// searchCriteriaDomainName
        /// </summary>
        public static async Task<SystemDomainGetListResponse22V2> SystemDomainGetListRequest22V2Async(this OcipClientBase client, SystemDomainGetListRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDomainGetListResponse22V2;
        }
        /// <summary>
        /// Request to get the list of system Domain parameters.
        /// The response is either SystemDomainParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainParametersGetRequestAsync instead.")]
        public static async Task<SystemDomainParametersGetResponse> SystemDomainParametersGetRequest(this OcipClientBase client, SystemDomainParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDomainParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of system Domain parameters.
        /// The response is either SystemDomainParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDomainParametersGetResponse> SystemDomainParametersGetRequestAsync(this OcipClientBase client, SystemDomainParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDomainParametersGetResponse;
        }
        /// <summary>
        /// Request to modify system Domain parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useAliasForDomain
        /// 
        /// The following elements are only used in AS and XS data mode and ignored in Amplify data mode:
        /// defaultDomain
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDomainParametersModifyRequest(this OcipClientBase client, SystemDomainParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify system Domain parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useAliasForDomain
        /// 
        /// The following elements are only used in AS and XS data mode and ignored in Amplify data mode:
        /// defaultDomain
        /// </summary>
        public static async Task<SuccessResponse> SystemDomainParametersModifyRequestAsync(this OcipClientBase client, SystemDomainParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system DTMF transmission configurations.
        /// The response is either SystemDTMFTransmissionGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDTMFTransmissionGetRequestAsync instead.")]
        public static async Task<SystemDTMFTransmissionGetResponse> SystemDTMFTransmissionGetRequest(this OcipClientBase client, SystemDTMFTransmissionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDTMFTransmissionGetResponse;
        }

        /// <summary>
        /// Get the system DTMF transmission configurations.
        /// The response is either SystemDTMFTransmissionGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDTMFTransmissionGetResponse> SystemDTMFTransmissionGetRequestAsync(this OcipClientBase client, SystemDTMFTransmissionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDTMFTransmissionGetResponse;
        }
        /// <summary>
        /// Modify the DTMF transmission settings.
        /// The response is either SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDTMFTransmissionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDTMFTransmissionModifyRequest(this OcipClientBase client, SystemDTMFTransmissionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the DTMF transmission settings.
        /// The response is either SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDTMFTransmissionModifyRequestAsync(this OcipClientBase client, SystemDTMFTransmissionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system Emergency Call DDos Protection configurations.
        /// The response is either SystemEmergencyCallDDoSProtectionGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyCallDDoSProtectionGetRequestAsync instead.")]
        public static async Task<SystemEmergencyCallDDoSProtectionGetResponse> SystemEmergencyCallDDoSProtectionGetRequest(this OcipClientBase client, SystemEmergencyCallDDoSProtectionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEmergencyCallDDoSProtectionGetResponse;
        }

        /// <summary>
        /// Get the system Emergency Call DDos Protection configurations.
        /// The response is either SystemEmergencyCallDDoSProtectionGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemEmergencyCallDDoSProtectionGetResponse> SystemEmergencyCallDDoSProtectionGetRequestAsync(this OcipClientBase client, SystemEmergencyCallDDoSProtectionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEmergencyCallDDoSProtectionGetResponse;
        }
        /// <summary>
        /// Modify the Emergency Call DDos Protection settings.
        /// The response is either SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyCallDDoSProtectionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemEmergencyCallDDoSProtectionModifyRequest(this OcipClientBase client, SystemEmergencyCallDDoSProtectionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Emergency Call DDos Protection settings.
        /// The response is either SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemEmergencyCallDDoSProtectionModifyRequestAsync(this OcipClientBase client, SystemEmergencyCallDDoSProtectionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Emergency Call Notification.
        /// The response is either a SystemEmergencyCallNotificationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyCallNotificationGetRequestAsync instead.")]
        public static async Task<SystemEmergencyCallNotificationGetResponse> SystemEmergencyCallNotificationGetRequest(this OcipClientBase client, SystemEmergencyCallNotificationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEmergencyCallNotificationGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Emergency Call Notification.
        /// The response is either a SystemEmergencyCallNotificationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemEmergencyCallNotificationGetResponse> SystemEmergencyCallNotificationGetRequestAsync(this OcipClientBase client, SystemEmergencyCallNotificationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEmergencyCallNotificationGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Emergency Call Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyCallNotificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemEmergencyCallNotificationModifyRequest(this OcipClientBase client, SystemEmergencyCallNotificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Emergency Call Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemEmergencyCallNotificationModifyRequestAsync(this OcipClientBase client, SystemEmergencyCallNotificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to search endpoints in the system.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All endpoints
        /// in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemEndpointGetListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEndpointGetListRequestAsync instead.")]
        public static async Task<SystemEndpointGetListResponse> SystemEndpointGetListRequest(this OcipClientBase client, SystemEndpointGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEndpointGetListResponse;
        }

        /// <summary>
        /// Request to search endpoints in the system.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All endpoints
        /// in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemEndpointGetListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<SystemEndpointGetListResponse> SystemEndpointGetListRequestAsync(this OcipClientBase client, SystemEndpointGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEndpointGetListResponse;
        }
        /// <summary>
        /// Request to get the expensive call notification service parameters.
        /// The response is either a SystemExpensiveCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallNotificationGetRequestAsync instead.")]
        public static async Task<SystemExpensiveCallNotificationGetResponse> SystemExpensiveCallNotificationGetRequest(this OcipClientBase client, SystemExpensiveCallNotificationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExpensiveCallNotificationGetResponse;
        }

        /// <summary>
        /// Request to get the expensive call notification service parameters.
        /// The response is either a SystemExpensiveCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemExpensiveCallNotificationGetResponse> SystemExpensiveCallNotificationGetRequestAsync(this OcipClientBase client, SystemExpensiveCallNotificationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExpensiveCallNotificationGetResponse;
        }
        /// <summary>
        /// Modify the expensive call notification service parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallNotificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExpensiveCallNotificationModifyRequest(this OcipClientBase client, SystemExpensiveCallNotificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the expensive call notification service parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExpensiveCallNotificationModifyRequestAsync(this OcipClientBase client, SystemExpensiveCallNotificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an alternate call indicator to the list of expensive alternate call indicators.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallTypeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExpensiveCallTypeAddRequest(this OcipClientBase client, SystemExpensiveCallTypeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an alternate call indicator to the list of expensive alternate call indicators.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExpensiveCallTypeAddRequestAsync(this OcipClientBase client, SystemExpensiveCallTypeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an alternate call indicator from the list of expensive alternate call indicators.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallTypeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExpensiveCallTypeDeleteRequest(this OcipClientBase client, SystemExpensiveCallTypeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an alternate call indicator from the list of expensive alternate call indicators.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExpensiveCallTypeDeleteRequestAsync(this OcipClientBase client, SystemExpensiveCallTypeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of expensive alternate call indicators in the system.
        /// The response is either a SystemExpensiveCallTypeGetListResponse16sp1
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallTypeGetListRequest16sp1Async instead.")]
        public static async Task<SystemExpensiveCallTypeGetListResponse16sp1> SystemExpensiveCallTypeGetListRequest16sp1(this OcipClientBase client, SystemExpensiveCallTypeGetListRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExpensiveCallTypeGetListResponse16sp1;
        }

        /// <summary>
        /// Request to get the list of expensive alternate call indicators in the system.
        /// The response is either a SystemExpensiveCallTypeGetListResponse16sp1
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemExpensiveCallTypeGetListResponse16sp1> SystemExpensiveCallTypeGetListRequest16sp1Async(this OcipClientBase client, SystemExpensiveCallTypeGetListRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExpensiveCallTypeGetListResponse16sp1;
        }
        /// <summary>
        /// Modify an existing call indicator in the list of expensive alternate call indicators.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallTypeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExpensiveCallTypeModifyRequest(this OcipClientBase client, SystemExpensiveCallTypeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing call indicator in the list of expensive alternate call indicators.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExpensiveCallTypeModifyRequestAsync(this OcipClientBase client, SystemExpensiveCallTypeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to export Application Server addressing data, such as DNs, extensions, alias and user ids
        /// to a file so they can be uploaded to a Network Server.
        /// In XS data mode, response is sent without waiting for completion.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExportAddressingDataRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExportAddressingDataRequest(this OcipClientBase client, SystemExportAddressingDataRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to export Application Server addressing data, such as DNs, extensions, alias and user ids
        /// to a file so they can be uploaded to a Network Server.
        /// In XS data mode, response is sent without waiting for completion.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExportAddressingDataRequestAsync(this OcipClientBase client, SystemExportAddressingDataRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to export all users that have BroadCloud services, such as
        /// user profile information and BroadCloud services related information for that user
        /// to a file so they can be uploaded to a Messaging Server/BroadCloud.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExportBroadCloudDataRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExportBroadCloudDataRequest(this OcipClientBase client, SystemExportBroadCloudDataRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to export all users that have BroadCloud services, such as
        /// user profile information and BroadCloud services related information for that user
        /// to a file so they can be uploaded to a Messaging Server/BroadCloud.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExportBroadCloudDataRequestAsync(this OcipClientBase client, SystemExportBroadCloudDataRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request subscribers be exported to files on the AS filesystem.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// 
        /// ***** Warning *****:
        /// This activity should only be done during non-busy hours on the secondary
        /// provisioning server because this may cause large amounts of data to be
        /// dumped to disk and it may take some time to execute.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExportSubscriberRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExportSubscriberRequest(this OcipClientBase client, SystemExportSubscriberRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request subscribers be exported to files on the AS filesystem.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// 
        /// ***** Warning *****:
        /// This activity should only be done during non-busy hours on the secondary
        /// provisioning server because this may cause large amounts of data to be
        /// dumped to disk and it may take some time to execute.
        /// </summary>
        public static async Task<SuccessResponse> SystemExportSubscriberRequestAsync(this OcipClientBase client, SystemExportSubscriberRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system's extension range.
        /// The response is either a SystemExtensionLengthGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExtensionLengthGetRequestAsync instead.")]
        public static async Task<SystemExtensionLengthGetResponse> SystemExtensionLengthGetRequest(this OcipClientBase client, SystemExtensionLengthGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExtensionLengthGetResponse;
        }

        /// <summary>
        /// Request the system's extension range.
        /// The response is either a SystemExtensionLengthGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemExtensionLengthGetResponse> SystemExtensionLengthGetRequestAsync(this OcipClientBase client, SystemExtensionLengthGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExtensionLengthGetResponse;
        }
        /// <summary>
        /// Modify the group's extension length range.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExtensionLengthModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExtensionLengthModifyRequest(this OcipClientBase client, SystemExtensionLengthModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's extension length range.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExtensionLengthModifyRequestAsync(this OcipClientBase client, SystemExtensionLengthModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalAuthenticationAddACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemExternalAuthenticationAddACLEntryRequest14sp2(this OcipClientBase client, SystemExternalAuthenticationAddACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalAuthenticationAddACLEntryRequest14sp2Async(this OcipClientBase client, SystemExternalAuthenticationAddACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalAuthenticationDeleteACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemExternalAuthenticationDeleteACLEntryRequest14sp2(this OcipClientBase client, SystemExternalAuthenticationDeleteACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalAuthenticationDeleteACLEntryRequest14sp2Async(this OcipClientBase client, SystemExternalAuthenticationDeleteACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the external authentication access control list.
        /// The response is either SystemExternalAuthenticationGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalAuthenticationGetACLListRequestAsync instead.")]
        public static async Task<SystemExternalAuthenticationGetACLListResponse> SystemExternalAuthenticationGetACLListRequest(this OcipClientBase client, SystemExternalAuthenticationGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExternalAuthenticationGetACLListResponse;
        }

        /// <summary>
        /// Get the external authentication access control list.
        /// The response is either SystemExternalAuthenticationGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemExternalAuthenticationGetACLListResponse> SystemExternalAuthenticationGetACLListRequestAsync(this OcipClientBase client, SystemExternalAuthenticationGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExternalAuthenticationGetACLListResponse;
        }
        /// <summary>
        /// Modify an entry from the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalAuthenticationModifyACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemExternalAuthenticationModifyACLEntryRequest14sp2(this OcipClientBase client, SystemExternalAuthenticationModifyACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalAuthenticationModifyACLEntryRequest14sp2Async(this OcipClientBase client, SystemExternalAuthenticationModifyACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of External Emergency Routing system parameters.
        /// The response is either SystemExternalEmergencyRoutingParametersGetResponse13mp13 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalEmergencyRoutingParametersGetRequest13mp13Async instead.")]
        public static async Task<SystemExternalEmergencyRoutingParametersGetResponse13mp13> SystemExternalEmergencyRoutingParametersGetRequest13mp13(this OcipClientBase client, SystemExternalEmergencyRoutingParametersGetRequest13mp13 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExternalEmergencyRoutingParametersGetResponse13mp13;
        }

        /// <summary>
        /// Request to get the list of External Emergency Routing system parameters.
        /// The response is either SystemExternalEmergencyRoutingParametersGetResponse13mp13 or ErrorResponse.
        /// </summary>
        public static async Task<SystemExternalEmergencyRoutingParametersGetResponse13mp13> SystemExternalEmergencyRoutingParametersGetRequest13mp13Async(this OcipClientBase client, SystemExternalEmergencyRoutingParametersGetRequest13mp13 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExternalEmergencyRoutingParametersGetResponse13mp13;
        }
        /// <summary>
        /// Request to modify Call External Emergency Routing system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalEmergencyRoutingParametersModifyRequest13mp13Async instead.")]
        public static async Task<SuccessResponse> SystemExternalEmergencyRoutingParametersModifyRequest13mp13(this OcipClientBase client, SystemExternalEmergencyRoutingParametersModifyRequest13mp13 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Call External Emergency Routing system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalEmergencyRoutingParametersModifyRequest13mp13Async(this OcipClientBase client, SystemExternalEmergencyRoutingParametersModifyRequest13mp13 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get list of default Feature Access Codes defined on system
        /// level.
        /// The response is either SystemFeatureAccessCodeGetListResponse20 or
        /// ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFeatureAccessCodeGetListRequest21Async instead.")]
        public static async Task<SystemFeatureAccessCodeGetListResponse20> SystemFeatureAccessCodeGetListRequest21(this OcipClientBase client, SystemFeatureAccessCodeGetListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFeatureAccessCodeGetListResponse20;
        }

        /// <summary>
        /// Request to get list of default Feature Access Codes defined on system
        /// level.
        /// The response is either SystemFeatureAccessCodeGetListResponse20 or
        /// ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        public static async Task<SystemFeatureAccessCodeGetListResponse20> SystemFeatureAccessCodeGetListRequest21Async(this OcipClientBase client, SystemFeatureAccessCodeGetListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFeatureAccessCodeGetListResponse20;
        }
        /// <summary>
        /// Modify default Feature Access Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFeatureAccessCodeModifyListRequest21Async instead.")]
        public static async Task<SuccessResponse> SystemFeatureAccessCodeModifyListRequest21(this OcipClientBase client, SystemFeatureAccessCodeModifyListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify default Feature Access Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        public static async Task<SuccessResponse> SystemFeatureAccessCodeModifyListRequest21Async(this OcipClientBase client, SystemFeatureAccessCodeModifyListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the contents of a file.  This transaction is only allowed to get content for files under
        /// /var/broadworks/userfiles/AuditLogs/ or /var/broadworks/IpDeviceConfig/.
        /// The response is either a SystemFileGetContentResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileGetContentRequestAsync instead.")]
        public static async Task<SystemFileGetContentResponse> SystemFileGetContentRequest(this OcipClientBase client, SystemFileGetContentRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileGetContentResponse;
        }

        /// <summary>
        /// Requests the contents of a file.  This transaction is only allowed to get content for files under
        /// /var/broadworks/userfiles/AuditLogs/ or /var/broadworks/IpDeviceConfig/.
        /// The response is either a SystemFileGetContentResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemFileGetContentResponse> SystemFileGetContentRequestAsync(this OcipClientBase client, SystemFileGetContentRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileGetContentResponse;
        }
        /// <summary>
        /// Add a new file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceAddRequest20Async instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceAddRequest20(this OcipClientBase client, SystemFileRepositoryDeviceAddRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceAddRequest20Async(this OcipClientBase client, SystemFileRepositoryDeviceAddRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceDeleteRequest(this OcipClientBase client, SystemFileRepositoryDeviceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceDeleteRequestAsync(this OcipClientBase client, SystemFileRepositoryDeviceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of file repositories in the system.
        /// The response is either a SystemFileRepositoryDeviceGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceGetListRequestAsync instead.")]
        public static async Task<SystemFileRepositoryDeviceGetListResponse> SystemFileRepositoryDeviceGetListRequest(this OcipClientBase client, SystemFileRepositoryDeviceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileRepositoryDeviceGetListResponse;
        }

        /// <summary>
        /// Request the list of file repositories in the system.
        /// The response is either a SystemFileRepositoryDeviceGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceGetListResponse> SystemFileRepositoryDeviceGetListRequestAsync(this OcipClientBase client, SystemFileRepositoryDeviceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileRepositoryDeviceGetListResponse;
        }
        /// <summary>
        /// Request to get the file repository information.  The response is either SystemFileRepositoryDeviceGetResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceGetRequest20Async instead.")]
        public static async Task<SystemFileRepositoryDeviceGetResponse20> SystemFileRepositoryDeviceGetRequest20(this OcipClientBase client, SystemFileRepositoryDeviceGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileRepositoryDeviceGetResponse20;
        }

        /// <summary>
        /// Request to get the file repository information.  The response is either SystemFileRepositoryDeviceGetResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceGetResponse20> SystemFileRepositoryDeviceGetRequest20Async(this OcipClientBase client, SystemFileRepositoryDeviceGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileRepositoryDeviceGetResponse20;
        }
        /// <summary>
        /// Modify a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceModifyRequest(this OcipClientBase client, SystemFileRepositoryDeviceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceModifyRequestAsync(this OcipClientBase client, SystemFileRepositoryDeviceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the file repository information.  The response is either SystemFileRepositoryDeviceGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceGetRequest22Async instead.")]
        public static async Task<SystemFileRepositoryDeviceGetResponse22> SystemFileRepositoryDeviceGetRequest22(this OcipClientBase client, SystemFileRepositoryDeviceGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileRepositoryDeviceGetResponse22;
        }

        /// <summary>
        /// Request to get the file repository information.  The response is either SystemFileRepositoryDeviceGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceGetResponse22> SystemFileRepositoryDeviceGetRequest22Async(this OcipClientBase client, SystemFileRepositoryDeviceGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileRepositoryDeviceGetResponse22;
        }
        /// <summary>
        /// Modify a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceModifyRequest22(this OcipClientBase client, SystemFileRepositoryDeviceModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceModifyRequest22Async(this OcipClientBase client, SystemFileRepositoryDeviceModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceUserAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserAddRequest(this OcipClientBase client, SystemFileRepositoryDeviceUserAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserAddRequestAsync(this OcipClientBase client, SystemFileRepositoryDeviceUserAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceUserDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserDeleteRequest(this OcipClientBase client, SystemFileRepositoryDeviceUserDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserDeleteRequestAsync(this OcipClientBase client, SystemFileRepositoryDeviceUserDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of users for a file repository in the system.
        /// The response is either a SystemFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceUserGetListRequestAsync instead.")]
        public static async Task<SystemFileRepositoryDeviceUserGetListResponse> SystemFileRepositoryDeviceUserGetListRequest(this OcipClientBase client, SystemFileRepositoryDeviceUserGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileRepositoryDeviceUserGetListResponse;
        }

        /// <summary>
        /// Request the list of users for a file repository in the system.
        /// The response is either a SystemFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceUserGetListResponse> SystemFileRepositoryDeviceUserGetListRequestAsync(this OcipClientBase client, SystemFileRepositoryDeviceUserGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileRepositoryDeviceUserGetListResponse;
        }
        /// <summary>
        /// Request a user of a file repository in the system.
        /// The response is either a SystemFileRepositoryDeviceUserGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceUserGetRequestAsync instead.")]
        public static async Task<SystemFileRepositoryDeviceUserGetResponse> SystemFileRepositoryDeviceUserGetRequest(this OcipClientBase client, SystemFileRepositoryDeviceUserGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileRepositoryDeviceUserGetResponse;
        }

        /// <summary>
        /// Request a user of a file repository in the system.
        /// The response is either a SystemFileRepositoryDeviceUserGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceUserGetResponse> SystemFileRepositoryDeviceUserGetRequestAsync(this OcipClientBase client, SystemFileRepositoryDeviceUserGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileRepositoryDeviceUserGetResponse;
        }
        /// <summary>
        /// Modify a file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceUserModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserModifyRequest(this OcipClientBase client, SystemFileRepositoryDeviceUserModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserModifyRequestAsync(this OcipClientBase client, SystemFileRepositoryDeviceUserModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Peer SIP Connection system parameters
        /// The response is a SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequestAsync instead.")]
        public static async Task<SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse> SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest(this OcipClientBase client, SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse;
        }

        /// <summary>
        /// Request to get the list of Peer SIP Connection system parameters
        /// The response is a SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse.
        /// </summary>
        public static async Task<SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse> SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequestAsync(this OcipClientBase client, SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse;
        }
        /// <summary>
        /// Modify the list of Peer SIP Connection Monitoring system parameters
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequest(this OcipClientBase client, SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the list of Peer SIP Connection Monitoring system parameters
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequestAsync(this OcipClientBase client, SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Geographic Redundancy Proxy system parameters
        /// The response is a SystemGeographicRedundancyProxyGetResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGeographicRedundancyProxyGetRequestAsync instead.")]
        public static async Task<SystemGeographicRedundancyProxyGetResponse> SystemGeographicRedundancyProxyGetRequest(this OcipClientBase client, SystemGeographicRedundancyProxyGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGeographicRedundancyProxyGetResponse;
        }

        /// <summary>
        /// Request to get the list of Geographic Redundancy Proxy system parameters
        /// The response is a SystemGeographicRedundancyProxyGetResponse.
        /// </summary>
        public static async Task<SystemGeographicRedundancyProxyGetResponse> SystemGeographicRedundancyProxyGetRequestAsync(this OcipClientBase client, SystemGeographicRedundancyProxyGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGeographicRedundancyProxyGetResponse;
        }
        /// <summary>
        /// Modify the list of Geographic Redundancy Proxysystem parameters
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGeographicRedundancyProxyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGeographicRedundancyProxyModifyRequest(this OcipClientBase client, SystemGeographicRedundancyProxyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the list of Geographic Redundancy Proxysystem parameters
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGeographicRedundancyProxyModifyRequestAsync(this OcipClientBase client, SystemGeographicRedundancyProxyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of users that are unreachable from the primary application server.
        /// The response is a SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22Async instead.")]
        public static async Task<SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22> SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22(this OcipClientBase client, SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22;
        }

        /// <summary>
        /// Get the list of users that are unreachable from the primary application server.
        /// The response is a SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22> SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22Async(this OcipClientBase client, SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22;
        }
        /// <summary>
        /// Get the list of registration contacts.
        /// This request handles all levels of administration privileges.  The content of the response will only contain
        /// items within the scope of the requester's login id.  At the system level any of the choice parameters may be
        /// specified to filter the registrations listed.  At the reseller level, the resellerId must be specified.
        /// ResellerId is not valid at service provider, group or user level. At the service provider level the
        /// serviceProviderId must be specified for the service provider and group options.  When using the userId or
        /// linePort options the specified value must be valid for that service provider login.  At the group level
        /// the servicProviderId and the groupId must be specified for the group option. When using the userId or linePort
        /// options the specified value must be valid for that group login.
        /// The serviceProviderId option is not valid at the group level.  At the user level when using the userId or
        /// linePort options the specified value must be valid for that user login.  The serviceProviderId and groupId
        /// options are not valid at the user level.
        /// The response is either SystemGetRegistrationContactListResponse21sp1 or ErrorResponse.
        /// The RegistrationEndpointType21sp1 is sent in response The Endpoint Type column contains one of the enumerated RegistrationEndpointType21sp1 values.
        /// The value Mobility in Endpoint Type column is only applicable in AS data mode.
        /// 
        /// The following elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGetRegistrationContactListRequest21sp1Async instead.")]
        public static async Task<SystemGetRegistrationContactListResponse21sp1> SystemGetRegistrationContactListRequest21sp1(this OcipClientBase client, SystemGetRegistrationContactListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGetRegistrationContactListResponse21sp1;
        }

        /// <summary>
        /// Get the list of registration contacts.
        /// This request handles all levels of administration privileges.  The content of the response will only contain
        /// items within the scope of the requester's login id.  At the system level any of the choice parameters may be
        /// specified to filter the registrations listed.  At the reseller level, the resellerId must be specified.
        /// ResellerId is not valid at service provider, group or user level. At the service provider level the
        /// serviceProviderId must be specified for the service provider and group options.  When using the userId or
        /// linePort options the specified value must be valid for that service provider login.  At the group level
        /// the servicProviderId and the groupId must be specified for the group option. When using the userId or linePort
        /// options the specified value must be valid for that group login.
        /// The serviceProviderId option is not valid at the group level.  At the user level when using the userId or
        /// linePort options the specified value must be valid for that user login.  The serviceProviderId and groupId
        /// options are not valid at the user level.
        /// The response is either SystemGetRegistrationContactListResponse21sp1 or ErrorResponse.
        /// The RegistrationEndpointType21sp1 is sent in response The Endpoint Type column contains one of the enumerated RegistrationEndpointType21sp1 values.
        /// The value Mobility in Endpoint Type column is only applicable in AS data mode.
        /// 
        /// The following elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SystemGetRegistrationContactListResponse21sp1> SystemGetRegistrationContactListRequest21sp1Async(this OcipClientBase client, SystemGetRegistrationContactListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGetRegistrationContactListResponse21sp1;
        }
        /// <summary>
        /// Add a GETS AVP Code map at the system level.  It maps a Diameter AVP Code with a vendor ID for.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSAvpCodeMapAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSAvpCodeMapAddRequest(this OcipClientBase client, SystemGETSAvpCodeMapAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a GETS AVP Code map at the system level.  It maps a Diameter AVP Code with a vendor ID for.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSAvpCodeMapAddRequestAsync(this OcipClientBase client, SystemGETSAvpCodeMapAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system GETS AVP Code map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSAvpCodeMapDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSAvpCodeMapDeleteRequest(this OcipClientBase client, SystemGETSAvpCodeMapDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system GETS AVP Code map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSAvpCodeMapDeleteRequestAsync(this OcipClientBase client, SystemGETSAvpCodeMapDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of GETS AVP Code Maps at the system level.
        /// The response is either SystemGETSAvpCodeMapGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSAvpCodeMapGetListRequestAsync instead.")]
        public static async Task<SystemGETSAvpCodeMapGetListResponse> SystemGETSAvpCodeMapGetListRequest(this OcipClientBase client, SystemGETSAvpCodeMapGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSAvpCodeMapGetListResponse;
        }

        /// <summary>
        /// Get a list of GETS AVP Code Maps at the system level.
        /// The response is either SystemGETSAvpCodeMapGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSAvpCodeMapGetListResponse> SystemGETSAvpCodeMapGetListRequestAsync(this OcipClientBase client, SystemGETSAvpCodeMapGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSAvpCodeMapGetListResponse;
        }
        /// <summary>
        /// Get the GETS system settings.
        /// The response is either SystemGETSGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSGetRequestAsync instead.")]
        public static async Task<SystemGETSGetResponse> SystemGETSGetRequest(this OcipClientBase client, SystemGETSGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSGetResponse;
        }

        /// <summary>
        /// Get the GETS system settings.
        /// The response is either SystemGETSGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSGetResponse> SystemGETSGetRequestAsync(this OcipClientBase client, SystemGETSGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSGetResponse;
        }
        /// <summary>
        /// Modify GETS system settings.
        /// The following elements are only used in AS data mode and ignored in the Amplify data mode:
        /// callIdentifierMode
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSModifyRequest(this OcipClientBase client, SystemGETSModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify GETS system settings.
        /// The following elements are only used in AS data mode and ignored in the Amplify data mode:
        /// callIdentifierMode
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSModifyRequestAsync(this OcipClientBase client, SystemGETSModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSNumberAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSNumberAddRequest(this OcipClientBase client, SystemGETSNumberAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSNumberAddRequestAsync(this OcipClientBase client, SystemGETSNumberAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSNumberDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSNumberDeleteRequest(this OcipClientBase client, SystemGETSNumberDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSNumberDeleteRequestAsync(this OcipClientBase client, SystemGETSNumberDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of GETS reserved Numbers.
        /// The response is either SystemGETSNumberGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSNumberGetListRequestAsync instead.")]
        public static async Task<SystemGETSNumberGetListResponse> SystemGETSNumberGetListRequest(this OcipClientBase client, SystemGETSNumberGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSNumberGetListResponse;
        }

        /// <summary>
        /// Get a list of GETS reserved Numbers.
        /// The response is either SystemGETSNumberGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSNumberGetListResponse> SystemGETSNumberGetListRequestAsync(this OcipClientBase client, SystemGETSNumberGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSNumberGetListResponse;
        }
        /// <summary>
        /// Modify a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSNumberModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSNumberModifyRequest(this OcipClientBase client, SystemGETSNumberModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSNumberModifyRequestAsync(this OcipClientBase client, SystemGETSNumberModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSReservedFeatureAccessCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeAddRequest(this OcipClientBase client, SystemGETSReservedFeatureAccessCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeAddRequestAsync(this OcipClientBase client, SystemGETSReservedFeatureAccessCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSReservedFeatureAccessCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeDeleteRequest(this OcipClientBase client, SystemGETSReservedFeatureAccessCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeDeleteRequestAsync(this OcipClientBase client, SystemGETSReservedFeatureAccessCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of GETS reserved FAC.
        /// The response is either SystemGETSReservedFeatureAccessCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSReservedFeatureAccessCodeGetListRequestAsync instead.")]
        public static async Task<SystemGETSReservedFeatureAccessCodeGetListResponse> SystemGETSReservedFeatureAccessCodeGetListRequest(this OcipClientBase client, SystemGETSReservedFeatureAccessCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSReservedFeatureAccessCodeGetListResponse;
        }

        /// <summary>
        /// Get a list of GETS reserved FAC.
        /// The response is either SystemGETSReservedFeatureAccessCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSReservedFeatureAccessCodeGetListResponse> SystemGETSReservedFeatureAccessCodeGetListRequestAsync(this OcipClientBase client, SystemGETSReservedFeatureAccessCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSReservedFeatureAccessCodeGetListResponse;
        }
        /// <summary>
        /// Modify a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSReservedFeatureAccessCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeModifyRequest(this OcipClientBase client, SystemGETSReservedFeatureAccessCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeModifyRequestAsync(this OcipClientBase client, SystemGETSReservedFeatureAccessCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a GETS Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSResourcePriorityAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSResourcePriorityAddRequest(this OcipClientBase client, SystemGETSResourcePriorityAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a GETS Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSResourcePriorityAddRequestAsync(this OcipClientBase client, SystemGETSResourcePriorityAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a GETS Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSResourcePriorityDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSResourcePriorityDeleteRequest(this OcipClientBase client, SystemGETSResourcePriorityDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a GETS Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSResourcePriorityDeleteRequestAsync(this OcipClientBase client, SystemGETSResourcePriorityDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of GETS Resource Priorities.
        /// The response is either SystemGETSResourcePriorityGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSResourcePriorityGetListRequestAsync instead.")]
        public static async Task<SystemGETSResourcePriorityGetListResponse> SystemGETSResourcePriorityGetListRequest(this OcipClientBase client, SystemGETSResourcePriorityGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSResourcePriorityGetListResponse;
        }

        /// <summary>
        /// Get a list of GETS Resource Priorities.
        /// The response is either SystemGETSResourcePriorityGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSResourcePriorityGetListResponse> SystemGETSResourcePriorityGetListRequestAsync(this OcipClientBase client, SystemGETSResourcePriorityGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSResourcePriorityGetListResponse;
        }
        /// <summary>
        /// Modify a GETS reserved Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSResourcePriorityModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSResourcePriorityModifyRequest(this OcipClientBase client, SystemGETSResourcePriorityModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a GETS reserved Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSResourcePriorityModifyRequestAsync(this OcipClientBase client, SystemGETSResourcePriorityModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a GETS Session Priority map.  It maps a priority level with a session priority AVP value.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSSessionPriorityMapAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapAddRequest(this OcipClientBase client, SystemGETSSessionPriorityMapAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a GETS Session Priority map.  It maps a priority level with a session priority AVP value.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapAddRequestAsync(this OcipClientBase client, SystemGETSSessionPriorityMapAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a GETS Session Priority map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSSessionPriorityMapDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapDeleteRequest(this OcipClientBase client, SystemGETSSessionPriorityMapDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a GETS Session Priority map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapDeleteRequestAsync(this OcipClientBase client, SystemGETSSessionPriorityMapDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of GETS Session Priority maps.
        /// The response is either SystemGETSSessionPriorityMapGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSSessionPriorityMapGetListRequestAsync instead.")]
        public static async Task<SystemGETSSessionPriorityMapGetListResponse> SystemGETSSessionPriorityMapGetListRequest(this OcipClientBase client, SystemGETSSessionPriorityMapGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSSessionPriorityMapGetListResponse;
        }

        /// <summary>
        /// Get a list of GETS Session Priority maps.
        /// The response is either SystemGETSSessionPriorityMapGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSSessionPriorityMapGetListResponse> SystemGETSSessionPriorityMapGetListRequestAsync(this OcipClientBase client, SystemGETSSessionPriorityMapGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSSessionPriorityMapGetListResponse;
        }
        /// <summary>
        /// Modify a GETS Session Priority Map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSSessionPriorityMapModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapModifyRequest(this OcipClientBase client, SystemGETSSessionPriorityMapModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a GETS Session Priority Map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapModifyRequestAsync(this OcipClientBase client, SystemGETSSessionPriorityMapModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Home Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHomeNetworkAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHomeNetworkAddRequest(this OcipClientBase client, SystemHomeNetworkAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Home Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHomeNetworkAddRequestAsync(this OcipClientBase client, SystemHomeNetworkAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Home Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHomeNetworkDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHomeNetworkDeleteRequest(this OcipClientBase client, SystemHomeNetworkDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Home Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHomeNetworkDeleteRequestAsync(this OcipClientBase client, SystemHomeNetworkDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Home Networks.
        /// The response is either a SystemHomeNetworkGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHomeNetworkGetListRequestAsync instead.")]
        public static async Task<SystemHomeNetworkGetListResponse> SystemHomeNetworkGetListRequest(this OcipClientBase client, SystemHomeNetworkGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemHomeNetworkGetListResponse;
        }

        /// <summary>
        /// Get the list of all Home Networks.
        /// The response is either a SystemHomeNetworkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemHomeNetworkGetListResponse> SystemHomeNetworkGetListRequestAsync(this OcipClientBase client, SystemHomeNetworkGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemHomeNetworkGetListResponse;
        }
        /// <summary>
        /// Add a new alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXAlternateCarrierSelectionAddCarrierRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionAddCarrierRequest(this OcipClientBase client, SystemHPBXAlternateCarrierSelectionAddCarrierRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionAddCarrierRequestAsync(this OcipClientBase client, SystemHPBXAlternateCarrierSelectionAddCarrierRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXAlternateCarrierSelectionDeleteCarrierRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionDeleteCarrierRequest(this OcipClientBase client, SystemHPBXAlternateCarrierSelectionDeleteCarrierRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionDeleteCarrierRequestAsync(this OcipClientBase client, SystemHPBXAlternateCarrierSelectionDeleteCarrierRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of alternate carriers available for CbC and Preselection.
        /// The response is either a SystemHPBXAlternateCarrierSelectionGetCarrierListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXAlternateCarrierSelectionGetCarrierListRequestAsync instead.")]
        public static async Task<SystemHPBXAlternateCarrierSelectionGetCarrierListResponse> SystemHPBXAlternateCarrierSelectionGetCarrierListRequest(this OcipClientBase client, SystemHPBXAlternateCarrierSelectionGetCarrierListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemHPBXAlternateCarrierSelectionGetCarrierListResponse;
        }

        /// <summary>
        /// Request the list of alternate carriers available for CbC and Preselection.
        /// The response is either a SystemHPBXAlternateCarrierSelectionGetCarrierListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemHPBXAlternateCarrierSelectionGetCarrierListResponse> SystemHPBXAlternateCarrierSelectionGetCarrierListRequestAsync(this OcipClientBase client, SystemHPBXAlternateCarrierSelectionGetCarrierListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemHPBXAlternateCarrierSelectionGetCarrierListResponse;
        }
        /// <summary>
        /// Modify an alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXAlternateCarrierSelectionModifyCarrierRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionModifyCarrierRequest(this OcipClientBase client, SystemHPBXAlternateCarrierSelectionModifyCarrierRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionModifyCarrierRequestAsync(this OcipClientBase client, SystemHPBXAlternateCarrierSelectionModifyCarrierRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the hPBX mobile termination related configuration parameters.
        /// The response is either a SystemHPBXMobileTerminationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXMobileTerminationGetRequestAsync instead.")]
        public static async Task<SystemHPBXMobileTerminationGetResponse> SystemHPBXMobileTerminationGetRequest(this OcipClientBase client, SystemHPBXMobileTerminationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemHPBXMobileTerminationGetResponse;
        }

        /// <summary>
        /// Request to get the hPBX mobile termination related configuration parameters.
        /// The response is either a SystemHPBXMobileTerminationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemHPBXMobileTerminationGetResponse> SystemHPBXMobileTerminationGetRequestAsync(this OcipClientBase client, SystemHPBXMobileTerminationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemHPBXMobileTerminationGetResponse;
        }
        /// <summary>
        /// Request to modify the hPBX mobile termination related configuration parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXMobileTerminationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHPBXMobileTerminationModifyRequest(this OcipClientBase client, SystemHPBXMobileTerminationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the hPBX mobile termination related configuration parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHPBXMobileTerminationModifyRequestAsync(this OcipClientBase client, SystemHPBXMobileTerminationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a language to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLanguageAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLanguageAddRequest(this OcipClientBase client, SystemLanguageAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a language to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLanguageAddRequestAsync(this OcipClientBase client, SystemLanguageAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a language from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLanguageDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLanguageDeleteRequest(this OcipClientBase client, SystemLanguageDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a language from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLanguageDeleteRequestAsync(this OcipClientBase client, SystemLanguageDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the defined languages in the system.
        /// The response is either a SystemLanguageGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLanguageGetListRequestAsync instead.")]
        public static async Task<SystemLanguageGetListResponse> SystemLanguageGetListRequest(this OcipClientBase client, SystemLanguageGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLanguageGetListResponse;
        }

        /// <summary>
        /// Request the defined languages in the system.
        /// The response is either a SystemLanguageGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemLanguageGetListResponse> SystemLanguageGetListRequestAsync(this OcipClientBase client, SystemLanguageGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLanguageGetListResponse;
        }
        /// <summary>
        /// Request to modify a language properties in the system.
        /// If the becomeDefaultLanguage element is present, the language in this request becomes
        /// the default language for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLanguageModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLanguageModifyRequest(this OcipClientBase client, SystemLanguageModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a language properties in the system.
        /// If the becomeDefaultLanguage element is present, the language in this request becomes
        /// the default language for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLanguageModifyRequestAsync(this OcipClientBase client, SystemLanguageModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get all the licensing information.
        /// The response is either SystemLicensingGetResponse14sp3 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetRequest14sp3Async instead.")]
        public static async Task<SystemLicensingGetResponse14sp3> SystemLicensingGetRequest14sp3(this OcipClientBase client, SystemLicensingGetRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetResponse14sp3;
        }

        /// <summary>
        /// Get all the licensing information.
        /// The response is either SystemLicensingGetResponse14sp3 or ErrorResponse.
        /// </summary>
        public static async Task<SystemLicensingGetResponse14sp3> SystemLicensingGetRequest14sp3Async(this OcipClientBase client, SystemLicensingGetRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetResponse14sp3;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequest22Async instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse22> SystemLicensingGetSystemLicenseListRequest22(this OcipClientBase client, SystemLicensingGetSystemLicenseListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse22;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse22> SystemLicensingGetSystemLicenseListRequest22Async(this OcipClientBase client, SystemLicensingGetSystemLicenseListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse22;
        }
        /// <summary>
        /// Load a new license file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingReloadRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLicensingReloadRequest(this OcipClientBase client, SystemLicensingReloadRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Load a new license file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLicensingReloadRequestAsync(this OcipClientBase client, SystemLicensingReloadRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Mail system parameters.
        /// The response is either SystemMailParametersGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMailParametersGetRequest22Async instead.")]
        public static async Task<SystemMailParametersGetResponse22> SystemMailParametersGetRequest22(this OcipClientBase client, SystemMailParametersGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMailParametersGetResponse22;
        }

        /// <summary>
        /// Request to get the list of Mail system parameters.
        /// The response is either SystemMailParametersGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemMailParametersGetResponse22> SystemMailParametersGetRequest22Async(this OcipClientBase client, SystemMailParametersGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMailParametersGetResponse22;
        }
        /// <summary>
        /// Request to modify Mail system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMailParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMailParametersModifyRequest(this OcipClientBase client, SystemMailParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Mail system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMailParametersModifyRequestAsync(this OcipClientBase client, SystemMailParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Media to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaAddRequest16Async instead.")]
        public static async Task<SuccessResponse> SystemMediaAddRequest16(this OcipClientBase client, SystemMediaAddRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Media to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaAddRequest16Async(this OcipClientBase client, SystemMediaAddRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Media from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaDeleteRequest(this OcipClientBase client, SystemMediaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Media from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaDeleteRequestAsync(this OcipClientBase client, SystemMediaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of media in the system.
        /// The response is either a SystemMediaGetListResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGetListRequestAsync instead.")]
        public static async Task<SystemMediaGetListResponse> SystemMediaGetListRequest(this OcipClientBase client, SystemMediaGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaGetListResponse;
        }

        /// <summary>
        /// Request to get a list of media in the system.
        /// The response is either a SystemMediaGetListResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaGetListResponse> SystemMediaGetListRequestAsync(this OcipClientBase client, SystemMediaGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaGetListResponse;
        }
        /// <summary>
        /// Request to add a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupAddRequest(this OcipClientBase client, SystemMediaGroupAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupAddRequestAsync(this OcipClientBase client, SystemMediaGroupAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a media to a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupCodecAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupCodecAddRequest(this OcipClientBase client, SystemMediaGroupCodecAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a media to a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupCodecAddRequestAsync(this OcipClientBase client, SystemMediaGroupCodecAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete media from a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupCodecDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupCodecDeleteRequest(this OcipClientBase client, SystemMediaGroupCodecDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete media from a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupCodecDeleteRequestAsync(this OcipClientBase client, SystemMediaGroupCodecDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of media under a media group.
        /// The response is either SystemMediaGroupCodecGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupCodecGetListRequestAsync instead.")]
        public static async Task<SystemMediaGroupCodecGetListResponse> SystemMediaGroupCodecGetListRequest(this OcipClientBase client, SystemMediaGroupCodecGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaGroupCodecGetListResponse;
        }

        /// <summary>
        /// Request to get the list of media under a media group.
        /// The response is either SystemMediaGroupCodecGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaGroupCodecGetListResponse> SystemMediaGroupCodecGetListRequestAsync(this OcipClientBase client, SystemMediaGroupCodecGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaGroupCodecGetListResponse;
        }
        /// <summary>
        /// Request to modify a media associated with a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupCodecModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupCodecModifyRequest(this OcipClientBase client, SystemMediaGroupCodecModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a media associated with a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupCodecModifyRequestAsync(this OcipClientBase client, SystemMediaGroupCodecModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupDeleteRequest(this OcipClientBase client, SystemMediaGroupDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupDeleteRequestAsync(this OcipClientBase client, SystemMediaGroupDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of media groups.
        /// The response is either SystemMediaGroupGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupGetListRequestAsync instead.")]
        public static async Task<SystemMediaGroupGetListResponse> SystemMediaGroupGetListRequest(this OcipClientBase client, SystemMediaGroupGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaGroupGetListResponse;
        }

        /// <summary>
        /// Request to get the list of media groups.
        /// The response is either SystemMediaGroupGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaGroupGetListResponse> SystemMediaGroupGetListRequestAsync(this OcipClientBase client, SystemMediaGroupGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaGroupGetListResponse;
        }
        /// <summary>
        /// Request to modify a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupModifyRequest(this OcipClientBase client, SystemMediaGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupModifyRequestAsync(this OcipClientBase client, SystemMediaGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of SAC groups associated with a media group.
        /// The response is either SystemMediaGroupUsageListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupUsageListRequestAsync instead.")]
        public static async Task<SystemMediaGroupUsageListResponse> SystemMediaGroupUsageListRequest(this OcipClientBase client, SystemMediaGroupUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaGroupUsageListResponse;
        }

        /// <summary>
        /// Request to get the list of SAC groups associated with a media group.
        /// The response is either SystemMediaGroupUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaGroupUsageListResponse> SystemMediaGroupUsageListRequestAsync(this OcipClientBase client, SystemMediaGroupUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaGroupUsageListResponse;
        }
        /// <summary>
        /// Request to modify a media.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaModifyRequest(this OcipClientBase client, SystemMediaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a media.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaModifyRequestAsync(this OcipClientBase client, SystemMediaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Media Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerAddRequest14Async instead.")]
        public static async Task<SuccessResponse> SystemMediaServerAddRequest14(this OcipClientBase client, SystemMediaServerAddRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Media Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaServerAddRequest14Async(this OcipClientBase client, SystemMediaServerAddRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Media Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaServerDeleteRequest(this OcipClientBase client, SystemMediaServerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Media Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaServerDeleteRequestAsync(this OcipClientBase client, SystemMediaServerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of Media Servers defined in the system.
        /// The response is either a SystemMediaServerGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerGetListRequestAsync instead.")]
        public static async Task<SystemMediaServerGetListResponse> SystemMediaServerGetListRequest(this OcipClientBase client, SystemMediaServerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaServerGetListResponse;
        }

        /// <summary>
        /// Request to get a list of Media Servers defined in the system.
        /// The response is either a SystemMediaServerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaServerGetListResponse> SystemMediaServerGetListRequestAsync(this OcipClientBase client, SystemMediaServerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaServerGetListResponse;
        }
        /// <summary>
        /// Request to modify a Media Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaServerModifyRequest(this OcipClientBase client, SystemMediaServerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Media Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaServerModifyRequestAsync(this OcipClientBase client, SystemMediaServerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Media Server system parameters.
        /// The response is either SystemMediaServerParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerParametersGetRequestAsync instead.")]
        public static async Task<SystemMediaServerParametersGetResponse> SystemMediaServerParametersGetRequest(this OcipClientBase client, SystemMediaServerParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaServerParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of Media Server system parameters.
        /// The response is either SystemMediaServerParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaServerParametersGetResponse> SystemMediaServerParametersGetRequestAsync(this OcipClientBase client, SystemMediaServerParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaServerParametersGetResponse;
        }
        /// <summary>
        /// Request to modify Media Server system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaServerParametersModifyRequest(this OcipClientBase client, SystemMediaServerParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Media Server system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaServerParametersModifyRequestAsync(this OcipClientBase client, SystemMediaServerParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaSetAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaSetAddRequest(this OcipClientBase client, SystemMediaSetAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaSetAddRequestAsync(this OcipClientBase client, SystemMediaSetAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaSetDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaSetDeleteRequest(this OcipClientBase client, SystemMediaSetDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaSetDeleteRequestAsync(this OcipClientBase client, SystemMediaSetDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Media Sets in the system.
        /// The response is either a SystemMediaSetGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaSetGetListRequestAsync instead.")]
        public static async Task<SystemMediaSetGetListResponse> SystemMediaSetGetListRequest(this OcipClientBase client, SystemMediaSetGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaSetGetListResponse;
        }

        /// <summary>
        /// Request to get the list of Media Sets in the system.
        /// The response is either a SystemMediaSetGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaSetGetListResponse> SystemMediaSetGetListRequestAsync(this OcipClientBase client, SystemMediaSetGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaSetGetListResponse;
        }
        /// <summary>
        /// Request to get a Media Set.
        /// The response is either a SystemMediaSetGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaSetGetRequestAsync instead.")]
        public static async Task<SystemMediaSetGetResponse> SystemMediaSetGetRequest(this OcipClientBase client, SystemMediaSetGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaSetGetResponse;
        }

        /// <summary>
        /// Request to get a Media Set.
        /// The response is either a SystemMediaSetGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaSetGetResponse> SystemMediaSetGetRequestAsync(this OcipClientBase client, SystemMediaSetGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaSetGetResponse;
        }
        /// <summary>
        /// Request to modify a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaSetModifyRequest(this OcipClientBase client, SystemMediaSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaSetModifyRequestAsync(this OcipClientBase client, SystemMediaSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of mgcp device types in the system.
        /// See Also: SystemDeviceTypeGetAvailableListRequest14sp3.
        /// The response is either SystemMGCPDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMGCPDeviceTypeGetListRequestAsync instead.")]
        public static async Task<SystemMGCPDeviceTypeGetListResponse> SystemMGCPDeviceTypeGetListRequest(this OcipClientBase client, SystemMGCPDeviceTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMGCPDeviceTypeGetListResponse;
        }

        /// <summary>
        /// Request to get the list of mgcp device types in the system.
        /// See Also: SystemDeviceTypeGetAvailableListRequest14sp3.
        /// The response is either SystemMGCPDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMGCPDeviceTypeGetListResponse> SystemMGCPDeviceTypeGetListRequestAsync(this OcipClientBase client, SystemMGCPDeviceTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMGCPDeviceTypeGetListResponse;
        }
        /// <summary>
        /// Request to get a mgcp device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemMGCPDeviceTypeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMGCPDeviceTypeGetRequestAsync instead.")]
        public static async Task<SystemMGCPDeviceTypeGetResponse> SystemMGCPDeviceTypeGetRequest(this OcipClientBase client, SystemMGCPDeviceTypeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMGCPDeviceTypeGetResponse;
        }

        /// <summary>
        /// Request to get a mgcp device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemMGCPDeviceTypeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMGCPDeviceTypeGetResponse> SystemMGCPDeviceTypeGetRequestAsync(this OcipClientBase client, SystemMGCPDeviceTypeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMGCPDeviceTypeGetResponse;
        }
        /// <summary>
        /// Request to modify a mgcp device type. In release 14, this is limited to changing the obsolete flag.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMGCPDeviceTypeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMGCPDeviceTypeModifyRequest(this OcipClientBase client, SystemMGCPDeviceTypeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a mgcp device type. In release 14, this is limited to changing the obsolete flag.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMGCPDeviceTypeModifyRequestAsync(this OcipClientBase client, SystemMGCPDeviceTypeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of migrated users.
        /// If the optional parameter userListSizeLimit is set, then the list returned in the response will contain entries up to value of userListSizeLimit.
        /// The response is either SystemMigratedUsersGetListResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMigratedUsersGetListRequest22Async instead.")]
        public static async Task<SystemMigratedUsersGetListResponse22> SystemMigratedUsersGetListRequest22(this OcipClientBase client, SystemMigratedUsersGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMigratedUsersGetListResponse22;
        }

        /// <summary>
        /// Get a list of migrated users.
        /// If the optional parameter userListSizeLimit is set, then the list returned in the response will contain entries up to value of userListSizeLimit.
        /// The response is either SystemMigratedUsersGetListResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemMigratedUsersGetListResponse22> SystemMigratedUsersGetListRequest22Async(this OcipClientBase client, SystemMigratedUsersGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMigratedUsersGetListResponse22;
        }
        /// <summary>
        /// Request the system level data associated with Multimedia Policy.
        /// The response is either a SystemMultimediaPolicyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMultimediaPolicyGetRequestAsync instead.")]
        public static async Task<SystemMultimediaPolicyGetResponse> SystemMultimediaPolicyGetRequest(this OcipClientBase client, SystemMultimediaPolicyGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMultimediaPolicyGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Multimedia Policy.
        /// The response is either a SystemMultimediaPolicyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemMultimediaPolicyGetResponse> SystemMultimediaPolicyGetRequestAsync(this OcipClientBase client, SystemMultimediaPolicyGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMultimediaPolicyGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Multimedia Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMultimediaPolicyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMultimediaPolicyModifyRequest(this OcipClientBase client, SystemMultimediaPolicyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Multimedia Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMultimediaPolicyModifyRequestAsync(this OcipClientBase client, SystemMultimediaPolicyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Network Class of Service.
        /// The following elements are only used in AS data mode:
        /// callProcessingPolicyProfileName
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceAddRequest(this OcipClientBase client, SystemNetworkClassOfServiceAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Network Class of Service.
        /// The following elements are only used in AS data mode:
        /// callProcessingPolicyProfileName
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceAddRequestAsync(this OcipClientBase client, SystemNetworkClassOfServiceAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Network Class of Service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceDeleteRequest(this OcipClientBase client, SystemNetworkClassOfServiceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Network Class of Service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceDeleteRequestAsync(this OcipClientBase client, SystemNetworkClassOfServiceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of service providers that have a given Network Class
        /// of Service assigned.
        /// The response is either a SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceGetAssignedServiceProviderListRequestAsync instead.")]
        public static async Task<SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse> SystemNetworkClassOfServiceGetAssignedServiceProviderListRequest(this OcipClientBase client, SystemNetworkClassOfServiceGetAssignedServiceProviderListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse;
        }

        /// <summary>
        /// Request a list of service providers that have a given Network Class
        /// of Service assigned.
        /// The response is either a SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse> SystemNetworkClassOfServiceGetAssignedServiceProviderListRequestAsync(this OcipClientBase client, SystemNetworkClassOfServiceGetAssignedServiceProviderListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse;
        }
        /// <summary>
        /// Get the list of Network Classes of Service that contain a specific
        /// Communication Barring Profile.
        /// The response is either a SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequestAsync instead.")]
        public static async Task<SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse> SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequest(this OcipClientBase client, SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse;
        }

        /// <summary>
        /// Get the list of Network Classes of Service that contain a specific
        /// Communication Barring Profile.
        /// The response is either a SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse> SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequestAsync(this OcipClientBase client, SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse;
        }
        /// <summary>
        /// Get the list of all Network Classes of Service.
        /// The response is either a SystemNetworkClassOfServiceGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceGetListRequestAsync instead.")]
        public static async Task<SystemNetworkClassOfServiceGetListResponse> SystemNetworkClassOfServiceGetListRequest(this OcipClientBase client, SystemNetworkClassOfServiceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkClassOfServiceGetListResponse;
        }

        /// <summary>
        /// Get the list of all Network Classes of Service.
        /// The response is either a SystemNetworkClassOfServiceGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetListResponse> SystemNetworkClassOfServiceGetListRequestAsync(this OcipClientBase client, SystemNetworkClassOfServiceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkClassOfServiceGetListResponse;
        }
        /// <summary>
        /// Get an existing Network Class of Service.
        /// The response is either a SystemNetworkClassOfServiceGetResponse19sp1
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceGetRequest19sp1Async instead.")]
        public static async Task<SystemNetworkClassOfServiceGetResponse19sp1> SystemNetworkClassOfServiceGetRequest19sp1(this OcipClientBase client, SystemNetworkClassOfServiceGetRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkClassOfServiceGetResponse19sp1;
        }

        /// <summary>
        /// Get an existing Network Class of Service.
        /// The response is either a SystemNetworkClassOfServiceGetResponse19sp1
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetResponse19sp1> SystemNetworkClassOfServiceGetRequest19sp1Async(this OcipClientBase client, SystemNetworkClassOfServiceGetRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkClassOfServiceGetResponse19sp1;
        }
        /// <summary>
        /// Modify an existing Network Class of Service.
        /// The following elements are only used in AS data mode:
        /// callProcessingPolicyProfileName
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceModifyRequest(this OcipClientBase client, SystemNetworkClassOfServiceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Network Class of Service.
        /// The following elements are only used in AS data mode:
        /// callProcessingPolicyProfileName
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceModifyRequestAsync(this OcipClientBase client, SystemNetworkClassOfServiceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Network Device Polling system parameters.
        /// The response is either SystemNetworkDeviceMonitorParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkDeviceMonitorParametersGetRequestAsync instead.")]
        public static async Task<SystemNetworkDeviceMonitorParametersGetResponse> SystemNetworkDeviceMonitorParametersGetRequest(this OcipClientBase client, SystemNetworkDeviceMonitorParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkDeviceMonitorParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of Network Device Polling system parameters.
        /// The response is either SystemNetworkDeviceMonitorParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkDeviceMonitorParametersGetResponse> SystemNetworkDeviceMonitorParametersGetRequestAsync(this OcipClientBase client, SystemNetworkDeviceMonitorParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkDeviceMonitorParametersGetResponse;
        }
        /// <summary>
        /// Request to modify Network Device Polling system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkDeviceMonitorParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkDeviceMonitorParametersModifyRequest(this OcipClientBase client, SystemNetworkDeviceMonitorParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Network Device Polling system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkDeviceMonitorParametersModifyRequestAsync(this OcipClientBase client, SystemNetworkDeviceMonitorParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with network progression.
        /// The response is either a SystemNetworkProgressionGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkProgressionGetRequestAsync instead.")]
        public static async Task<SystemNetworkProgressionGetResponse> SystemNetworkProgressionGetRequest(this OcipClientBase client, SystemNetworkProgressionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkProgressionGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with network progression.
        /// The response is either a SystemNetworkProgressionGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkProgressionGetResponse> SystemNetworkProgressionGetRequestAsync(this OcipClientBase client, SystemNetworkProgressionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkProgressionGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with network progression.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkProgressionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkProgressionModifyRequest(this OcipClientBase client, SystemNetworkProgressionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with network progression.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkProgressionModifyRequestAsync(this OcipClientBase client, SystemNetworkProgressionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a routing Network Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkRoutingServerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkRoutingServerAddRequest(this OcipClientBase client, SystemNetworkRoutingServerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a routing Network Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkRoutingServerAddRequestAsync(this OcipClientBase client, SystemNetworkRoutingServerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a routing Network Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkRoutingServerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkRoutingServerDeleteRequest(this OcipClientBase client, SystemNetworkRoutingServerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a routing Network Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkRoutingServerDeleteRequestAsync(this OcipClientBase client, SystemNetworkRoutingServerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of routing Network Servers defined in the system.
        /// The response is either a SystemNetworkRoutingServerGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkRoutingServerGetListRequestAsync instead.")]
        public static async Task<SystemNetworkRoutingServerGetListResponse> SystemNetworkRoutingServerGetListRequest(this OcipClientBase client, SystemNetworkRoutingServerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkRoutingServerGetListResponse;
        }

        /// <summary>
        /// Request to get a list of routing Network Servers defined in the system.
        /// The response is either a SystemNetworkRoutingServerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkRoutingServerGetListResponse> SystemNetworkRoutingServerGetListRequestAsync(this OcipClientBase client, SystemNetworkRoutingServerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkRoutingServerGetListResponse;
        }
        /// <summary>
        /// Request to modify a routing Network Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkRoutingServerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkRoutingServerModifyRequest(this OcipClientBase client, SystemNetworkRoutingServerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a routing Network Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkRoutingServerModifyRequestAsync(this OcipClientBase client, SystemNetworkRoutingServerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse17sp4 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkServerSyncParametersGetRequest17sp4Async instead.")]
        public static async Task<SystemNetworkServerSyncParametersGetResponse17sp4> SystemNetworkServerSyncParametersGetRequest17sp4(this OcipClientBase client, SystemNetworkServerSyncParametersGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkServerSyncParametersGetResponse17sp4;
        }

        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse17sp4 or ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkServerSyncParametersGetResponse17sp4> SystemNetworkServerSyncParametersGetRequest17sp4Async(this OcipClientBase client, SystemNetworkServerSyncParametersGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkServerSyncParametersGetResponse17sp4;
        }
        /// <summary>
        /// Request to modify Network Server Sync system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// syncTrunkGroups
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkServerSyncParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkServerSyncParametersModifyRequest(this OcipClientBase client, SystemNetworkServerSyncParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Network Server Sync system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// syncTrunkGroups
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkServerSyncParametersModifyRequestAsync(this OcipClientBase client, SystemNetworkServerSyncParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Network Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// order
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkSynchingServerAddRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemNetworkSynchingServerAddRequest22V2(this OcipClientBase client, SystemNetworkSynchingServerAddRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Network Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// order
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkSynchingServerAddRequest22V2Async(this OcipClientBase client, SystemNetworkSynchingServerAddRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Network Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkSynchingServerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkSynchingServerDeleteRequest(this OcipClientBase client, SystemNetworkSynchingServerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Network Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkSynchingServerDeleteRequestAsync(this OcipClientBase client, SystemNetworkSynchingServerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of Network Servers defined in the system.
        /// The response is either a SystemNetworkSynchingServerGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkSynchingServerGetListRequestAsync instead.")]
        public static async Task<SystemNetworkSynchingServerGetListResponse> SystemNetworkSynchingServerGetListRequest(this OcipClientBase client, SystemNetworkSynchingServerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkSynchingServerGetListResponse;
        }

        /// <summary>
        /// Request to get a list of Network Servers defined in the system.
        /// The response is either a SystemNetworkSynchingServerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkSynchingServerGetListResponse> SystemNetworkSynchingServerGetListRequestAsync(this OcipClientBase client, SystemNetworkSynchingServerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkSynchingServerGetListResponse;
        }
        /// <summary>
        /// Request to modify a Network Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// becomePreferred
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// order
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkSynchingServerModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemNetworkSynchingServerModifyRequest22(this OcipClientBase client, SystemNetworkSynchingServerModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Network Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// becomePreferred
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// order
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkSynchingServerModifyRequest22Async(this OcipClientBase client, SystemNetworkSynchingServerModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the number activation state and enterprise trunk number range activation status.
        /// The response is either SystemNumberActivationGetResponse21 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberActivationGetRequest21Async instead.")]
        public static async Task<SystemNumberActivationGetResponse21> SystemNumberActivationGetRequest21(this OcipClientBase client, SystemNumberActivationGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberActivationGetResponse21;
        }

        /// <summary>
        /// Request to get the number activation state and enterprise trunk number range activation status.
        /// The response is either SystemNumberActivationGetResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberActivationGetResponse21> SystemNumberActivationGetRequest21Async(this OcipClientBase client, SystemNumberActivationGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberActivationGetResponse21;
        }
        /// <summary>
        /// Request to modify system number activation and enterprise trunk number range activation setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following element values are only applicable in AS data mode:
        /// enableEnterpriseTrunkNumberRangeActivation
        /// numberActivationMode = Group And User Activation Enabled will raise an error in XS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberActivationModifyRequest18sp1Async instead.")]
        public static async Task<SuccessResponse> SystemNumberActivationModifyRequest18sp1(this OcipClientBase client, SystemNumberActivationModifyRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify system number activation and enterprise trunk number range activation setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following element values are only applicable in AS data mode:
        /// enableEnterpriseTrunkNumberRangeActivation
        /// numberActivationMode = Group And User Activation Enabled will raise an error in XS data mode.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberActivationModifyRequest18sp1Async(this OcipClientBase client, SystemNumberActivationModifyRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a System Number Portability Query Status Digit Pattern mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryDigitPatternAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternAddRequest(this OcipClientBase client, SystemNumberPortabilityQueryDigitPatternAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a System Number Portability Query Status Digit Pattern mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternAddRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryDigitPatternAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a list of System Number Portability Status Digit Pattern mappings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryDigitPatternDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternDeleteListRequest(this OcipClientBase client, SystemNumberPortabilityQueryDigitPatternDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a list of System Number Portability Status Digit Pattern mappings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternDeleteListRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryDigitPatternDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the System Number Portability Query Digit Pattern List information.
        /// The response is either a SystemNumberPortabilityQueryDigitPatternGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryDigitPatternGetListRequestAsync instead.")]
        public static async Task<SystemNumberPortabilityQueryDigitPatternGetListResponse> SystemNumberPortabilityQueryDigitPatternGetListRequest(this OcipClientBase client, SystemNumberPortabilityQueryDigitPatternGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberPortabilityQueryDigitPatternGetListResponse;
        }

        /// <summary>
        /// Request to get the System Number Portability Query Digit Pattern List information.
        /// The response is either a SystemNumberPortabilityQueryDigitPatternGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberPortabilityQueryDigitPatternGetListResponse> SystemNumberPortabilityQueryDigitPatternGetListRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryDigitPatternGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberPortabilityQueryDigitPatternGetListResponse;
        }
        /// <summary>
        /// Request to get a System Number Portability Status Digit Pattern mapping.
        /// The response is either a SystemNumberPortabilityQueryDigitPatternGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryDigitPatternGetRequestAsync instead.")]
        public static async Task<SystemNumberPortabilityQueryDigitPatternGetResponse> SystemNumberPortabilityQueryDigitPatternGetRequest(this OcipClientBase client, SystemNumberPortabilityQueryDigitPatternGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberPortabilityQueryDigitPatternGetResponse;
        }

        /// <summary>
        /// Request to get a System Number Portability Status Digit Pattern mapping.
        /// The response is either a SystemNumberPortabilityQueryDigitPatternGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberPortabilityQueryDigitPatternGetResponse> SystemNumberPortabilityQueryDigitPatternGetRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryDigitPatternGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberPortabilityQueryDigitPatternGetResponse;
        }
        /// <summary>
        /// Request to modify a System Number Portability Status Digit Pattern mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryDigitPatternModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternModifyRequest(this OcipClientBase client, SystemNumberPortabilityQueryDigitPatternModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a System Number Portability Status Digit Pattern mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternModifyRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryDigitPatternModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get system Number Portability Query Parameters.
        /// The response is either SystemNumberPortabilityQueryGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryGetRequestAsync instead.")]
        public static async Task<SystemNumberPortabilityQueryGetResponse> SystemNumberPortabilityQueryGetRequest(this OcipClientBase client, SystemNumberPortabilityQueryGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberPortabilityQueryGetResponse;
        }

        /// <summary>
        /// Get system Number Portability Query Parameters.
        /// The response is either SystemNumberPortabilityQueryGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberPortabilityQueryGetResponse> SystemNumberPortabilityQueryGetRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberPortabilityQueryGetResponse;
        }
        /// <summary>
        /// Modify system Number Portability Query Parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryModifyRequest(this OcipClientBase client, SystemNumberPortabilityQueryModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify system Number Portability Query Parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryModifyRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system number portability status information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryStatusAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusAddRequest(this OcipClientBase client, SystemNumberPortabilityQueryStatusAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system number portability status information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusAddRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryStatusAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of system number portability query statuses.
        /// The number of status entries is limited to 100.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryStatusDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusDeleteListRequest(this OcipClientBase client, SystemNumberPortabilityQueryStatusDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of system number portability query statuses.
        /// The number of status entries is limited to 100.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusDeleteListRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryStatusDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list system Number Portability Query Statuses.
        /// The response is either SystemNumberPortabilityQueryStatusGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryStatusGetListRequestAsync instead.")]
        public static async Task<SystemNumberPortabilityQueryStatusGetListResponse> SystemNumberPortabilityQueryStatusGetListRequest(this OcipClientBase client, SystemNumberPortabilityQueryStatusGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberPortabilityQueryStatusGetListResponse;
        }

        /// <summary>
        /// Get a list system Number Portability Query Statuses.
        /// The response is either SystemNumberPortabilityQueryStatusGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberPortabilityQueryStatusGetListResponse> SystemNumberPortabilityQueryStatusGetListRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryStatusGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberPortabilityQueryStatusGetListResponse;
        }
        /// <summary>
        /// Get information for a system Number Portability Query Status.
        /// The response is either SystemNumberPortabilityQueryStatusGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryStatusGetRequestAsync instead.")]
        public static async Task<SystemNumberPortabilityQueryStatusGetResponse> SystemNumberPortabilityQueryStatusGetRequest(this OcipClientBase client, SystemNumberPortabilityQueryStatusGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberPortabilityQueryStatusGetResponse;
        }

        /// <summary>
        /// Get information for a system Number Portability Query Status.
        /// The response is either SystemNumberPortabilityQueryStatusGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberPortabilityQueryStatusGetResponse> SystemNumberPortabilityQueryStatusGetRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryStatusGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberPortabilityQueryStatusGetResponse;
        }
        /// <summary>
        /// Modify the system number portability status information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryStatusModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusModifyRequest(this OcipClientBase client, SystemNumberPortabilityQueryStatusModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system number portability status information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusModifyRequestAsync(this OcipClientBase client, SystemNumberPortabilityQueryStatusModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIAddACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIAddACLEntryRequest(this OcipClientBase client, SystemOCIAddACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIAddACLEntryRequestAsync(this OcipClientBase client, SystemOCIAddACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the OCI call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlAddACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlAddACLEntryRequest(this OcipClientBase client, SystemOCICallControlAddACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the OCI call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlAddACLEntryRequestAsync(this OcipClientBase client, SystemOCICallControlAddACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the OCI call control application access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationAddACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddACLEntryRequest(this OcipClientBase client, SystemOCICallControlApplicationAddACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the OCI call control application access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddACLEntryRequestAsync(this OcipClientBase client, SystemOCICallControlApplicationAddACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an application to the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationAddRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddRequest22(this OcipClientBase client, SystemOCICallControlApplicationAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an application to the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddRequest22Async(this OcipClientBase client, SystemOCICallControlApplicationAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the OCI call control application access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationDeleteACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationDeleteACLEntryRequest(this OcipClientBase client, SystemOCICallControlApplicationDeleteACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the OCI call control application access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationDeleteACLEntryRequestAsync(this OcipClientBase client, SystemOCICallControlApplicationDeleteACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationDeleteRequest(this OcipClientBase client, SystemOCICallControlApplicationDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationDeleteRequestAsync(this OcipClientBase client, SystemOCICallControlApplicationDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the OCI call control access control list.
        /// The response is either SystemOCICallControlApplicationGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationGetACLListRequestAsync instead.")]
        public static async Task<SystemOCICallControlApplicationGetACLListResponse> SystemOCICallControlApplicationGetACLListRequest(this OcipClientBase client, SystemOCICallControlApplicationGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCICallControlApplicationGetACLListResponse;
        }

        /// <summary>
        /// Get the OCI call control access control list.
        /// The response is either SystemOCICallControlApplicationGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOCICallControlApplicationGetACLListResponse> SystemOCICallControlApplicationGetACLListRequestAsync(this OcipClientBase client, SystemOCICallControlApplicationGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCICallControlApplicationGetACLListResponse;
        }
        /// <summary>
        /// Get the OCI call control application list.
        /// The response is either SystemOCICallControlApplicationGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationGetListRequestAsync instead.")]
        public static async Task<SystemOCICallControlApplicationGetListResponse> SystemOCICallControlApplicationGetListRequest(this OcipClientBase client, SystemOCICallControlApplicationGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCICallControlApplicationGetListResponse;
        }

        /// <summary>
        /// Get the OCI call control application list.
        /// The response is either SystemOCICallControlApplicationGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOCICallControlApplicationGetListResponse> SystemOCICallControlApplicationGetListRequestAsync(this OcipClientBase client, SystemOCICallControlApplicationGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCICallControlApplicationGetListResponse;
        }
        /// <summary>
        /// Modify an entry from the call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationModifyACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationModifyACLEntryRequest(this OcipClientBase client, SystemOCICallControlApplicationModifyACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationModifyACLEntryRequestAsync(this OcipClientBase client, SystemOCICallControlApplicationModifyACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify an application from the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationModifyRequest(this OcipClientBase client, SystemOCICallControlApplicationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an application from the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationModifyRequestAsync(this OcipClientBase client, SystemOCICallControlApplicationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the OCI call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlDeleteACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlDeleteACLEntryRequest(this OcipClientBase client, SystemOCICallControlDeleteACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the OCI call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlDeleteACLEntryRequestAsync(this OcipClientBase client, SystemOCICallControlDeleteACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the OCI call control access control list.
        /// The response is either SystemOCICallControlGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlGetACLListRequestAsync instead.")]
        public static async Task<SystemOCICallControlGetACLListResponse> SystemOCICallControlGetACLListRequest(this OcipClientBase client, SystemOCICallControlGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCICallControlGetACLListResponse;
        }

        /// <summary>
        /// Get the OCI call control access control list.
        /// The response is either SystemOCICallControlGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOCICallControlGetACLListResponse> SystemOCICallControlGetACLListRequestAsync(this OcipClientBase client, SystemOCICallControlGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCICallControlGetACLListResponse;
        }
        /// <summary>
        /// Modify an entry from the call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlModifyACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlModifyACLEntryRequest(this OcipClientBase client, SystemOCICallControlModifyACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlModifyACLEntryRequestAsync(this OcipClientBase client, SystemOCICallControlModifyACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIDeleteACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIDeleteACLEntryRequest(this OcipClientBase client, SystemOCIDeleteACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIDeleteACLEntryRequestAsync(this OcipClientBase client, SystemOCIDeleteACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the OCI access control list.
        /// The response is either SystemOCIGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIGetACLListRequestAsync instead.")]
        public static async Task<SystemOCIGetACLListResponse> SystemOCIGetACLListRequest(this OcipClientBase client, SystemOCIGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCIGetACLListResponse;
        }

        /// <summary>
        /// Get the OCI access control list.
        /// The response is either SystemOCIGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIGetACLListResponse> SystemOCIGetACLListRequestAsync(this OcipClientBase client, SystemOCIGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCIGetACLListResponse;
        }
        /// <summary>
        /// Modify an entry in the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIModifyACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIModifyACLEntryRequest(this OcipClientBase client, SystemOCIModifyACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry in the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIModifyACLEntryRequestAsync(this OcipClientBase client, SystemOCIModifyACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingAddACLEntryRequest13mp9Async instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingAddACLEntryRequest13mp9(this OcipClientBase client, SystemOCIReportingAddACLEntryRequest13mp9 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingAddACLEntryRequest13mp9Async(this OcipClientBase client, SystemOCIReportingAddACLEntryRequest13mp9 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of reported messages for a host in the OCI Reporting
        /// Access Control List. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingAddMessageNameListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingAddMessageNameListRequest(this OcipClientBase client, SystemOCIReportingAddMessageNameListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of reported messages for a host in the OCI Reporting
        /// Access Control List. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingAddMessageNameListRequestAsync(this OcipClientBase client, SystemOCIReportingAddMessageNameListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingDeleteACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingDeleteACLEntryRequest(this OcipClientBase client, SystemOCIReportingDeleteACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingDeleteACLEntryRequestAsync(this OcipClientBase client, SystemOCIReportingDeleteACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of reported messages from a host in the OCI Reporting
        /// Access Control List. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingDeleteMessageNameListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingDeleteMessageNameListRequest(this OcipClientBase client, SystemOCIReportingDeleteMessageNameListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of reported messages from a host in the OCI Reporting
        /// Access Control List. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingDeleteMessageNameListRequestAsync(this OcipClientBase client, SystemOCIReportingDeleteMessageNameListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the OCI Reporting Access Control List.
        /// The response is either a SystemOCIReportingGetACLListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingGetACLListRequestAsync instead.")]
        public static async Task<SystemOCIReportingGetACLListResponse> SystemOCIReportingGetACLListRequest(this OcipClientBase client, SystemOCIReportingGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCIReportingGetACLListResponse;
        }

        /// <summary>
        /// Get the OCI Reporting Access Control List.
        /// The response is either a SystemOCIReportingGetACLListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIReportingGetACLListResponse> SystemOCIReportingGetACLListRequestAsync(this OcipClientBase client, SystemOCIReportingGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCIReportingGetACLListResponse;
        }
        /// <summary>
        /// Get a list of restricted messages from a host in the OCI Reporting
        /// Access Control List. The response is either a SystemOCIReportingGetMessageNameListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingGetMessageNameListRequestAsync instead.")]
        public static async Task<SystemOCIReportingGetMessageNameListResponse> SystemOCIReportingGetMessageNameListRequest(this OcipClientBase client, SystemOCIReportingGetMessageNameListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCIReportingGetMessageNameListResponse;
        }

        /// <summary>
        /// Get a list of restricted messages from a host in the OCI Reporting
        /// Access Control List. The response is either a SystemOCIReportingGetMessageNameListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIReportingGetMessageNameListResponse> SystemOCIReportingGetMessageNameListRequestAsync(this OcipClientBase client, SystemOCIReportingGetMessageNameListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCIReportingGetMessageNameListResponse;
        }
        /// <summary>
        /// Modify the description on an entry in the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingModifyACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingModifyACLEntryRequest(this OcipClientBase client, SystemOCIReportingModifyACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the description on an entry in the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingModifyACLEntryRequestAsync(this OcipClientBase client, SystemOCIReportingModifyACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of OCIReporting system parameters.
        /// The response is either SystemOCIReportingParametersGetResponse14sp1 or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingParametersGetRequest14sp1Async instead.")]
        public static async Task<SystemOCIReportingParametersGetResponse14sp1> SystemOCIReportingParametersGetRequest14sp1(this OcipClientBase client, SystemOCIReportingParametersGetRequest14sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCIReportingParametersGetResponse14sp1;
        }

        /// <summary>
        /// Request to get the list of OCIReporting system parameters.
        /// The response is either SystemOCIReportingParametersGetResponse14sp1 or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIReportingParametersGetResponse14sp1> SystemOCIReportingParametersGetRequest14sp1Async(this OcipClientBase client, SystemOCIReportingParametersGetRequest14sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCIReportingParametersGetResponse14sp1;
        }
        /// <summary>
        /// Request to get the list of OCIReporting system parameters.
        /// The response is either SystemOCIReportingParametersGetResponse22 or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingParametersGetRequest22Async instead.")]
        public static async Task<SystemOCIReportingParametersGetResponse22> SystemOCIReportingParametersGetRequest22(this OcipClientBase client, SystemOCIReportingParametersGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCIReportingParametersGetResponse22;
        }

        /// <summary>
        /// Request to get the list of OCIReporting system parameters.
        /// The response is either SystemOCIReportingParametersGetResponse22 or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIReportingParametersGetResponse22> SystemOCIReportingParametersGetRequest22Async(this OcipClientBase client, SystemOCIReportingParametersGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCIReportingParametersGetResponse22;
        }
        /// <summary>
        /// Request to modify OCI Reporting system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingParametersModifyRequest(this OcipClientBase client, SystemOCIReportingParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify OCI Reporting system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingParametersModifyRequestAsync(this OcipClientBase client, SystemOCIReportingParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Office Zone.  The zoneList is an ordered list with the first member being of the highest priority.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOfficeZoneAddRequest(this OcipClientBase client, SystemOfficeZoneAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Office Zone.  The zoneList is an ordered list with the first member being of the highest priority.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOfficeZoneAddRequestAsync(this OcipClientBase client, SystemOfficeZoneAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an Office Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOfficeZoneDeleteRequest(this OcipClientBase client, SystemOfficeZoneDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an Office Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOfficeZoneDeleteRequestAsync(this OcipClientBase client, SystemOfficeZoneDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of service providers that have a given Office Zone assigned.  The response is either a SystemOfficeZoneGetAssignedServiceProviderListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneGetAssignedServiceProviderListRequestAsync instead.")]
        public static async Task<SystemOfficeZoneGetAssignedServiceProviderListResponse> SystemOfficeZoneGetAssignedServiceProviderListRequest(this OcipClientBase client, SystemOfficeZoneGetAssignedServiceProviderListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOfficeZoneGetAssignedServiceProviderListResponse;
        }

        /// <summary>
        /// Request a list of service providers that have a given Office Zone assigned.  The response is either a SystemOfficeZoneGetAssignedServiceProviderListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOfficeZoneGetAssignedServiceProviderListResponse> SystemOfficeZoneGetAssignedServiceProviderListRequestAsync(this OcipClientBase client, SystemOfficeZoneGetAssignedServiceProviderListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOfficeZoneGetAssignedServiceProviderListResponse;
        }
        /// <summary>
        /// Get the list of all Office Zones.
        /// The response is either a SystemOfficeZoneGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneGetListRequestAsync instead.")]
        public static async Task<SystemOfficeZoneGetListResponse> SystemOfficeZoneGetListRequest(this OcipClientBase client, SystemOfficeZoneGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOfficeZoneGetListResponse;
        }

        /// <summary>
        /// Get the list of all Office Zones.
        /// The response is either a SystemOfficeZoneGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOfficeZoneGetListResponse> SystemOfficeZoneGetListRequestAsync(this OcipClientBase client, SystemOfficeZoneGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOfficeZoneGetListResponse;
        }
        /// <summary>
        /// Get an existing Office Zone.
        /// The response is either a SystemOfficeZoneGetResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneGetRequestAsync instead.")]
        public static async Task<SystemOfficeZoneGetResponse> SystemOfficeZoneGetRequest(this OcipClientBase client, SystemOfficeZoneGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOfficeZoneGetResponse;
        }

        /// <summary>
        /// Get an existing Office Zone.
        /// The response is either a SystemOfficeZoneGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOfficeZoneGetResponse> SystemOfficeZoneGetRequestAsync(this OcipClientBase client, SystemOfficeZoneGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOfficeZoneGetResponse;
        }
        /// <summary>
        /// Get the list of Office Zones that contain a specific
        /// Zone.
        /// The response is either a SystemOfficeZoneGetZoneUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneGetZoneUsageListRequestAsync instead.")]
        public static async Task<SystemOfficeZoneGetZoneUsageListResponse> SystemOfficeZoneGetZoneUsageListRequest(this OcipClientBase client, SystemOfficeZoneGetZoneUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOfficeZoneGetZoneUsageListResponse;
        }

        /// <summary>
        /// Get the list of Office Zones that contain a specific
        /// Zone.
        /// The response is either a SystemOfficeZoneGetZoneUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOfficeZoneGetZoneUsageListResponse> SystemOfficeZoneGetZoneUsageListRequestAsync(this OcipClientBase client, SystemOfficeZoneGetZoneUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOfficeZoneGetZoneUsageListResponse;
        }
        /// <summary>
        /// Modify an existing Office Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOfficeZoneModifyRequest(this OcipClientBase client, SystemOfficeZoneModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Office Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOfficeZoneModifyRequestAsync(this OcipClientBase client, SystemOfficeZoneModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordRulesGetRequest22Async instead.")]
        public static async Task<SystemPasswordRulesGetResponse22> SystemPasswordRulesGetRequest22(this OcipClientBase client, SystemPasswordRulesGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPasswordRulesGetResponse22;
        }

        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPasswordRulesGetResponse22> SystemPasswordRulesGetRequest22Async(this OcipClientBase client, SystemPasswordRulesGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPasswordRulesGetResponse22;
        }
        /// <summary>
        /// Request to modify the system providers password rule
        /// setting applicable to System Adminstrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, User.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// forcePasswordChangeAfterReset
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordRulesModifyRequest14sp3Async instead.")]
        public static async Task<SuccessResponse> SystemPasswordRulesModifyRequest14sp3(this OcipClientBase client, SystemPasswordRulesModifyRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system providers password rule
        /// setting applicable to System Adminstrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, User.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// forcePasswordChangeAfterReset
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPasswordRulesModifyRequest14sp3Async(this OcipClientBase client, SystemPasswordRulesModifyRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the password security parameters for the system.
        /// The response is either a SystemPasswordSecurityParametersGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordSecurityParametersGetRequestAsync instead.")]
        public static async Task<SystemPasswordSecurityParametersGetResponse> SystemPasswordSecurityParametersGetRequest(this OcipClientBase client, SystemPasswordSecurityParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPasswordSecurityParametersGetResponse;
        }

        /// <summary>
        /// Get the password security parameters for the system.
        /// The response is either a SystemPasswordSecurityParametersGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemPasswordSecurityParametersGetResponse> SystemPasswordSecurityParametersGetRequestAsync(this OcipClientBase client, SystemPasswordSecurityParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPasswordSecurityParametersGetResponse;
        }
        /// <summary>
        /// Modify the password security settings for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordSecurityParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPasswordSecurityParametersModifyRequest(this OcipClientBase client, SystemPasswordSecurityParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the password security settings for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPasswordSecurityParametersModifyRequestAsync(this OcipClientBase client, SystemPasswordSecurityParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Generate a performance measurements report.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementGenerateReportRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementGenerateReportRequest(this OcipClientBase client, SystemPerformanceMeasurementGenerateReportRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Generate a performance measurements report.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementGenerateReportRequestAsync(this OcipClientBase client, SystemPerformanceMeasurementGenerateReportRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingAddFileServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingAddFileServerRequest(this OcipClientBase client, SystemPerformanceMeasurementReportingAddFileServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingAddFileServerRequestAsync(this OcipClientBase client, SystemPerformanceMeasurementReportingAddFileServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingDeleteFileServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingDeleteFileServerRequest(this OcipClientBase client, SystemPerformanceMeasurementReportingDeleteFileServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingDeleteFileServerRequestAsync(this OcipClientBase client, SystemPerformanceMeasurementReportingDeleteFileServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list performance measurements reporting ftp servers.
        /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingGetFileServerListRequestAsync instead.")]
        public static async Task<SystemPerformanceMeasurementReportingGetFileServerListResponse> SystemPerformanceMeasurementReportingGetFileServerListRequest(this OcipClientBase client, SystemPerformanceMeasurementReportingGetFileServerListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetFileServerListResponse;
        }

        /// <summary>
        /// Requests the list performance measurements reporting ftp servers.
        /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemPerformanceMeasurementReportingGetFileServerListResponse> SystemPerformanceMeasurementReportingGetFileServerListRequestAsync(this OcipClientBase client, SystemPerformanceMeasurementReportingGetFileServerListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetFileServerListResponse;
        }
        /// <summary>
        /// Add a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingAddFileServerRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingAddFileServerRequest22(this OcipClientBase client, SystemPerformanceMeasurementReportingAddFileServerRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingAddFileServerRequest22Async(this OcipClientBase client, SystemPerformanceMeasurementReportingAddFileServerRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingDeleteFileServerRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingDeleteFileServerRequest22(this OcipClientBase client, SystemPerformanceMeasurementReportingDeleteFileServerRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingDeleteFileServerRequest22Async(this OcipClientBase client, SystemPerformanceMeasurementReportingDeleteFileServerRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list performance measurements reporting ftp servers.
        /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingGetFileServerListRequest22Async instead.")]
        public static async Task<SystemPerformanceMeasurementReportingGetFileServerListResponse22> SystemPerformanceMeasurementReportingGetFileServerListRequest22(this OcipClientBase client, SystemPerformanceMeasurementReportingGetFileServerListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetFileServerListResponse22;
        }

        /// <summary>
        /// Requests the list performance measurements reporting ftp servers.
        /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPerformanceMeasurementReportingGetFileServerListResponse22> SystemPerformanceMeasurementReportingGetFileServerListRequest22Async(this OcipClientBase client, SystemPerformanceMeasurementReportingGetFileServerListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetFileServerListResponse22;
        }
        /// <summary>
        /// Requests the performance measurements reporting settings.
        /// The response is either SystemPerformanceMeasurementReportingGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingGetRequest22Async instead.")]
        public static async Task<SystemPerformanceMeasurementReportingGetResponse22> SystemPerformanceMeasurementReportingGetRequest22(this OcipClientBase client, SystemPerformanceMeasurementReportingGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetResponse22;
        }

        /// <summary>
        /// Requests the performance measurements reporting settings.
        /// The response is either SystemPerformanceMeasurementReportingGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPerformanceMeasurementReportingGetResponse22> SystemPerformanceMeasurementReportingGetRequest22Async(this OcipClientBase client, SystemPerformanceMeasurementReportingGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetResponse22;
        }
        /// <summary>
        /// Modify a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingModifyFileServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyFileServerRequest(this OcipClientBase client, SystemPerformanceMeasurementReportingModifyFileServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyFileServerRequestAsync(this OcipClientBase client, SystemPerformanceMeasurementReportingModifyFileServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingModifyFileServerRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyFileServerRequest22(this OcipClientBase client, SystemPerformanceMeasurementReportingModifyFileServerRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyFileServerRequest22Async(this OcipClientBase client, SystemPerformanceMeasurementReportingModifyFileServerRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the performance measurements reporting settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyRequest(this OcipClientBase client, SystemPerformanceMeasurementReportingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the performance measurements reporting settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyRequestAsync(this OcipClientBase client, SystemPerformanceMeasurementReportingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyGetDefaultRequest22Async instead.")]
        public static async Task<SystemPolicyGetDefaultResponse22> SystemPolicyGetDefaultRequest22(this OcipClientBase client, SystemPolicyGetDefaultRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPolicyGetDefaultResponse22;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse22> SystemPolicyGetDefaultRequest22Async(this OcipClientBase client, SystemPolicyGetDefaultRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPolicyGetDefaultResponse22;
        }
        /// <summary>
        /// Request to modify the system's default policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// GroupAdminDialableCallerIDAccess
        /// ServiceProviderAdminDialableCallerIDAccess
        /// GroupAdminCommunicationBarringUserProfileAccess (This element is only used for groups in an Enterprise)
        /// GroupAdminVerifyTranslationAndRoutingAccess
        /// ServiceProviderVerifyTranslationAndRoutingAccess
        /// groupUserAutoAttendantNameDialingAccess
        /// The following elements are only used in XS data mode:
        /// serviceProviderAdminCommunicationBarringAccess
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyModifyDefaultRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemPolicyModifyDefaultRequest22(this OcipClientBase client, SystemPolicyModifyDefaultRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system's default policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// GroupAdminDialableCallerIDAccess
        /// ServiceProviderAdminDialableCallerIDAccess
        /// GroupAdminCommunicationBarringUserProfileAccess (This element is only used for groups in an Enterprise)
        /// GroupAdminVerifyTranslationAndRoutingAccess
        /// ServiceProviderVerifyTranslationAndRoutingAccess
        /// groupUserAutoAttendantNameDialingAccess
        /// The following elements are only used in XS data mode:
        /// serviceProviderAdminCommunicationBarringAccess
        /// </summary>
        public static async Task<SuccessResponse> SystemPolicyModifyDefaultRequest22Async(this OcipClientBase client, SystemPolicyModifyDefaultRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the system passcode rules setting.
        /// The response is either SystemPortalPasscodeRulesGetResponse19 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPortalPasscodeRulesGetRequest19Async instead.")]
        public static async Task<SystemPortalPasscodeRulesGetResponse19> SystemPortalPasscodeRulesGetRequest19(this OcipClientBase client, SystemPortalPasscodeRulesGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPortalPasscodeRulesGetResponse19;
        }

        /// <summary>
        /// Requests the system passcode rules setting.
        /// The response is either SystemPortalPasscodeRulesGetResponse19 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPortalPasscodeRulesGetResponse19> SystemPortalPasscodeRulesGetRequest19Async(this OcipClientBase client, SystemPortalPasscodeRulesGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPortalPasscodeRulesGetResponse19;
        }
        /// <summary>
        /// Request to modify the system passcode rules setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// numberOfRepeatedDigits
        /// disallowRepeatedPatterns
        /// disallowContiguousSequences
        /// numberOfAscendingDigits
        /// numberOfDescendingDigits
        /// numberOfPreviousPasscodes
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPortalPasscodeRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPortalPasscodeRulesModifyRequest(this OcipClientBase client, SystemPortalPasscodeRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system passcode rules setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// numberOfRepeatedDigits
        /// disallowRepeatedPatterns
        /// disallowContiguousSequences
        /// numberOfAscendingDigits
        /// numberOfDescendingDigits
        /// numberOfPreviousPasscodes
        /// </summary>
        public static async Task<SuccessResponse> SystemPortalPasscodeRulesModifyRequestAsync(this OcipClientBase client, SystemPortalPasscodeRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the system's provisioning validation attributes.
        /// The response is either a SystemProvisioningValidationGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemProvisioningValidationGetRequest22Async instead.")]
        public static async Task<SystemProvisioningValidationGetResponse22> SystemProvisioningValidationGetRequest22(this OcipClientBase client, SystemProvisioningValidationGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemProvisioningValidationGetResponse22;
        }

        /// <summary>
        /// Request to get the system's provisioning validation attributes.
        /// The response is either a SystemProvisioningValidationGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemProvisioningValidationGetResponse22> SystemProvisioningValidationGetRequest22Async(this OcipClientBase client, SystemProvisioningValidationGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemProvisioningValidationGetResponse22;
        }
        /// <summary>
        /// Request to modify the system's provisioning validation attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// denyMobilityNumberAsRedirectionDestination
        /// denyEnterpriseNumberAsNetworkLocationDestination
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemProvisioningValidationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemProvisioningValidationModifyRequest(this OcipClientBase client, SystemProvisioningValidationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system's provisioning validation attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// denyMobilityNumberAsRedirectionDestination
        /// denyEnterpriseNumberAsNetworkLocationDestination
        /// </summary>
        public static async Task<SuccessResponse> SystemProvisioningValidationModifyRequestAsync(this OcipClientBase client, SystemProvisioningValidationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an application to the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationAllowedApplicationAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationAddRequest(this OcipClientBase client, SystemPushNotificationAllowedApplicationAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an application to the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationAddRequestAsync(this OcipClientBase client, SystemPushNotificationAllowedApplicationAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to remove an application from the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationAllowedApplicationDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationDeleteRequest(this OcipClientBase client, SystemPushNotificationAllowedApplicationDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to remove an application from the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationDeleteRequestAsync(this OcipClientBase client, SystemPushNotificationAllowedApplicationDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of allowed push notification applications.
        /// The response is either SystemPushNotificationAllowedApplicationGetListResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationAllowedApplicationGetListRequestAsync instead.")]
        public static async Task<SystemPushNotificationAllowedApplicationGetListResponse> SystemPushNotificationAllowedApplicationGetListRequest(this OcipClientBase client, SystemPushNotificationAllowedApplicationGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPushNotificationAllowedApplicationGetListResponse;
        }

        /// <summary>
        /// Request to get the list of allowed push notification applications.
        /// The response is either SystemPushNotificationAllowedApplicationGetListResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemPushNotificationAllowedApplicationGetListResponse> SystemPushNotificationAllowedApplicationGetListRequestAsync(this OcipClientBase client, SystemPushNotificationAllowedApplicationGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPushNotificationAllowedApplicationGetListResponse;
        }
        /// <summary>
        /// Request to modify an application in the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationAllowedApplicationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationModifyRequest(this OcipClientBase client, SystemPushNotificationAllowedApplicationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an application in the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationModifyRequestAsync(this OcipClientBase client, SystemPushNotificationAllowedApplicationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of push notification system parameters.
        /// The response is either SystemPushNotificationParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationParametersGetRequestAsync instead.")]
        public static async Task<SystemPushNotificationParametersGetResponse> SystemPushNotificationParametersGetRequest(this OcipClientBase client, SystemPushNotificationParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPushNotificationParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of push notification system parameters.
        /// The response is either SystemPushNotificationParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemPushNotificationParametersGetResponse> SystemPushNotificationParametersGetRequestAsync(this OcipClientBase client, SystemPushNotificationParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPushNotificationParametersGetResponse;
        }
        /// <summary>
        /// Request to modify push notification system parameters.
        /// 
        /// The following elements are only used in AS data mode and ignored in the Amplify data mode:
        /// subscriptionEventsPerSecond
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPushNotificationParametersModifyRequest(this OcipClientBase client, SystemPushNotificationParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify push notification system parameters.
        /// 
        /// The following elements are only used in AS data mode and ignored in the Amplify data mode:
        /// subscriptionEventsPerSecond
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPushNotificationParametersModifyRequestAsync(this OcipClientBase client, SystemPushNotificationParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Redundancy system parameters.
        /// The response is either SystemRedundancyParametersGetResponse16sp2 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRedundancyParametersGetRequest16sp2Async instead.")]
        public static async Task<SystemRedundancyParametersGetResponse16sp2> SystemRedundancyParametersGetRequest16sp2(this OcipClientBase client, SystemRedundancyParametersGetRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRedundancyParametersGetResponse16sp2;
        }

        /// <summary>
        /// Request to get the list of Redundancy system parameters.
        /// The response is either SystemRedundancyParametersGetResponse16sp2 or ErrorResponse.
        /// </summary>
        public static async Task<SystemRedundancyParametersGetResponse16sp2> SystemRedundancyParametersGetRequest16sp2Async(this OcipClientBase client, SystemRedundancyParametersGetRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRedundancyParametersGetResponse16sp2;
        }
        /// <summary>
        /// Request to modify Redundancy system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRedundancyParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRedundancyParametersModifyRequest(this OcipClientBase client, SystemRedundancyParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Redundancy system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRedundancyParametersModifyRequestAsync(this OcipClientBase client, SystemRedundancyParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoamingNetworkAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoamingNetworkAddRequest(this OcipClientBase client, SystemRoamingNetworkAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoamingNetworkAddRequestAsync(this OcipClientBase client, SystemRoamingNetworkAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoamingNetworkDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoamingNetworkDeleteRequest(this OcipClientBase client, SystemRoamingNetworkDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoamingNetworkDeleteRequestAsync(this OcipClientBase client, SystemRoamingNetworkDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Roaming Networks.
        /// The response is either a SystemRoamingNetworkGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoamingNetworkGetListRequestAsync instead.")]
        public static async Task<SystemRoamingNetworkGetListResponse> SystemRoamingNetworkGetListRequest(this OcipClientBase client, SystemRoamingNetworkGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoamingNetworkGetListResponse;
        }

        /// <summary>
        /// Get the list of all Roaming Networks.
        /// The response is either a SystemRoamingNetworkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoamingNetworkGetListResponse> SystemRoamingNetworkGetListRequestAsync(this OcipClientBase client, SystemRoamingNetworkGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoamingNetworkGetListResponse;
        }
        /// <summary>
        /// Modify a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoamingNetworkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoamingNetworkModifyRequest(this OcipClientBase client, SystemRoamingNetworkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoamingNetworkModifyRequestAsync(this OcipClientBase client, SystemRoamingNetworkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an Route Point External System, which is a cluster of Application
        /// Controllers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemAddRequest(this OcipClientBase client, SystemRoutePointExternalSystemAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an Route Point External System, which is a cluster of Application
        /// Controllers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemAddRequestAsync(this OcipClientBase client, SystemRoutePointExternalSystemAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an application controller to Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemApplicationControllerAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemApplicationControllerAddListRequest(this OcipClientBase client, SystemRoutePointExternalSystemApplicationControllerAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an application controller to Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemApplicationControllerAddListRequestAsync(this OcipClientBase client, SystemRoutePointExternalSystemApplicationControllerAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an application controller for Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemApplicationControllerDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemApplicationControllerDeleteListRequest(this OcipClientBase client, SystemRoutePointExternalSystemApplicationControllerDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an application controller for Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemApplicationControllerDeleteListRequestAsync(this OcipClientBase client, SystemRoutePointExternalSystemApplicationControllerDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Application Controllers assigned to the Route Point External Systems specified.
        /// The response is either SystemRoutePointExternalSystemApplicationControllerGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemApplicationControllerGetRequestAsync instead.")]
        public static async Task<SystemRoutePointExternalSystemApplicationControllerGetResponse> SystemRoutePointExternalSystemApplicationControllerGetRequest(this OcipClientBase client, SystemRoutePointExternalSystemApplicationControllerGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutePointExternalSystemApplicationControllerGetResponse;
        }

        /// <summary>
        /// Get a list of Application Controllers assigned to the Route Point External Systems specified.
        /// The response is either SystemRoutePointExternalSystemApplicationControllerGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutePointExternalSystemApplicationControllerGetResponse> SystemRoutePointExternalSystemApplicationControllerGetRequestAsync(this OcipClientBase client, SystemRoutePointExternalSystemApplicationControllerGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutePointExternalSystemApplicationControllerGetResponse;
        }
        /// <summary>
        /// Delete an Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemDeleteRequest(this OcipClientBase client, SystemRoutePointExternalSystemDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemDeleteRequestAsync(this OcipClientBase client, SystemRoutePointExternalSystemDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Route Point External Systems that are configured for the system.
        /// The response is either SystemRoutePointExternalSystemGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemGetListRequestAsync instead.")]
        public static async Task<SystemRoutePointExternalSystemGetListResponse> SystemRoutePointExternalSystemGetListRequest(this OcipClientBase client, SystemRoutePointExternalSystemGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutePointExternalSystemGetListResponse;
        }

        /// <summary>
        /// Get a list of Route Point External Systems that are configured for the system.
        /// The response is either SystemRoutePointExternalSystemGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutePointExternalSystemGetListResponse> SystemRoutePointExternalSystemGetListRequestAsync(this OcipClientBase client, SystemRoutePointExternalSystemGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutePointExternalSystemGetListResponse;
        }
        /// <summary>
        /// Get a list of Route Points that are using the specified Route Point External System.
        /// The response is either a SystemRoutePointExternalSystemGetRoutePointListResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemGetRoutePointListRequestAsync instead.")]
        public static async Task<SystemRoutePointExternalSystemGetRoutePointListResponse> SystemRoutePointExternalSystemGetRoutePointListRequest(this OcipClientBase client, SystemRoutePointExternalSystemGetRoutePointListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutePointExternalSystemGetRoutePointListResponse;
        }

        /// <summary>
        /// Get a list of Route Points that are using the specified Route Point External System.
        /// The response is either a SystemRoutePointExternalSystemGetRoutePointListResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutePointExternalSystemGetRoutePointListResponse> SystemRoutePointExternalSystemGetRoutePointListRequestAsync(this OcipClientBase client, SystemRoutePointExternalSystemGetRoutePointListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutePointExternalSystemGetRoutePointListResponse;
        }
        /// <summary>
        /// Modify an Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemModifyRequest(this OcipClientBase client, SystemRoutePointExternalSystemModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemModifyRequestAsync(this OcipClientBase client, SystemRoutePointExternalSystemModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a routing device to a route.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingAddRouteDeviceRequest14Async instead.")]
        public static async Task<SuccessResponse> SystemRoutingAddRouteDeviceRequest14(this OcipClientBase client, SystemRoutingAddRouteDeviceRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a routing device to a route.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingAddRouteDeviceRequest14Async(this OcipClientBase client, SystemRoutingAddRouteDeviceRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a route to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingAddRouteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingAddRouteRequest(this OcipClientBase client, SystemRoutingAddRouteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a route to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingAddRouteRequestAsync(this OcipClientBase client, SystemRoutingAddRouteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a digit routing table entry to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingAddTranslationRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingAddTranslationRequest(this OcipClientBase client, SystemRoutingAddTranslationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a digit routing table entry to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingAddTranslationRequestAsync(this OcipClientBase client, SystemRoutingAddTranslationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a routing device from a route.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingDeleteRouteDeviceRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingDeleteRouteDeviceRequest(this OcipClientBase client, SystemRoutingDeleteRouteDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a routing device from a route.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingDeleteRouteDeviceRequestAsync(this OcipClientBase client, SystemRoutingDeleteRouteDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a route from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingDeleteRouteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingDeleteRouteRequest(this OcipClientBase client, SystemRoutingDeleteRouteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a route from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingDeleteRouteRequestAsync(this OcipClientBase client, SystemRoutingDeleteRouteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a digit routing table entry from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingDeleteTranslationRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingDeleteTranslationRequest(this OcipClientBase client, SystemRoutingDeleteTranslationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a digit routing table entry from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingDeleteTranslationRequestAsync(this OcipClientBase client, SystemRoutingDeleteTranslationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system's general routing attributes.
        /// The response is either a SystemRoutingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingGetRequestAsync instead.")]
        public static async Task<SystemRoutingGetResponse> SystemRoutingGetRequest(this OcipClientBase client, SystemRoutingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutingGetResponse;
        }

        /// <summary>
        /// Request the system's general routing attributes.
        /// The response is either a SystemRoutingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutingGetResponse> SystemRoutingGetRequestAsync(this OcipClientBase client, SystemRoutingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutingGetResponse;
        }
        /// <summary>
        /// Request to get a list of devices for a route.
        /// The response is either a SystemRoutingGetRouteDeviceListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingGetRouteDeviceListRequestAsync instead.")]
        public static async Task<SystemRoutingGetRouteDeviceListResponse> SystemRoutingGetRouteDeviceListRequest(this OcipClientBase client, SystemRoutingGetRouteDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutingGetRouteDeviceListResponse;
        }

        /// <summary>
        /// Request to get a list of devices for a route.
        /// The response is either a SystemRoutingGetRouteDeviceListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutingGetRouteDeviceListResponse> SystemRoutingGetRouteDeviceListRequestAsync(this OcipClientBase client, SystemRoutingGetRouteDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutingGetRouteDeviceListResponse;
        }
        /// <summary>
        /// Request to get a list of routes in the system.
        /// The response is either a SystemRoutingGetRouteListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingGetRouteListRequestAsync instead.")]
        public static async Task<SystemRoutingGetRouteListResponse> SystemRoutingGetRouteListRequest(this OcipClientBase client, SystemRoutingGetRouteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutingGetRouteListResponse;
        }

        /// <summary>
        /// Request to get a list of routes in the system.
        /// The response is either a SystemRoutingGetRouteListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutingGetRouteListResponse> SystemRoutingGetRouteListRequestAsync(this OcipClientBase client, SystemRoutingGetRouteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutingGetRouteListResponse;
        }
        /// <summary>
        /// Request to get the system digit routing table.
        /// The response is either a SystemRoutingGetTranslationListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingGetTranslationListRequestAsync instead.")]
        public static async Task<SystemRoutingGetTranslationListResponse> SystemRoutingGetTranslationListRequest(this OcipClientBase client, SystemRoutingGetTranslationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutingGetTranslationListResponse;
        }

        /// <summary>
        /// Request to get the system digit routing table.
        /// The response is either a SystemRoutingGetTranslationListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutingGetTranslationListResponse> SystemRoutingGetTranslationListRequestAsync(this OcipClientBase client, SystemRoutingGetTranslationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutingGetTranslationListResponse;
        }
        /// <summary>
        /// Modifies the system's general routing attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingModifyRequest(this OcipClientBase client, SystemRoutingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's general routing attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingModifyRequestAsync(this OcipClientBase client, SystemRoutingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a routing device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingModifyRouteDeviceRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingModifyRouteDeviceRequest(this OcipClientBase client, SystemRoutingModifyRouteDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a routing device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingModifyRouteDeviceRequestAsync(this OcipClientBase client, SystemRoutingModifyRouteDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a digit routing table entry in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingModifyTranslationRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingModifyTranslationRequest(this OcipClientBase client, SystemRoutingModifyTranslationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a digit routing table entry in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingModifyTranslationRequestAsync(this OcipClientBase client, SystemRoutingModifyTranslationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of system routing profiles.
        /// 
        /// If resellerId is specified, the routing profiles assigned to the given reseller are returned. If reseller administrator sends the request, resellerId is not specified, the administrator’s resellerId is used.
        /// If system or provisioning administrator sends the request, resellerId is not specified, all system routing profiles are returned.
        /// 
        /// The response is either a SystemRoutingProfileGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingProfileGetListRequestAsync instead.")]
        public static async Task<SystemRoutingProfileGetListResponse> SystemRoutingProfileGetListRequest(this OcipClientBase client, SystemRoutingProfileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutingProfileGetListResponse;
        }

        /// <summary>
        /// Request to get the list of system routing profiles.
        /// 
        /// If resellerId is specified, the routing profiles assigned to the given reseller are returned. If reseller administrator sends the request, resellerId is not specified, the administrator’s resellerId is used.
        /// If system or provisioning administrator sends the request, resellerId is not specified, all system routing profiles are returned.
        /// 
        /// The response is either a SystemRoutingProfileGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutingProfileGetListResponse> SystemRoutingProfileGetListRequestAsync(this OcipClientBase client, SystemRoutingProfileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutingProfileGetListResponse;
        }
        /// <summary>
        /// Get the system call admission control parameters.
        /// The response is either a SystemRuntimeDataPublicationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRuntimeDataPublicationGetRequestAsync instead.")]
        public static async Task<SystemRuntimeDataPublicationGetResponse> SystemRuntimeDataPublicationGetRequest(this OcipClientBase client, SystemRuntimeDataPublicationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRuntimeDataPublicationGetResponse;
        }

        /// <summary>
        /// Get the system call admission control parameters.
        /// The response is either a SystemRuntimeDataPublicationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRuntimeDataPublicationGetResponse> SystemRuntimeDataPublicationGetRequestAsync(this OcipClientBase client, SystemRuntimeDataPublicationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRuntimeDataPublicationGetResponse;
        }
        /// <summary>
        /// Modify the system call admission control parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableRuntimeDataSync,
        /// runtimeIntervalInMilliSeconds
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRuntimeDataPublicationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRuntimeDataPublicationModifyRequest(this OcipClientBase client, SystemRuntimeDataPublicationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system call admission control parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableRuntimeDataSync,
        /// runtimeIntervalInMilliSeconds
        /// </summary>
        public static async Task<SuccessResponse> SystemRuntimeDataPublicationModifyRequestAsync(this OcipClientBase client, SystemRuntimeDataPublicationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an event to system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleAddEventRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleAddEventRequest(this OcipClientBase client, SystemScheduleAddEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an event to system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleAddEventRequestAsync(this OcipClientBase client, SystemScheduleAddEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleAddRequest(this OcipClientBase client, SystemScheduleAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleAddRequestAsync(this OcipClientBase client, SystemScheduleAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of events from a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleDeleteEventListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleDeleteEventListRequest(this OcipClientBase client, SystemScheduleDeleteEventListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of events from a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleDeleteEventListRequestAsync(this OcipClientBase client, SystemScheduleDeleteEventListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleDeleteListRequest(this OcipClientBase client, SystemScheduleDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleDeleteListRequestAsync(this OcipClientBase client, SystemScheduleDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of events of a system schedule.
        /// The response is either a SystemScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleGetEventListRequestAsync instead.")]
        public static async Task<SystemScheduleGetEventListResponse> SystemScheduleGetEventListRequest(this OcipClientBase client, SystemScheduleGetEventListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemScheduleGetEventListResponse;
        }

        /// <summary>
        /// Get the list of events of a system schedule.
        /// The response is either a SystemScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemScheduleGetEventListResponse> SystemScheduleGetEventListRequestAsync(this OcipClientBase client, SystemScheduleGetEventListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemScheduleGetEventListResponse;
        }
        /// <summary>
        /// Get an event from a system schedule.
        /// The response is either a SystemScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleGetEventRequestAsync instead.")]
        public static async Task<SystemScheduleGetEventResponse> SystemScheduleGetEventRequest(this OcipClientBase client, SystemScheduleGetEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemScheduleGetEventResponse;
        }

        /// <summary>
        /// Get an event from a system schedule.
        /// The response is either a SystemScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemScheduleGetEventResponse> SystemScheduleGetEventRequestAsync(this OcipClientBase client, SystemScheduleGetEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemScheduleGetEventResponse;
        }
        /// <summary>
        /// Get the list of a system schedules. The list can be filtered by schedule type.
        /// The response is either a SystemScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleGetListRequestAsync instead.")]
        public static async Task<SystemScheduleGetListResponse> SystemScheduleGetListRequest(this OcipClientBase client, SystemScheduleGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemScheduleGetListResponse;
        }

        /// <summary>
        /// Get the list of a system schedules. The list can be filtered by schedule type.
        /// The response is either a SystemScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemScheduleGetListResponse> SystemScheduleGetListRequestAsync(this OcipClientBase client, SystemScheduleGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemScheduleGetListResponse;
        }
        /// <summary>
        /// Modify an event of a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleModifyEventRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleModifyEventRequest(this OcipClientBase client, SystemScheduleModifyEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an event of a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleModifyEventRequestAsync(this OcipClientBase client, SystemScheduleModifyEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleModifyRequest(this OcipClientBase client, SystemScheduleModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleModifyRequestAsync(this OcipClientBase client, SystemScheduleModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Selective Services.
        /// The response is either a SystemSelectiveServicesGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSelectiveServicesGetRequest22Async instead.")]
        public static async Task<SystemSelectiveServicesGetResponse22> SystemSelectiveServicesGetRequest22(this OcipClientBase client, SystemSelectiveServicesGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSelectiveServicesGetResponse22;
        }

        /// <summary>
        /// Request the system level data associated with Selective Services.
        /// The response is either a SystemSelectiveServicesGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemSelectiveServicesGetResponse22> SystemSelectiveServicesGetRequest22Async(this OcipClientBase client, SystemSelectiveServicesGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSelectiveServicesGetResponse22;
        }
        /// <summary>
        /// Modify the system level data associated with SystemSelectiveServicesRequest.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSelectiveServicesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSelectiveServicesModifyRequest(this OcipClientBase client, SystemSelectiveServicesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with SystemSelectiveServicesRequest.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSelectiveServicesModifyRequestAsync(this OcipClientBase client, SystemSelectiveServicesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Server Addresses.
        /// The response is either SystemServerAddressesGetResponse or ErrorResponse.
        /// See also:
        /// PrimaryInfoGetRequest
        /// PublicClusterGetFullyQualifiedDomainNameRequest
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServerAddressesGetRequestAsync instead.")]
        public static async Task<SystemServerAddressesGetResponse> SystemServerAddressesGetRequest(this OcipClientBase client, SystemServerAddressesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServerAddressesGetResponse;
        }

        /// <summary>
        /// Request to get the list of Server Addresses.
        /// The response is either SystemServerAddressesGetResponse or ErrorResponse.
        /// See also:
        /// PrimaryInfoGetRequest
        /// PublicClusterGetFullyQualifiedDomainNameRequest
        /// </summary>
        public static async Task<SystemServerAddressesGetResponse> SystemServerAddressesGetRequestAsync(this OcipClientBase client, SystemServerAddressesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServerAddressesGetResponse;
        }
        /// <summary>
        /// Request to modify Server Addresses.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServerAddressesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServerAddressesModifyRequest(this OcipClientBase client, SystemServerAddressesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Server Addresses.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServerAddressesModifyRequestAsync(this OcipClientBase client, SystemServerAddressesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the Service Activation Access Code system parameters.
        /// The response is either a SystemServiceActivationAccessCodeGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceActivationAccessCodeGetRequestAsync instead.")]
        public static async Task<SystemServiceActivationAccessCodeGetResponse> SystemServiceActivationAccessCodeGetRequest(this OcipClientBase client, SystemServiceActivationAccessCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServiceActivationAccessCodeGetResponse;
        }

        /// <summary>
        /// Get the Service Activation Access Code system parameters.
        /// The response is either a SystemServiceActivationAccessCodeGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemServiceActivationAccessCodeGetResponse> SystemServiceActivationAccessCodeGetRequestAsync(this OcipClientBase client, SystemServiceActivationAccessCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServiceActivationAccessCodeGetResponse;
        }
        /// <summary>
        /// Request to modify Service Activation Access Code system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceActivationAccessCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServiceActivationAccessCodeModifyRequest(this OcipClientBase client, SystemServiceActivationAccessCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Service Activation Access Code system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServiceActivationAccessCodeModifyRequestAsync(this OcipClientBase client, SystemServiceActivationAccessCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the default attributes for a service that are used when assigning the feature.
        /// The response is either a SystemServiceAttributeDefaultGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceAttributeDefaultGetListRequestAsync instead.")]
        public static async Task<SystemServiceAttributeDefaultGetListResponse> SystemServiceAttributeDefaultGetListRequest(this OcipClientBase client, SystemServiceAttributeDefaultGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServiceAttributeDefaultGetListResponse;
        }

        /// <summary>
        /// Request to get the default attributes for a service that are used when assigning the feature.
        /// The response is either a SystemServiceAttributeDefaultGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemServiceAttributeDefaultGetListResponse> SystemServiceAttributeDefaultGetListRequestAsync(this OcipClientBase client, SystemServiceAttributeDefaultGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServiceAttributeDefaultGetListResponse;
        }
        /// <summary>
        /// Request to modify a list of default attributes that are used when assigning the feature.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceAttributeDefaultModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServiceAttributeDefaultModifyListRequest(this OcipClientBase client, SystemServiceAttributeDefaultModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a list of default attributes that are used when assigning the feature.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServiceAttributeDefaultModifyListRequestAsync(this OcipClientBase client, SystemServiceAttributeDefaultModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a service code for the purpose of providing free format routable strings for dialing
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServiceCodeAddRequest(this OcipClientBase client, SystemServiceCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a service code for the purpose of providing free format routable strings for dialing
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServiceCodeAddRequestAsync(this OcipClientBase client, SystemServiceCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a service code for the purpose of providing free format routable strings for dialing
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServiceCodeDeleteRequest(this OcipClientBase client, SystemServiceCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a service code for the purpose of providing free format routable strings for dialing
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServiceCodeDeleteRequestAsync(this OcipClientBase client, SystemServiceCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all service codes that have been defined in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either SystemServiceCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceCodeGetListRequestAsync instead.")]
        public static async Task<SystemServiceCodeGetListResponse> SystemServiceCodeGetListRequest(this OcipClientBase client, SystemServiceCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServiceCodeGetListResponse;
        }

        /// <summary>
        /// Request to get all service codes that have been defined in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either SystemServiceCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemServiceCodeGetListResponse> SystemServiceCodeGetListRequestAsync(this OcipClientBase client, SystemServiceCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServiceCodeGetListResponse;
        }
        /// <summary>
        /// Request to modify service code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServiceCodeModifyRequest(this OcipClientBase client, SystemServiceCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify service code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServiceCodeModifyRequestAsync(this OcipClientBase client, SystemServiceCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get system level Service Pack Migration parameters.
        /// The response is either a SystemServicePackMigrationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServicePackMigrationGetRequestAsync instead.")]
        public static async Task<SystemServicePackMigrationGetResponse> SystemServicePackMigrationGetRequest(this OcipClientBase client, SystemServicePackMigrationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServicePackMigrationGetResponse;
        }

        /// <summary>
        /// Get system level Service Pack Migration parameters.
        /// The response is either a SystemServicePackMigrationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemServicePackMigrationGetResponse> SystemServicePackMigrationGetRequestAsync(this OcipClientBase client, SystemServicePackMigrationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServicePackMigrationGetResponse;
        }
        /// <summary>
        /// Modify system level settings for Service Pack Migration.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServicePackMigrationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServicePackMigrationModifyRequest(this OcipClientBase client, SystemServicePackMigrationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify system level settings for Service Pack Migration.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServicePackMigrationModifyRequestAsync(this OcipClientBase client, SystemServicePackMigrationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Lookup if the given number is defined in the specified service in the system.
        /// The response is SystemServicePhoneNumberLookupResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServicePhoneNumberLookupRequestAsync instead.")]
        public static async Task<SystemServicePhoneNumberLookupResponse> SystemServicePhoneNumberLookupRequest(this OcipClientBase client, SystemServicePhoneNumberLookupRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServicePhoneNumberLookupResponse;
        }

        /// <summary>
        /// Lookup if the given number is defined in the specified service in the system.
        /// The response is SystemServicePhoneNumberLookupResponse.
        /// </summary>
        public static async Task<SystemServicePhoneNumberLookupResponse> SystemServicePhoneNumberLookupRequestAsync(this OcipClientBase client, SystemServicePhoneNumberLookupRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServicePhoneNumberLookupResponse;
        }
        /// <summary>
        /// Get the session admission control settings for the system.
        /// The response is either a SystemSessionAdmissionControlGetResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSessionAdmissionControlGetRequest22Async instead.")]
        public static async Task<SystemSessionAdmissionControlGetResponse22> SystemSessionAdmissionControlGetRequest22(this OcipClientBase client, SystemSessionAdmissionControlGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSessionAdmissionControlGetResponse22;
        }

        /// <summary>
        /// Get the session admission control settings for the system.
        /// The response is either a SystemSessionAdmissionControlGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSessionAdmissionControlGetResponse22> SystemSessionAdmissionControlGetRequest22Async(this OcipClientBase client, SystemSessionAdmissionControlGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSessionAdmissionControlGetResponse22;
        }
        /// <summary>
        /// Modify the session admission control settings for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSessionAdmissionControlModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSessionAdmissionControlModifyRequest(this OcipClientBase client, SystemSessionAdmissionControlModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the session admission control settings for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSessionAdmissionControlModifyRequestAsync(this OcipClientBase client, SystemSessionAdmissionControlModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with session audit.
        /// The response is either a SystemSessionAuditGetResponse23 or
        /// an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSessionAuditGetRequest23Async instead.")]
        public static async Task<SystemSessionAuditGetResponse23> SystemSessionAuditGetRequest23(this OcipClientBase client, SystemSessionAuditGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSessionAuditGetResponse23;
        }

        /// <summary>
        /// Request the system level data associated with session audit.
        /// The response is either a SystemSessionAuditGetResponse23 or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<SystemSessionAuditGetResponse23> SystemSessionAuditGetRequest23Async(this OcipClientBase client, SystemSessionAuditGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSessionAuditGetResponse23;
        }
        /// <summary>
        /// Modify the system level data associated with session audit.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// alwaysAllowRefreshForMS
        /// msAuditIntervalSeconds
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSessionAuditModifyRequest14sp3Async instead.")]
        public static async Task<SuccessResponse> SystemSessionAuditModifyRequest14sp3(this OcipClientBase client, SystemSessionAuditModifyRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with session audit.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// alwaysAllowRefreshForMS
        /// msAuditIntervalSeconds
        /// </summary>
        public static async Task<SuccessResponse> SystemSessionAuditModifyRequest14sp3Async(this OcipClientBase client, SystemSessionAuditModifyRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Retrieves the Sh Interface system parameters.
        /// The response is either a SystemShInterfaceParametersGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemShInterfaceParametersGetRequest17Async instead.")]
        public static async Task<SystemShInterfaceParametersGetResponse> SystemShInterfaceParametersGetRequest17(this OcipClientBase client, SystemShInterfaceParametersGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemShInterfaceParametersGetResponse;
        }

        /// <summary>
        /// Retrieves the Sh Interface system parameters.
        /// The response is either a SystemShInterfaceParametersGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemShInterfaceParametersGetResponse> SystemShInterfaceParametersGetRequest17Async(this OcipClientBase client, SystemShInterfaceParametersGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemShInterfaceParametersGetResponse;
        }
        /// <summary>
        /// Modifies the Sh Interface system parameters.  This request must be submitted on both nodes in the redundant Application Server cluster in order for the changes to take effect on each node without requiring a restart.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemShInterfaceParametersModifyRequest17Async instead.")]
        public static async Task<SuccessResponse> SystemShInterfaceParametersModifyRequest17(this OcipClientBase client, SystemShInterfaceParametersModifyRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the Sh Interface system parameters.  This request must be submitted on both nodes in the redundant Application Server cluster in order for the changes to take effect on each node without requiring a restart.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemShInterfaceParametersModifyRequest17Async(this OcipClientBase client, SystemShInterfaceParametersModifyRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Retrieves the status of the system refresh task on the local Application Server node.
        /// The response is either a SystemShInterfaceRefreshTaskGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemShInterfaceRefreshTaskGetRequestAsync instead.")]
        public static async Task<SystemShInterfaceRefreshTaskGetResponse> SystemShInterfaceRefreshTaskGetRequest(this OcipClientBase client, SystemShInterfaceRefreshTaskGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemShInterfaceRefreshTaskGetResponse;
        }

        /// <summary>
        /// Retrieves the status of the system refresh task on the local Application Server node.
        /// The response is either a SystemShInterfaceRefreshTaskGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemShInterfaceRefreshTaskGetResponse> SystemShInterfaceRefreshTaskGetRequestAsync(this OcipClientBase client, SystemShInterfaceRefreshTaskGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemShInterfaceRefreshTaskGetResponse;
        }
        /// <summary>
        /// Dispatches the system refresh task on the local Application Server node.  At most one instance of the system refresh task may run on an Application Server node at a given point in time.  If the system refresh task is already running when this request is made, an ErrorResponse is returned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemShInterfaceRefreshTaskStartRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemShInterfaceRefreshTaskStartRequest(this OcipClientBase client, SystemShInterfaceRefreshTaskStartRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Dispatches the system refresh task on the local Application Server node.  At most one instance of the system refresh task may run on an Application Server node at a given point in time.  If the system refresh task is already running when this request is made, an ErrorResponse is returned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemShInterfaceRefreshTaskStartRequestAsync(this OcipClientBase client, SystemShInterfaceRefreshTaskStartRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Terminates the system refresh task in progress on the local Application Server node.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemShInterfaceRefreshTaskTerminateRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemShInterfaceRefreshTaskTerminateRequest(this OcipClientBase client, SystemShInterfaceRefreshTaskTerminateRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Terminates the system refresh task in progress on the local Application Server node.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemShInterfaceRefreshTaskTerminateRequestAsync(this OcipClientBase client, SystemShInterfaceRefreshTaskTerminateRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAddACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSIPAddACLEntryRequest14sp2(this OcipClientBase client, SystemSIPAddACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAddACLEntryRequest14sp2Async(this OcipClientBase client, SystemSIPAddACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAddContentTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPAddContentTypeRequest(this OcipClientBase client, SystemSIPAddContentTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAddContentTypeRequestAsync(this OcipClientBase client, SystemSIPAddContentTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to clear sip authentication endpoint lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationEndpointLockoutClearRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPAuthenticationEndpointLockoutClearRequest(this OcipClientBase client, SystemSIPAuthenticationEndpointLockoutClearRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to clear sip authentication endpoint lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAuthenticationEndpointLockoutClearRequestAsync(this OcipClientBase client, SystemSIPAuthenticationEndpointLockoutClearRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get sip authentication endpoint lockout data in the system.
        /// The response is either a SystemSIPAuthenticationEndpointLockoutGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationEndpointLockoutGetRequestAsync instead.")]
        public static async Task<SystemSIPAuthenticationEndpointLockoutGetResponse> SystemSIPAuthenticationEndpointLockoutGetRequest(this OcipClientBase client, SystemSIPAuthenticationEndpointLockoutGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPAuthenticationEndpointLockoutGetResponse;
        }

        /// <summary>
        /// Request to get sip authentication endpoint lockout data in the system.
        /// The response is either a SystemSIPAuthenticationEndpointLockoutGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPAuthenticationEndpointLockoutGetResponse> SystemSIPAuthenticationEndpointLockoutGetRequestAsync(this OcipClientBase client, SystemSIPAuthenticationEndpointLockoutGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPAuthenticationEndpointLockoutGetResponse;
        }
        /// <summary>
        /// Request to clear all sip authentication lockouts (both endpoint and trunk group) in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationLockoutClearAllRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPAuthenticationLockoutClearAllRequest(this OcipClientBase client, SystemSIPAuthenticationLockoutClearAllRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to clear all sip authentication lockouts (both endpoint and trunk group) in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAuthenticationLockoutClearAllRequestAsync(this OcipClientBase client, SystemSIPAuthenticationLockoutClearAllRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the system level SIP authentication password rule settings.
        /// The response is either a SystemSIPAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationPasswordRulesGetRequestAsync instead.")]
        public static async Task<SystemSIPAuthenticationPasswordRulesGetResponse> SystemSIPAuthenticationPasswordRulesGetRequest(this OcipClientBase client, SystemSIPAuthenticationPasswordRulesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPAuthenticationPasswordRulesGetResponse;
        }

        /// <summary>
        /// Request to get the system level SIP authentication password rule settings.
        /// The response is either a SystemSIPAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPAuthenticationPasswordRulesGetResponse> SystemSIPAuthenticationPasswordRulesGetRequestAsync(this OcipClientBase client, SystemSIPAuthenticationPasswordRulesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPAuthenticationPasswordRulesGetResponse;
        }
        /// <summary>
        /// Request to modify the system level SIP authentication password rule settings
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationPasswordRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPAuthenticationPasswordRulesModifyRequest(this OcipClientBase client, SystemSIPAuthenticationPasswordRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system level SIP authentication password rule settings
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAuthenticationPasswordRulesModifyRequestAsync(this OcipClientBase client, SystemSIPAuthenticationPasswordRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to clear sip authentication trunk group lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationTrunkGroupLockoutClearRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPAuthenticationTrunkGroupLockoutClearRequest(this OcipClientBase client, SystemSIPAuthenticationTrunkGroupLockoutClearRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to clear sip authentication trunk group lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAuthenticationTrunkGroupLockoutClearRequestAsync(this OcipClientBase client, SystemSIPAuthenticationTrunkGroupLockoutClearRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get sip authentication trunk group lockout data in the system.
        /// The response is either a SystemSIPAuthenticationTrunkGroupLockoutGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationTrunkGroupLockoutGetRequestAsync instead.")]
        public static async Task<SystemSIPAuthenticationTrunkGroupLockoutGetResponse> SystemSIPAuthenticationTrunkGroupLockoutGetRequest(this OcipClientBase client, SystemSIPAuthenticationTrunkGroupLockoutGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPAuthenticationTrunkGroupLockoutGetResponse;
        }

        /// <summary>
        /// Request to get sip authentication trunk group lockout data in the system.
        /// The response is either a SystemSIPAuthenticationTrunkGroupLockoutGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPAuthenticationTrunkGroupLockoutGetResponse> SystemSIPAuthenticationTrunkGroupLockoutGetRequestAsync(this OcipClientBase client, SystemSIPAuthenticationTrunkGroupLockoutGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPAuthenticationTrunkGroupLockoutGetResponse;
        }
        /// <summary>
        /// Delete an entry from the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeleteACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeleteACLEntryRequest14sp2(this OcipClientBase client, SystemSIPDeleteACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeleteACLEntryRequest14sp2Async(this OcipClientBase client, SystemSIPDeleteACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeleteContentTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDeleteContentTypeRequest(this OcipClientBase client, SystemSIPDeleteContentTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeleteContentTypeRequestAsync(this OcipClientBase client, SystemSIPDeleteContentTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to apply an extended file capture value to all the profile instances associated to a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequest(this OcipClientBase client, SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to apply an extended file capture value to all the profile instances associated to a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequestAsync(this OcipClientBase client, SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// 
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagement, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest22V3Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V3(this OcipClientBase client, SystemSIPDeviceTypeAddRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// 
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagement, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V3Async(this OcipClientBase client, SystemSIPDeviceTypeAddRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// 
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagement, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// supportCallingPartyCategoryInOutboundFromHeader, use value "true" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23(this OcipClientBase client, SystemSIPDeviceTypeAddRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// 
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagement, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// supportCallingPartyCategoryInOutboundFromHeader, use value "true" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23Async(this OcipClientBase client, SystemSIPDeviceTypeAddRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeDeleteRequest(this OcipClientBase client, SystemSIPDeviceTypeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeDeleteRequestAsync(this OcipClientBase client, SystemSIPDeviceTypeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileAddRequest21sp1Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest21sp1(this OcipClientBase client, SystemSIPDeviceTypeFileAddRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest21sp1Async(this OcipClientBase client, SystemSIPDeviceTypeFileAddRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileDeleteRequest14sp8Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileDeleteRequest14sp8(this OcipClientBase client, SystemSIPDeviceTypeFileDeleteRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileDeleteRequest14sp8Async(this OcipClientBase client, SystemSIPDeviceTypeFileDeleteRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device type basis.
        /// The response is either SystemSIPDeviceTypeFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileGetListRequest14sp8Async instead.")]
        public static async Task<SystemSIPDeviceTypeFileGetListResponse14sp8> SystemSIPDeviceTypeFileGetListRequest14sp8(this OcipClientBase client, SystemSIPDeviceTypeFileGetListRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeFileGetListResponse14sp8;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device type basis.
        /// The response is either SystemSIPDeviceTypeFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetListResponse14sp8> SystemSIPDeviceTypeFileGetListRequest14sp8Async(this OcipClientBase client, SystemSIPDeviceTypeFileGetListRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeFileGetListResponse14sp8;
        }
        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse21sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileGetRequest21sp1Async instead.")]
        public static async Task<SystemSIPDeviceTypeFileGetResponse21sp1> SystemSIPDeviceTypeFileGetRequest21sp1(this OcipClientBase client, SystemSIPDeviceTypeFileGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeFileGetResponse21sp1;
        }

        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetResponse21sp1> SystemSIPDeviceTypeFileGetRequest21sp1Async(this OcipClientBase client, SystemSIPDeviceTypeFileGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeFileGetResponse21sp1;
        }
        /// <summary>
        /// Request to modify a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileModifyRequest16sp1Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileModifyRequest16sp1(this OcipClientBase client, SystemSIPDeviceTypeFileModifyRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileModifyRequest16sp1Async(this OcipClientBase client, SystemSIPDeviceTypeFileModifyRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of sip device types in the system.
        /// If includeSystemLevel is specified, all system level device types and the reseller device types matching search criteria
        /// are returned even when searchCriteriaResellerId is specified.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All system level device
        /// types and the device types in the administrator's reseller meeting the search criteria are returned.
        /// See Also: SystemDeviceTypeGetAvailableListRequest22 in AS data mode, SystemDeviceTypeGetAvailableListRequest19 in XS data mode.
        /// The response is either SystemSIPDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetListRequestAsync instead.")]
        public static async Task<SystemSIPDeviceTypeGetListResponse> SystemSIPDeviceTypeGetListRequest(this OcipClientBase client, SystemSIPDeviceTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetListResponse;
        }

        /// <summary>
        /// Request to get the list of sip device types in the system.
        /// If includeSystemLevel is specified, all system level device types and the reseller device types matching search criteria
        /// are returned even when searchCriteriaResellerId is specified.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All system level device
        /// types and the device types in the administrator's reseller meeting the search criteria are returned.
        /// See Also: SystemDeviceTypeGetAvailableListRequest22 in AS data mode, SystemDeviceTypeGetAvailableListRequest19 in XS data mode.
        /// The response is either SystemSIPDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetListResponse> SystemSIPDeviceTypeGetListRequestAsync(this OcipClientBase client, SystemSIPDeviceTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetListResponse;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V4 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest22V4Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse22V4> SystemSIPDeviceTypeGetRequest22V4(this OcipClientBase client, SystemSIPDeviceTypeGetRequest22V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V4;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V4 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse22V4> SystemSIPDeviceTypeGetRequest22V4Async(this OcipClientBase client, SystemSIPDeviceTypeGetRequest22V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V4;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest23Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse23> SystemSIPDeviceTypeGetRequest23(this OcipClientBase client, SystemSIPDeviceTypeGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse23> SystemSIPDeviceTypeGetRequest23Async(this OcipClientBase client, SystemSIPDeviceTypeGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23;
        }
        /// <summary>
        /// Request to get the list of device language names mapped to BroadWorks language names, per-device type.
        /// The response is either SystemSIPDeviceTypeLanguageMappingGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeLanguageMappingGetListRequestAsync instead.")]
        public static async Task<SystemSIPDeviceTypeLanguageMappingGetListResponse> SystemSIPDeviceTypeLanguageMappingGetListRequest(this OcipClientBase client, SystemSIPDeviceTypeLanguageMappingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeLanguageMappingGetListResponse;
        }

        /// <summary>
        /// Request to get the list of device language names mapped to BroadWorks language names, per-device type.
        /// The response is either SystemSIPDeviceTypeLanguageMappingGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeLanguageMappingGetListResponse> SystemSIPDeviceTypeLanguageMappingGetListRequestAsync(this OcipClientBase client, SystemSIPDeviceTypeLanguageMappingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeLanguageMappingGetListResponse;
        }
        /// <summary>
        /// Request to modify the device language name that is mapped to a BroadWorks language name. The request can be used to map many languages.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeLanguageMappingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeLanguageMappingModifyRequest(this OcipClientBase client, SystemSIPDeviceTypeLanguageMappingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the device language name that is mapped to a BroadWorks language name. The request can be used to map many languages.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeLanguageMappingModifyRequestAsync(this OcipClientBase client, SystemSIPDeviceTypeLanguageMappingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// deviceTypeConfigurationOption
        /// staticLineOrdering
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// 
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22(this OcipClientBase client, SystemSIPDeviceTypeModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// deviceTypeConfigurationOption
        /// staticLineOrdering
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// 
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22Async(this OcipClientBase client, SystemSIPDeviceTypeModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// deviceTypeConfigurationOption
        /// staticLineOrdering
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// supportCallingPartyCategoryInOutboundFromHeader
        /// 
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeModifyRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22V2(this OcipClientBase client, SystemSIPDeviceTypeModifyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// deviceTypeConfigurationOption
        /// staticLineOrdering
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// supportCallingPartyCategoryInOutboundFromHeader
        /// 
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22V2Async(this OcipClientBase client, SystemSIPDeviceTypeModifyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of BroadWorks services that can be integrated to a device type and the level of integration for this device type.
        /// The response is either SystemSIPDeviceTypeServiceGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeServiceGetRequestAsync instead.")]
        public static async Task<SystemSIPDeviceTypeServiceGetResponse> SystemSIPDeviceTypeServiceGetRequest(this OcipClientBase client, SystemSIPDeviceTypeServiceGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeServiceGetResponse;
        }

        /// <summary>
        /// Request to get the list of BroadWorks services that can be integrated to a device type and the level of integration for this device type.
        /// The response is either SystemSIPDeviceTypeServiceGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeServiceGetResponse> SystemSIPDeviceTypeServiceGetRequestAsync(this OcipClientBase client, SystemSIPDeviceTypeServiceGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeServiceGetResponse;
        }
        /// <summary>
        /// Request to set the level of integration that a device type has in relation to BroadWorks services.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeServiceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeServiceModifyRequest(this OcipClientBase client, SystemSIPDeviceTypeServiceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the level of integration that a device type has in relation to BroadWorks services.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeServiceModifyRequestAsync(this OcipClientBase client, SystemSIPDeviceTypeServiceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of SIP Diversion Cause values.
        /// The response is either a SystemSIPDiversionReasonGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDiversionReasonGetRequestAsync instead.")]
        public static async Task<SystemSIPDiversionReasonGetResponse> SystemSIPDiversionReasonGetRequest(this OcipClientBase client, SystemSIPDiversionReasonGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDiversionReasonGetResponse;
        }

        /// <summary>
        /// Request to get the list of SIP Diversion Cause values.
        /// The response is either a SystemSIPDiversionReasonGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDiversionReasonGetResponse> SystemSIPDiversionReasonGetRequestAsync(this OcipClientBase client, SystemSIPDiversionReasonGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDiversionReasonGetResponse;
        }
        /// <summary>
        /// Request to modify the SIP cause value for a given diversion reason.
        /// The response is either a SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDiversionReasonModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDiversionReasonModifyRequest(this OcipClientBase client, SystemSIPDiversionReasonModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the SIP cause value for a given diversion reason.
        /// The response is either a SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDiversionReasonModifyRequestAsync(this OcipClientBase client, SystemSIPDiversionReasonModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the SIP access control list.
        /// The response is either SystemSIPGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPGetACLListRequestAsync instead.")]
        public static async Task<SystemSIPGetACLListResponse> SystemSIPGetACLListRequest(this OcipClientBase client, SystemSIPGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPGetACLListResponse;
        }

        /// <summary>
        /// Get the SIP access control list.
        /// The response is either SystemSIPGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPGetACLListResponse> SystemSIPGetACLListRequestAsync(this OcipClientBase client, SystemSIPGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPGetACLListResponse;
        }
        /// <summary>
        /// Get the content type list for the SIP interface.
        /// The response is either SystemSIPGetContentTypeListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPGetContentTypeListRequestAsync instead.")]
        public static async Task<SystemSIPGetContentTypeListResponse> SystemSIPGetContentTypeListRequest(this OcipClientBase client, SystemSIPGetContentTypeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPGetContentTypeListResponse;
        }

        /// <summary>
        /// Get the content type list for the SIP interface.
        /// The response is either SystemSIPGetContentTypeListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPGetContentTypeListResponse> SystemSIPGetContentTypeListRequestAsync(this OcipClientBase client, SystemSIPGetContentTypeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPGetContentTypeListResponse;
        }
        /// <summary>
        /// Modify an entry from the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPModifyACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSIPModifyACLEntryRequest14sp2(this OcipClientBase client, SystemSIPModifyACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPModifyACLEntryRequest14sp2Async(this OcipClientBase client, SystemSIPModifyACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify an content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPModifyContentTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPModifyContentTypeRequest(this OcipClientBase client, SystemSIPModifyContentTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPModifyContentTypeRequestAsync(this OcipClientBase client, SystemSIPModifyContentTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIAddACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSMDIAddACLEntryRequest14sp2(this OcipClientBase client, SystemSMDIAddACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIAddACLEntryRequest14sp2Async(this OcipClientBase client, SystemSMDIAddACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIDeleteACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSMDIDeleteACLEntryRequest14sp2(this OcipClientBase client, SystemSMDIDeleteACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIDeleteACLEntryRequest14sp2Async(this OcipClientBase client, SystemSMDIDeleteACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the SMDI access control list.
        /// The response is either SystemSMDIGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIGetACLListRequestAsync instead.")]
        public static async Task<SystemSMDIGetACLListResponse> SystemSMDIGetACLListRequest(this OcipClientBase client, SystemSMDIGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMDIGetACLListResponse;
        }

        /// <summary>
        /// Get the SMDI access control list.
        /// The response is either SystemSMDIGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSMDIGetACLListResponse> SystemSMDIGetACLListRequestAsync(this OcipClientBase client, SystemSMDIGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMDIGetACLListResponse;
        }
        /// <summary>
        /// Modify an entry from the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIModifyACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSMDIModifyACLEntryRequest14sp2(this OcipClientBase client, SystemSMDIModifyACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIModifyACLEntryRequest14sp2Async(this OcipClientBase client, SystemSMDIModifyACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of SMDI system parameters.
        /// The response is either SystemSMDIParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIParametersGetRequestAsync instead.")]
        public static async Task<SystemSMDIParametersGetResponse> SystemSMDIParametersGetRequest(this OcipClientBase client, SystemSMDIParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMDIParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of SMDI system parameters.
        /// The response is either SystemSMDIParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSMDIParametersGetResponse> SystemSMDIParametersGetRequestAsync(this OcipClientBase client, SystemSMDIParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMDIParametersGetResponse;
        }
        /// <summary>
        /// Request to modify SMDI system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSMDIParametersModifyRequest(this OcipClientBase client, SystemSMDIParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify SMDI system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIParametersModifyRequestAsync(this OcipClientBase client, SystemSMDIParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMPPGetRequest22Async instead.")]
        public static async Task<SystemSMPPGetResponse21> SystemSMPPGetRequest22(this OcipClientBase client, SystemSMPPGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMPPGetResponse21;
        }

        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSMPPGetResponse21> SystemSMPPGetRequest22Async(this OcipClientBase client, SystemSMPPGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMPPGetResponse21;
        }
        /// <summary>
        /// Request to modify the system level data associated with the SMPP external interface.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMPPModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSMPPModifyRequest(this OcipClientBase client, SystemSMPPModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system level data associated with the SMPP external interface.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMPPModifyRequestAsync(this OcipClientBase client, SystemSMPPModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the software version of the Application Server.
        /// The response is either SystemSoftwareVersionGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSoftwareVersionGetRequestAsync instead.")]
        public static async Task<SystemSoftwareVersionGetResponse> SystemSoftwareVersionGetRequest(this OcipClientBase client, SystemSoftwareVersionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSoftwareVersionGetResponse;
        }

        /// <summary>
        /// Requests the software version of the Application Server.
        /// The response is either SystemSoftwareVersionGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSoftwareVersionGetResponse> SystemSoftwareVersionGetRequestAsync(this OcipClientBase client, SystemSoftwareVersionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSoftwareVersionGetResponse;
        }
        /// <summary>
        /// Requests the list of state and province names.
        /// The response is either SystemStateOrProvinceGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemStateOrProvinceGetListRequestAsync instead.")]
        public static async Task<SystemStateOrProvinceGetListResponse> SystemStateOrProvinceGetListRequest(this OcipClientBase client, SystemStateOrProvinceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemStateOrProvinceGetListResponse;
        }

        /// <summary>
        /// Requests the list of state and province names.
        /// The response is either SystemStateOrProvinceGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemStateOrProvinceGetListResponse> SystemStateOrProvinceGetListRequestAsync(this OcipClientBase client, SystemStateOrProvinceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemStateOrProvinceGetListResponse;
        }
        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse18sp1
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberGetCallProcessingParametersRequest18sp1Async instead.")]
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse18sp1> SystemSubscriberGetCallProcessingParametersRequest18sp1(this OcipClientBase client, SystemSubscriberGetCallProcessingParametersRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSubscriberGetCallProcessingParametersResponse18sp1;
        }

        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse18sp1
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse18sp1> SystemSubscriberGetCallProcessingParametersRequest18sp1Async(this OcipClientBase client, SystemSubscriberGetCallProcessingParametersRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSubscriberGetCallProcessingParametersResponse18sp1;
        }
        /// <summary>
        /// Get the system login configuration for all subscribers.
        /// The response is either a SystemSubscriberGetLoginParametersResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberGetLoginParametersRequestAsync instead.")]
        public static async Task<SystemSubscriberGetLoginParametersResponse> SystemSubscriberGetLoginParametersRequest(this OcipClientBase client, SystemSubscriberGetLoginParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSubscriberGetLoginParametersResponse;
        }

        /// <summary>
        /// Get the system login configuration for all subscribers.
        /// The response is either a SystemSubscriberGetLoginParametersResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSubscriberGetLoginParametersResponse> SystemSubscriberGetLoginParametersRequestAsync(this OcipClientBase client, SystemSubscriberGetLoginParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSubscriberGetLoginParametersResponse;
        }
        /// <summary>
        /// Get the system provisioning configuration for all subscribers
        /// The response is either a SystemSubscriberGetProvisioningParametersResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberGetProvisioningParametersRequestAsync instead.")]
        public static async Task<SystemSubscriberGetProvisioningParametersResponse> SystemSubscriberGetProvisioningParametersRequest(this OcipClientBase client, SystemSubscriberGetProvisioningParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSubscriberGetProvisioningParametersResponse;
        }

        /// <summary>
        /// Get the system provisioning configuration for all subscribers
        /// The response is either a SystemSubscriberGetProvisioningParametersResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSubscriberGetProvisioningParametersResponse> SystemSubscriberGetProvisioningParametersRequestAsync(this OcipClientBase client, SystemSubscriberGetProvisioningParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSubscriberGetProvisioningParametersResponse;
        }
        /// <summary>
        /// Modify the system call processing configuration for all subscribers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in the AS data mode:
        /// minNoAnswerNumberOfRings
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// isExtendedCallingLineIdActive
        /// isRingTimeOutActive
        /// ringTimeoutSeconds
        /// allowEmergencyRemoteOfficeOriginations
        /// incomingCallToUserAliasMode
        /// bypassTerminationLoopDetection
        /// honorCLIDBlockingForEmergencyCalls
        /// useUnicodeIdentityName
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberModifyCallProcessingParametersRequest14sp7Async instead.")]
        public static async Task<SuccessResponse> SystemSubscriberModifyCallProcessingParametersRequest14sp7(this OcipClientBase client, SystemSubscriberModifyCallProcessingParametersRequest14sp7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system call processing configuration for all subscribers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in the AS data mode:
        /// minNoAnswerNumberOfRings
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// isExtendedCallingLineIdActive
        /// isRingTimeOutActive
        /// ringTimeoutSeconds
        /// allowEmergencyRemoteOfficeOriginations
        /// incomingCallToUserAliasMode
        /// bypassTerminationLoopDetection
        /// honorCLIDBlockingForEmergencyCalls
        /// useUnicodeIdentityName
        /// </summary>
        public static async Task<SuccessResponse> SystemSubscriberModifyCallProcessingParametersRequest14sp7Async(this OcipClientBase client, SystemSubscriberModifyCallProcessingParametersRequest14sp7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system login configuration for all subscribers
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberModifyLoginParametersRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSubscriberModifyLoginParametersRequest(this OcipClientBase client, SystemSubscriberModifyLoginParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system login configuration for all subscribers
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSubscriberModifyLoginParametersRequestAsync(this OcipClientBase client, SystemSubscriberModifyLoginParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system provisioning configuration for all subscribers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberModifyProvisioningParametersRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSubscriberModifyProvisioningParametersRequest(this OcipClientBase client, SystemSubscriberModifyProvisioningParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system provisioning configuration for all subscribers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSubscriberModifyProvisioningParametersRequestAsync(this OcipClientBase client, SystemSubscriberModifyProvisioningParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the data associated with Call Processing Policy for system service instances.
        /// The response is either SystemSystemServiceCallProcessingPoliciesGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceCallProcessingPoliciesGetRequestAsync instead.")]
        public static async Task<SystemSystemServiceCallProcessingPoliciesGetResponse> SystemSystemServiceCallProcessingPoliciesGetRequest(this OcipClientBase client, SystemSystemServiceCallProcessingPoliciesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemServiceCallProcessingPoliciesGetResponse;
        }

        /// <summary>
        /// Request the data associated with Call Processing Policy for system service instances.
        /// The response is either SystemSystemServiceCallProcessingPoliciesGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemServiceCallProcessingPoliciesGetResponse> SystemSystemServiceCallProcessingPoliciesGetRequestAsync(this OcipClientBase client, SystemSystemServiceCallProcessingPoliciesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemServiceCallProcessingPoliciesGetResponse;
        }
        /// <summary>
        /// Request the data associated with Call Processing Policy for system service instances.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceCallProcessingPoliciesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSystemServiceCallProcessingPoliciesModifyRequest(this OcipClientBase client, SystemSystemServiceCallProcessingPoliciesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request the data associated with Call Processing Policy for system service instances.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemServiceCallProcessingPoliciesModifyRequestAsync(this OcipClientBase client, SystemSystemServiceCallProcessingPoliciesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Adds system service Dns. It is possible to add either: a single DN,
        /// a list of DNs a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceDnAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSystemServiceDnAddListRequest(this OcipClientBase client, SystemSystemServiceDnAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds system service Dns. It is possible to add either: a single DN,
        /// a list of DNs a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemServiceDnAddListRequestAsync(this OcipClientBase client, SystemSystemServiceDnAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes system service DNs. It is possible to delete either:
        /// a single DN,
        /// a list of DNs, a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceDnDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSystemServiceDnDeleteListRequest(this OcipClientBase client, SystemSystemServiceDnDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes system service DNs. It is possible to delete either:
        /// a single DN,
        /// a list of DNs, a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemServiceDnDeleteListRequestAsync(this OcipClientBase client, SystemSystemServiceDnDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of system service DNs not yet in use.
        /// The response is either SystemSystemServiceDnGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceDnGetAvailableListRequestAsync instead.")]
        public static async Task<SystemSystemServiceDnGetAvailableListResponse> SystemSystemServiceDnGetAvailableListRequest(this OcipClientBase client, SystemSystemServiceDnGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemServiceDnGetAvailableListResponse;
        }

        /// <summary>
        /// Request a list of system service DNs not yet in use.
        /// The response is either SystemSystemServiceDnGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemServiceDnGetAvailableListResponse> SystemSystemServiceDnGetAvailableListRequestAsync(this OcipClientBase client, SystemSystemServiceDnGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemServiceDnGetAvailableListResponse;
        }
        /// <summary>
        /// Request a summary table of all System Service DNs.
        /// The response is either SystemSystemServiceDnGetSummaryListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceDnGetSummaryListRequestAsync instead.")]
        public static async Task<SystemSystemServiceDnGetSummaryListResponse> SystemSystemServiceDnGetSummaryListRequest(this OcipClientBase client, SystemSystemServiceDnGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemServiceDnGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all System Service DNs.
        /// The response is either SystemSystemServiceDnGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemServiceDnGetSummaryListResponse> SystemSystemServiceDnGetSummaryListRequestAsync(this OcipClientBase client, SystemSystemServiceDnGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemServiceDnGetSummaryListResponse;
        }
        /// <summary>
        /// Request a list of System Service DN utilization.
        /// The response is either SystemSystemServiceDnGetUsageListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceDnGetUsageListRequestAsync instead.")]
        public static async Task<SystemSystemServiceDnGetUsageListResponse> SystemSystemServiceDnGetUsageListRequest(this OcipClientBase client, SystemSystemServiceDnGetUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemServiceDnGetUsageListResponse;
        }

        /// <summary>
        /// Request a list of System Service DN utilization.
        /// The response is either SystemSystemServiceDnGetUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemServiceDnGetUsageListResponse> SystemSystemServiceDnGetUsageListRequestAsync(this OcipClientBase client, SystemSystemServiceDnGetUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemServiceDnGetUsageListResponse;
        }
        /// <summary>
        /// Request to add a system voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in IMS mode:
        /// publicUserIdentity, ignored in standalone mode if provided.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemVoicePortalAddRequest21sp1Async instead.")]
        public static async Task<SuccessResponse> SystemSystemVoicePortalAddRequest21sp1(this OcipClientBase client, SystemSystemVoicePortalAddRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in IMS mode:
        /// publicUserIdentity, ignored in standalone mode if provided.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemVoicePortalAddRequest21sp1Async(this OcipClientBase client, SystemSystemVoicePortalAddRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a system voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemVoicePortalDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSystemVoicePortalDeleteRequest(this OcipClientBase client, SystemSystemVoicePortalDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a system voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemVoicePortalDeleteRequestAsync(this OcipClientBase client, SystemSystemVoicePortalDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of the system voice portals.
        /// The response is either SystemSystemVoicePortalGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemVoicePortalGetListRequestAsync instead.")]
        public static async Task<SystemSystemVoicePortalGetListResponse> SystemSystemVoicePortalGetListRequest(this OcipClientBase client, SystemSystemVoicePortalGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemVoicePortalGetListResponse;
        }

        /// <summary>
        /// Request to get the list of the system voice portals.
        /// The response is either SystemSystemVoicePortalGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemVoicePortalGetListResponse> SystemSystemVoicePortalGetListRequestAsync(this OcipClientBase client, SystemSystemVoicePortalGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemVoicePortalGetListResponse;
        }
        /// <summary>
        /// Request to get a system voice portal instance.
        /// The response is either SystemSystemVoicePortalGetResponse21sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemVoicePortalGetRequest21sp1Async instead.")]
        public static async Task<SystemSystemVoicePortalGetResponse21sp1> SystemSystemVoicePortalGetRequest21sp1(this OcipClientBase client, SystemSystemVoicePortalGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemVoicePortalGetResponse21sp1;
        }

        /// <summary>
        /// Request to get a system voice portal instance.
        /// The response is either SystemSystemVoicePortalGetResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemVoicePortalGetResponse21sp1> SystemSystemVoicePortalGetRequest21sp1Async(this OcipClientBase client, SystemSystemVoicePortalGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemVoicePortalGetResponse21sp1;
        }
        /// <summary>
        /// Request to update a System  Voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemVoicePortalModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSystemVoicePortalModifyRequest(this OcipClientBase client, SystemSystemVoicePortalModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to update a System  Voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemVoicePortalModifyRequestAsync(this OcipClientBase client, SystemSystemVoicePortalModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the configured time zone of the server processing the request and the list of time zone names.
        /// The response is either SystemTimeZoneGetListResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTimeZoneGetListRequest20Async instead.")]
        public static async Task<SystemTimeZoneGetListResponse20> SystemTimeZoneGetListRequest20(this OcipClientBase client, SystemTimeZoneGetListRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTimeZoneGetListResponse20;
        }

        /// <summary>
        /// Requests the configured time zone of the server processing the request and the list of time zone names.
        /// The response is either SystemTimeZoneGetListResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<SystemTimeZoneGetListResponse20> SystemTimeZoneGetListRequest20Async(this OcipClientBase client, SystemTimeZoneGetListRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTimeZoneGetListResponse20;
        }
        /// <summary>
        /// Add an Access SIP Status Code Mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingAccessSIPStatusAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusAddRequest(this OcipClientBase client, SystemTreatmentMappingAccessSIPStatusAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an Access SIP Status Code Mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusAddRequestAsync(this OcipClientBase client, SystemTreatmentMappingAccessSIPStatusAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an Access SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingAccessSIPStatusDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusDeleteRequest(this OcipClientBase client, SystemTreatmentMappingAccessSIPStatusDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an Access SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusDeleteRequestAsync(this OcipClientBase client, SystemTreatmentMappingAccessSIPStatusDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Access Side SIP Status Code Mappings in the system.
        /// The response is either an SystemTreatmentMappingAccessSIPStatusGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingAccessSIPStatusGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingAccessSIPStatusGetListResponse> SystemTreatmentMappingAccessSIPStatusGetListRequest(this OcipClientBase client, SystemTreatmentMappingAccessSIPStatusGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingAccessSIPStatusGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the existing Access Side SIP Status Code Mappings in the system.
        /// The response is either an SystemTreatmentMappingAccessSIPStatusGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingAccessSIPStatusGetListResponse> SystemTreatmentMappingAccessSIPStatusGetListRequestAsync(this OcipClientBase client, SystemTreatmentMappingAccessSIPStatusGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingAccessSIPStatusGetListResponse;
        }
        /// <summary>
        /// Modify the fields for an Access SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingAccessSIPStatusModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusModifyRequest(this OcipClientBase client, SystemTreatmentMappingAccessSIPStatusModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for an Access SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusModifyRequestAsync(this OcipClientBase client, SystemTreatmentMappingAccessSIPStatusModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest23(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceAddRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest23Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceAddRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest23(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceDeleteRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest23Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceDeleteRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse23
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceGetListRequest23Async instead.")]
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse23> SystemTreatmentMappingCallBlockingServiceGetListRequest23(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceGetListRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse23;
        }

        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse23
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse23> SystemTreatmentMappingCallBlockingServiceGetListRequest23Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceGetListRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse23;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest23(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceModifyRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest23Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceModifyRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingInternalReleaseCauseAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseAddRequest(this OcipClientBase client, SystemTreatmentMappingInternalReleaseCauseAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseAddRequestAsync(this OcipClientBase client, SystemTreatmentMappingInternalReleaseCauseAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingInternalReleaseCauseDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseDeleteRequest(this OcipClientBase client, SystemTreatmentMappingInternalReleaseCauseDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseDeleteRequestAsync(this OcipClientBase client, SystemTreatmentMappingInternalReleaseCauseDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the Internal Release Cause mappings in the system.
        /// The response is either a SystemTreatmentMappingInternalReleaseCauseGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingInternalReleaseCauseGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingInternalReleaseCauseGetListResponse> SystemTreatmentMappingInternalReleaseCauseGetListRequest(this OcipClientBase client, SystemTreatmentMappingInternalReleaseCauseGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingInternalReleaseCauseGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the Internal Release Cause mappings in the system.
        /// The response is either a SystemTreatmentMappingInternalReleaseCauseGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingInternalReleaseCauseGetListResponse> SystemTreatmentMappingInternalReleaseCauseGetListRequestAsync(this OcipClientBase client, SystemTreatmentMappingInternalReleaseCauseGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingInternalReleaseCauseGetListResponse;
        }
        /// <summary>
        /// Modify the fields for an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingInternalReleaseCauseModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseModifyRequest(this OcipClientBase client, SystemTreatmentMappingInternalReleaseCauseModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseModifyRequestAsync(this OcipClientBase client, SystemTreatmentMappingInternalReleaseCauseModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Network Server Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkServerTreatmentAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentAddRequest(this OcipClientBase client, SystemTreatmentMappingNetworkServerTreatmentAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Network Server Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentAddRequestAsync(this OcipClientBase client, SystemTreatmentMappingNetworkServerTreatmentAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a NS Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkServerTreatmentDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentDeleteRequest(this OcipClientBase client, SystemTreatmentMappingNetworkServerTreatmentDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a NS Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentDeleteRequestAsync(this OcipClientBase client, SystemTreatmentMappingNetworkServerTreatmentDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing NS Treatment Mappings in the system.
        /// The response is either a   SystemTreatmentMappingNetworkServerTreatmentGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkServerTreatmentGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingNetworkServerTreatmentGetListResponse> SystemTreatmentMappingNetworkServerTreatmentGetListRequest(this OcipClientBase client, SystemTreatmentMappingNetworkServerTreatmentGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingNetworkServerTreatmentGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the existing NS Treatment Mappings in the system.
        /// The response is either a   SystemTreatmentMappingNetworkServerTreatmentGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingNetworkServerTreatmentGetListResponse> SystemTreatmentMappingNetworkServerTreatmentGetListRequestAsync(this OcipClientBase client, SystemTreatmentMappingNetworkServerTreatmentGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingNetworkServerTreatmentGetListResponse;
        }
        /// <summary>
        /// Modify the fields for a Network Server Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkServerTreatmentModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentModifyRequest(this OcipClientBase client, SystemTreatmentMappingNetworkServerTreatmentModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Network Server Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentModifyRequestAsync(this OcipClientBase client, SystemTreatmentMappingNetworkServerTreatmentModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkSIPStatusAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusAddRequest(this OcipClientBase client, SystemTreatmentMappingNetworkSIPStatusAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusAddRequestAsync(this OcipClientBase client, SystemTreatmentMappingNetworkSIPStatusAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkSIPStatusDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusDeleteRequest(this OcipClientBase client, SystemTreatmentMappingNetworkSIPStatusDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusDeleteRequestAsync(this OcipClientBase client, SystemTreatmentMappingNetworkSIPStatusDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Network SIP Status Code Mappings in the system.
        /// The response is either an SystemTreatmentMappingNetworkSIPStatusGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkSIPStatusGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingNetworkSIPStatusGetListResponse> SystemTreatmentMappingNetworkSIPStatusGetListRequest(this OcipClientBase client, SystemTreatmentMappingNetworkSIPStatusGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingNetworkSIPStatusGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the existing Network SIP Status Code Mappings in the system.
        /// The response is either an SystemTreatmentMappingNetworkSIPStatusGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingNetworkSIPStatusGetListResponse> SystemTreatmentMappingNetworkSIPStatusGetListRequestAsync(this OcipClientBase client, SystemTreatmentMappingNetworkSIPStatusGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingNetworkSIPStatusGetListResponse;
        }
        /// <summary>
        /// Modify the fields for a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkSIPStatusModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusModifyRequest(this OcipClientBase client, SystemTreatmentMappingNetworkSIPStatusModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusModifyRequestAsync(this OcipClientBase client, SystemTreatmentMappingNetworkSIPStatusModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Q850 Cause Value mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingQ850CauseAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseAddRequest(this OcipClientBase client, SystemTreatmentMappingQ850CauseAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Q850 Cause Value mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseAddRequestAsync(this OcipClientBase client, SystemTreatmentMappingQ850CauseAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Q850 Cause Value mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingQ850CauseDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseDeleteRequest(this OcipClientBase client, SystemTreatmentMappingQ850CauseDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Q850 Cause Value mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseDeleteRequestAsync(this OcipClientBase client, SystemTreatmentMappingQ850CauseDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Q850 Cause Value Mappings in the system.
        /// The response is either a SystemTreatmentMappingQ850CauseGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingQ850CauseGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingQ850CauseGetListResponse> SystemTreatmentMappingQ850CauseGetListRequest(this OcipClientBase client, SystemTreatmentMappingQ850CauseGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingQ850CauseGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the existing Q850 Cause Value Mappings in the system.
        /// The response is either a SystemTreatmentMappingQ850CauseGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingQ850CauseGetListResponse> SystemTreatmentMappingQ850CauseGetListRequestAsync(this OcipClientBase client, SystemTreatmentMappingQ850CauseGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingQ850CauseGetListResponse;
        }
        /// <summary>
        /// Modify the fields for a Q850CauseValue mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingQ850CauseModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseModifyRequest(this OcipClientBase client, SystemTreatmentMappingQ850CauseModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Q850CauseValue mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseModifyRequestAsync(this OcipClientBase client, SystemTreatmentMappingQ850CauseModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Represents a Verify Translation and Routing request which can be either a request containing
        /// parameters or a request containing a SIP message. The response is a SystemVerifyTranslationAndRoutingResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVerifyTranslationAndRoutingRequestAsync instead.")]
        public static async Task<SystemVerifyTranslationAndRoutingResponse> SystemVerifyTranslationAndRoutingRequest(this OcipClientBase client, SystemVerifyTranslationAndRoutingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVerifyTranslationAndRoutingResponse;
        }

        /// <summary>
        /// Represents a Verify Translation and Routing request which can be either a request containing
        /// parameters or a request containing a SIP message. The response is a SystemVerifyTranslationAndRoutingResponse.
        /// </summary>
        public static async Task<SystemVerifyTranslationAndRoutingResponse> SystemVerifyTranslationAndRoutingRequestAsync(this OcipClientBase client, SystemVerifyTranslationAndRoutingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVerifyTranslationAndRoutingResponse;
        }
        /// <summary>
        /// Request to add a video server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVideoServerAddRequest(this OcipClientBase client, SystemVideoServerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a video server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVideoServerAddRequestAsync(this OcipClientBase client, SystemVideoServerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a video server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVideoServerDeleteRequest(this OcipClientBase client, SystemVideoServerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a video server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVideoServerDeleteRequestAsync(this OcipClientBase client, SystemVideoServerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of video servers defined in the system.
        /// The response is either a SystemVideoServerGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerGetListRequestAsync instead.")]
        public static async Task<SystemVideoServerGetListResponse> SystemVideoServerGetListRequest(this OcipClientBase client, SystemVideoServerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVideoServerGetListResponse;
        }

        /// <summary>
        /// Request to get a list of video servers defined in the system.
        /// The response is either a SystemVideoServerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemVideoServerGetListResponse> SystemVideoServerGetListRequestAsync(this OcipClientBase client, SystemVideoServerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVideoServerGetListResponse;
        }
        /// <summary>
        /// Request to modify a video server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVideoServerModifyRequest(this OcipClientBase client, SystemVideoServerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a video server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVideoServerModifyRequestAsync(this OcipClientBase client, SystemVideoServerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of video server system parameters.
        /// The response is either SystemVideoServerParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerParametersGetRequestAsync instead.")]
        public static async Task<SystemVideoServerParametersGetResponse> SystemVideoServerParametersGetRequest(this OcipClientBase client, SystemVideoServerParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVideoServerParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of video server system parameters.
        /// The response is either SystemVideoServerParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemVideoServerParametersGetResponse> SystemVideoServerParametersGetRequestAsync(this OcipClientBase client, SystemVideoServerParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVideoServerParametersGetResponse;
        }
        /// <summary>
        /// Request to modify video server system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVideoServerParametersModifyRequest(this OcipClientBase client, SystemVideoServerParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify video server system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVideoServerParametersModifyRequestAsync(this OcipClientBase client, SystemVideoServerParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Zone and optional Net Addresses and Physical Locations.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneAddRequest(this OcipClientBase client, SystemZoneAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Zone and optional Net Addresses and Physical Locations.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneAddRequestAsync(this OcipClientBase client, SystemZoneAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Returns a zone calling physical location for a given zone.
        /// The response is SystemZoneCallingZonePhysicalLocationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneCallingZonePhysicalLocationGetRequestAsync instead.")]
        public static async Task<SystemZoneCallingZonePhysicalLocationGetResponse> SystemZoneCallingZonePhysicalLocationGetRequest(this OcipClientBase client, SystemZoneCallingZonePhysicalLocationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemZoneCallingZonePhysicalLocationGetResponse;
        }

        /// <summary>
        /// Returns a zone calling physical location for a given zone.
        /// The response is SystemZoneCallingZonePhysicalLocationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemZoneCallingZonePhysicalLocationGetResponse> SystemZoneCallingZonePhysicalLocationGetRequestAsync(this OcipClientBase client, SystemZoneCallingZonePhysicalLocationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemZoneCallingZonePhysicalLocationGetResponse;
        }
        /// <summary>
        /// Modifies a zone calling physical location for a given zone.
        /// The response is a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneCallingZonePhysicalLocationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneCallingZonePhysicalLocationModifyRequest(this OcipClientBase client, SystemZoneCallingZonePhysicalLocationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies a zone calling physical location for a given zone.
        /// The response is a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneCallingZonePhysicalLocationModifyRequestAsync(this OcipClientBase client, SystemZoneCallingZonePhysicalLocationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneDeleteRequest(this OcipClientBase client, SystemZoneDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneDeleteRequestAsync(this OcipClientBase client, SystemZoneDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Zones.
        /// The response is either a SystemZoneGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneGetListRequestAsync instead.")]
        public static async Task<SystemZoneGetListResponse> SystemZoneGetListRequest(this OcipClientBase client, SystemZoneGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemZoneGetListResponse;
        }

        /// <summary>
        /// Get the list of all Zones.
        /// The response is either a SystemZoneGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemZoneGetListResponse> SystemZoneGetListRequestAsync(this OcipClientBase client, SystemZoneGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemZoneGetListResponse;
        }
        /// <summary>
        /// Adds a list of physical locations to a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneLocationBasedPhysicalLocationAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneLocationBasedPhysicalLocationAddListRequest(this OcipClientBase client, SystemZoneLocationBasedPhysicalLocationAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds a list of physical locations to a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneLocationBasedPhysicalLocationAddListRequestAsync(this OcipClientBase client, SystemZoneLocationBasedPhysicalLocationAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes a list of physical addresses from a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneLocationBasedPhysicalLocationDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneLocationBasedPhysicalLocationDeleteListRequest(this OcipClientBase client, SystemZoneLocationBasedPhysicalLocationDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a list of physical addresses from a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneLocationBasedPhysicalLocationDeleteListRequestAsync(this OcipClientBase client, SystemZoneLocationBasedPhysicalLocationDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets a list of physical locations assigned to a zone.
        /// The response is SystemZoneLocationBasedPhysicalLocationGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneLocationBasedPhysicalLocationGetListRequestAsync instead.")]
        public static async Task<SystemZoneLocationBasedPhysicalLocationGetListResponse> SystemZoneLocationBasedPhysicalLocationGetListRequest(this OcipClientBase client, SystemZoneLocationBasedPhysicalLocationGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemZoneLocationBasedPhysicalLocationGetListResponse;
        }

        /// <summary>
        /// Gets a list of physical locations assigned to a zone.
        /// The response is SystemZoneLocationBasedPhysicalLocationGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemZoneLocationBasedPhysicalLocationGetListResponse> SystemZoneLocationBasedPhysicalLocationGetListRequestAsync(this OcipClientBase client, SystemZoneLocationBasedPhysicalLocationGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemZoneLocationBasedPhysicalLocationGetListResponse;
        }
        /// <summary>
        /// Adds a list of IP addresses to a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneNetAddressAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneNetAddressAddListRequest(this OcipClientBase client, SystemZoneNetAddressAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds a list of IP addresses to a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneNetAddressAddListRequestAsync(this OcipClientBase client, SystemZoneNetAddressAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes a list of IP addresses from a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneNetAddressDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneNetAddressDeleteListRequest(this OcipClientBase client, SystemZoneNetAddressDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a list of IP addresses from a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneNetAddressDeleteListRequestAsync(this OcipClientBase client, SystemZoneNetAddressDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets a list of IP Addresses and/or Ranges assigned to a zone.
        /// The response is SystemZoneNetAddressGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneNetAddressGetListRequestAsync instead.")]
        public static async Task<SystemZoneNetAddressGetListResponse> SystemZoneNetAddressGetListRequest(this OcipClientBase client, SystemZoneNetAddressGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemZoneNetAddressGetListResponse;
        }

        /// <summary>
        /// Gets a list of IP Addresses and/or Ranges assigned to a zone.
        /// The response is SystemZoneNetAddressGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemZoneNetAddressGetListResponse> SystemZoneNetAddressGetListRequestAsync(this OcipClientBase client, SystemZoneNetAddressGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemZoneNetAddressGetListResponse;
        }

    }
}
