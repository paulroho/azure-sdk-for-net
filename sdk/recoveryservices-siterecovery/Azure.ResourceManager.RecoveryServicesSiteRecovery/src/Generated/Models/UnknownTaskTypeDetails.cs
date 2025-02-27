// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownTaskTypeDetails. </summary>
    internal partial class UnknownTaskTypeDetails : SiteRecoveryTaskTypeDetails
    {
        /// <summary> Initializes a new instance of UnknownTaskTypeDetails. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        internal UnknownTaskTypeDetails(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}
