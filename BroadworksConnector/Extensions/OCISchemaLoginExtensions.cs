using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaLoginExtensions
    {

        /// <summary>
        /// AuthenticationVerifyRequest22V2 is used to authenticate a user either by userId/password, userId/sip username/sip password,
        /// dn/passcode, lineport/password or a token previously authorized with the ExternalAuthenticationAuthorizeTokenRequest.
        /// The phone number may be any DN associated with a user.
        /// The lineport may be any lineport associated with a user.
        /// The password used for the lineport is the user's password associated with userId.
        /// 
        /// The response is a AuthenticationVerifyResponse22V2 or an ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use AuthenticationVerifyRequest22V2Async instead.")]
        public static async Task<AuthenticationVerifyResponse22V2> AuthenticationVerifyRequest22V2(this OcipClientBase client, AuthenticationVerifyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as AuthenticationVerifyResponse22V2;
        }

        /// <summary>
        /// AuthenticationVerifyRequest22V2 is used to authenticate a user either by userId/password, userId/sip username/sip password,
        /// dn/passcode, lineport/password or a token previously authorized with the ExternalAuthenticationAuthorizeTokenRequest.
        /// The phone number may be any DN associated with a user.
        /// The lineport may be any lineport associated with a user.
        /// The password used for the lineport is the user's password associated with userId.
        /// 
        /// The response is a AuthenticationVerifyResponse22V2 or an ErrorResponse
        /// </summary>
        public static async Task<AuthenticationVerifyResponse22V2> AuthenticationVerifyRequest22V2Async(this OcipClientBase client, AuthenticationVerifyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as AuthenticationVerifyResponse22V2;
        }
        /// <summary>
        /// AvailabilityTestRequest is for high-availability support. The response is either SuccessResponse
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use AvailabilityTestRequestAsync instead.")]
        public static async Task<SuccessResponse> AvailabilityTestRequest(this OcipClientBase client, AvailabilityTestRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// AvailabilityTestRequest is for high-availability support. The response is either SuccessResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> AvailabilityTestRequestAsync(this OcipClientBase client, AvailabilityTestRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the address and credentials of the File Repository hosting the requested access device file.
        /// Also get the file name and path on the File Repository.
        /// The response is either DeviceManagementFileAuthLocationGetResponse21sp1 or ErrorResponse.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// deviceToken
        /// </summary>
        [Obsolete("This method is deprecated. Use DeviceManagementFileAuthLocationGetRequest21sp1Async instead.")]
        public static async Task<DeviceManagementFileAuthLocationGetResponse21sp1> DeviceManagementFileAuthLocationGetRequest21sp1(this OcipClientBase client, DeviceManagementFileAuthLocationGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as DeviceManagementFileAuthLocationGetResponse21sp1;
        }

        /// <summary>
        /// Get the address and credentials of the File Repository hosting the requested access device file.
        /// Also get the file name and path on the File Repository.
        /// The response is either DeviceManagementFileAuthLocationGetResponse21sp1 or ErrorResponse.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// deviceToken
        /// </summary>
        public static async Task<DeviceManagementFileAuthLocationGetResponse21sp1> DeviceManagementFileAuthLocationGetRequest21sp1Async(this OcipClientBase client, DeviceManagementFileAuthLocationGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as DeviceManagementFileAuthLocationGetResponse21sp1;
        }
        /// <summary>
        /// Get the address and credentials of the File Repository hosting the requested access device file.
        /// Also get the file name and path on the File Repository.
        /// The response is either DeviceManagementFileAuthLocationGetResponse22V2 or ErrorResponse.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// deviceToken
        /// The following elements are only used in XS data mode and will be ignored in AS data mode:
        /// fileNameLookup
        /// fileNameOnDisk
        /// </summary>
        [Obsolete("This method is deprecated. Use DeviceManagementFileAuthLocationGetRequest22V2Async instead.")]
        public static async Task<DeviceManagementFileAuthLocationGetResponse22V2> DeviceManagementFileAuthLocationGetRequest22V2(this OcipClientBase client, DeviceManagementFileAuthLocationGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as DeviceManagementFileAuthLocationGetResponse22V2;
        }

        /// <summary>
        /// Get the address and credentials of the File Repository hosting the requested access device file.
        /// Also get the file name and path on the File Repository.
        /// The response is either DeviceManagementFileAuthLocationGetResponse22V2 or ErrorResponse.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// deviceToken
        /// The following elements are only used in XS data mode and will be ignored in AS data mode:
        /// fileNameLookup
        /// fileNameOnDisk
        /// </summary>
        public static async Task<DeviceManagementFileAuthLocationGetResponse22V2> DeviceManagementFileAuthLocationGetRequest22V2Async(this OcipClientBase client, DeviceManagementFileAuthLocationGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as DeviceManagementFileAuthLocationGetResponse22V2;
        }
        /// <summary>
        /// Informs BroadWorks that a file was uploaded to the repository. The response is always a SuccessResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use DeviceManagementPutFileRequestAsync instead.")]
        public static async Task<SuccessResponse> DeviceManagementPutFileRequest(this OcipClientBase client, DeviceManagementPutFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Informs BroadWorks that a file was uploaded to the repository. The response is always a SuccessResponse.
        /// </summary>
        public static async Task<SuccessResponse> DeviceManagementPutFileRequestAsync(this OcipClientBase client, DeviceManagementPutFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// This command is part of the Portal API.
        /// Sent when a Web or CLI user logs in using external authentication.
        /// The hashed password value in the request is supported only when the request is sent from the CommPilot web portal.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ExternalAuthenticationAuthorizeTokenRequest22Async instead.")]
        public static async Task<SuccessResponse> ExternalAuthenticationAuthorizeTokenRequest22(this OcipClientBase client, ExternalAuthenticationAuthorizeTokenRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// This command is part of the Portal API.
        /// Sent when a Web or CLI user logs in using external authentication.
        /// The hashed password value in the request is supported only when the request is sent from the CommPilot web portal.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ExternalAuthenticationAuthorizeTokenRequest22Async(this OcipClientBase client, ExternalAuthenticationAuthorizeTokenRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// This command allows a BroadWorks or Third-Party Client Application to
        /// create a Single Sign-On token for a user.
        /// The response is either ExternalAuthenticationCreateLoginTokenResponse
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ExternalAuthenticationCreateLoginTokenRequestAsync instead.")]
        public static async Task<ExternalAuthenticationCreateLoginTokenResponse> ExternalAuthenticationCreateLoginTokenRequest(this OcipClientBase client, ExternalAuthenticationCreateLoginTokenRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ExternalAuthenticationCreateLoginTokenResponse;
        }

        /// <summary>
        /// This command allows a BroadWorks or Third-Party Client Application to
        /// create a Single Sign-On token for a user.
        /// The response is either ExternalAuthenticationCreateLoginTokenResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<ExternalAuthenticationCreateLoginTokenResponse> ExternalAuthenticationCreateLoginTokenRequestAsync(this OcipClientBase client, ExternalAuthenticationCreateLoginTokenRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ExternalAuthenticationCreateLoginTokenResponse;
        }
        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// The response is LoginResponse22V3 or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use LoginRequest22V3Async instead.")]
        public static async Task<LoginResponse22V3> LoginRequest22V3(this OcipClientBase client, LoginRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as LoginResponse22V3;
        }

        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// The response is LoginResponse22V3 or ErrorResponse
        /// </summary>
        public static async Task<LoginResponse22V3> LoginRequest22V3Async(this OcipClientBase client, LoginRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as LoginResponse22V3;
        }
        /// <summary>
        /// LogoutRequest is sent when an OCI user logs out or when connection is lost.
        /// This command can be sent either to the server, or to the client from OCS.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use LogoutRequestAsync instead.")]
        public static async Task<SuccessResponse> LogoutRequest(this OcipClientBase client, LogoutRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// LogoutRequest is sent when an OCI user logs out or when connection is lost.
        /// This command can be sent either to the server, or to the client from OCS.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> LogoutRequestAsync(this OcipClientBase client, LogoutRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Revoke all previously issued long lived tokens.
        /// If the userId is not specified, revoke all tokens in the system.
        /// If the userId is specified, revoke all tokens issued to the user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use LongLivedTokenRevokeRequestAsync instead.")]
        public static async Task<SuccessResponse> LongLivedTokenRevokeRequest(this OcipClientBase client, LongLivedTokenRevokeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Revoke all previously issued long lived tokens.
        /// If the userId is not specified, revoke all tokens in the system.
        /// If the userId is specified, revoke all tokens issued to the user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> LongLivedTokenRevokeRequestAsync(this OcipClientBase client, LongLivedTokenRevokeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Generate passwords based on the corresponding password/passcode rules.
        /// The response is either PasswordGenerateResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use PasswordGenerateRequestAsync instead.")]
        public static async Task<PasswordGenerateResponse> PasswordGenerateRequest(this OcipClientBase client, PasswordGenerateRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as PasswordGenerateResponse;
        }

        /// <summary>
        /// Generate passwords based on the corresponding password/passcode rules.
        /// The response is either PasswordGenerateResponse or ErrorResponse.
        /// </summary>
        public static async Task<PasswordGenerateResponse> PasswordGenerateRequestAsync(this OcipClientBase client, PasswordGenerateRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as PasswordGenerateResponse;
        }
        /// <summary>
        /// Modify the password for a user/administrator.
        /// When oldPassword is specified, password rule applies. If oldPassword in not specified,
        /// any password rule related to old password does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use PasswordModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> PasswordModifyRequest(this OcipClientBase client, PasswordModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the password for a user/administrator.
        /// When oldPassword is specified, password rule applies. If oldPassword in not specified,
        /// any password rule related to old password does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> PasswordModifyRequestAsync(this OcipClientBase client, PasswordModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests information about the primary server for high-availability support.
        /// The response is either PrimaryInfoGetResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use PrimaryInfoGetRequestAsync instead.")]
        public static async Task<PrimaryInfoGetResponse> PrimaryInfoGetRequest(this OcipClientBase client, PrimaryInfoGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as PrimaryInfoGetResponse;
        }

        /// <summary>
        /// Requests information about the primary server for high-availability support.
        /// The response is either PrimaryInfoGetResponse or ErrorResponse
        /// </summary>
        public static async Task<PrimaryInfoGetResponse> PrimaryInfoGetRequestAsync(this OcipClientBase client, PrimaryInfoGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as PrimaryInfoGetResponse;
        }
        /// <summary>
        /// Get the public cluster fully qualified domain name (FQDN).
        /// The response is either a PublicClusterGetFullyQualifiedDomainNameResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use PublicClusterGetFullyQualifiedDomainNameRequestAsync instead.")]
        public static async Task<PublicClusterGetFullyQualifiedDomainNameResponse> PublicClusterGetFullyQualifiedDomainNameRequest(this OcipClientBase client, PublicClusterGetFullyQualifiedDomainNameRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as PublicClusterGetFullyQualifiedDomainNameResponse;
        }

        /// <summary>
        /// Get the public cluster fully qualified domain name (FQDN).
        /// The response is either a PublicClusterGetFullyQualifiedDomainNameResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<PublicClusterGetFullyQualifiedDomainNameResponse> PublicClusterGetFullyQualifiedDomainNameRequestAsync(this OcipClientBase client, PublicClusterGetFullyQualifiedDomainNameRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as PublicClusterGetFullyQualifiedDomainNameResponse;
        }
        /// <summary>
        /// Get the tutorial flag setting for a user or admin.
        /// The response is either a TutorialFlagGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use TutorialFlagGetRequestAsync instead.")]
        public static async Task<TutorialFlagGetResponse> TutorialFlagGetRequest(this OcipClientBase client, TutorialFlagGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as TutorialFlagGetResponse;
        }

        /// <summary>
        /// Get the tutorial flag setting for a user or admin.
        /// The response is either a TutorialFlagGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<TutorialFlagGetResponse> TutorialFlagGetRequestAsync(this OcipClientBase client, TutorialFlagGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as TutorialFlagGetResponse;
        }
        /// <summary>
        /// Modify the tutorial flag setting for a user or admin.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use TutorialFlagModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> TutorialFlagModifyRequest(this OcipClientBase client, TutorialFlagModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the tutorial flag setting for a user or admin.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> TutorialFlagModifyRequestAsync(this OcipClientBase client, TutorialFlagModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// UserGetLoginInfoRequest22V2 is used to access login information for a user
        /// either by a userId, dn or lineport.
        /// The phone number may be any DN associated with a user.
        /// The lineport may be any lineport associated with a user.
        /// 
        /// The response is a UserGetLoginInfoResponse22V2 or an ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetLoginInfoRequest22V2Async instead.")]
        public static async Task<UserGetLoginInfoResponse22V2> UserGetLoginInfoRequest22V2(this OcipClientBase client, UserGetLoginInfoRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetLoginInfoResponse22V2;
        }

        /// <summary>
        /// UserGetLoginInfoRequest22V2 is used to access login information for a user
        /// either by a userId, dn or lineport.
        /// The phone number may be any DN associated with a user.
        /// The lineport may be any lineport associated with a user.
        /// 
        /// The response is a UserGetLoginInfoResponse22V2 or an ErrorResponse
        /// </summary>
        public static async Task<UserGetLoginInfoResponse22V2> UserGetLoginInfoRequest22V2Async(this OcipClientBase client, UserGetLoginInfoRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetLoginInfoResponse22V2;
        }
        /// <summary>
        /// This command allows a BroadWorks or Third-Party Client Application to
        /// create a Single Sign-On token for a device of a user.
        /// The token is created only if:
        /// 1. the specified user is the owner of a lineport on the specified device
        /// (including a trunk user on a trunk device).
        /// 2. and, the specified device is not in locked state.
        /// 3. and, the device type of the device does support Device Management.
        /// The response is either UserSingleSignOnCreateDeviceTokenResponse
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSingleSignOnCreateDeviceTokenRequestAsync instead.")]
        public static async Task<UserSingleSignOnCreateDeviceTokenResponse> UserSingleSignOnCreateDeviceTokenRequest(this OcipClientBase client, UserSingleSignOnCreateDeviceTokenRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSingleSignOnCreateDeviceTokenResponse;
        }

        /// <summary>
        /// This command allows a BroadWorks or Third-Party Client Application to
        /// create a Single Sign-On token for a device of a user.
        /// The token is created only if:
        /// 1. the specified user is the owner of a lineport on the specified device
        /// (including a trunk user on a trunk device).
        /// 2. and, the specified device is not in locked state.
        /// 3. and, the device type of the device does support Device Management.
        /// The response is either UserSingleSignOnCreateDeviceTokenResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<UserSingleSignOnCreateDeviceTokenResponse> UserSingleSignOnCreateDeviceTokenRequestAsync(this OcipClientBase client, UserSingleSignOnCreateDeviceTokenRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSingleSignOnCreateDeviceTokenResponse;
        }
        /// <summary>
        /// Query the provisioning server to verify the session is authorized. Most
        /// applications should not need this command, because the provisioning server
        /// verifies the session is authorized for all commands.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use VerifySessionIsValidRequestAsync instead.")]
        public static async Task<SuccessResponse> VerifySessionIsValidRequest(this OcipClientBase client, VerifySessionIsValidRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Query the provisioning server to verify the session is authorized. Most
        /// applications should not need this command, because the provisioning server
        /// verifies the session is authorized for all commands.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> VerifySessionIsValidRequestAsync(this OcipClientBase client, VerifySessionIsValidRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
