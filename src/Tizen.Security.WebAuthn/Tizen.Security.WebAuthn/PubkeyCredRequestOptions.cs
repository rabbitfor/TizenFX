/*
 *  Copyright (c) 2024 Samsung Electronics Co., Ltd All Rights Reserved
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License
 */

using System.Collections.Generic;

namespace Tizen.Security.WebAuthn
{
    /// <summary>
    /// Get assertion options.
    /// </summary>
    /// <remarks>
    /// Refer to the following W3C specification for more information.
    /// https://www.w3.org/TR/webauthn-3/#dictionary-assertion-options
    /// </remarks>
    /// <since_tizen> 12 </since_tizen>
    public class PubkeyCredRequestOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PubkeyCredRequestOptions"/> class.
        /// </summary>
        /// <since_tizen> 12 </since_tizen>
        /// <param name="timeout">
        /// Specifies a time, in milliseconds, that the Relying Party is willing to wait for the
        /// call to complete. This is treated as a hint, and MAY be overridden by the client.
        /// The value, '0', means no timeout is set. (optional)
        /// </param>
        /// <param name="rpId">
        /// Specifies the RP ID claimed by the Relying Party. (optional)
        /// </param>
        /// <param name="allowCredentials">
        /// Used by the client to find authenticators eligible for this authentication ceremony. (optional)
        /// </param>
        /// <param name="userVerification">
        /// Specifies the Relying Party's requirements regarding user verification for the
        /// GetAssertion() operation. The default value is <see cref="UserVerificationRequirement.Preferred"/>. (optional)
        /// </param>
        /// <param name="hints">
        /// Contains zero or more elements from <see cref="PubkeyCredHint"/> to
        /// guide the user agent in interacting with the user. (optional)
        /// </param>
        /// <param name="attestation">
        /// The Relying Party MAY use this argument to specify a preference regarding
        /// attestation conveyance. The default value is <see cref="AttestationPref.None"/>. (optional)
        /// </param>
        /// <param name="attestationFormats">
        /// The Relying Party MAY use this argument to specify a preference regarding the attestation
        /// statement format used by the authenticator. The default value is the empty list,
        /// which indicates no preference. (optional)
        /// </param>
        /// <param name="extensions">
        /// The Relying Party MAY use this argument to provide client extension inputs requesting
        /// additional processing by the client and authenticator. (optional)
        /// </param>
        /// <param name="linkedDevice">
        /// Linked Device Connection Info. Optional.
        /// If not null, the state assisted transaction will start.
        /// </param>
        public PubkeyCredRequestOptions(
            ulong timeout = 0,
            string rpId = null,
            IEnumerable<PubkeyCredDescriptor> allowCredentials = null,
            UserVerificationRequirement userVerification = UserVerificationRequirement.Preferred,
            IEnumerable<PubkeyCredHint> hints = null,
            AttestationPref attestation = AttestationPref.None,
            IEnumerable<byte[]> attestationFormats = null,
            IEnumerable<AuthenticationExtension> extensions = null,
            HybridLinkedData linkedDevice = null)
        {
            Timeout = timeout;
            RpId = rpId;
            AllowCredentials = allowCredentials;
            UserVerification = userVerification;
            Hints = hints;
            Attestation = attestation;
            AttestationFormats = attestationFormats;
            Extensions = extensions;
            LinkedDevice = linkedDevice;
        }

        /// <summary>
        /// Specifies a time, in milliseconds, that the Relying Party is willing to wait for the
        /// call to complete. This is treated as a hint, and MAY be overridden by the client.
        /// The value, '0', means no timeout is set.
        /// </summary>
        public ulong Timeout { get; init; }
        /// <summary>
        /// Specifies the RP ID claimed by the Relying Party.
        /// </summary>
        public string RpId { get; init; }
        /// <summary>
        /// Used by the client to find authenticators eligible for this authentication ceremony.
        /// </summary>
        public IEnumerable<PubkeyCredDescriptor> AllowCredentials { get; init; }
        /// <summary>
        /// Specifies the Relying Party's requirements regarding user verification for the GetAssertion() operation.
        /// </summary>
        public UserVerificationRequirement UserVerification { get; init; }
        /// <summary>
        /// Contains zero or more elements from <see cref="PubkeyCredHint"/> to
        /// guide the user agent in interacting with the user.
        /// </summary>
        public IEnumerable<PubkeyCredHint> Hints { get; init; }
        /// <summary>
        /// Specifies a preference regarding attestation conveyance.
        /// </summary>
        public AttestationPref Attestation { get; init; }
        /// <summary>
        /// Specifies a preference regarding the attestation statement format used by the authenticator.
        /// </summary>
        public IEnumerable<byte[]> AttestationFormats { get; init; }
        /// <summary>
        /// Client extension inputs requesting additional processing by the client and authenticator.
        /// </summary>
        public IEnumerable<AuthenticationExtension> Extensions { get; init; }
        /// <summary>
        /// Linked Device Connection Info. If not null, the state assisted transaction will start.
        /// </summary>
        public HybridLinkedData LinkedDevice { get; init; }
    }
}