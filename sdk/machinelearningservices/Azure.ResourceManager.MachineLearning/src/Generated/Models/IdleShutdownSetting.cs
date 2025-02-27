// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Stops compute instance after user defined period of inactivity. </summary>
    public partial class IdleShutdownSetting
    {
        /// <summary> Initializes a new instance of IdleShutdownSetting. </summary>
        public IdleShutdownSetting()
        {
        }

        /// <summary> Time is defined in ISO8601 format. Minimum is 15 min, maximum is 3 days. </summary>
        public string IdleTimeBeforeShutdown { get; set; }
    }
}
