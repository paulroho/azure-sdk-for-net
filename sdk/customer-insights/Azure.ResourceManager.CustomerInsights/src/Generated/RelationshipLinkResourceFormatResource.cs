// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A Class representing a RelationshipLinkResourceFormat along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RelationshipLinkResourceFormatResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRelationshipLinkResourceFormatResource method.
    /// Otherwise you can get one from its parent resource <see cref="HubResource" /> using the GetRelationshipLinkResourceFormat method.
    /// </summary>
    public partial class RelationshipLinkResourceFormatResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RelationshipLinkResourceFormatResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="hubName"> The hubName. </param>
        /// <param name="relationshipLinkName"> The relationshipLinkName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hubName, string relationshipLinkName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/relationshipLinks/{relationshipLinkName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _relationshipLinkResourceFormatRelationshipLinksClientDiagnostics;
        private readonly RelationshipLinksRestOperations _relationshipLinkResourceFormatRelationshipLinksRestClient;
        private readonly RelationshipLinkResourceFormatData _data;

        /// <summary> Initializes a new instance of the <see cref="RelationshipLinkResourceFormatResource"/> class for mocking. </summary>
        protected RelationshipLinkResourceFormatResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RelationshipLinkResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RelationshipLinkResourceFormatResource(ArmClient client, RelationshipLinkResourceFormatData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RelationshipLinkResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RelationshipLinkResourceFormatResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _relationshipLinkResourceFormatRelationshipLinksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string relationshipLinkResourceFormatRelationshipLinksApiVersion);
            _relationshipLinkResourceFormatRelationshipLinksRestClient = new RelationshipLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, relationshipLinkResourceFormatRelationshipLinksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CustomerInsights/hubs/relationshipLinks";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RelationshipLinkResourceFormatData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about the specified relationship Link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/relationshipLinks/{relationshipLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RelationshipLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RelationshipLinkResourceFormatResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _relationshipLinkResourceFormatRelationshipLinksClientDiagnostics.CreateScope("RelationshipLinkResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = await _relationshipLinkResourceFormatRelationshipLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RelationshipLinkResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified relationship Link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/relationshipLinks/{relationshipLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RelationshipLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RelationshipLinkResourceFormatResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _relationshipLinkResourceFormatRelationshipLinksClientDiagnostics.CreateScope("RelationshipLinkResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = _relationshipLinkResourceFormatRelationshipLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RelationshipLinkResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a relationship link within a hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/relationshipLinks/{relationshipLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RelationshipLinks_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _relationshipLinkResourceFormatRelationshipLinksClientDiagnostics.CreateScope("RelationshipLinkResourceFormatResource.Delete");
            scope.Start();
            try
            {
                var response = await _relationshipLinkResourceFormatRelationshipLinksRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation(_relationshipLinkResourceFormatRelationshipLinksClientDiagnostics, Pipeline, _relationshipLinkResourceFormatRelationshipLinksRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a relationship link within a hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/relationshipLinks/{relationshipLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RelationshipLinks_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _relationshipLinkResourceFormatRelationshipLinksClientDiagnostics.CreateScope("RelationshipLinkResourceFormatResource.Delete");
            scope.Start();
            try
            {
                var response = _relationshipLinkResourceFormatRelationshipLinksRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CustomerInsightsArmOperation(_relationshipLinkResourceFormatRelationshipLinksClientDiagnostics, Pipeline, _relationshipLinkResourceFormatRelationshipLinksRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a relationship link or updates an existing relationship link within a hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/relationshipLinks/{relationshipLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RelationshipLinks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate relationship link operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RelationshipLinkResourceFormatResource>> UpdateAsync(WaitUntil waitUntil, RelationshipLinkResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relationshipLinkResourceFormatRelationshipLinksClientDiagnostics.CreateScope("RelationshipLinkResourceFormatResource.Update");
            scope.Start();
            try
            {
                var response = await _relationshipLinkResourceFormatRelationshipLinksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<RelationshipLinkResourceFormatResource>(new RelationshipLinkResourceFormatOperationSource(Client), _relationshipLinkResourceFormatRelationshipLinksClientDiagnostics, Pipeline, _relationshipLinkResourceFormatRelationshipLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a relationship link or updates an existing relationship link within a hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/relationshipLinks/{relationshipLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RelationshipLinks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate relationship link operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RelationshipLinkResourceFormatResource> Update(WaitUntil waitUntil, RelationshipLinkResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relationshipLinkResourceFormatRelationshipLinksClientDiagnostics.CreateScope("RelationshipLinkResourceFormatResource.Update");
            scope.Start();
            try
            {
                var response = _relationshipLinkResourceFormatRelationshipLinksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<RelationshipLinkResourceFormatResource>(new RelationshipLinkResourceFormatOperationSource(Client), _relationshipLinkResourceFormatRelationshipLinksClientDiagnostics, Pipeline, _relationshipLinkResourceFormatRelationshipLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
