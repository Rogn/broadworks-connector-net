using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceMWIDeliveryToMobileEndpointExtensions
    {

        /// <summary>
        /// Create a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMWIDeliveryToMobileEndpointCustomTemplateAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateAddRequest(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointCustomTemplateAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Create a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateAddRequestAsync(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointCustomTemplateAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMWIDeliveryToMobileEndpointCustomTemplateDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateDeleteRequest(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointCustomTemplateDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateDeleteRequestAsync(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointCustomTemplateDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a GroupMWIDeliveryToMobileEndpointCustomTemplateGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMWIDeliveryToMobileEndpointCustomTemplateGetRequestAsync instead.")]
        public static async Task<GroupMWIDeliveryToMobileEndpointCustomTemplateGetResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateGetRequest(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointCustomTemplateGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMWIDeliveryToMobileEndpointCustomTemplateGetResponse;
        }

        /// <summary>
        /// Request a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a GroupMWIDeliveryToMobileEndpointCustomTemplateGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupMWIDeliveryToMobileEndpointCustomTemplateGetResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateGetRequestAsync(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointCustomTemplateGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMWIDeliveryToMobileEndpointCustomTemplateGetResponse;
        }
        /// <summary>
        /// Modify a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMWIDeliveryToMobileEndpointCustomTemplateModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateModifyRequest(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointCustomTemplateModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateModifyRequestAsync(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointCustomTemplateModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests group MWI custom notifications settings.
        /// The response is either a GroupMWIDeliveryToMobileEndpointGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMWIDeliveryToMobileEndpointGetRequestAsync instead.")]
        public static async Task<GroupMWIDeliveryToMobileEndpointGetResponse> GroupMWIDeliveryToMobileEndpointGetRequest(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMWIDeliveryToMobileEndpointGetResponse;
        }

        /// <summary>
        /// Requests group MWI custom notifications settings.
        /// The response is either a GroupMWIDeliveryToMobileEndpointGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupMWIDeliveryToMobileEndpointGetResponse> GroupMWIDeliveryToMobileEndpointGetRequestAsync(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMWIDeliveryToMobileEndpointGetResponse;
        }
        /// <summary>
        /// Modify the group level MWI custom notifications settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// If the request is executed by a group administrator and modifies the useSettingLevel, the request is rejected.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMWIDeliveryToMobileEndpointModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointModifyRequest(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level MWI custom notifications settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// If the request is executed by a group administrator and modifies the useSettingLevel, the request is rejected.
        /// </summary>
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointModifyRequestAsync(this OcipClientBase client, GroupMWIDeliveryToMobileEndpointModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Create a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateAddRequest(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Create a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateAddRequestAsync(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateDeleteRequest(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateDeleteRequestAsync(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequestAsync instead.")]
        public static async Task<ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequest(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse;
        }

        /// <summary>
        /// Request a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequestAsync(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse;
        }
        /// <summary>
        /// Modify a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateModifyRequest(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateModifyRequestAsync(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the service provider level data associated with MWI Delivery to Mobile Endpoint service.
        /// The response is either a ServiceProviderMWIDeliveryToMobileEndpointGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderMWIDeliveryToMobileEndpointGetRequestAsync instead.")]
        public static async Task<ServiceProviderMWIDeliveryToMobileEndpointGetResponse> ServiceProviderMWIDeliveryToMobileEndpointGetRequest(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderMWIDeliveryToMobileEndpointGetResponse;
        }

        /// <summary>
        /// Request the service provider level data associated with MWI Delivery to Mobile Endpoint service.
        /// The response is either a ServiceProviderMWIDeliveryToMobileEndpointGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderMWIDeliveryToMobileEndpointGetResponse> ServiceProviderMWIDeliveryToMobileEndpointGetRequestAsync(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderMWIDeliveryToMobileEndpointGetResponse;
        }
        /// <summary>
        /// Modify the service provider level MWI custom notifications settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderMWIDeliveryToMobileEndpointModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointModifyRequest(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider level MWI custom notifications settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointModifyRequestAsync(this OcipClientBase client, ServiceProviderMWIDeliveryToMobileEndpointModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with MWI Delivery to Mobile Endpoint service.
        /// The response is either a UserMWIDeliveryToMobileEndpointGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMWIDeliveryToMobileEndpointGetRequestAsync instead.")]
        public static async Task<UserMWIDeliveryToMobileEndpointGetResponse> UserMWIDeliveryToMobileEndpointGetRequest(this OcipClientBase client, UserMWIDeliveryToMobileEndpointGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMWIDeliveryToMobileEndpointGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with MWI Delivery to Mobile Endpoint service.
        /// The response is either a UserMWIDeliveryToMobileEndpointGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserMWIDeliveryToMobileEndpointGetResponse> UserMWIDeliveryToMobileEndpointGetRequestAsync(this OcipClientBase client, UserMWIDeliveryToMobileEndpointGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMWIDeliveryToMobileEndpointGetResponse;
        }
        /// <summary>
        /// Request to modify the user level data associated with MWI Delivery to Mobile Endpoint service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMWIDeliveryToMobileEndpointModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserMWIDeliveryToMobileEndpointModifyRequest(this OcipClientBase client, UserMWIDeliveryToMobileEndpointModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the user level data associated with MWI Delivery to Mobile Endpoint service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMWIDeliveryToMobileEndpointModifyRequestAsync(this OcipClientBase client, UserMWIDeliveryToMobileEndpointModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
