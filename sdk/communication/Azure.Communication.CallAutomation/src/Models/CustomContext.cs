// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// CustomContext details.
    /// </summary>
    public class CustomContext
    {
        /// <summary> Dictionary of VOIP headers. </summary>
        public IDictionary<string, string> VoipHeaders { get; set; }

        /// <summary> Dictionary of SIP headers. </summary>
        public IDictionary<string, string> SipHeaders { get; set; }

        /// <summary>
        /// Creates a new CustomContext.
        /// </summary>
        internal CustomContext(IDictionary<string, string> sipHeaders, IDictionary<string, string> voipHeaders)
        {
            SipHeaders = sipHeaders;
            VoipHeaders = voipHeaders;
        }
    }
}
