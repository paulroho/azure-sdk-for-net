// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing the ScopeMap data model.
    /// An object that represents a scope map for a container registry.
    /// </summary>
    public partial class ScopeMapData : ResourceData
    {
        /// <summary> Initializes a new instance of ScopeMapData. </summary>
        public ScopeMapData()
        {
            Actions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ScopeMapData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> The user friendly description of the scope map. </param>
        /// <param name="scopeMapType"> The type of the scope map. E.g. BuildIn scope map. </param>
        /// <param name="createdOn"> The creation date of scope map. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="actions">
        /// The list of scoped permissions for registry artifacts.
        /// E.g. repositories/repository-name/content/read,
        /// repositories/repository-name/metadata/write
        /// </param>
        internal ScopeMapData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string scopeMapType, DateTimeOffset? createdOn, ContainerRegistryProvisioningState? provisioningState, IList<string> actions) : base(id, name, resourceType, systemData)
        {
            Description = description;
            ScopeMapType = scopeMapType;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            Actions = actions;
        }

        /// <summary> The user friendly description of the scope map. </summary>
        public string Description { get; set; }
        /// <summary> The type of the scope map. E.g. BuildIn scope map. </summary>
        public string ScopeMapType { get; }
        /// <summary> The creation date of scope map. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public ContainerRegistryProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// The list of scoped permissions for registry artifacts.
        /// E.g. repositories/repository-name/content/read,
        /// repositories/repository-name/metadata/write
        /// </summary>
        public IList<string> Actions { get; }
    }
}
