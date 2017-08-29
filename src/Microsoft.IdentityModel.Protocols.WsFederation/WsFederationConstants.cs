//------------------------------------------------------------------------------
//
// Copyright (c) Microsoft Corporation.
// All rights reserved.
//
// This code is licensed under the MIT License.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------

namespace Microsoft.IdentityModel.Protocols.WsFederation
{
    /// <summary>
    /// Constants for WsFederation.
    /// </summary>
    public static class WsFederationConstants
    {
        #pragma warning disable 1591

        /// <summary>
        /// Constants for WsFederation actions.
        /// </summary>
        public static class WsFederationActions
        {
            public const string Attribute = "wattr1.0";
            public const string Pseudonym = "wpseudo1.0";
            public const string SignIn = "wsignin1.0";
            public const string SignOut = "wsignout1.0";
            public const string SignOutCleanup = "wsignoutcleanup1.0";
        }

        /// <summary>
        /// Constants for WsFederation Fault codes.
        /// </summary>
        public static class WsFederationFaultCodes
        {
            public const string AlreadySignedIn = "AlreadySignedIn";
            public const string BadRequest = "BadRequest";
            public const string IssuerNameNotSupported = "IssuerNameNotSupported";
            public const string NeedFresherCredentials = "NeedFresherCredentials";
            public const string NoMatchInScope = "NoMatchInScope";
            public const string NoPseudonymInScope = "NoPseudonymInScope";
            public const string NotSignedIn = "NotSignedIn";
            public const string RstParameterNotAccepted = "RstParameterNotAccepted";
            public const string SpecificPolicy = "SpecificPolicy";
            public const string UnsupportedClaimsDialect = "UnsupportedClaimsDialect";
            public const string UnsupportedEncoding = "UnsupportedEncoding";
        }

        /// <summary>
        /// Defines the WsFederation Constants
        /// </summary>
        public static class WsFederationParameterNames
        {
            public const string Wa = "wa";
            public const string Wattr = "wattr";
            public const string Wattrptr = "wattrptr";
            public const string Wauth = "wauth";
            public const string Wct = "wct";
            public const string Wctx = "wctx";
            public const string Wencoding = "wencoding";
            public const string Wfed = "wfed";
            public const string Wfresh = "wfresh";
            public const string Whr = "whr";
            public const string Wp = "wp";
            public const string Wpseudo = "wpseudo";
            public const string Wpseudoptr = "wpseudoptr";
            public const string Wreply = "wreply";
            public const string Wreq = "wreq";
            public const string Wreqptr = "wreqptr";
            public const string Wres = "wres";
            public const string Wresult = "wresult";
            public const string Wresultptr = "wresultptr";
            public const string Wtrealm = "wtrealm";
        }

        /// <summary>
        /// Attributes for WsFederation metadata xml.
        /// </summary>
        public static class Attributes
        {
            public const string EntityId = "entityID";
            public const string Id = "ID";
            public const string Type = "type";
            public const string Use = "use";
        }

        /// <summary>
        /// Elements for WsFederation metadata xml.
        /// </summary>
        public static class Elements
        {
            public const string Address = "Address";
            public const string EndpointReference = "EndpointReference";
            public const string EntityDescriptor = "EntityDescriptor";
            public const string IdpssoDescriptor = "IDPSSODescriptor";
            public const string KeyDescriptor = "KeyDescriptor";
            public const string RoleDescriptor = "RoleDescriptor";
            public const string SecurityTokenEndpoint = "SecurityTokenServiceEndpoint";
            public const string Signature = "Signature";
            public const string SpssoDescriptor = "SPSSODescriptor";
        }

        /// <summary>
        /// Namespaces for WsFederation metadata xml.
        /// </summary>
        public static class Namespaces
        {
            public const string AddressingNamspace = "http://www.w3.org/2005/08/addressing";
            public const string FederationNamespace = "http://docs.oasis-open.org/wsfed/federation/200706";
            public const string MetadataNamespace = "urn:oasis:names:tc:SAML:2.0:metadata";
        }

        /// <summary>
        /// Types for WsFederation metadata xml.
        /// </summary>
        public static class Types
        {
            public const string ApplicationServiceType = "ApplicationServiceType";
            public const string SecurityTokenServiceType = "SecurityTokenServiceType";
        }

        /// <summary>
        /// Defines the key use value in key descriptor for WsFederation metadata xml.
        /// </summary>
        public static class keyUse
        {
            public const string Signing = "signing";
        }

        /// <summary>
        /// xmlns string.
        /// </summary>
        public static string Xmlns = "xmlns";

        /// <summary>
        /// Sub namespace names.
        /// </summary>
        public static class NamespaceName
        {
            public const string Fed = "fed";
            public const string Xsi = "xsi";
            public const string Wsa = "wsa";
        }

        #pragma warning restore 1591
    }
}
 
