// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityCenterLocationResource" /> and their operations.
    /// Each <see cref="SecurityCenterLocationResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SecurityCenterLocationCollection" /> instance call the GetSecurityCenterLocations method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SecurityCenterLocationCollection : ArmCollection, IEnumerable<SecurityCenterLocationResource>, IAsyncEnumerable<SecurityCenterLocationResource>
    {
        private readonly ClientDiagnostics _securityCenterLocationLocationsClientDiagnostics;
        private readonly LocationsRestOperations _securityCenterLocationLocationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityCenterLocationCollection"/> class for mocking. </summary>
        protected SecurityCenterLocationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityCenterLocationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityCenterLocationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityCenterLocationLocationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecurityCenterLocationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityCenterLocationResource.ResourceType, out string securityCenterLocationLocationsApiVersion);
            _securityCenterLocationLocationsRestClient = new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityCenterLocationLocationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Details of a specific location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityCenterLocationResource>> GetAsync(AzureLocation ascLocation, CancellationToken cancellationToken = default)
        {
            using var scope = _securityCenterLocationLocationsClientDiagnostics.CreateScope("SecurityCenterLocationCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityCenterLocationLocationsRestClient.GetAsync(Id.SubscriptionId, ascLocation, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Details of a specific location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityCenterLocationResource> Get(AzureLocation ascLocation, CancellationToken cancellationToken = default)
        {
            using var scope = _securityCenterLocationLocationsClientDiagnostics.CreateScope("SecurityCenterLocationCollection.Get");
            scope.Start();
            try
            {
                var response = _securityCenterLocationLocationsRestClient.Get(Id.SubscriptionId, ascLocation, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The location of the responsible ASC of the specific subscription (home region). For each subscription there is only one responsible location. The location in the response should be used to read or write other resources in ASC according to their ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityCenterLocationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityCenterLocationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityCenterLocationLocationsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityCenterLocationLocationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityCenterLocationResource(Client, SecurityCenterLocationData.DeserializeSecurityCenterLocationData(e)), _securityCenterLocationLocationsClientDiagnostics, Pipeline, "SecurityCenterLocationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The location of the responsible ASC of the specific subscription (home region). For each subscription there is only one responsible location. The location in the response should be used to read or write other resources in ASC according to their ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityCenterLocationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityCenterLocationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityCenterLocationLocationsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityCenterLocationLocationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityCenterLocationResource(Client, SecurityCenterLocationData.DeserializeSecurityCenterLocationData(e)), _securityCenterLocationLocationsClientDiagnostics, Pipeline, "SecurityCenterLocationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation ascLocation, CancellationToken cancellationToken = default)
        {
            using var scope = _securityCenterLocationLocationsClientDiagnostics.CreateScope("SecurityCenterLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityCenterLocationLocationsRestClient.GetAsync(Id.SubscriptionId, ascLocation, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AzureLocation ascLocation, CancellationToken cancellationToken = default)
        {
            using var scope = _securityCenterLocationLocationsClientDiagnostics.CreateScope("SecurityCenterLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityCenterLocationLocationsRestClient.Get(Id.SubscriptionId, ascLocation, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SecurityCenterLocationResource>> GetIfExistsAsync(AzureLocation ascLocation, CancellationToken cancellationToken = default)
        {
            using var scope = _securityCenterLocationLocationsClientDiagnostics.CreateScope("SecurityCenterLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityCenterLocationLocationsRestClient.GetAsync(Id.SubscriptionId, ascLocation, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityCenterLocationResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SecurityCenterLocationResource> GetIfExists(AzureLocation ascLocation, CancellationToken cancellationToken = default)
        {
            using var scope = _securityCenterLocationLocationsClientDiagnostics.CreateScope("SecurityCenterLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityCenterLocationLocationsRestClient.Get(Id.SubscriptionId, ascLocation, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityCenterLocationResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityCenterLocationResource> IEnumerable<SecurityCenterLocationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityCenterLocationResource> IAsyncEnumerable<SecurityCenterLocationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
