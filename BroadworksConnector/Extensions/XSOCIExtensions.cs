using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class XSOCIExtensions
    {

        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantModifyInstanceExecutionServerRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceExecutionServerRequest(this OcipClientBase client, GroupAutoAttendantModifyInstanceExecutionServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceExecutionServerRequestAsync(this OcipClientBase client, GroupAutoAttendantModifyInstanceExecutionServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupModifyVoicePortalBrandingExecutionServerRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingExecutionServerRequest(this OcipClientBase client, GroupVoiceMessagingGroupModifyVoicePortalBrandingExecutionServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingExecutionServerRequestAsync(this OcipClientBase client, GroupVoiceMessagingGroupModifyVoicePortalBrandingExecutionServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify an existing custom greeting audio file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingModifyConferenceGreetingExecutionServerRequestAsync instead.")]
        public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceGreetingExecutionServerRequest(this OcipClientBase client, UserMeetMeConferencingModifyConferenceGreetingExecutionServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing custom greeting audio file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceGreetingExecutionServerRequestAsync(this OcipClientBase client, UserMeetMeConferencingModifyConferenceGreetingExecutionServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's voice messaging greeting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserModifyGreetingExecutionServerRequestAsync instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyGreetingExecutionServerRequest(this OcipClientBase client, UserVoiceMessagingUserModifyGreetingExecutionServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging greeting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyGreetingExecutionServerRequestAsync(this OcipClientBase client, UserVoiceMessagingUserModifyGreetingExecutionServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution
        /// Server
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserModifyVoicePortalExecutionServerRequestAsync instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoicePortalExecutionServerRequest(this OcipClientBase client, UserVoiceMessagingUserModifyVoicePortalExecutionServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution
        /// Server
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoicePortalExecutionServerRequestAsync(this OcipClientBase client, UserVoiceMessagingUserModifyVoicePortalExecutionServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
