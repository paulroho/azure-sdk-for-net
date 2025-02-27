// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Search;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Response containing a list of Azure Cognitive Search services. </summary>
    internal partial class SearchServiceListResult
    {
        /// <summary> Initializes a new instance of SearchServiceListResult. </summary>
        internal SearchServiceListResult()
        {
            Value = new ChangeTrackingList<SearchServiceData>();
        }

        /// <summary> Initializes a new instance of SearchServiceListResult. </summary>
        /// <param name="value"> The list of Search services. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of search services. Returned when the total number of requested search services exceed maximum page size. </param>
        internal SearchServiceListResult(IReadOnlyList<SearchServiceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of Search services. </summary>
        public IReadOnlyList<SearchServiceData> Value { get; }
        /// <summary> Request URL that can be used to query next page of search services. Returned when the total number of requested search services exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
