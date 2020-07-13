using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallCenterExtensions
    {

        /// <summary>
        /// Gets an existing default Call Center Agent Threshold Profile in an Enterprise.
        /// If includeAgentsTable is set to true, a table with the list of agents assigned to
        /// the profile is included in the response. The search criteria is used to filter the
        /// list of agents to be included in the table.
        /// The response is either a EnterpriseCallCenterAgentThresholdDefaultProfileGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdDefaultProfileGetRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterAgentThresholdDefaultProfileGetResponse> EnterpriseCallCenterAgentThresholdDefaultProfileGetRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdDefaultProfileGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdDefaultProfileGetResponse;
        }

        /// <summary>
        /// Gets an existing default Call Center Agent Threshold Profile in an Enterprise.
        /// If includeAgentsTable is set to true, a table with the list of agents assigned to
        /// the profile is included in the response. The search criteria is used to filter the
        /// list of agents to be included in the table.
        /// The response is either a EnterpriseCallCenterAgentThresholdDefaultProfileGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterAgentThresholdDefaultProfileGetResponse> EnterpriseCallCenterAgentThresholdDefaultProfileGetRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdDefaultProfileGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdDefaultProfileGetResponse;
        }
        /// <summary>
        /// Add agent(s) to a Agent Threshold Profile.
        /// When an agent is assigned (added) to a profile, it is automatically unassigned (deleted) from the previous profile it was assigned to.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdProfileAddAgentListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentThresholdProfileAddAgentListRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileAddAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add agent(s) to a Agent Threshold Profile.
        /// When an agent is assigned (added) to a profile, it is automatically unassigned (deleted) from the previous profile it was assigned to.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentThresholdProfileAddAgentListRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileAddAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Call Center Agent Threshold Profile in an Enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdProfileAddRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentThresholdProfileAddRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Call Center Agent Threshold Profile in an Enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentThresholdProfileAddRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete agent(s) from a Agent Threshold Profile.
        /// Agents cannot be unassigned (deleted) directly from the default profile, they need to be assigned (added) to a different profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdProfileDeleteAgentListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentThresholdProfileDeleteAgentListRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileDeleteAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete agent(s) from a Agent Threshold Profile.
        /// Agents cannot be unassigned (deleted) directly from the default profile, they need to be assigned (added) to a different profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentThresholdProfileDeleteAgentListRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileDeleteAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes an existing Call Center Agent Threshold Profile in an Enterprise.
        /// The default profile cannot be deleted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdProfileDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentThresholdProfileDeleteRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes an existing Call Center Agent Threshold Profile in an Enterprise.
        /// The default profile cannot be deleted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentThresholdProfileDeleteRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Agents in the Enterprise that can be assigned to a given Call Center Agent Threshold Profile in an Enterprise.
        /// An agent is available to be assigned to a given Agent Threshold Profile if it is a Call Center Standard or Call Center Premium agent
        /// and the agent is not yet assigned to the profile.
        /// The available agent list for a new Call Center Agent Threshold profile can be obtained by not setting the excludeAgentsAssignedToProfileName.
        /// When the excludeAgentsAssignedToProfileName is specified, all agents already assigned to the specified profile are not included in the response, even if the search
        /// criterion element searchCriteriaAgentThresholdProfile is specified using the same profile name.
        /// The response is either a EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListResponse> EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListResponse;
        }

        /// <summary>
        /// Get the list of all Agents in the Enterprise that can be assigned to a given Call Center Agent Threshold Profile in an Enterprise.
        /// An agent is available to be assigned to a given Agent Threshold Profile if it is a Call Center Standard or Call Center Premium agent
        /// and the agent is not yet assigned to the profile.
        /// The available agent list for a new Call Center Agent Threshold profile can be obtained by not setting the excludeAgentsAssignedToProfileName.
        /// When the excludeAgentsAssignedToProfileName is specified, all agents already assigned to the specified profile are not included in the response, even if the search
        /// criterion element searchCriteriaAgentThresholdProfile is specified using the same profile name.
        /// The response is either a EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListResponse> EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListResponse;
        }
        /// <summary>
        /// Get the list of all Agents in the Enterprise that can be assigned to a given Call Center Agent Threshold Profile in an Enterprise.
        /// An agent is available to be assigned to a given Agent Threshold Profile if it is a Call Center Standard or Call Center Premium agent
        /// and the agent is not yet assigned to the profile.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// The available agent list for a new Call Center Agent Threshold profile can be obtained by not setting the excludeAgentsAssignedToProfileName.
        /// When the excludeAgentsAssignedToProfileName is specified, all agents already assigned to the specified profile are not included in the response, even if the search
        /// criterion element searchCriteriaAgentThresholdProfile is specified using the same profile name.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup has multiple entries and searchCriteriaModeOr is not included.
        /// 
        /// The response is either a EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse> EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse;
        }

        /// <summary>
        /// Get the list of all Agents in the Enterprise that can be assigned to a given Call Center Agent Threshold Profile in an Enterprise.
        /// An agent is available to be assigned to a given Agent Threshold Profile if it is a Call Center Standard or Call Center Premium agent
        /// and the agent is not yet assigned to the profile.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// The available agent list for a new Call Center Agent Threshold profile can be obtained by not setting the excludeAgentsAssignedToProfileName.
        /// When the excludeAgentsAssignedToProfileName is specified, all agents already assigned to the specified profile are not included in the response, even if the search
        /// criterion element searchCriteriaAgentThresholdProfile is specified using the same profile name.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup has multiple entries and searchCriteriaModeOr is not included.
        /// 
        /// The response is either a EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse> EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse;
        }
        /// <summary>
        /// Get the list of Call Center Agent Threshold Profiles in the Enterprise.
        /// The response is either EnterpriseCallCenterAgentThresholdProfileGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdProfileGetListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterAgentThresholdProfileGetListResponse> EnterpriseCallCenterAgentThresholdProfileGetListRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdProfileGetListResponse;
        }

        /// <summary>
        /// Get the list of Call Center Agent Threshold Profiles in the Enterprise.
        /// The response is either EnterpriseCallCenterAgentThresholdProfileGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterAgentThresholdProfileGetListResponse> EnterpriseCallCenterAgentThresholdProfileGetListRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdProfileGetListResponse;
        }
        /// <summary>
        /// Gets an existing specified Call Center Agent Threshold Profile in an Enterprise.
        /// 
        /// The agentTable is what the search, sort, and pagination fields apply to.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup has multiple entries and searchCriteriaModeOr is not included.
        /// 
        /// The response is either a EnterpriseCallCenterAgentThresholdProfileGetPagedSortedResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdProfileGetPagedSortedRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterAgentThresholdProfileGetPagedSortedResponse> EnterpriseCallCenterAgentThresholdProfileGetPagedSortedRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileGetPagedSortedRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdProfileGetPagedSortedResponse;
        }

        /// <summary>
        /// Gets an existing specified Call Center Agent Threshold Profile in an Enterprise.
        /// 
        /// The agentTable is what the search, sort, and pagination fields apply to.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup has multiple entries and searchCriteriaModeOr is not included.
        /// 
        /// The response is either a EnterpriseCallCenterAgentThresholdProfileGetPagedSortedResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterAgentThresholdProfileGetPagedSortedResponse> EnterpriseCallCenterAgentThresholdProfileGetPagedSortedRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileGetPagedSortedRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdProfileGetPagedSortedResponse;
        }
        /// <summary>
        /// Gets an existing non-default Call Center Agent Threshold Profile in an Enterprise.
        /// The response is either a EnterpriseCallCenterAgentThresholdProfileGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdProfileGetRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterAgentThresholdProfileGetResponse> EnterpriseCallCenterAgentThresholdProfileGetRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdProfileGetResponse;
        }

        /// <summary>
        /// Gets an existing non-default Call Center Agent Threshold Profile in an Enterprise.
        /// The response is either a EnterpriseCallCenterAgentThresholdProfileGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterAgentThresholdProfileGetResponse> EnterpriseCallCenterAgentThresholdProfileGetRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterAgentThresholdProfileGetResponse;
        }
        /// <summary>
        /// Modifies an existing Call Center Agent Threshold Profile in the Enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentThresholdProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentThresholdProfileModifyRequest(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies an existing Call Center Agent Threshold Profile in the Enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentThresholdProfileModifyRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentThresholdProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentUnavailableCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentUnavailableCodeAddRequest(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentUnavailableCodeAddRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentUnavailableCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentUnavailableCodeDeleteRequest(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentUnavailableCodeDeleteRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Call Center Agent Unavailable Codes.
        /// The response is either EnterpriseCallCenterAgentUnavailableCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentUnavailableCodeGetListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterAgentUnavailableCodeGetListResponse> EnterpriseCallCenterAgentUnavailableCodeGetListRequest(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterAgentUnavailableCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of Call Center Agent Unavailable Codes.
        /// The response is either EnterpriseCallCenterAgentUnavailableCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterAgentUnavailableCodeGetListResponse> EnterpriseCallCenterAgentUnavailableCodeGetListRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterAgentUnavailableCodeGetListResponse;
        }
        /// <summary>
        /// Get a Call Center Agent Unavailable Code.
        /// The response is either EnterpriseCallCenterAgentUnavailableCodeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentUnavailableCodeGetRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterAgentUnavailableCodeGetResponse> EnterpriseCallCenterAgentUnavailableCodeGetRequest(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterAgentUnavailableCodeGetResponse;
        }

        /// <summary>
        /// Get a Call Center Agent Unavailable Code.
        /// The response is either EnterpriseCallCenterAgentUnavailableCodeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterAgentUnavailableCodeGetResponse> EnterpriseCallCenterAgentUnavailableCodeGetRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterAgentUnavailableCodeGetResponse;
        }
        /// <summary>
        /// Modify a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentUnavailableCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentUnavailableCodeModifyRequest(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentUnavailableCodeModifyRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the enterprise level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either an EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest17sp4Async instead.")]
        public static async Task<EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse17sp4> EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest17sp4(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse17sp4;
        }

        /// <summary>
        /// Request the enterprise level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either an EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse17sp4> EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest17sp4Async(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse17sp4;
        }
        /// <summary>
        /// Modify the enterprise level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterAgentUnavailableCodeSettingsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentUnavailableCodeSettingsModifyRequest(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeSettingsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the enterprise level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterAgentUnavailableCodeSettingsModifyRequestAsync(this OcipClientBase client, EnterpriseCallCenterAgentUnavailableCodeSettingsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterCallDispositionCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterCallDispositionCodeAddRequest(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterCallDispositionCodeAddRequestAsync(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterCallDispositionCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterCallDispositionCodeDeleteRequest(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterCallDispositionCodeDeleteRequestAsync(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Call Center Call Disposition Codes.
        /// The response is either EnterpriseCallCenterCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterCallDispositionCodeGetListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterCallDispositionCodeGetListResponse> EnterpriseCallCenterCallDispositionCodeGetListRequest(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterCallDispositionCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of Call Center Call Disposition Codes.
        /// The response is either EnterpriseCallCenterCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterCallDispositionCodeGetListResponse> EnterpriseCallCenterCallDispositionCodeGetListRequestAsync(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterCallDispositionCodeGetListResponse;
        }
        /// <summary>
        /// Get a Call Center Call Disposition Code.
        /// The response is either EnterpriseCallCenterCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterCallDispositionCodeGetRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterCallDispositionCodeGetResponse> EnterpriseCallCenterCallDispositionCodeGetRequest(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterCallDispositionCodeGetResponse;
        }

        /// <summary>
        /// Get a Call Center Call Disposition Code.
        /// The response is either EnterpriseCallCenterCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterCallDispositionCodeGetResponse> EnterpriseCallCenterCallDispositionCodeGetRequestAsync(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterCallDispositionCodeGetResponse;
        }
        /// <summary>
        /// Get the list of Call Centers and Route Points using the specified disposition code.
        /// The response is either EnterpriseCallCenterCallDispositionCodeGetUsageListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterCallDispositionCodeGetUsageListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterCallDispositionCodeGetUsageListResponse> EnterpriseCallCenterCallDispositionCodeGetUsageListRequest(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeGetUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterCallDispositionCodeGetUsageListResponse;
        }

        /// <summary>
        /// Get the list of Call Centers and Route Points using the specified disposition code.
        /// The response is either EnterpriseCallCenterCallDispositionCodeGetUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterCallDispositionCodeGetUsageListResponse> EnterpriseCallCenterCallDispositionCodeGetUsageListRequestAsync(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeGetUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterCallDispositionCodeGetUsageListResponse;
        }
        /// <summary>
        /// Request to set the active status of Call Center Call Disposition Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterCallDispositionCodeModifyActiveListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterCallDispositionCodeModifyActiveListRequest(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeModifyActiveListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of Call Center Call Disposition Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterCallDispositionCodeModifyActiveListRequestAsync(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeModifyActiveListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterCallDispositionCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterCallDispositionCodeModifyRequest(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterCallDispositionCodeModifyRequestAsync(this OcipClientBase client, EnterpriseCallCenterCallDispositionCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to all the current and past agents in the enterprise.
        /// The searchCriteriaExactUserGroup does not apply to past agents.
        /// The response is either EnterpriseCallCenterCurrentAndPastAgentGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterCurrentAndPastAgentGetListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterCurrentAndPastAgentGetListResponse> EnterpriseCallCenterCurrentAndPastAgentGetListRequest(this OcipClientBase client, EnterpriseCallCenterCurrentAndPastAgentGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterCurrentAndPastAgentGetListResponse;
        }

        /// <summary>
        /// Request to all the current and past agents in the enterprise.
        /// The searchCriteriaExactUserGroup does not apply to past agents.
        /// The response is either EnterpriseCallCenterCurrentAndPastAgentGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterCurrentAndPastAgentGetListResponse> EnterpriseCallCenterCurrentAndPastAgentGetListRequestAsync(this OcipClientBase client, EnterpriseCallCenterCurrentAndPastAgentGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterCurrentAndPastAgentGetListResponse;
        }
        /// <summary>
        /// Request to get all the current and past call centers for the enterprise.
        /// The searchCriteriaExactUserGroup does not apply to past call centers.
        /// The response is either EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterCurrentAndPastCallCenterGetListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse> EnterpriseCallCenterCurrentAndPastCallCenterGetListRequest(this OcipClientBase client, EnterpriseCallCenterCurrentAndPastCallCenterGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse;
        }

        /// <summary>
        /// Request to get all the current and past call centers for the enterprise.
        /// The searchCriteriaExactUserGroup does not apply to past call centers.
        /// The response is either EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse> EnterpriseCallCenterCurrentAndPastCallCenterGetListRequestAsync(this OcipClientBase client, EnterpriseCallCenterCurrentAndPastCallCenterGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse;
        }
        /// <summary>
        /// Request to get all the past and current DNIS for the Call Center for the enterprise.
        /// The response is either EnterpriseCallCenterCurrentAndPastDNISGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterCurrentAndPastDNISGetListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterCurrentAndPastDNISGetListResponse> EnterpriseCallCenterCurrentAndPastDNISGetListRequest(this OcipClientBase client, EnterpriseCallCenterCurrentAndPastDNISGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterCurrentAndPastDNISGetListResponse;
        }

        /// <summary>
        /// Request to get all the past and current DNIS for the Call Center for the enterprise.
        /// The response is either EnterpriseCallCenterCurrentAndPastDNISGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterCurrentAndPastDNISGetListResponse> EnterpriseCallCenterCurrentAndPastDNISGetListRequestAsync(this OcipClientBase client, EnterpriseCallCenterCurrentAndPastDNISGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterCurrentAndPastDNISGetListResponse;
        }
        /// <summary>
        /// Request to get the enterprise branding information.
        /// The response is either EnterpriseCallCenterEnhancedReportingBrandingGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingBrandingGetRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterEnhancedReportingBrandingGetResponse> EnterpriseCallCenterEnhancedReportingBrandingGetRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingBrandingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingBrandingGetResponse;
        }

        /// <summary>
        /// Request to get the enterprise branding information.
        /// The response is either EnterpriseCallCenterEnhancedReportingBrandingGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingBrandingGetResponse> EnterpriseCallCenterEnhancedReportingBrandingGetRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingBrandingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingBrandingGetResponse;
        }
        /// <summary>
        /// Request to modify the enterprise branding configuration.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingBrandingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingBrandingModifyRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingBrandingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the enterprise branding configuration.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingBrandingModifyRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingBrandingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all enabled call center report template for an enterprise.
        /// The response is either an EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListResponse> EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListResponse;
        }

        /// <summary>
        /// Request to get all enabled call center report template for an enterprise.
        /// The response is either an EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListResponse> EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingGetAvailableReportTemplateListResponse;
        }
        /// <summary>
        /// Request to get an enterprise level call center enhanced reporting setting.
        /// The response is either an EnterpriseCallCenterEnhancedReportingGetResponse19 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingGetRequest19Async instead.")]
        public static async Task<EnterpriseCallCenterEnhancedReportingGetResponse19> EnterpriseCallCenterEnhancedReportingGetRequest19(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingGetResponse19;
        }

        /// <summary>
        /// Request to get an enterprise level call center enhanced reporting setting.
        /// The response is either an EnterpriseCallCenterEnhancedReportingGetResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingGetResponse19> EnterpriseCallCenterEnhancedReportingGetRequest19Async(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingGetResponse19;
        }
        /// <summary>
        /// Request to modify enterprise level call center enhanced reporting settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingModifyRequest19Async instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingModifyRequest19(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingModifyRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify enterprise level call center enhanced reporting settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingModifyRequest19Async(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingModifyRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an Enterprise level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingReportTemplateAddRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingReportTemplateAddRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingReportTemplateAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an Enterprise level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingReportTemplateAddRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingReportTemplateAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete an enterprise level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingReportTemplateDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingReportTemplateDeleteRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingReportTemplateDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an enterprise level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingReportTemplateDeleteRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingReportTemplateDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get enterprise level call center report template list.
        /// The response is either an EnterpriseCallCenterEnhancedReportingReportTemplateGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingReportTemplateGetListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterEnhancedReportingReportTemplateGetListResponse> EnterpriseCallCenterEnhancedReportingReportTemplateGetListRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingReportTemplateGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingReportTemplateGetListResponse;
        }

        /// <summary>
        /// Request to get enterprise level call center report template list.
        /// The response is either an EnterpriseCallCenterEnhancedReportingReportTemplateGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingReportTemplateGetListResponse> EnterpriseCallCenterEnhancedReportingReportTemplateGetListRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingReportTemplateGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingReportTemplateGetListResponse;
        }
        /// <summary>
        /// Request to get an enterprise level call center report template.
        /// The response is either an EnterpriseCallCenterEnhancedReportingReportTemplateGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingReportTemplateGetRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterEnhancedReportingReportTemplateGetResponse> EnterpriseCallCenterEnhancedReportingReportTemplateGetRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingReportTemplateGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingReportTemplateGetResponse;
        }

        /// <summary>
        /// Request to get an enterprise level call center report template.
        /// The response is either an EnterpriseCallCenterEnhancedReportingReportTemplateGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingReportTemplateGetResponse> EnterpriseCallCenterEnhancedReportingReportTemplateGetRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingReportTemplateGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingReportTemplateGetResponse;
        }
        /// <summary>
        /// Request to modify an enterprise level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingReportTemplateModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingReportTemplateModifyRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingReportTemplateModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an enterprise level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingReportTemplateModifyRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingReportTemplateModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an enterprise level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingScheduledReportAddRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingScheduledReportAddRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an enterprise level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingScheduledReportAddRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete an enterprise level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingScheduledReportDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingScheduledReportDeleteRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an enterprise level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingScheduledReportDeleteRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of active enterprise level call center reporting scheduled reports.
        /// The response is either an EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListResponse> EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListResponse;
        }

        /// <summary>
        /// Request to get a list of active enterprise level call center reporting scheduled reports.
        /// The response is either an EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListResponse> EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingScheduledReportGetActiveListResponse;
        }
        /// <summary>
        /// Request to get a list of completed enterprise level call center reporting scheduled reports.
        /// The response is either an EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListResponse> EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListResponse;
        }

        /// <summary>
        /// Request to get a list of completed enterprise level call center reporting scheduled reports.
        /// The response is either an EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListResponse> EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListResponse;
        }
        /// <summary>
        /// Request to get a list of enterprise level call center reporting scheduled reports.
        /// The response is either an EnterpriseCallCenterEnhancedReportingScheduledReportGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingScheduledReportGetListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterEnhancedReportingScheduledReportGetListResponse> EnterpriseCallCenterEnhancedReportingScheduledReportGetListRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingScheduledReportGetListResponse;
        }

        /// <summary>
        /// Request to get a list of enterprise level call center reporting scheduled reports.
        /// The response is either an EnterpriseCallCenterEnhancedReportingScheduledReportGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingScheduledReportGetListResponse> EnterpriseCallCenterEnhancedReportingScheduledReportGetListRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingScheduledReportGetListResponse;
        }
        /// <summary>
        /// Request to get all the call center reporting scheduled report in an enterprise that uses a given enterprise level report template.
        /// The response is either a EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse> EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse;
        }

        /// <summary>
        /// Request to get all the call center reporting scheduled report in an enterprise that uses a given enterprise level report template.
        /// The response is either a EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse> EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse;
        }
        /// <summary>
        /// Request to get an enterprise level call center reporting scheduled report.
        /// The response is either an EnterpriseCallCenterEnhancedReportingScheduledReportGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingScheduledReportGetRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterEnhancedReportingScheduledReportGetResponse> EnterpriseCallCenterEnhancedReportingScheduledReportGetRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingScheduledReportGetResponse;
        }

        /// <summary>
        /// Request to get an enterprise level call center reporting scheduled report.
        /// The response is either an EnterpriseCallCenterEnhancedReportingScheduledReportGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingScheduledReportGetResponse> EnterpriseCallCenterEnhancedReportingScheduledReportGetRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterEnhancedReportingScheduledReportGetResponse;
        }
        /// <summary>
        /// Request to modify an enterprise level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterEnhancedReportingScheduledReportModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingScheduledReportModifyRequest(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an enterprise level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingScheduledReportModifyRequestAsync(this OcipClientBase client, EnterpriseCallCenterEnhancedReportingScheduledReportModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the enterprise level data associated with Call Center.
        /// The response is either an EnterpriseCallCenterGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterGetRequest17sp4Async instead.")]
        public static async Task<EnterpriseCallCenterGetResponse17sp4> EnterpriseCallCenterGetRequest17sp4(this OcipClientBase client, EnterpriseCallCenterGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterGetResponse17sp4;
        }

        /// <summary>
        /// Request the enterprise level data associated with Call Center.
        /// The response is either an EnterpriseCallCenterGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterGetResponse17sp4> EnterpriseCallCenterGetRequest17sp4Async(this OcipClientBase client, EnterpriseCallCenterGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterGetResponse17sp4;
        }
        /// <summary>
        /// Request the enterprise call center routing policy.
        /// The response is either an EnterpriseCallCenterGetRoutingPolicyResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterGetRoutingPolicyRequestAsync instead.")]
        public static async Task<EnterpriseCallCenterGetRoutingPolicyResponse> EnterpriseCallCenterGetRoutingPolicyRequest(this OcipClientBase client, EnterpriseCallCenterGetRoutingPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterGetRoutingPolicyResponse;
        }

        /// <summary>
        /// Request the enterprise call center routing policy.
        /// The response is either an EnterpriseCallCenterGetRoutingPolicyResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterGetRoutingPolicyResponse> EnterpriseCallCenterGetRoutingPolicyRequestAsync(this OcipClientBase client, EnterpriseCallCenterGetRoutingPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterGetRoutingPolicyResponse;
        }
        /// <summary>
        /// Modify the enterprise level data associated with Call Center
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useSystemDefaultUnavailableSettings
        /// forceAgentUnavailableOnDNDActivation
        /// forceAgentUnavailableOnPersonalCalls
        /// forceAgentUnavailableOnBouncedCallLimit
        /// numberConsecutiveBouncedCallsToForceAgentUnavailable
        /// forceAgentUnavailableOnNotReachable
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterModifyRequest(this OcipClientBase client, EnterpriseCallCenterModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the enterprise level data associated with Call Center
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useSystemDefaultUnavailableSettings
        /// forceAgentUnavailableOnDNDActivation
        /// forceAgentUnavailableOnPersonalCalls
        /// forceAgentUnavailableOnBouncedCallLimit
        /// numberConsecutiveBouncedCallsToForceAgentUnavailable
        /// forceAgentUnavailableOnNotReachable
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterModifyRequestAsync(this OcipClientBase client, EnterpriseCallCenterModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the enterprise call center routing policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterModifyRoutingPolicyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterModifyRoutingPolicyRequest(this OcipClientBase client, EnterpriseCallCenterModifyRoutingPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the enterprise call center routing policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterModifyRoutingPolicyRequestAsync(this OcipClientBase client, EnterpriseCallCenterModifyRoutingPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add agent(s) to a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// If the skill level is not present for skill based premium call centers, the users will be set to skill level 1.
        /// 
        /// The following element is only used in AS data mode and ignored in XS data mode:
        /// agentSkillList
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAddAgentListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAddAgentListRequest(this OcipClientBase client, GroupCallCenterAddAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add agent(s) to a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// If the skill level is not present for skill based premium call centers, the users will be set to skill level 1.
        /// 
        /// The following element is only used in AS data mode and ignored in XS data mode:
        /// agentSkillList
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddAgentListRequestAsync(this OcipClientBase client, GroupCallCenterAddAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Center DNIS
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAddDNISRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAddDNISRequest(this OcipClientBase client, GroupCallCenterAddDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center DNIS
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddDNISRequestAsync(this OcipClientBase client, GroupCallCenterAddDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Center instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// routingType
        /// enableReporting
        /// allowCallsToAgentsInWrapUp
        /// overrideAgentWrapUpTime
        /// wrapUpSeconds
        /// forceDeliveryOfCalls
        /// forceDeliveryWaitTimeSeconds
        /// enableAutomaticStateChangeForAgents
        /// agentStateAfterCall
        /// agentUnavailableCode
        /// networkClassOfService
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAddInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAddInstanceRequest22(this OcipClientBase client, GroupCallCenterAddInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// routingType
        /// enableReporting
        /// allowCallsToAgentsInWrapUp
        /// overrideAgentWrapUpTime
        /// wrapUpSeconds
        /// forceDeliveryOfCalls
        /// forceDeliveryWaitTimeSeconds
        /// enableAutomaticStateChangeForAgents
        /// agentStateAfterCall
        /// agentUnavailableCode
        /// networkClassOfService
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddInstanceRequest22Async(this OcipClientBase client, GroupCallCenterAddInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add supervisor(s) to a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAddSupervisorListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAddSupervisorListRequest(this OcipClientBase client, GroupCallCenterAddSupervisorListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add supervisor(s) to a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddSupervisorListRequestAsync(this OcipClientBase client, GroupCallCenterAddSupervisorListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets an existing default Call Center Agent Threshold Profile in a Group.
        /// If includeAgentsTable is set to true, a table with the list of agents assigned to
        /// the profile is included in the response. The search criteria is used to filter the
        /// list of agents to be included in the table.
        /// The response is either a GroupCallCenterAgentThresholdDefaultProfileGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdDefaultProfileGetRequestAsync instead.")]
        public static async Task<GroupCallCenterAgentThresholdDefaultProfileGetResponse> GroupCallCenterAgentThresholdDefaultProfileGetRequest(this OcipClientBase client, GroupCallCenterAgentThresholdDefaultProfileGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterAgentThresholdDefaultProfileGetResponse;
        }

        /// <summary>
        /// Gets an existing default Call Center Agent Threshold Profile in a Group.
        /// If includeAgentsTable is set to true, a table with the list of agents assigned to
        /// the profile is included in the response. The search criteria is used to filter the
        /// list of agents to be included in the table.
        /// The response is either a GroupCallCenterAgentThresholdDefaultProfileGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterAgentThresholdDefaultProfileGetResponse> GroupCallCenterAgentThresholdDefaultProfileGetRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdDefaultProfileGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterAgentThresholdDefaultProfileGetResponse;
        }
        /// <summary>
        /// Add agent(s) to a Agent Threshold Profile.
        /// When an agent is assigned (added )to a profile, it is automatically unassigned (deleted) from the previous profile it was assigned to.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdProfileAddAgentListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAgentThresholdProfileAddAgentListRequest(this OcipClientBase client, GroupCallCenterAgentThresholdProfileAddAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add agent(s) to a Agent Threshold Profile.
        /// When an agent is assigned (added )to a profile, it is automatically unassigned (deleted) from the previous profile it was assigned to.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAgentThresholdProfileAddAgentListRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdProfileAddAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Call Center Agent Threshold Profile in a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdProfileAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAgentThresholdProfileAddRequest(this OcipClientBase client, GroupCallCenterAgentThresholdProfileAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Call Center Agent Threshold Profile in a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAgentThresholdProfileAddRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdProfileAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete agent(s) from a Agent Threshold Profile.
        /// Agents cannot be unassigned (deleted) directly from the default profile, they need to be assigned (added) to a different profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdProfileDeleteAgentListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAgentThresholdProfileDeleteAgentListRequest(this OcipClientBase client, GroupCallCenterAgentThresholdProfileDeleteAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete agent(s) from a Agent Threshold Profile.
        /// Agents cannot be unassigned (deleted) directly from the default profile, they need to be assigned (added) to a different profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAgentThresholdProfileDeleteAgentListRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdProfileDeleteAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes an existing Call Center Agent Threshold Profile in a Group.
        /// The default profile cannot be deleted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdProfileDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAgentThresholdProfileDeleteRequest(this OcipClientBase client, GroupCallCenterAgentThresholdProfileDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes an existing Call Center Agent Threshold Profile in a Group.
        /// The default profile cannot be deleted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAgentThresholdProfileDeleteRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdProfileDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Agents in the Group that can be assigned to a given Call Center Agent Threshold Profile in a Group.
        /// An agent is available to be assigned to a given Agent Threshold Profile if it is a Call Center Standard or Call Center Premium agent
        /// and the agent is not yet assigned to the profile.
        /// The available agent list for a new Call Center Agent Threshold profile can be obtained by not setting the excludeAgentsAssignedToProfileName.
        /// When the excludeAgentsAssignedToProfileName is specified, all agents already assigned to the specified profile are not included in the response, even if the search
        /// criterion element searchCriteriaAgentThresholdProfile is specified using the same profile name.
        /// The response is either a GroupCallCenterAgentThresholdProfileGetAvailableAgentListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdProfileGetAvailableAgentListRequestAsync instead.")]
        public static async Task<GroupCallCenterAgentThresholdProfileGetAvailableAgentListResponse> GroupCallCenterAgentThresholdProfileGetAvailableAgentListRequest(this OcipClientBase client, GroupCallCenterAgentThresholdProfileGetAvailableAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterAgentThresholdProfileGetAvailableAgentListResponse;
        }

        /// <summary>
        /// Get the list of all Agents in the Group that can be assigned to a given Call Center Agent Threshold Profile in a Group.
        /// An agent is available to be assigned to a given Agent Threshold Profile if it is a Call Center Standard or Call Center Premium agent
        /// and the agent is not yet assigned to the profile.
        /// The available agent list for a new Call Center Agent Threshold profile can be obtained by not setting the excludeAgentsAssignedToProfileName.
        /// When the excludeAgentsAssignedToProfileName is specified, all agents already assigned to the specified profile are not included in the response, even if the search
        /// criterion element searchCriteriaAgentThresholdProfile is specified using the same profile name.
        /// The response is either a GroupCallCenterAgentThresholdProfileGetAvailableAgentListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterAgentThresholdProfileGetAvailableAgentListResponse> GroupCallCenterAgentThresholdProfileGetAvailableAgentListRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdProfileGetAvailableAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterAgentThresholdProfileGetAvailableAgentListResponse;
        }
        /// <summary>
        /// Get the list of all Agents in the Group that can be assigned to a given Call Center Agent Threshold Profile in a Group.
        /// An agent is available to be assigned to a given Agent Threshold Profile if it is a Call Center Standard or Call Center Premium agent
        /// and the agent is not yet assigned to the profile.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// The available agent list for a new Call Center Agent Threshold profile can be obtained by not setting the excludeAgentsAssignedToProfileName.
        /// When the excludeAgentsAssignedToProfileName is specified, all agents already assigned to the specified profile are not included in the response, even if the search
        /// criterion element searchCriteriaAgentThresholdProfile is specified using the same profile name.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either a GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequestAsync instead.")]
        public static async Task<GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse> GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequest(this OcipClientBase client, GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse;
        }

        /// <summary>
        /// Get the list of all Agents in the Group that can be assigned to a given Call Center Agent Threshold Profile in a Group.
        /// An agent is available to be assigned to a given Agent Threshold Profile if it is a Call Center Standard or Call Center Premium agent
        /// and the agent is not yet assigned to the profile.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// The available agent list for a new Call Center Agent Threshold profile can be obtained by not setting the excludeAgentsAssignedToProfileName.
        /// When the excludeAgentsAssignedToProfileName is specified, all agents already assigned to the specified profile are not included in the response, even if the search
        /// criterion element searchCriteriaAgentThresholdProfile is specified using the same profile name.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either a GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse> GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse;
        }
        /// <summary>
        /// Get the list of Call Center Agent Threshold Profiles in the Group.
        /// The response is either GroupCallCenterAgentThresholdProfileGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdProfileGetListRequestAsync instead.")]
        public static async Task<GroupCallCenterAgentThresholdProfileGetListResponse> GroupCallCenterAgentThresholdProfileGetListRequest(this OcipClientBase client, GroupCallCenterAgentThresholdProfileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterAgentThresholdProfileGetListResponse;
        }

        /// <summary>
        /// Get the list of Call Center Agent Threshold Profiles in the Group.
        /// The response is either GroupCallCenterAgentThresholdProfileGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterAgentThresholdProfileGetListResponse> GroupCallCenterAgentThresholdProfileGetListRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdProfileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterAgentThresholdProfileGetListResponse;
        }
        /// <summary>
        /// Gets an existing non-default Call Center Agent Threshold Profile in a Group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either a GroupCallCenterAgentThresholdProfileGetPagedSortedResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdProfileGetPagedSortedRequestAsync instead.")]
        public static async Task<GroupCallCenterAgentThresholdProfileGetPagedSortedResponse> GroupCallCenterAgentThresholdProfileGetPagedSortedRequest(this OcipClientBase client, GroupCallCenterAgentThresholdProfileGetPagedSortedRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterAgentThresholdProfileGetPagedSortedResponse;
        }

        /// <summary>
        /// Gets an existing non-default Call Center Agent Threshold Profile in a Group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either a GroupCallCenterAgentThresholdProfileGetPagedSortedResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterAgentThresholdProfileGetPagedSortedResponse> GroupCallCenterAgentThresholdProfileGetPagedSortedRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdProfileGetPagedSortedRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterAgentThresholdProfileGetPagedSortedResponse;
        }
        /// <summary>
        /// Gets an existing non-default Call Center Agent Threshold Profile in a Group.
        /// The response is either a GroupCallCenterAgentThresholdProfileGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdProfileGetRequestAsync instead.")]
        public static async Task<GroupCallCenterAgentThresholdProfileGetResponse> GroupCallCenterAgentThresholdProfileGetRequest(this OcipClientBase client, GroupCallCenterAgentThresholdProfileGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterAgentThresholdProfileGetResponse;
        }

        /// <summary>
        /// Gets an existing non-default Call Center Agent Threshold Profile in a Group.
        /// The response is either a GroupCallCenterAgentThresholdProfileGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterAgentThresholdProfileGetResponse> GroupCallCenterAgentThresholdProfileGetRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdProfileGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterAgentThresholdProfileGetResponse;
        }
        /// <summary>
        /// Modifies an existing Call Center Agent Threshold Profile in the Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentThresholdProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAgentThresholdProfileModifyRequest(this OcipClientBase client, GroupCallCenterAgentThresholdProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies an existing Call Center Agent Threshold Profile in the Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAgentThresholdProfileModifyRequestAsync(this OcipClientBase client, GroupCallCenterAgentThresholdProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentUnavailableCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAgentUnavailableCodeAddRequest(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAgentUnavailableCodeAddRequestAsync(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentUnavailableCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAgentUnavailableCodeDeleteRequest(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAgentUnavailableCodeDeleteRequestAsync(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Call Center Agent Unavailable Codes.
        /// The response is either GroupCallCenterAgentUnavailableCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentUnavailableCodeGetListRequestAsync instead.")]
        public static async Task<GroupCallCenterAgentUnavailableCodeGetListResponse> GroupCallCenterAgentUnavailableCodeGetListRequest(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterAgentUnavailableCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of Call Center Agent Unavailable Codes.
        /// The response is either GroupCallCenterAgentUnavailableCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterAgentUnavailableCodeGetListResponse> GroupCallCenterAgentUnavailableCodeGetListRequestAsync(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterAgentUnavailableCodeGetListResponse;
        }
        /// <summary>
        /// Get a Call Center Agent Unavailable Code.
        /// The response is either GroupCallCenterAgentUnavailableCodeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentUnavailableCodeGetRequestAsync instead.")]
        public static async Task<GroupCallCenterAgentUnavailableCodeGetResponse> GroupCallCenterAgentUnavailableCodeGetRequest(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterAgentUnavailableCodeGetResponse;
        }

        /// <summary>
        /// Get a Call Center Agent Unavailable Code.
        /// The response is either GroupCallCenterAgentUnavailableCodeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterAgentUnavailableCodeGetResponse> GroupCallCenterAgentUnavailableCodeGetRequestAsync(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterAgentUnavailableCodeGetResponse;
        }
        /// <summary>
        /// Modify a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentUnavailableCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAgentUnavailableCodeModifyRequest(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Call Center Agent Unavailable Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAgentUnavailableCodeModifyRequestAsync(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the group level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either a GroupCallCenterAgentUnavailableCodeSettingsGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentUnavailableCodeSettingsGetRequest17sp4Async instead.")]
        public static async Task<GroupCallCenterAgentUnavailableCodeSettingsGetResponse17sp4> GroupCallCenterAgentUnavailableCodeSettingsGetRequest17sp4(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeSettingsGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterAgentUnavailableCodeSettingsGetResponse17sp4;
        }

        /// <summary>
        /// Request the group level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either a GroupCallCenterAgentUnavailableCodeSettingsGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterAgentUnavailableCodeSettingsGetResponse17sp4> GroupCallCenterAgentUnavailableCodeSettingsGetRequest17sp4Async(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeSettingsGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterAgentUnavailableCodeSettingsGetResponse17sp4;
        }
        /// <summary>
        /// Modify the group level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterAgentUnavailableCodeSettingsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterAgentUnavailableCodeSettingsModifyRequest(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeSettingsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAgentUnavailableCodeSettingsModifyRequestAsync(this OcipClientBase client, GroupCallCenterAgentUnavailableCodeSettingsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a call center's bounced call settings.
        /// The response is either a GroupCallCenterBouncedCallGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterBouncedCallGetRequest17Async instead.")]
        public static async Task<GroupCallCenterBouncedCallGetResponse17> GroupCallCenterBouncedCallGetRequest17(this OcipClientBase client, GroupCallCenterBouncedCallGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterBouncedCallGetResponse17;
        }

        /// <summary>
        /// Get a call center's bounced call settings.
        /// The response is either a GroupCallCenterBouncedCallGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterBouncedCallGetResponse17> GroupCallCenterBouncedCallGetRequest17Async(this OcipClientBase client, GroupCallCenterBouncedCallGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterBouncedCallGetResponse17;
        }
        /// <summary>
        /// Modify a call center's bounced call settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableTransfer
        /// transferPhoneNumber
        /// bounceCallWhenAgentUnavailable
        /// alertCallCenterCallOnHold
        /// alertCallCenterCallOnHoldSeconds
        /// bounceCallCenterCallOnHold
        /// bounceCallCenterCallOnHoldSeconds
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterBouncedCallModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterBouncedCallModifyRequest(this OcipClientBase client, GroupCallCenterBouncedCallModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's bounced call settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableTransfer
        /// transferPhoneNumber
        /// bounceCallWhenAgentUnavailable
        /// alertCallCenterCallOnHold
        /// alertCallCenterCallOnHoldSeconds
        /// bounceCallCenterCallOnHold
        /// bounceCallCenterCallOnHoldSeconds
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterBouncedCallModifyRequestAsync(this OcipClientBase client, GroupCallCenterBouncedCallModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterCallDispositionCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterCallDispositionCodeAddRequest(this OcipClientBase client, GroupCallCenterCallDispositionCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterCallDispositionCodeAddRequestAsync(this OcipClientBase client, GroupCallCenterCallDispositionCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterCallDispositionCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterCallDispositionCodeDeleteRequest(this OcipClientBase client, GroupCallCenterCallDispositionCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterCallDispositionCodeDeleteRequestAsync(this OcipClientBase client, GroupCallCenterCallDispositionCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Call Center Call Disposition  Codes.
        /// The response is either GroupCallCenterCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterCallDispositionCodeGetListRequestAsync instead.")]
        public static async Task<GroupCallCenterCallDispositionCodeGetListResponse> GroupCallCenterCallDispositionCodeGetListRequest(this OcipClientBase client, GroupCallCenterCallDispositionCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterCallDispositionCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of Call Center Call Disposition  Codes.
        /// The response is either GroupCallCenterCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterCallDispositionCodeGetListResponse> GroupCallCenterCallDispositionCodeGetListRequestAsync(this OcipClientBase client, GroupCallCenterCallDispositionCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterCallDispositionCodeGetListResponse;
        }
        /// <summary>
        /// Get a Call Center Call Disposition Code.
        /// The response is either GroupCallCenterCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterCallDispositionCodeGetRequestAsync instead.")]
        public static async Task<GroupCallCenterCallDispositionCodeGetResponse> GroupCallCenterCallDispositionCodeGetRequest(this OcipClientBase client, GroupCallCenterCallDispositionCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterCallDispositionCodeGetResponse;
        }

        /// <summary>
        /// Get a Call Center Call Disposition Code.
        /// The response is either GroupCallCenterCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterCallDispositionCodeGetResponse> GroupCallCenterCallDispositionCodeGetRequestAsync(this OcipClientBase client, GroupCallCenterCallDispositionCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterCallDispositionCodeGetResponse;
        }
        /// <summary>
        /// Get the list of Call Centers and Route Points using the specified disposition code.
        /// The response is either GroupCallCenterCallDispositionCodeGetUsageListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterCallDispositionCodeGetUsageListRequestAsync instead.")]
        public static async Task<GroupCallCenterCallDispositionCodeGetUsageListResponse> GroupCallCenterCallDispositionCodeGetUsageListRequest(this OcipClientBase client, GroupCallCenterCallDispositionCodeGetUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterCallDispositionCodeGetUsageListResponse;
        }

        /// <summary>
        /// Get the list of Call Centers and Route Points using the specified disposition code.
        /// The response is either GroupCallCenterCallDispositionCodeGetUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterCallDispositionCodeGetUsageListResponse> GroupCallCenterCallDispositionCodeGetUsageListRequestAsync(this OcipClientBase client, GroupCallCenterCallDispositionCodeGetUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterCallDispositionCodeGetUsageListResponse;
        }
        /// <summary>
        /// Request to set the active status of Call Center Call Disposition Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterCallDispositionCodeModifyActiveListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterCallDispositionCodeModifyActiveListRequest(this OcipClientBase client, GroupCallCenterCallDispositionCodeModifyActiveListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of Call Center Call Disposition Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterCallDispositionCodeModifyActiveListRequestAsync(this OcipClientBase client, GroupCallCenterCallDispositionCodeModifyActiveListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterCallDispositionCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterCallDispositionCodeModifyRequest(this OcipClientBase client, GroupCallCenterCallDispositionCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterCallDispositionCodeModifyRequestAsync(this OcipClientBase client, GroupCallCenterCallDispositionCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a call center's comfort message bypass settings.
        /// The response is either a GroupCallCenterComfortMessageBypassGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterComfortMessageBypassGetRequest20Async instead.")]
        public static async Task<GroupCallCenterComfortMessageBypassGetResponse20> GroupCallCenterComfortMessageBypassGetRequest20(this OcipClientBase client, GroupCallCenterComfortMessageBypassGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterComfortMessageBypassGetResponse20;
        }

        /// <summary>
        /// Get a call center's comfort message bypass settings.
        /// The response is either a GroupCallCenterComfortMessageBypassGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterComfortMessageBypassGetResponse20> GroupCallCenterComfortMessageBypassGetRequest20Async(this OcipClientBase client, GroupCallCenterComfortMessageBypassGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterComfortMessageBypassGetResponse20;
        }
        /// <summary>
        /// Modify a call center's comfort message bypass settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterComfortMessageBypassModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterComfortMessageBypassModifyRequest20(this OcipClientBase client, GroupCallCenterComfortMessageBypassModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's comfort message bypass settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterComfortMessageBypassModifyRequest20Async(this OcipClientBase client, GroupCallCenterComfortMessageBypassModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the current and past agents for the group.
        /// The response is either GroupCallCenterCurrentAndPastAgentGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterCurrentAndPastAgentGetListRequestAsync instead.")]
        public static async Task<GroupCallCenterCurrentAndPastAgentGetListResponse> GroupCallCenterCurrentAndPastAgentGetListRequest(this OcipClientBase client, GroupCallCenterCurrentAndPastAgentGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterCurrentAndPastAgentGetListResponse;
        }

        /// <summary>
        /// Request to get all the current and past agents for the group.
        /// The response is either GroupCallCenterCurrentAndPastAgentGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterCurrentAndPastAgentGetListResponse> GroupCallCenterCurrentAndPastAgentGetListRequestAsync(this OcipClientBase client, GroupCallCenterCurrentAndPastAgentGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterCurrentAndPastAgentGetListResponse;
        }
        /// <summary>
        /// Request to get all the current and past call centers for the group.
        /// The response is either GroupCallCenterCurrentAndPastCallCenterGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterCurrentAndPastCallCenterGetListRequestAsync instead.")]
        public static async Task<GroupCallCenterCurrentAndPastCallCenterGetListResponse> GroupCallCenterCurrentAndPastCallCenterGetListRequest(this OcipClientBase client, GroupCallCenterCurrentAndPastCallCenterGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterCurrentAndPastCallCenterGetListResponse;
        }

        /// <summary>
        /// Request to get all the current and past call centers for the group.
        /// The response is either GroupCallCenterCurrentAndPastCallCenterGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterCurrentAndPastCallCenterGetListResponse> GroupCallCenterCurrentAndPastCallCenterGetListRequestAsync(this OcipClientBase client, GroupCallCenterCurrentAndPastCallCenterGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterCurrentAndPastCallCenterGetListResponse;
        }
        /// <summary>
        /// Request to get all the past and current DNIS for the Call Center for the group.
        /// The response is either GroupCallCenterCurrentAndPastDNISGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterCurrentAndPastDNISGetListRequestAsync instead.")]
        public static async Task<GroupCallCenterCurrentAndPastDNISGetListResponse> GroupCallCenterCurrentAndPastDNISGetListRequest(this OcipClientBase client, GroupCallCenterCurrentAndPastDNISGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterCurrentAndPastDNISGetListResponse;
        }

        /// <summary>
        /// Request to get all the past and current DNIS for the Call Center for the group.
        /// The response is either GroupCallCenterCurrentAndPastDNISGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterCurrentAndPastDNISGetListResponse> GroupCallCenterCurrentAndPastDNISGetListRequestAsync(this OcipClientBase client, GroupCallCenterCurrentAndPastDNISGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterCurrentAndPastDNISGetListResponse;
        }
        /// <summary>
        /// Delete agent(s) from a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterDeleteAgentListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterDeleteAgentListRequest(this OcipClientBase client, GroupCallCenterDeleteAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete agent(s) from a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterDeleteAgentListRequestAsync(this OcipClientBase client, GroupCallCenterDeleteAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a call center's DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterDeleteDNISRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterDeleteDNISRequest(this OcipClientBase client, GroupCallCenterDeleteDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a call center's DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterDeleteDNISRequestAsync(this OcipClientBase client, GroupCallCenterDeleteDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Center instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterDeleteInstanceRequest(this OcipClientBase client, GroupCallCenterDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Center instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterDeleteInstanceRequestAsync(this OcipClientBase client, GroupCallCenterDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete supervisor(s) from a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterDeleteSupervisorListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterDeleteSupervisorListRequest(this OcipClientBase client, GroupCallCenterDeleteSupervisorListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete supervisor(s) from a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterDeleteSupervisorListRequestAsync(this OcipClientBase client, GroupCallCenterDeleteSupervisorListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the distinctive ringing configuration values for call center.
        /// The response is either a GroupCallCenterDistinctiveRingingGetResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterDistinctiveRingingGetRequestAsync instead.")]
        public static async Task<GroupCallCenterDistinctiveRingingGetResponse> GroupCallCenterDistinctiveRingingGetRequest(this OcipClientBase client, GroupCallCenterDistinctiveRingingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterDistinctiveRingingGetResponse;
        }

        /// <summary>
        /// Get the distinctive ringing configuration values for call center.
        /// The response is either a GroupCallCenterDistinctiveRingingGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterDistinctiveRingingGetResponse> GroupCallCenterDistinctiveRingingGetRequestAsync(this OcipClientBase client, GroupCallCenterDistinctiveRingingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterDistinctiveRingingGetResponse;
        }
        /// <summary>
        /// Modify the distinctive ringing configuration values for call center.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following element is only used in AS data mode and ignored in XS data mode:
        /// distinctiveRingingForceDeliveryRingPattern
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterDistinctiveRingingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterDistinctiveRingingModifyRequest(this OcipClientBase client, GroupCallCenterDistinctiveRingingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the distinctive ringing configuration values for call center.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following element is only used in AS data mode and ignored in XS data mode:
        /// distinctiveRingingForceDeliveryRingPattern
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterDistinctiveRingingModifyRequestAsync(this OcipClientBase client, GroupCallCenterDistinctiveRingingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the group branding information.
        /// The response is either GroupCallCenterEnhancedReportingBrandingGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingBrandingGetRequestAsync instead.")]
        public static async Task<GroupCallCenterEnhancedReportingBrandingGetResponse> GroupCallCenterEnhancedReportingBrandingGetRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingBrandingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterEnhancedReportingBrandingGetResponse;
        }

        /// <summary>
        /// Request to get the group branding information.
        /// The response is either GroupCallCenterEnhancedReportingBrandingGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingBrandingGetResponse> GroupCallCenterEnhancedReportingBrandingGetRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingBrandingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterEnhancedReportingBrandingGetResponse;
        }
        /// <summary>
        /// Request to modify the group branding configuration.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingBrandingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingBrandingModifyRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingBrandingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the group branding configuration.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingBrandingModifyRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingBrandingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all enabled call center report template for a group.
        /// The response is either a GroupCallCenterEnhancedReportingGetAvailableReportTemplateListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingGetAvailableReportTemplateListRequestAsync instead.")]
        public static async Task<GroupCallCenterEnhancedReportingGetAvailableReportTemplateListResponse> GroupCallCenterEnhancedReportingGetAvailableReportTemplateListRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingGetAvailableReportTemplateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterEnhancedReportingGetAvailableReportTemplateListResponse;
        }

        /// <summary>
        /// Request to get all enabled call center report template for a group.
        /// The response is either a GroupCallCenterEnhancedReportingGetAvailableReportTemplateListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingGetAvailableReportTemplateListResponse> GroupCallCenterEnhancedReportingGetAvailableReportTemplateListRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingGetAvailableReportTemplateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterEnhancedReportingGetAvailableReportTemplateListResponse;
        }
        /// <summary>
        /// Request to get a group level call center enhanced reporting setting.
        /// The response is either a GroupCallCenterEnhancedReportingGetResponse19 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingGetRequest19Async instead.")]
        public static async Task<GroupCallCenterEnhancedReportingGetResponse19> GroupCallCenterEnhancedReportingGetRequest19(this OcipClientBase client, GroupCallCenterEnhancedReportingGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterEnhancedReportingGetResponse19;
        }

        /// <summary>
        /// Request to get a group level call center enhanced reporting setting.
        /// The response is either a GroupCallCenterEnhancedReportingGetResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingGetResponse19> GroupCallCenterEnhancedReportingGetRequest19Async(this OcipClientBase client, GroupCallCenterEnhancedReportingGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterEnhancedReportingGetResponse19;
        }
        /// <summary>
        /// Request to modify group level call center enhanced reporting settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingModifyRequest19Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingModifyRequest19(this OcipClientBase client, GroupCallCenterEnhancedReportingModifyRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify group level call center enhanced reporting settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingModifyRequest19Async(this OcipClientBase client, GroupCallCenterEnhancedReportingModifyRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a group level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingReportTemplateAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingReportTemplateAddRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingReportTemplateAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a group level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingReportTemplateAddRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingReportTemplateAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a group level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingReportTemplateDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingReportTemplateDeleteRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingReportTemplateDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a group level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingReportTemplateDeleteRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingReportTemplateDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get group level call center report template list.
        /// The response is either a GroupCallCenterEnhancedReportingReportTemplateGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingReportTemplateGetListRequestAsync instead.")]
        public static async Task<GroupCallCenterEnhancedReportingReportTemplateGetListResponse> GroupCallCenterEnhancedReportingReportTemplateGetListRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingReportTemplateGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterEnhancedReportingReportTemplateGetListResponse;
        }

        /// <summary>
        /// Request to get group level call center report template list.
        /// The response is either a GroupCallCenterEnhancedReportingReportTemplateGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingReportTemplateGetListResponse> GroupCallCenterEnhancedReportingReportTemplateGetListRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingReportTemplateGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterEnhancedReportingReportTemplateGetListResponse;
        }
        /// <summary>
        /// Request to get a group level call center report template.
        /// The response is either a GroupCallCenterEnhancedReportingReportTemplateGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingReportTemplateGetRequestAsync instead.")]
        public static async Task<GroupCallCenterEnhancedReportingReportTemplateGetResponse> GroupCallCenterEnhancedReportingReportTemplateGetRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingReportTemplateGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterEnhancedReportingReportTemplateGetResponse;
        }

        /// <summary>
        /// Request to get a group level call center report template.
        /// The response is either a GroupCallCenterEnhancedReportingReportTemplateGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingReportTemplateGetResponse> GroupCallCenterEnhancedReportingReportTemplateGetRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingReportTemplateGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterEnhancedReportingReportTemplateGetResponse;
        }
        /// <summary>
        /// Request to modify a group level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingReportTemplateModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingReportTemplateModifyRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingReportTemplateModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a group level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingReportTemplateModifyRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingReportTemplateModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a group level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingScheduledReportAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingScheduledReportAddRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a group level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingScheduledReportAddRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a group level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingScheduledReportDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingScheduledReportDeleteRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a group level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingScheduledReportDeleteRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of active group level call center reporting scheduled reports.
        /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetActiveListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingScheduledReportGetActiveListRequestAsync instead.")]
        public static async Task<GroupCallCenterEnhancedReportingScheduledReportGetActiveListResponse> GroupCallCenterEnhancedReportingScheduledReportGetActiveListRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportGetActiveListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterEnhancedReportingScheduledReportGetActiveListResponse;
        }

        /// <summary>
        /// Request to get a list of active group level call center reporting scheduled reports.
        /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetActiveListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingScheduledReportGetActiveListResponse> GroupCallCenterEnhancedReportingScheduledReportGetActiveListRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportGetActiveListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterEnhancedReportingScheduledReportGetActiveListResponse;
        }
        /// <summary>
        /// Request to get a list of completed group level call center reporting scheduled reports.
        /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetCompletedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingScheduledReportGetCompletedListRequestAsync instead.")]
        public static async Task<GroupCallCenterEnhancedReportingScheduledReportGetCompletedListResponse> GroupCallCenterEnhancedReportingScheduledReportGetCompletedListRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportGetCompletedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterEnhancedReportingScheduledReportGetCompletedListResponse;
        }

        /// <summary>
        /// Request to get a list of completed group level call center reporting scheduled reports.
        /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetCompletedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingScheduledReportGetCompletedListResponse> GroupCallCenterEnhancedReportingScheduledReportGetCompletedListRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportGetCompletedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterEnhancedReportingScheduledReportGetCompletedListResponse;
        }
        /// <summary>
        /// Request to get a list of group level call center reporting scheduled reports.
        /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingScheduledReportGetListRequestAsync instead.")]
        public static async Task<GroupCallCenterEnhancedReportingScheduledReportGetListResponse> GroupCallCenterEnhancedReportingScheduledReportGetListRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterEnhancedReportingScheduledReportGetListResponse;
        }

        /// <summary>
        /// Request to get a list of group level call center reporting scheduled reports.
        /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingScheduledReportGetListResponse> GroupCallCenterEnhancedReportingScheduledReportGetListRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterEnhancedReportingScheduledReportGetListResponse;
        }
        /// <summary>
        /// Request to get all the call center reporting scheduled report in a group that uses a given group level report template.
        /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequestAsync instead.")]
        public static async Task<GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse> GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse;
        }

        /// <summary>
        /// Request to get all the call center reporting scheduled report in a group that uses a given group level report template.
        /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse> GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse;
        }
        /// <summary>
        /// Request to get a group level call center reporting scheduled report.
        /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingScheduledReportGetRequestAsync instead.")]
        public static async Task<GroupCallCenterEnhancedReportingScheduledReportGetResponse> GroupCallCenterEnhancedReportingScheduledReportGetRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterEnhancedReportingScheduledReportGetResponse;
        }

        /// <summary>
        /// Request to get a group level call center reporting scheduled report.
        /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingScheduledReportGetResponse> GroupCallCenterEnhancedReportingScheduledReportGetRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterEnhancedReportingScheduledReportGetResponse;
        }
        /// <summary>
        /// Request to modify a group level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterEnhancedReportingScheduledReportModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingScheduledReportModifyRequest(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a group level call center reporting scheduled report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingScheduledReportModifyRequestAsync(this OcipClientBase client, GroupCallCenterEnhancedReportingScheduledReportModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a call center's forced forwarding settings.
        /// The response is either a GroupCallCenterForcedForwardingGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterForcedForwardingGetRequest20Async instead.")]
        public static async Task<GroupCallCenterForcedForwardingGetResponse20> GroupCallCenterForcedForwardingGetRequest20(this OcipClientBase client, GroupCallCenterForcedForwardingGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterForcedForwardingGetResponse20;
        }

        /// <summary>
        /// Get a call center's forced forwarding settings.
        /// The response is either a GroupCallCenterForcedForwardingGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterForcedForwardingGetResponse20> GroupCallCenterForcedForwardingGetRequest20Async(this OcipClientBase client, GroupCallCenterForcedForwardingGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterForcedForwardingGetResponse20;
        }
        /// <summary>
        /// Modify a call center's forced forwarding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterForcedForwardingModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterForcedForwardingModifyRequest20(this OcipClientBase client, GroupCallCenterForcedForwardingModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's forced forwarding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterForcedForwardingModifyRequest20Async(this OcipClientBase client, GroupCallCenterForcedForwardingModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of agents assigned to a call center.
        /// The response is either a GroupCallCenterGetAgentListResponse or an ErrorResponse.
        /// 
        /// The following element is only used in AS data mode and ignored in XS data mode:
        /// searchCriteriaExactSkillLevel
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetAgentListRequestAsync instead.")]
        public static async Task<GroupCallCenterGetAgentListResponse> GroupCallCenterGetAgentListRequest(this OcipClientBase client, GroupCallCenterGetAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetAgentListResponse;
        }

        /// <summary>
        /// Get a list of agents assigned to a call center.
        /// The response is either a GroupCallCenterGetAgentListResponse or an ErrorResponse.
        /// 
        /// The following element is only used in AS data mode and ignored in XS data mode:
        /// searchCriteriaExactSkillLevel
        /// </summary>
        public static async Task<GroupCallCenterGetAgentListResponse> GroupCallCenterGetAgentListRequestAsync(this OcipClientBase client, GroupCallCenterGetAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetAgentListResponse;
        }
        /// <summary>
        /// Get a list of agents assigned to a call center.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup or searchCriteriaExactSkillLevel have multiple entries and searchCriteriaModeOr is not included.
        /// 
        /// Sorting is done on either a priority basis or a skill basis depending on the type of call center.
        /// 
        /// The response is either a GroupCallCenterGetAgentPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetAgentPagedSortedListRequestAsync instead.")]
        public static async Task<GroupCallCenterGetAgentPagedSortedListResponse> GroupCallCenterGetAgentPagedSortedListRequest(this OcipClientBase client, GroupCallCenterGetAgentPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetAgentPagedSortedListResponse;
        }

        /// <summary>
        /// Get a list of agents assigned to a call center.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup or searchCriteriaExactSkillLevel have multiple entries and searchCriteriaModeOr is not included.
        /// 
        /// Sorting is done on either a priority basis or a skill basis depending on the type of call center.
        /// 
        /// The response is either a GroupCallCenterGetAgentPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAgentPagedSortedListResponse> GroupCallCenterGetAgentPagedSortedListRequestAsync(this OcipClientBase client, GroupCallCenterGetAgentPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetAgentPagedSortedListResponse;
        }
        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetAnnouncementRequest22Async instead.")]
        public static async Task<GroupCallCenterGetAnnouncementResponse22> GroupCallCenterGetAnnouncementRequest22(this OcipClientBase client, GroupCallCenterGetAnnouncementRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetAnnouncementResponse22;
        }

        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAnnouncementResponse22> GroupCallCenterGetAnnouncementRequest22Async(this OcipClientBase client, GroupCallCenterGetAnnouncementRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetAnnouncementResponse22;
        }
        /// <summary>
        /// Get a list of users that can be assigned as agents to a given type of Call Center.
        /// Searching for users by group only makes sense when the call center is part of an Enterprise.
        /// The response is either GroupCallCenterGetAvailableAgentListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetAvailableAgentListRequestAsync instead.")]
        public static async Task<GroupCallCenterGetAvailableAgentListResponse> GroupCallCenterGetAvailableAgentListRequest(this OcipClientBase client, GroupCallCenterGetAvailableAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetAvailableAgentListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned as agents to a given type of Call Center.
        /// Searching for users by group only makes sense when the call center is part of an Enterprise.
        /// The response is either GroupCallCenterGetAvailableAgentListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAvailableAgentListResponse> GroupCallCenterGetAvailableAgentListRequestAsync(this OcipClientBase client, GroupCallCenterGetAvailableAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetAvailableAgentListResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned as agents to a given type of Call Center.
        /// Searching for users by group only makes sense when the call center is part of an Enterprise.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup has multiple entries and searchCriteriaModeOr is not included.
        /// 
        /// The response is either GroupCallCenterGetAvailableAgentPagedSortedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetAvailableAgentPagedSortedListRequestAsync instead.")]
        public static async Task<GroupCallCenterGetAvailableAgentPagedSortedListResponse> GroupCallCenterGetAvailableAgentPagedSortedListRequest(this OcipClientBase client, GroupCallCenterGetAvailableAgentPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetAvailableAgentPagedSortedListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned as agents to a given type of Call Center.
        /// Searching for users by group only makes sense when the call center is part of an Enterprise.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup has multiple entries and searchCriteriaModeOr is not included.
        /// 
        /// The response is either GroupCallCenterGetAvailableAgentPagedSortedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAvailableAgentPagedSortedListResponse> GroupCallCenterGetAvailableAgentPagedSortedListRequestAsync(this OcipClientBase client, GroupCallCenterGetAvailableAgentPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetAvailableAgentPagedSortedListResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned as supervisors to a Call Center.
        /// Searching for users by group only makes sense when the call center is part of an Enterprise.
        /// The response is either GroupCallCenterGetAvailableSupervisorListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetAvailableSupervisorListRequestAsync instead.")]
        public static async Task<GroupCallCenterGetAvailableSupervisorListResponse> GroupCallCenterGetAvailableSupervisorListRequest(this OcipClientBase client, GroupCallCenterGetAvailableSupervisorListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetAvailableSupervisorListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned as supervisors to a Call Center.
        /// Searching for users by group only makes sense when the call center is part of an Enterprise.
        /// The response is either GroupCallCenterGetAvailableSupervisorListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAvailableSupervisorListResponse> GroupCallCenterGetAvailableSupervisorListRequestAsync(this OcipClientBase client, GroupCallCenterGetAvailableSupervisorListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetAvailableSupervisorListResponse;
        }
        /// <summary>
        /// Get the distinctive ringing configuration values for call center.
        /// The response is either a GroupCallCenterGetDistinctiveRingingResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetDistinctiveRingingRequestAsync instead.")]
        public static async Task<GroupCallCenterGetDistinctiveRingingResponse> GroupCallCenterGetDistinctiveRingingRequest(this OcipClientBase client, GroupCallCenterGetDistinctiveRingingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetDistinctiveRingingResponse;
        }

        /// <summary>
        /// Get the distinctive ringing configuration values for call center.
        /// The response is either a GroupCallCenterGetDistinctiveRingingResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetDistinctiveRingingResponse> GroupCallCenterGetDistinctiveRingingRequestAsync(this OcipClientBase client, GroupCallCenterGetDistinctiveRingingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetDistinctiveRingingResponse;
        }
        /// <summary>
        /// Get a list of agent who selected the DNIS as the outgoing call.
        /// The response is either GroupCallCenterGetDNISAgentListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetDNISAgentListRequestAsync instead.")]
        public static async Task<GroupCallCenterGetDNISAgentListResponse> GroupCallCenterGetDNISAgentListRequest(this OcipClientBase client, GroupCallCenterGetDNISAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetDNISAgentListResponse;
        }

        /// <summary>
        /// Get a list of agent who selected the DNIS as the outgoing call.
        /// The response is either GroupCallCenterGetDNISAgentListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetDNISAgentListResponse> GroupCallCenterGetDNISAgentListRequestAsync(this OcipClientBase client, GroupCallCenterGetDNISAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetDNISAgentListResponse;
        }
        /// <summary>
        /// Get a call center's DNIS Announcements
        /// The response is either a GroupCallCenterGetDNISAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetDNISAnnouncementRequest20Async instead.")]
        public static async Task<GroupCallCenterGetDNISAnnouncementResponse20> GroupCallCenterGetDNISAnnouncementRequest20(this OcipClientBase client, GroupCallCenterGetDNISAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetDNISAnnouncementResponse20;
        }

        /// <summary>
        /// Get a call center's DNIS Announcements
        /// The response is either a GroupCallCenterGetDNISAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetDNISAnnouncementResponse20> GroupCallCenterGetDNISAnnouncementRequest20Async(this OcipClientBase client, GroupCallCenterGetDNISAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetDNISAnnouncementResponse20;
        }
        /// <summary>
        /// Get a call center's DNIS Announcements
        /// The response is either a GroupCallCenterGetDNISAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetDNISAnnouncementRequest22Async instead.")]
        public static async Task<GroupCallCenterGetDNISAnnouncementResponse22> GroupCallCenterGetDNISAnnouncementRequest22(this OcipClientBase client, GroupCallCenterGetDNISAnnouncementRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetDNISAnnouncementResponse22;
        }

        /// <summary>
        /// Get a call center's DNIS Announcements
        /// The response is either a GroupCallCenterGetDNISAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetDNISAnnouncementResponse22> GroupCallCenterGetDNISAnnouncementRequest22Async(this OcipClientBase client, GroupCallCenterGetDNISAnnouncementRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetDNISAnnouncementResponse22;
        }
        /// <summary>
        /// Get a list of DNIS that are configured for a Call Center.
        /// The response is either GroupCallCenterGetDNISListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetDNISListRequestAsync instead.")]
        public static async Task<GroupCallCenterGetDNISListResponse> GroupCallCenterGetDNISListRequest(this OcipClientBase client, GroupCallCenterGetDNISListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetDNISListResponse;
        }

        /// <summary>
        /// Get a list of DNIS that are configured for a Call Center.
        /// The response is either GroupCallCenterGetDNISListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetDNISListResponse> GroupCallCenterGetDNISListRequestAsync(this OcipClientBase client, GroupCallCenterGetDNISListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetDNISListResponse;
        }
        /// <summary>
        /// Get a call center's DNIS.
        /// The response is either a GroupCallCenterGetDNISResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetDNISRequestAsync instead.")]
        public static async Task<GroupCallCenterGetDNISResponse> GroupCallCenterGetDNISRequest(this OcipClientBase client, GroupCallCenterGetDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetDNISResponse;
        }

        /// <summary>
        /// Get a call center's DNIS.
        /// The response is either a GroupCallCenterGetDNISResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetDNISResponse> GroupCallCenterGetDNISRequestAsync(this OcipClientBase client, GroupCallCenterGetDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetDNISResponse;
        }
        /// <summary>
        /// Get a list of Call Center instances within a group.
        /// The response is either GroupCallCenterGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetInstanceListRequestAsync instead.")]
        public static async Task<GroupCallCenterGetInstanceListResponse> GroupCallCenterGetInstanceListRequest(this OcipClientBase client, GroupCallCenterGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetInstanceListResponse;
        }

        /// <summary>
        /// Get a list of Call Center instances within a group.
        /// The response is either GroupCallCenterGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceListResponse> GroupCallCenterGetInstanceListRequestAsync(this OcipClientBase client, GroupCallCenterGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetInstanceListResponse;
        }
        /// <summary>
        /// Get a list of Call Center instances within a group.
        /// The response is either GroupCallCenterGetInstancePagedSortedListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactHuntPolicy or searchCriteriaExactCallCenterType have multiple entries and searchCriteriaModeOr is not include.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetInstancePagedSortedListRequestAsync instead.")]
        public static async Task<GroupCallCenterGetInstancePagedSortedListResponse> GroupCallCenterGetInstancePagedSortedListRequest(this OcipClientBase client, GroupCallCenterGetInstancePagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetInstancePagedSortedListResponse;
        }

        /// <summary>
        /// Get a list of Call Center instances within a group.
        /// The response is either GroupCallCenterGetInstancePagedSortedListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactHuntPolicy or searchCriteriaExactCallCenterType have multiple entries and searchCriteriaModeOr is not include.
        /// </summary>
        public static async Task<GroupCallCenterGetInstancePagedSortedListResponse> GroupCallCenterGetInstancePagedSortedListRequestAsync(this OcipClientBase client, GroupCallCenterGetInstancePagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetInstancePagedSortedListResponse;
        }
        /// <summary>
        /// Get Call Center queue status.
        /// The response is either GroupCallCenterGetInstanceQueueStatusResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetInstanceQueueStatusRequestAsync instead.")]
        public static async Task<GroupCallCenterGetInstanceQueueStatusResponse> GroupCallCenterGetInstanceQueueStatusRequest(this OcipClientBase client, GroupCallCenterGetInstanceQueueStatusRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetInstanceQueueStatusResponse;
        }

        /// <summary>
        /// Get Call Center queue status.
        /// The response is either GroupCallCenterGetInstanceQueueStatusResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceQueueStatusResponse> GroupCallCenterGetInstanceQueueStatusRequestAsync(this OcipClientBase client, GroupCallCenterGetInstanceQueueStatusRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetInstanceQueueStatusResponse;
        }
        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetInstanceRequest22Async instead.")]
        public static async Task<GroupCallCenterGetInstanceResponse22> GroupCallCenterGetInstanceRequest22(this OcipClientBase client, GroupCallCenterGetInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetInstanceResponse22;
        }

        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceResponse22> GroupCallCenterGetInstanceRequest22Async(this OcipClientBase client, GroupCallCenterGetInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetInstanceResponse22;
        }
        /// <summary>
        /// Request to get the call center statistics reporting settings.
        /// The response is either GroupCallCenterGetInstanceStatisticsReportingResponse17sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetInstanceStatisticsReportingRequest17sp1Async instead.")]
        public static async Task<GroupCallCenterGetInstanceStatisticsReportingResponse17sp1> GroupCallCenterGetInstanceStatisticsReportingRequest17sp1(this OcipClientBase client, GroupCallCenterGetInstanceStatisticsReportingRequest17sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetInstanceStatisticsReportingResponse17sp1;
        }

        /// <summary>
        /// Request to get the call center statistics reporting settings.
        /// The response is either GroupCallCenterGetInstanceStatisticsReportingResponse17sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceStatisticsReportingResponse17sp1> GroupCallCenterGetInstanceStatisticsReportingRequest17sp1Async(this OcipClientBase client, GroupCallCenterGetInstanceStatisticsReportingRequest17sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetInstanceStatisticsReportingResponse17sp1;
        }
        /// <summary>
        /// Get Call Center queue and agent statistics.
        /// The response is either GroupCallCenterGetInstanceStatisticsResponse14sp9 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetInstanceStatisticsRequest14sp9Async instead.")]
        public static async Task<GroupCallCenterGetInstanceStatisticsResponse14sp9> GroupCallCenterGetInstanceStatisticsRequest14sp9(this OcipClientBase client, GroupCallCenterGetInstanceStatisticsRequest14sp9 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetInstanceStatisticsResponse14sp9;
        }

        /// <summary>
        /// Get Call Center queue and agent statistics.
        /// The response is either GroupCallCenterGetInstanceStatisticsResponse14sp9 or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceStatisticsResponse14sp9> GroupCallCenterGetInstanceStatisticsRequest14sp9Async(this OcipClientBase client, GroupCallCenterGetInstanceStatisticsRequest14sp9 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetInstanceStatisticsResponse14sp9;
        }
        /// <summary>
        /// Request the Group level data associated with Call Center.
        /// The response is either a GroupCallCenterGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetRequest17sp4Async instead.")]
        public static async Task<GroupCallCenterGetResponse17sp4> GroupCallCenterGetRequest17sp4(this OcipClientBase client, GroupCallCenterGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetResponse17sp4;
        }

        /// <summary>
        /// Request the Group level data associated with Call Center.
        /// The response is either a GroupCallCenterGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetResponse17sp4> GroupCallCenterGetRequest17sp4Async(this OcipClientBase client, GroupCallCenterGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetResponse17sp4;
        }
        /// <summary>
        /// Request the group call center routing policy.
        /// The response is either a GroupCallCenterGetRoutingPolicyResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetRoutingPolicyRequestAsync instead.")]
        public static async Task<GroupCallCenterGetRoutingPolicyResponse> GroupCallCenterGetRoutingPolicyRequest(this OcipClientBase client, GroupCallCenterGetRoutingPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetRoutingPolicyResponse;
        }

        /// <summary>
        /// Request the group call center routing policy.
        /// The response is either a GroupCallCenterGetRoutingPolicyResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetRoutingPolicyResponse> GroupCallCenterGetRoutingPolicyRequestAsync(this OcipClientBase client, GroupCallCenterGetRoutingPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetRoutingPolicyResponse;
        }
        /// <summary>
        /// Get a list of supervisors assigned to a call center.
        /// The response is either a GroupCallCenterGetSupervisorListResponse16 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetSupervisorListRequest16Async instead.")]
        public static async Task<GroupCallCenterGetSupervisorListResponse16> GroupCallCenterGetSupervisorListRequest16(this OcipClientBase client, GroupCallCenterGetSupervisorListRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetSupervisorListResponse16;
        }

        /// <summary>
        /// Get a list of supervisors assigned to a call center.
        /// The response is either a GroupCallCenterGetSupervisorListResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetSupervisorListResponse16> GroupCallCenterGetSupervisorListRequest16Async(this OcipClientBase client, GroupCallCenterGetSupervisorListRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetSupervisorListResponse16;
        }
        /// <summary>
        /// Get a list of unlicensed users who are preventing the Call Center from upgrading to another type.
        /// The response is either GroupCallCenterGetUnlicensedAgentListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetUnlicensedAgentListRequestAsync instead.")]
        public static async Task<GroupCallCenterGetUnlicensedAgentListResponse> GroupCallCenterGetUnlicensedAgentListRequest(this OcipClientBase client, GroupCallCenterGetUnlicensedAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetUnlicensedAgentListResponse;
        }

        /// <summary>
        /// Get a list of unlicensed users who are preventing the Call Center from upgrading to another type.
        /// The response is either GroupCallCenterGetUnlicensedAgentListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetUnlicensedAgentListResponse> GroupCallCenterGetUnlicensedAgentListRequestAsync(this OcipClientBase client, GroupCallCenterGetUnlicensedAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetUnlicensedAgentListResponse;
        }
        /// <summary>
        /// Get a call center's holiday service settings.
        /// The response is either a GroupCallCenterHolidayServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterHolidayServiceGetRequest20Async instead.")]
        public static async Task<GroupCallCenterHolidayServiceGetResponse20> GroupCallCenterHolidayServiceGetRequest20(this OcipClientBase client, GroupCallCenterHolidayServiceGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterHolidayServiceGetResponse20;
        }

        /// <summary>
        /// Get a call center's holiday service settings.
        /// The response is either a GroupCallCenterHolidayServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterHolidayServiceGetResponse20> GroupCallCenterHolidayServiceGetRequest20Async(this OcipClientBase client, GroupCallCenterHolidayServiceGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterHolidayServiceGetResponse20;
        }
        /// <summary>
        /// Modify a call center's holiday service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterHolidayServiceModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterHolidayServiceModifyRequest20(this OcipClientBase client, GroupCallCenterHolidayServiceModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's holiday service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterHolidayServiceModifyRequest20Async(this OcipClientBase client, GroupCallCenterHolidayServiceModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to set the active status of Call Center instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyActiveInstanceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyActiveInstanceListRequest(this OcipClientBase client, GroupCallCenterModifyActiveInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of Call Center instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyActiveInstanceListRequestAsync(this OcipClientBase client, GroupCallCenterModifyActiveInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify the agent list for a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// If the agentUserIdList is used for Skill Based Premium call centers,
        /// the agents will be set to skill level 1.
        /// 
        /// The following element is only used in AS data mode and ignored in XS data mode:
        /// skilledAgentUserIdList
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyAgentListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyAgentListRequest(this OcipClientBase client, GroupCallCenterModifyAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the agent list for a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// If the agentUserIdList is used for Skill Based Premium call centers,
        /// the agents will be set to skill level 1.
        /// 
        /// The following element is only used in AS data mode and ignored in XS data mode:
        /// skilledAgentUserIdList
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyAgentListRequestAsync(this OcipClientBase client, GroupCallCenterModifyAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a call center's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyAnnouncementRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyAnnouncementRequest20(this OcipClientBase client, GroupCallCenterModifyAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyAnnouncementRequest20Async(this OcipClientBase client, GroupCallCenterModifyAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the distinctive ringing configuration values for call center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyDistinctiveRingingRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyDistinctiveRingingRequest(this OcipClientBase client, GroupCallCenterModifyDistinctiveRingingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the distinctive ringing configuration values for call center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyDistinctiveRingingRequestAsync(this OcipClientBase client, GroupCallCenterModifyDistinctiveRingingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a call center DNIS announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyDNISAnnouncementRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyDNISAnnouncementRequest20(this OcipClientBase client, GroupCallCenterModifyDNISAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center DNIS announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyDNISAnnouncementRequest20Async(this OcipClientBase client, GroupCallCenterModifyDNISAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the setting that are configured for all the DNIS in a Call Center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyDNISParametersRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyDNISParametersRequest(this OcipClientBase client, GroupCallCenterModifyDNISParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the setting that are configured for all the DNIS in a Call Center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyDNISParametersRequestAsync(this OcipClientBase client, GroupCallCenterModifyDNISParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a call center's DNIS settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyDNISRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyDNISRequest(this OcipClientBase client, GroupCallCenterModifyDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's DNIS settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyDNISRequestAsync(this OcipClientBase client, GroupCallCenterModifyDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a Call Center instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// routingType
        /// enableReporting
        /// allowCallsToAgentsInWrapUp
        /// overrideAgentWrapUpTime
        /// wrapUpSeconds
        /// forceDeliveryOfCalls
        /// forceDeliveryWaitTimeSeconds
        /// enableAutomaticStateChangeForAgents
        /// agentStateAfterCall
        /// agentUnavailableCode
        /// callCenterQueueThresholdsIsActive
        /// networkClassOfService
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceRequest22(this OcipClientBase client, GroupCallCenterModifyInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Call Center instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// routingType
        /// enableReporting
        /// allowCallsToAgentsInWrapUp
        /// overrideAgentWrapUpTime
        /// wrapUpSeconds
        /// forceDeliveryOfCalls
        /// forceDeliveryWaitTimeSeconds
        /// enableAutomaticStateChangeForAgents
        /// agentStateAfterCall
        /// agentUnavailableCode
        /// callCenterQueueThresholdsIsActive
        /// networkClassOfService
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceRequest22Async(this OcipClientBase client, GroupCallCenterModifyInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the Call Center statistics reporting frequency and destination.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyInstanceStatisticsReportingRequest17sp1Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceStatisticsReportingRequest17sp1(this OcipClientBase client, GroupCallCenterModifyInstanceStatisticsReportingRequest17sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Center statistics reporting frequency and destination.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceStatisticsReportingRequest17sp1Async(this OcipClientBase client, GroupCallCenterModifyInstanceStatisticsReportingRequest17sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify the weighted call distribution of a Call Center instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyInstanceWeightedCallDistributionRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceWeightedCallDistributionRequest(this OcipClientBase client, GroupCallCenterModifyInstanceWeightedCallDistributionRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the weighted call distribution of a Call Center instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceWeightedCallDistributionRequestAsync(this OcipClientBase client, GroupCallCenterModifyInstanceWeightedCallDistributionRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the group level data associated with Call Center and
        /// the active status of Call Center instances.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useSystemDefaultUnavailableSettings
        /// forceAgentUnavailableOnDNDActivation
        /// forceAgentUnavailableOnPersonalCalls
        /// forceAgentUnavailableOnBouncedCallLimit
        /// numberConsecutiveBouncedCallsToForceAgentUnavailable
        /// forceAgentUnavailableOnNotReachable
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyRequest(this OcipClientBase client, GroupCallCenterModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level data associated with Call Center and
        /// the active status of Call Center instances.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useSystemDefaultUnavailableSettings
        /// forceAgentUnavailableOnDNDActivation
        /// forceAgentUnavailableOnPersonalCalls
        /// forceAgentUnavailableOnBouncedCallLimit
        /// numberConsecutiveBouncedCallsToForceAgentUnavailable
        /// forceAgentUnavailableOnNotReachable
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyRequestAsync(this OcipClientBase client, GroupCallCenterModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the group call center routing policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyRoutingPolicyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyRoutingPolicyRequest(this OcipClientBase client, GroupCallCenterModifyRoutingPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group call center routing policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyRoutingPolicyRequestAsync(this OcipClientBase client, GroupCallCenterModifyRoutingPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify the supervisor list for a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifySupervisorListRequest16Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifySupervisorListRequest16(this OcipClientBase client, GroupCallCenterModifySupervisorListRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the supervisor list for a call center.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifySupervisorListRequest16Async(this OcipClientBase client, GroupCallCenterModifySupervisorListRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a call center's night service settings.
        /// The response is either a GroupCallCenterNightServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterNightServiceGetRequest20Async instead.")]
        public static async Task<GroupCallCenterNightServiceGetResponse20> GroupCallCenterNightServiceGetRequest20(this OcipClientBase client, GroupCallCenterNightServiceGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterNightServiceGetResponse20;
        }

        /// <summary>
        /// Get a call center's night service settings.
        /// The response is either a GroupCallCenterNightServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterNightServiceGetResponse20> GroupCallCenterNightServiceGetRequest20Async(this OcipClientBase client, GroupCallCenterNightServiceGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterNightServiceGetResponse20;
        }
        /// <summary>
        /// Modify a call center's night service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterNightServiceModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterNightServiceModifyRequest20(this OcipClientBase client, GroupCallCenterNightServiceModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's night service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterNightServiceModifyRequest20Async(this OcipClientBase client, GroupCallCenterNightServiceModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a call center's overflow settings.
        /// The response is either a GroupCallCenterOverflowGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterOverflowGetRequest20Async instead.")]
        public static async Task<GroupCallCenterOverflowGetResponse20> GroupCallCenterOverflowGetRequest20(this OcipClientBase client, GroupCallCenterOverflowGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterOverflowGetResponse20;
        }

        /// <summary>
        /// Get a call center's overflow settings.
        /// The response is either a GroupCallCenterOverflowGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterOverflowGetResponse20> GroupCallCenterOverflowGetRequest20Async(this OcipClientBase client, GroupCallCenterOverflowGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterOverflowGetResponse20;
        }
        /// <summary>
        /// Modify a call center's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterOverflowModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterOverflowModifyRequest20(this OcipClientBase client, GroupCallCenterOverflowModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterOverflowModifyRequest20Async(this OcipClientBase client, GroupCallCenterOverflowModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueCallDispositionCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterQueueCallDispositionCodeAddRequest(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterQueueCallDispositionCodeAddRequestAsync(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueCallDispositionCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterQueueCallDispositionCodeDeleteRequest(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterQueueCallDispositionCodeDeleteRequestAsync(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Call Center Level and Organization Level Call Disposition Codes.
        /// The response is either GroupCallCenterQueueCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueCallDispositionCodeGetListRequestAsync instead.")]
        public static async Task<GroupCallCenterQueueCallDispositionCodeGetListResponse> GroupCallCenterQueueCallDispositionCodeGetListRequest(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterQueueCallDispositionCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of Call Center Level and Organization Level Call Disposition Codes.
        /// The response is either GroupCallCenterQueueCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterQueueCallDispositionCodeGetListResponse> GroupCallCenterQueueCallDispositionCodeGetListRequestAsync(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterQueueCallDispositionCodeGetListResponse;
        }
        /// <summary>
        /// Get a Call Center Call Disposition Code.
        /// The response is either GroupCallCenterQueueCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueCallDispositionCodeGetRequestAsync instead.")]
        public static async Task<GroupCallCenterQueueCallDispositionCodeGetResponse> GroupCallCenterQueueCallDispositionCodeGetRequest(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterQueueCallDispositionCodeGetResponse;
        }

        /// <summary>
        /// Get a Call Center Call Disposition Code.
        /// The response is either GroupCallCenterQueueCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterQueueCallDispositionCodeGetResponse> GroupCallCenterQueueCallDispositionCodeGetRequestAsync(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterQueueCallDispositionCodeGetResponse;
        }
        /// <summary>
        /// Modify a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueCallDispositionCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterQueueCallDispositionCodeModifyRequest(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Call Center Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterQueueCallDispositionCodeModifyRequestAsync(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Call Center Call Disposition Code Settings.
        /// The response is either a GroupCallCenterQueueCallDispositionCodeSettingsGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueCallDispositionCodeSettingsGetRequestAsync instead.")]
        public static async Task<GroupCallCenterQueueCallDispositionCodeSettingsGetResponse> GroupCallCenterQueueCallDispositionCodeSettingsGetRequest(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeSettingsGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterQueueCallDispositionCodeSettingsGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Call Center Call Disposition Code Settings.
        /// The response is either a GroupCallCenterQueueCallDispositionCodeSettingsGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterQueueCallDispositionCodeSettingsGetResponse> GroupCallCenterQueueCallDispositionCodeSettingsGetRequestAsync(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeSettingsGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterQueueCallDispositionCodeSettingsGetResponse;
        }
        /// <summary>
        /// Modify the enterprise level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueCallDispositionCodeSettingsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterQueueCallDispositionCodeSettingsModifyRequest(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeSettingsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the enterprise level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterQueueCallDispositionCodeSettingsModifyRequestAsync(this OcipClientBase client, GroupCallCenterQueueCallDispositionCodeSettingsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the status configuration for a given call center.
        /// The response is either a GroupCallCenterQueueStatusNotificationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueStatusNotificationGetRequestAsync instead.")]
        public static async Task<GroupCallCenterQueueStatusNotificationGetResponse> GroupCallCenterQueueStatusNotificationGetRequest(this OcipClientBase client, GroupCallCenterQueueStatusNotificationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterQueueStatusNotificationGetResponse;
        }

        /// <summary>
        /// Get the status configuration for a given call center.
        /// The response is either a GroupCallCenterQueueStatusNotificationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterQueueStatusNotificationGetResponse> GroupCallCenterQueueStatusNotificationGetRequestAsync(this OcipClientBase client, GroupCallCenterQueueStatusNotificationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterQueueStatusNotificationGetResponse;
        }
        /// <summary>
        /// Set the status configuration for a given call center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueStatusNotificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterQueueStatusNotificationModifyRequest(this OcipClientBase client, GroupCallCenterQueueStatusNotificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Set the status configuration for a given call center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterQueueStatusNotificationModifyRequestAsync(this OcipClientBase client, GroupCallCenterQueueStatusNotificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a call center's queue Thresholds settings.
        /// The response is either a GroupCallCenterQueueThresholdsGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueThresholdsGetRequestAsync instead.")]
        public static async Task<GroupCallCenterQueueThresholdsGetResponse> GroupCallCenterQueueThresholdsGetRequest(this OcipClientBase client, GroupCallCenterQueueThresholdsGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterQueueThresholdsGetResponse;
        }

        /// <summary>
        /// Get a call center's queue Thresholds settings.
        /// The response is either a GroupCallCenterQueueThresholdsGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterQueueThresholdsGetResponse> GroupCallCenterQueueThresholdsGetRequestAsync(this OcipClientBase client, GroupCallCenterQueueThresholdsGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterQueueThresholdsGetResponse;
        }
        /// <summary>
        /// Modify a call center's queue Thresholds settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterQueueThresholdsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterQueueThresholdsModifyRequest(this OcipClientBase client, GroupCallCenterQueueThresholdsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's queue Thresholds settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterQueueThresholdsModifyRequestAsync(this OcipClientBase client, GroupCallCenterQueueThresholdsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a call center's stranded call settings.
        /// The response is either a GroupCallCenterStrandedCallGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterStrandedCallGetRequest20Async instead.")]
        public static async Task<GroupCallCenterStrandedCallGetResponse20> GroupCallCenterStrandedCallGetRequest20(this OcipClientBase client, GroupCallCenterStrandedCallGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterStrandedCallGetResponse20;
        }

        /// <summary>
        /// Get a call center's stranded call settings.
        /// The response is either a GroupCallCenterStrandedCallGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterStrandedCallGetResponse20> GroupCallCenterStrandedCallGetRequest20Async(this OcipClientBase client, GroupCallCenterStrandedCallGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterStrandedCallGetResponse20;
        }
        /// <summary>
        /// Modify a call center's stranded call settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterStrandedCallModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterStrandedCallModifyRequest20(this OcipClientBase client, GroupCallCenterStrandedCallModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's stranded call settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterStrandedCallModifyRequest20Async(this OcipClientBase client, GroupCallCenterStrandedCallModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a call center's stranded calls - unavailable settings.
        /// The response is either a GroupCallCenterStrandedCallUnavailableGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterStrandedCallUnavailableGetRequest20Async instead.")]
        public static async Task<GroupCallCenterStrandedCallUnavailableGetResponse> GroupCallCenterStrandedCallUnavailableGetRequest20(this OcipClientBase client, GroupCallCenterStrandedCallUnavailableGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterStrandedCallUnavailableGetResponse;
        }

        /// <summary>
        /// Get a call center's stranded calls - unavailable settings.
        /// The response is either a GroupCallCenterStrandedCallUnavailableGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterStrandedCallUnavailableGetResponse> GroupCallCenterStrandedCallUnavailableGetRequest20Async(this OcipClientBase client, GroupCallCenterStrandedCallUnavailableGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterStrandedCallUnavailableGetResponse;
        }
        /// <summary>
        /// Modify a call center's stranded calls - unavailable settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterStrandedCallUnavailableModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterStrandedCallUnavailableModifyRequest20(this OcipClientBase client, GroupCallCenterStrandedCallUnavailableModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's stranded calls - unavailable settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterStrandedCallUnavailableModifyRequest20Async(this OcipClientBase client, GroupCallCenterStrandedCallUnavailableModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the reseller level data associated with Call Center.
        /// The response is either a ResellerCallCenterGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallCenterGetRequestAsync instead.")]
        public static async Task<ResellerCallCenterGetResponse> ResellerCallCenterGetRequest(this OcipClientBase client, ResellerCallCenterGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerCallCenterGetResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Call Center.
        /// The response is either a ResellerCallCenterGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ResellerCallCenterGetResponse> ResellerCallCenterGetRequestAsync(this OcipClientBase client, ResellerCallCenterGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerCallCenterGetResponse;
        }
        /// <summary>
        /// Modify the reseller level data associated with Call Center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallCenterModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerCallCenterModifyRequest(this OcipClientBase client, ResellerCallCenterModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Call Center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerCallCenterModifyRequestAsync(this OcipClientBase client, ResellerCallCenterModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the system branding information.
        /// The response is either SystemCallCenterEnhancedReportingBrandingGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingBrandingGetRequestAsync instead.")]
        public static async Task<SystemCallCenterEnhancedReportingBrandingGetResponse> SystemCallCenterEnhancedReportingBrandingGetRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingBrandingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterEnhancedReportingBrandingGetResponse;
        }

        /// <summary>
        /// Request to get the system branding information.
        /// The response is either SystemCallCenterEnhancedReportingBrandingGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterEnhancedReportingBrandingGetResponse> SystemCallCenterEnhancedReportingBrandingGetRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingBrandingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterEnhancedReportingBrandingGetResponse;
        }
        /// <summary>
        /// Request to modify the system branding configuration.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingBrandingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingBrandingModifyRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingBrandingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system branding configuration.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingBrandingModifyRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingBrandingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of data template and the corresponding information in the system.
        /// The response is either a SystemCallCenterEnhancedReportingDataTemplateGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingDataTemplateGetListRequestAsync instead.")]
        public static async Task<SystemCallCenterEnhancedReportingDataTemplateGetListResponse> SystemCallCenterEnhancedReportingDataTemplateGetListRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingDataTemplateGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterEnhancedReportingDataTemplateGetListResponse;
        }

        /// <summary>
        /// Request to get the list of data template and the corresponding information in the system.
        /// The response is either a SystemCallCenterEnhancedReportingDataTemplateGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterEnhancedReportingDataTemplateGetListResponse> SystemCallCenterEnhancedReportingDataTemplateGetListRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingDataTemplateGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterEnhancedReportingDataTemplateGetListResponse;
        }
        /// <summary>
        /// Request to get the call center enhanced reporting system settings.
        /// The response is either a SystemCallCenterEnhancedReportingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingGetRequestAsync instead.")]
        public static async Task<SystemCallCenterEnhancedReportingGetResponse> SystemCallCenterEnhancedReportingGetRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterEnhancedReportingGetResponse;
        }

        /// <summary>
        /// Request to get the call center enhanced reporting system settings.
        /// The response is either a SystemCallCenterEnhancedReportingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterEnhancedReportingGetResponse> SystemCallCenterEnhancedReportingGetRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterEnhancedReportingGetResponse;
        }
        /// <summary>
        /// Modify the system settings for call center enhanced reporting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingModifyRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system settings for call center enhanced reporting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingModifyRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a system level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingReportTemplateAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingReportTemplateAddRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingReportTemplateAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingReportTemplateAddRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingReportTemplateAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a system level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingReportTemplateDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingReportTemplateDeleteRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingReportTemplateDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a system level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingReportTemplateDeleteRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingReportTemplateDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get system level call center report template list.
        /// The response is either a SystemCallCenterEnhancedReportingReportTemplateGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingReportTemplateGetListRequestAsync instead.")]
        public static async Task<SystemCallCenterEnhancedReportingReportTemplateGetListResponse> SystemCallCenterEnhancedReportingReportTemplateGetListRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingReportTemplateGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterEnhancedReportingReportTemplateGetListResponse;
        }

        /// <summary>
        /// Request to get system level call center report template list.
        /// The response is either a SystemCallCenterEnhancedReportingReportTemplateGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterEnhancedReportingReportTemplateGetListResponse> SystemCallCenterEnhancedReportingReportTemplateGetListRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingReportTemplateGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterEnhancedReportingReportTemplateGetListResponse;
        }
        /// <summary>
        /// Request to get a system level call center report template.
        /// The response is either a SystemCallCenterEnhancedReportingReportTemplateGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingReportTemplateGetRequestAsync instead.")]
        public static async Task<SystemCallCenterEnhancedReportingReportTemplateGetResponse> SystemCallCenterEnhancedReportingReportTemplateGetRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingReportTemplateGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterEnhancedReportingReportTemplateGetResponse;
        }

        /// <summary>
        /// Request to get a system level call center report template.
        /// The response is either a SystemCallCenterEnhancedReportingReportTemplateGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterEnhancedReportingReportTemplateGetResponse> SystemCallCenterEnhancedReportingReportTemplateGetRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingReportTemplateGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterEnhancedReportingReportTemplateGetResponse;
        }
        /// <summary>
        /// Request to modify a system level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingReportTemplateModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingReportTemplateModifyRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingReportTemplateModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a system level call center report template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingReportTemplateModifyRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingReportTemplateModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of all active call center reporting scheduled reports in the system.
        /// The response is either a SystemCallCenterEnhancedReportingScheduledReportGetActiveListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingScheduledReportGetActiveListRequestAsync instead.")]
        public static async Task<SystemCallCenterEnhancedReportingScheduledReportGetActiveListResponse> SystemCallCenterEnhancedReportingScheduledReportGetActiveListRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledReportGetActiveListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterEnhancedReportingScheduledReportGetActiveListResponse;
        }

        /// <summary>
        /// Request to get the list of all active call center reporting scheduled reports in the system.
        /// The response is either a SystemCallCenterEnhancedReportingScheduledReportGetActiveListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterEnhancedReportingScheduledReportGetActiveListResponse> SystemCallCenterEnhancedReportingScheduledReportGetActiveListRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledReportGetActiveListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterEnhancedReportingScheduledReportGetActiveListResponse;
        }
        /// <summary>
        /// Request to get the list of all completed call center reporting scheduled reports in the system.
        /// The response is either a SystemCallCenterEnhancedReportingScheduledReportGetCompletedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingScheduledReportGetCompletedListRequestAsync instead.")]
        public static async Task<SystemCallCenterEnhancedReportingScheduledReportGetCompletedListResponse> SystemCallCenterEnhancedReportingScheduledReportGetCompletedListRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledReportGetCompletedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterEnhancedReportingScheduledReportGetCompletedListResponse;
        }

        /// <summary>
        /// Request to get the list of all completed call center reporting scheduled reports in the system.
        /// The response is either a SystemCallCenterEnhancedReportingScheduledReportGetCompletedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterEnhancedReportingScheduledReportGetCompletedListResponse> SystemCallCenterEnhancedReportingScheduledReportGetCompletedListRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledReportGetCompletedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterEnhancedReportingScheduledReportGetCompletedListResponse;
        }
        /// <summary>
        /// Request to get the list of all call center reporting scheduled reports in the system.
        /// The response is either an SystemCallCenterEnhancedReportingScheduledReportGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingScheduledReportGetListRequestAsync instead.")]
        public static async Task<SystemCallCenterEnhancedReportingScheduledReportGetListResponse> SystemCallCenterEnhancedReportingScheduledReportGetListRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledReportGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterEnhancedReportingScheduledReportGetListResponse;
        }

        /// <summary>
        /// Request to get the list of all call center reporting scheduled reports in the system.
        /// The response is either an SystemCallCenterEnhancedReportingScheduledReportGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterEnhancedReportingScheduledReportGetListResponse> SystemCallCenterEnhancedReportingScheduledReportGetListRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledReportGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterEnhancedReportingScheduledReportGetListResponse;
        }
        /// <summary>
        /// Request to get all the call center reporting scheduled report in the system that uses a
        /// given system level report template.
        /// The response is either a SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequestAsync instead.")]
        public static async Task<SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse> SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse;
        }

        /// <summary>
        /// Request to get all the call center reporting scheduled report in the system that uses a
        /// given system level report template.
        /// The response is either a SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse> SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse;
        }
        /// <summary>
        /// Request to get the system settings for the call center enhanced reporting scheduling tasks.
        /// The response is either a SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequestAsync instead.")]
        public static async Task<SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse> SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse;
        }

        /// <summary>
        /// Request to get the system settings for the call center enhanced reporting scheduling tasks.
        /// The response is either a SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse> SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse;
        }
        /// <summary>
        /// Modify the system settings for the call center enhanced reporting scheduling tasks.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterEnhancedReportingScheduledTaskParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingScheduledTaskParametersModifyRequest(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledTaskParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system settings for the call center enhanced reporting scheduling tasks.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallCenterEnhancedReportingScheduledTaskParametersModifyRequestAsync(this OcipClientBase client, SystemCallCenterEnhancedReportingScheduledTaskParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Call Center.
        /// The response is either a SystemCallCenterGetResponse21 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterGetRequest21Async instead.")]
        public static async Task<SystemCallCenterGetResponse21> SystemCallCenterGetRequest21(this OcipClientBase client, SystemCallCenterGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallCenterGetResponse21;
        }

        /// <summary>
        /// Request the system level data associated with Call Center.
        /// The response is either a SystemCallCenterGetResponse21 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterGetResponse21> SystemCallCenterGetRequest21Async(this OcipClientBase client, SystemCallCenterGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallCenterGetResponse21;
        }
        /// <summary>
        /// Modify the system level data associated with Call Center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify data mode:
        /// callHandlingSamplingPeriodMinutes
        /// callHandlingMinimumSamplingSize
        /// thresholdCrossingNotificationEmailGuardTimerSeconds
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallCenterModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallCenterModifyRequest(this OcipClientBase client, SystemCallCenterModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Call Center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify data mode:
        /// callHandlingSamplingPeriodMinutes
        /// callHandlingMinimumSamplingSize
        /// thresholdCrossingNotificationEmailGuardTimerSeconds
        /// </summary>
        public static async Task<SuccessResponse> SystemCallCenterModifyRequestAsync(this OcipClientBase client, SystemCallCenterModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign agent(s) to a call center supervisor.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterAddSupervisedAgentListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallCenterAddSupervisedAgentListRequest(this OcipClientBase client, UserCallCenterAddSupervisedAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign agent(s) to a call center supervisor.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterAddSupervisedAgentListRequestAsync(this OcipClientBase client, UserCallCenterAddSupervisedAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the detail information of a Call Center Agent. Administrator, supervisor and agent
        /// itself can send this command.
        /// The response is either UserCallCenterAgentDetailsGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterAgentDetailsGetRequestAsync instead.")]
        public static async Task<UserCallCenterAgentDetailsGetResponse> UserCallCenterAgentDetailsGetRequest(this OcipClientBase client, UserCallCenterAgentDetailsGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterAgentDetailsGetResponse;
        }

        /// <summary>
        /// Request to get the detail information of a Call Center Agent. Administrator, supervisor and agent
        /// itself can send this command.
        /// The response is either UserCallCenterAgentDetailsGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterAgentDetailsGetResponse> UserCallCenterAgentDetailsGetRequestAsync(this OcipClientBase client, UserCallCenterAgentDetailsGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterAgentDetailsGetResponse;
        }
        /// <summary>
        /// This request signs-out a call center agent. Administrator, supervisor and agent itself can sign-out an agent.
        /// An empty OCI table in OCI-P response indicates success and the agent has been signed out. This sign-out
        /// command will fail if the agent is the last signed-in agent of any standard or premium call center to
        /// which she is currently joined. If the sign-out fails, the OCI-P response will contain a list of
        /// Call Centers for which the agent is the last signed-in agent.
        /// If this special logic is not needed, UserCallCenterModifyRequest19 can still be used to change
        /// the agents ACD state without checking if the agent is the last signed-in agent.
        /// The response is either a UserCallCenterAgentSignOutResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterAgentSignOutRequestAsync instead.")]
        public static async Task<UserCallCenterAgentSignOutResponse> UserCallCenterAgentSignOutRequest(this OcipClientBase client, UserCallCenterAgentSignOutRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterAgentSignOutResponse;
        }

        /// <summary>
        /// This request signs-out a call center agent. Administrator, supervisor and agent itself can sign-out an agent.
        /// An empty OCI table in OCI-P response indicates success and the agent has been signed out. This sign-out
        /// command will fail if the agent is the last signed-in agent of any standard or premium call center to
        /// which she is currently joined. If the sign-out fails, the OCI-P response will contain a list of
        /// Call Centers for which the agent is the last signed-in agent.
        /// If this special logic is not needed, UserCallCenterModifyRequest19 can still be used to change
        /// the agents ACD state without checking if the agent is the last signed-in agent.
        /// The response is either a UserCallCenterAgentSignOutResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterAgentSignOutResponse> UserCallCenterAgentSignOutRequestAsync(this OcipClientBase client, UserCallCenterAgentSignOutRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterAgentSignOutResponse;
        }
        /// <summary>
        /// Get the list of available Call Center Call Disposition Codes to be used by a client.
        /// The response is either UserCallCenterCallDispositionCodeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterCallDispositionCodeGetAvailableListRequestAsync instead.")]
        public static async Task<UserCallCenterCallDispositionCodeGetAvailableListResponse> UserCallCenterCallDispositionCodeGetAvailableListRequest(this OcipClientBase client, UserCallCenterCallDispositionCodeGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterCallDispositionCodeGetAvailableListResponse;
        }

        /// <summary>
        /// Get the list of available Call Center Call Disposition Codes to be used by a client.
        /// The response is either UserCallCenterCallDispositionCodeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterCallDispositionCodeGetAvailableListResponse> UserCallCenterCallDispositionCodeGetAvailableListRequestAsync(this OcipClientBase client, UserCallCenterCallDispositionCodeGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterCallDispositionCodeGetAvailableListResponse;
        }
        /// <summary>
        /// Delete agent(s) from a call center supervisor.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterDeleteSupervisedAgentListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallCenterDeleteSupervisedAgentListRequest(this OcipClientBase client, UserCallCenterDeleteSupervisedAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete agent(s) from a call center supervisor.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterDeleteSupervisedAgentListRequestAsync(this OcipClientBase client, UserCallCenterDeleteSupervisedAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the input parameter info for a call center report template.
        /// The response is either a UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequestAsync instead.")]
        public static async Task<UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse> UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest(this OcipClientBase client, UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse;
        }

        /// <summary>
        /// Request to get the input parameter info for a call center report template.
        /// The response is either a UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse> UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequestAsync(this OcipClientBase client, UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse;
        }
        /// <summary>
        /// Request to delete a call center reporting scheduled report created by a supervisor.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterEnhancedReportingScheduledReportDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallCenterEnhancedReportingScheduledReportDeleteRequest(this OcipClientBase client, UserCallCenterEnhancedReportingScheduledReportDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a call center reporting scheduled report created by a supervisor.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterEnhancedReportingScheduledReportDeleteRequestAsync(this OcipClientBase client, UserCallCenterEnhancedReportingScheduledReportDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a call center reporting scheduled report created by supervisor.
        /// The response is either a UserCallCenterEnhancedReportingScheduledReportGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterEnhancedReportingScheduledReportGetRequestAsync instead.")]
        public static async Task<UserCallCenterEnhancedReportingScheduledReportGetResponse> UserCallCenterEnhancedReportingScheduledReportGetRequest(this OcipClientBase client, UserCallCenterEnhancedReportingScheduledReportGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterEnhancedReportingScheduledReportGetResponse;
        }

        /// <summary>
        /// Request to get a call center reporting scheduled report created by supervisor.
        /// The response is either a UserCallCenterEnhancedReportingScheduledReportGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterEnhancedReportingScheduledReportGetResponse> UserCallCenterEnhancedReportingScheduledReportGetRequestAsync(this OcipClientBase client, UserCallCenterEnhancedReportingScheduledReportGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterEnhancedReportingScheduledReportGetResponse;
        }
        /// <summary>
        /// Request to modify a call center reporting scheduled report created by a supervisor.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterEnhancedReportingScheduledReportModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallCenterEnhancedReportingScheduledReportModifyRequest(this OcipClientBase client, UserCallCenterEnhancedReportingScheduledReportModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a call center reporting scheduled report created by a supervisor.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterEnhancedReportingScheduledReportModifyRequestAsync(this OcipClientBase client, UserCallCenterEnhancedReportingScheduledReportModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of supervisors for an agent on a given call center.
        /// The response is either a UserCallCenterGetAgentSupervisorListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterGetAgentSupervisorListRequestAsync instead.")]
        public static async Task<UserCallCenterGetAgentSupervisorListResponse> UserCallCenterGetAgentSupervisorListRequest(this OcipClientBase client, UserCallCenterGetAgentSupervisorListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterGetAgentSupervisorListResponse;
        }

        /// <summary>
        /// Get a list of supervisors for an agent on a given call center.
        /// The response is either a UserCallCenterGetAgentSupervisorListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterGetAgentSupervisorListResponse> UserCallCenterGetAgentSupervisorListRequestAsync(this OcipClientBase client, UserCallCenterGetAgentSupervisorListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterGetAgentSupervisorListResponse;
        }
        /// <summary>
        /// This request gets a list of all call centers which the user can be assigned to as an agent.
        /// Some of the call centers may already have the user as an agent.  It is the clients
        /// responsibility to discard the call centers that the user is already an agent of.
        /// The response is either a UserCallCenterGetAvailableCallCenterListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterGetAvailableCallCenterListRequestAsync instead.")]
        public static async Task<UserCallCenterGetAvailableCallCenterListResponse> UserCallCenterGetAvailableCallCenterListRequest(this OcipClientBase client, UserCallCenterGetAvailableCallCenterListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterGetAvailableCallCenterListResponse;
        }

        /// <summary>
        /// This request gets a list of all call centers which the user can be assigned to as an agent.
        /// Some of the call centers may already have the user as an agent.  It is the clients
        /// responsibility to discard the call centers that the user is already an agent of.
        /// The response is either a UserCallCenterGetAvailableCallCenterListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterGetAvailableCallCenterListResponse> UserCallCenterGetAvailableCallCenterListRequestAsync(this OcipClientBase client, UserCallCenterGetAvailableCallCenterListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterGetAvailableCallCenterListResponse;
        }
        /// <summary>
        /// This request gets a list of all call centers which the user can be assigned to as an agent.
        /// Some of the call centers may already have the user as an agent.  It is the clients
        /// responsibility to discard the call centers that the user is already an agent of.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either a UserCallCenterGetAvailableCallCenterPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterGetAvailableCallCenterPagedSortedListRequestAsync instead.")]
        public static async Task<UserCallCenterGetAvailableCallCenterPagedSortedListResponse> UserCallCenterGetAvailableCallCenterPagedSortedListRequest(this OcipClientBase client, UserCallCenterGetAvailableCallCenterPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterGetAvailableCallCenterPagedSortedListResponse;
        }

        /// <summary>
        /// This request gets a list of all call centers which the user can be assigned to as an agent.
        /// Some of the call centers may already have the user as an agent.  It is the clients
        /// responsibility to discard the call centers that the user is already an agent of.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either a UserCallCenterGetAvailableCallCenterPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterGetAvailableCallCenterPagedSortedListResponse> UserCallCenterGetAvailableCallCenterPagedSortedListRequestAsync(this OcipClientBase client, UserCallCenterGetAvailableCallCenterPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterGetAvailableCallCenterPagedSortedListResponse;
        }
        /// <summary>
        /// Request a list of available DNIS for agent to select.
        /// The response is either UserCallCenterGetAvailableDNISListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterGetAvailableDNISListRequestAsync instead.")]
        public static async Task<UserCallCenterGetAvailableDNISListResponse> UserCallCenterGetAvailableDNISListRequest(this OcipClientBase client, UserCallCenterGetAvailableDNISListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterGetAvailableDNISListResponse;
        }

        /// <summary>
        /// Request a list of available DNIS for agent to select.
        /// The response is either UserCallCenterGetAvailableDNISListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterGetAvailableDNISListResponse> UserCallCenterGetAvailableDNISListRequestAsync(this OcipClientBase client, UserCallCenterGetAvailableDNISListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterGetAvailableDNISListResponse;
        }
        /// <summary>
        /// Get the user's call center settings and the list of call centers the specified user belongs to.
        /// The response is either a UserCallCenterGetResponse19 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterGetRequest19Async instead.")]
        public static async Task<UserCallCenterGetResponse19> UserCallCenterGetRequest19(this OcipClientBase client, UserCallCenterGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterGetResponse19;
        }

        /// <summary>
        /// Get the user's call center settings and the list of call centers the specified user belongs to.
        /// The response is either a UserCallCenterGetResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterGetResponse19> UserCallCenterGetRequest19Async(this OcipClientBase client, UserCallCenterGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterGetResponse19;
        }
        /// <summary>
        /// Get a list of agents supervised by a supervisor on a given call
        /// center.
        /// The response is either a UserCallCenterGetSupervisedAgentListResponse
        /// or an ErrorResponse.
        /// The search can be done using multiple criterias.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results. Otherwise, only
        /// results matching all the search criterias are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterGetSupervisedAgentListRequestAsync instead.")]
        public static async Task<UserCallCenterGetSupervisedAgentListResponse> UserCallCenterGetSupervisedAgentListRequest(this OcipClientBase client, UserCallCenterGetSupervisedAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterGetSupervisedAgentListResponse;
        }

        /// <summary>
        /// Get a list of agents supervised by a supervisor on a given call
        /// center.
        /// The response is either a UserCallCenterGetSupervisedAgentListResponse
        /// or an ErrorResponse.
        /// The search can be done using multiple criterias.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results. Otherwise, only
        /// results matching all the search criterias are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterGetSupervisedAgentListResponse> UserCallCenterGetSupervisedAgentListRequestAsync(this OcipClientBase client, UserCallCenterGetSupervisedAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterGetSupervisedAgentListResponse;
        }
        /// <summary>
        /// Get a list of call centers the user is assigned to as a supervisor.
        /// The response is either a UserCallCenterGetSupervisorCallCenterListResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterGetSupervisorCallCenterListRequestAsync instead.")]
        public static async Task<UserCallCenterGetSupervisorCallCenterListResponse> UserCallCenterGetSupervisorCallCenterListRequest(this OcipClientBase client, UserCallCenterGetSupervisorCallCenterListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterGetSupervisorCallCenterListResponse;
        }

        /// <summary>
        /// Get a list of call centers the user is assigned to as a supervisor.
        /// The response is either a UserCallCenterGetSupervisorCallCenterListResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterGetSupervisorCallCenterListResponse> UserCallCenterGetSupervisorCallCenterListRequestAsync(this OcipClientBase client, UserCallCenterGetSupervisorCallCenterListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterGetSupervisorCallCenterListResponse;
        }
        /// <summary>
        /// Request to modify the call center list for an agent.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterModifyCallCenterListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallCenterModifyCallCenterListRequest(this OcipClientBase client, UserCallCenterModifyCallCenterListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the call center list for an agent.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterModifyCallCenterListRequestAsync(this OcipClientBase client, UserCallCenterModifyCallCenterListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modifies the agents call center settings and the availability for an agent in one or more Call Centers.
        /// Contains a list specifying the desired availability status of one or more call centers.
        /// A default unavailable code will be used if the parameter agentUnavailableCode is not active, included or is invalid.
        /// Changing the agentACDState from unavailable to any other state will automatically clear the unavailable code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// agentACDState
        /// agentThresholdProfileName
        /// agentUnavailableCode
        /// useSystemDefaultUnavailableSettings
        /// forceAgentUnavailableOnDNDActivation
        /// forceAgentUnavailableOnPersonalCalls
        /// forceAgentUnavailableOnBouncedCallLimit
        /// numberConsecutiveBouncedCallsToForceAgentUnavailable
        /// forceAgentUnavailableOnNotReachable
        /// makeOutgoingCallsAsCallCenter
        /// outgoingCallDNIS
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterModifyRequest19Async instead.")]
        public static async Task<SuccessResponse> UserCallCenterModifyRequest19(this OcipClientBase client, UserCallCenterModifyRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the agents call center settings and the availability for an agent in one or more Call Centers.
        /// Contains a list specifying the desired availability status of one or more call centers.
        /// A default unavailable code will be used if the parameter agentUnavailableCode is not active, included or is invalid.
        /// Changing the agentACDState from unavailable to any other state will automatically clear the unavailable code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// agentACDState
        /// agentThresholdProfileName
        /// agentUnavailableCode
        /// useSystemDefaultUnavailableSettings
        /// forceAgentUnavailableOnDNDActivation
        /// forceAgentUnavailableOnPersonalCalls
        /// forceAgentUnavailableOnBouncedCallLimit
        /// numberConsecutiveBouncedCallsToForceAgentUnavailable
        /// forceAgentUnavailableOnNotReachable
        /// makeOutgoingCallsAsCallCenter
        /// outgoingCallDNIS
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterModifyRequest19Async(this OcipClientBase client, UserCallCenterModifyRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modifies a list of users to be supervised by a supervisor on a call center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterModifySupervisedAgentListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallCenterModifySupervisedAgentListRequest(this OcipClientBase client, UserCallCenterModifySupervisedAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies a list of users to be supervised by a supervisor on a call center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterModifySupervisedAgentListRequestAsync(this OcipClientBase client, UserCallCenterModifySupervisedAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
