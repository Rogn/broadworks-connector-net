using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceBroadWorksAnywhereExtensions
    {

        /// <summary>
        /// Add a BroadWorks Anywhere instance to a group.
        /// The domain is required in the serviceUserId.
        /// The following elements are only used in AS data mode:
        /// networkClassOfService
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksAnywhereAddInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksAnywhereAddInstanceRequest(this OcipClientBase client, GroupBroadWorksAnywhereAddInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a BroadWorks Anywhere instance to a group.
        /// The domain is required in the serviceUserId.
        /// The following elements are only used in AS data mode:
        /// networkClassOfService
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksAnywhereAddInstanceRequestAsync(this OcipClientBase client, GroupBroadWorksAnywhereAddInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a BroadWorks Anywhere instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksAnywhereDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksAnywhereDeleteInstanceRequest(this OcipClientBase client, GroupBroadWorksAnywhereDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a BroadWorks Anywhere instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksAnywhereDeleteInstanceRequestAsync(this OcipClientBase client, GroupBroadWorksAnywhereDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of BroadWorks Anywhere instances within a group.
        /// The response is either GroupBroadWorksAnywhereGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksAnywhereGetInstanceListRequestAsync instead.")]
        public static async Task<GroupBroadWorksAnywhereGetInstanceListResponse> GroupBroadWorksAnywhereGetInstanceListRequest(this OcipClientBase client, GroupBroadWorksAnywhereGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupBroadWorksAnywhereGetInstanceListResponse;
        }

        /// <summary>
        /// Get a list of BroadWorks Anywhere instances within a group.
        /// The response is either GroupBroadWorksAnywhereGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupBroadWorksAnywhereGetInstanceListResponse> GroupBroadWorksAnywhereGetInstanceListRequestAsync(this OcipClientBase client, GroupBroadWorksAnywhereGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupBroadWorksAnywhereGetInstanceListResponse;
        }
        /// <summary>
        /// Request to get all the information of a BroadWorks Anywhere instance.
        /// The response is either GroupBroadWorksAnywhereGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksAnywhereGetInstanceRequest19sp1Async instead.")]
        public static async Task<GroupBroadWorksAnywhereGetInstanceResponse19sp1> GroupBroadWorksAnywhereGetInstanceRequest19sp1(this OcipClientBase client, GroupBroadWorksAnywhereGetInstanceRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupBroadWorksAnywhereGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a BroadWorks Anywhere instance.
        /// The response is either GroupBroadWorksAnywhereGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupBroadWorksAnywhereGetInstanceResponse19sp1> GroupBroadWorksAnywhereGetInstanceRequest19sp1Async(this OcipClientBase client, GroupBroadWorksAnywhereGetInstanceRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupBroadWorksAnywhereGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Request to set the active status of BroadWorks Anywhere instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksAnywhereModifyActiveInstanceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksAnywhereModifyActiveInstanceListRequest(this OcipClientBase client, GroupBroadWorksAnywhereModifyActiveInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of BroadWorks Anywhere instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksAnywhereModifyActiveInstanceListRequestAsync(this OcipClientBase client, GroupBroadWorksAnywhereModifyActiveInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a BroadWorks Anywhere instance.
        /// The following elements are only used in AS data mode:
        /// networkClassOfService
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksAnywhereModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksAnywhereModifyInstanceRequest(this OcipClientBase client, GroupBroadWorksAnywhereModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a BroadWorks Anywhere instance.
        /// The following elements are only used in AS data mode:
        /// networkClassOfService
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksAnywhereModifyInstanceRequestAsync(this OcipClientBase client, GroupBroadWorksAnywhereModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the Broadworks Anywhere system parameters.
        /// The response is either a SystemBroadWorksAnywhereGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadWorksAnywhereGetRequestAsync instead.")]
        public static async Task<SystemBroadWorksAnywhereGetResponse> SystemBroadWorksAnywhereGetRequest(this OcipClientBase client, SystemBroadWorksAnywhereGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBroadWorksAnywhereGetResponse;
        }

        /// <summary>
        /// Get the Broadworks Anywhere system parameters.
        /// The response is either a SystemBroadWorksAnywhereGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksAnywhereGetResponse> SystemBroadWorksAnywhereGetRequestAsync(this OcipClientBase client, SystemBroadWorksAnywhereGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBroadWorksAnywhereGetResponse;
        }
        /// <summary>
        /// Modify the BroadWorks Anywhere system parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadWorksAnywhereModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBroadWorksAnywhereModifyRequest(this OcipClientBase client, SystemBroadWorksAnywhereModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the BroadWorks Anywhere system parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksAnywhereModifyRequestAsync(this OcipClientBase client, SystemBroadWorksAnywhereModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a broadworks Anywhere phone number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereAddPhoneNumberRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksAnywhereAddPhoneNumberRequest(this OcipClientBase client, UserBroadWorksAnywhereAddPhoneNumberRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a broadworks Anywhere phone number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksAnywhereAddPhoneNumberRequestAsync(this OcipClientBase client, UserBroadWorksAnywhereAddPhoneNumberRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a criteria to the user's BroadWorks Anywhere phone number.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereAddSelectiveCriteriaRequest16Async instead.")]
        public static async Task<SuccessResponse> UserBroadWorksAnywhereAddSelectiveCriteriaRequest16(this OcipClientBase client, UserBroadWorksAnywhereAddSelectiveCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's BroadWorks Anywhere phone number.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksAnywhereAddSelectiveCriteriaRequest16Async(this OcipClientBase client, UserBroadWorksAnywhereAddSelectiveCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a broadworks anywhere phone number. Also deletes all the selective criteria for the phone number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereDeletePhoneNumberRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksAnywhereDeletePhoneNumberRequest(this OcipClientBase client, UserBroadWorksAnywhereDeletePhoneNumberRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a broadworks anywhere phone number. Also deletes all the selective criteria for the phone number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksAnywhereDeletePhoneNumberRequestAsync(this OcipClientBase client, UserBroadWorksAnywhereDeletePhoneNumberRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's BroadWorks Anywhere phone number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereDeleteSelectiveCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksAnywhereDeleteSelectiveCriteriaRequest(this OcipClientBase client, UserBroadWorksAnywhereDeleteSelectiveCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's BroadWorks Anywhere phone number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksAnywhereDeleteSelectiveCriteriaRequestAsync(this OcipClientBase client, UserBroadWorksAnywhereDeleteSelectiveCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of all the available BroadWorks Anywhere portal instances for a specific user
        /// The response is either UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1Async instead.")]
        public static async Task<UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1> UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1(this OcipClientBase client, UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1;
        }

        /// <summary>
        /// Get a list of all the available BroadWorks Anywhere portal instances for a specific user
        /// The response is either UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1> UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1Async(this OcipClientBase client, UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1;
        }
        /// <summary>
        /// Get the list of all the BroadWorks Anywhere phone numbers for the user.
        /// If no sortOrder is included the response is sorted by Phone Number ascending by default.
        /// The response is either a UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequestAsync instead.")]
        public static async Task<UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse> UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest(this OcipClientBase client, UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse;
        }

        /// <summary>
        /// Get the list of all the BroadWorks Anywhere phone numbers for the user.
        /// If no sortOrder is included the response is sorted by Phone Number ascending by default.
        /// The response is either a UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse> UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequestAsync(this OcipClientBase client, UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse;
        }
        /// <summary>
        /// Get a broadworks anywhere phone number
        /// The response is UserBroadWorksAnywhereGetPhoneNumberResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereGetPhoneNumberRequestAsync instead.")]
        public static async Task<UserBroadWorksAnywhereGetPhoneNumberResponse> UserBroadWorksAnywhereGetPhoneNumberRequest(this OcipClientBase client, UserBroadWorksAnywhereGetPhoneNumberRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksAnywhereGetPhoneNumberResponse;
        }

        /// <summary>
        /// Get a broadworks anywhere phone number
        /// The response is UserBroadWorksAnywhereGetPhoneNumberResponse.
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetPhoneNumberResponse> UserBroadWorksAnywhereGetPhoneNumberRequestAsync(this OcipClientBase client, UserBroadWorksAnywhereGetPhoneNumberRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksAnywhereGetPhoneNumberResponse;
        }
        /// <summary>
        /// Get the list of all the BroadWorks Anywhere phone numbers for the user.
        /// The response is either a UserBroadWorksAnywhereGetResponse16sp2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereGetRequest16sp2Async instead.")]
        public static async Task<UserBroadWorksAnywhereGetResponse16sp2> UserBroadWorksAnywhereGetRequest16sp2(this OcipClientBase client, UserBroadWorksAnywhereGetRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksAnywhereGetResponse16sp2;
        }

        /// <summary>
        /// Get the list of all the BroadWorks Anywhere phone numbers for the user.
        /// The response is either a UserBroadWorksAnywhereGetResponse16sp2 or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetResponse16sp2> UserBroadWorksAnywhereGetRequest16sp2Async(this OcipClientBase client, UserBroadWorksAnywhereGetRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksAnywhereGetResponse16sp2;
        }
        /// <summary>
        /// Get a criteria for the user's BroadWorks Anywhere phone number.
        /// The response is either a UserBroadWorksAnywhereGetSelectiveCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereGetSelectiveCriteriaRequest21Async instead.")]
        public static async Task<UserBroadWorksAnywhereGetSelectiveCriteriaResponse21> UserBroadWorksAnywhereGetSelectiveCriteriaRequest21(this OcipClientBase client, UserBroadWorksAnywhereGetSelectiveCriteriaRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksAnywhereGetSelectiveCriteriaResponse21;
        }

        /// <summary>
        /// Get a criteria for the user's BroadWorks Anywhere phone number.
        /// The response is either a UserBroadWorksAnywhereGetSelectiveCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetSelectiveCriteriaResponse21> UserBroadWorksAnywhereGetSelectiveCriteriaRequest21Async(this OcipClientBase client, UserBroadWorksAnywhereGetSelectiveCriteriaRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksAnywhereGetSelectiveCriteriaResponse21;
        }
        /// <summary>
        /// Modify a BroadWorks Anywhere phone number
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereModifyPhoneNumberRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksAnywhereModifyPhoneNumberRequest(this OcipClientBase client, UserBroadWorksAnywhereModifyPhoneNumberRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a BroadWorks Anywhere phone number
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksAnywhereModifyPhoneNumberRequestAsync(this OcipClientBase client, UserBroadWorksAnywhereModifyPhoneNumberRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify the user-level settings for the BroadWorks Anywhere service for a specified user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksAnywhereModifyRequest(this OcipClientBase client, UserBroadWorksAnywhereModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the user-level settings for the BroadWorks Anywhere service for a specified user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksAnywhereModifyRequestAsync(this OcipClientBase client, UserBroadWorksAnywhereModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify selective criteria for the user's BroadWorks Anywhere phone number.
        /// The following elements are only used in AS data mode:
        /// callToNumbers
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereModifySelectiveCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksAnywhereModifySelectiveCriteriaRequest(this OcipClientBase client, UserBroadWorksAnywhereModifySelectiveCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify selective criteria for the user's BroadWorks Anywhere phone number.
        /// The following elements are only used in AS data mode:
        /// callToNumbers
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksAnywhereModifySelectiveCriteriaRequestAsync(this OcipClientBase client, UserBroadWorksAnywhereModifySelectiveCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
