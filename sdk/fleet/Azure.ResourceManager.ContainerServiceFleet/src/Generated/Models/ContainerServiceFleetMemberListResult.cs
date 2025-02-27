// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ContainerServiceFleet;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    /// <summary> The response of a FleetMember list operation. </summary>
    internal partial class ContainerServiceFleetMemberListResult
    {
        /// <summary> Initializes a new instance of ContainerServiceFleetMemberListResult. </summary>
        /// <param name="value"> The FleetMember items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ContainerServiceFleetMemberListResult(IEnumerable<ContainerServiceFleetMemberData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ContainerServiceFleetMemberListResult. </summary>
        /// <param name="value"> The FleetMember items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal ContainerServiceFleetMemberListResult(IReadOnlyList<ContainerServiceFleetMemberData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The FleetMember items on this page. </summary>
        public IReadOnlyList<ContainerServiceFleetMemberData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
