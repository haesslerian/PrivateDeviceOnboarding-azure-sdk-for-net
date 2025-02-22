// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using MgmtTypeSpec;

namespace MgmtTypeSpec.Models
{
    /// <summary> A factory class for creating instances of the models for mocking. </summary>
    public static partial class MgmtTypeSpecModelFactory
    {
        /// <summary> Concrete tracked resource types can be created by aliasing this type using a specific property type. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="extendedLocation"></param>
        /// <returns> A new <see cref="Models.Foo"/> instance for mocking. </returns>
        public static Foo Foo(ResourceIdentifier id = default, string name = default, string @type = default, SystemData systemData = default, IDictionary<string, string> tags = default, string location = default, FooProperties properties = default, ExtendedLocation extendedLocation = default)
        {
            tags ??= new ChangeTrackingDictionary<string, string>();

            return new Foo(
                id,
                name,
                @type,
                systemData,
                additionalBinaryDataProperties: null,
                tags,
                location,
                properties,
                extendedLocation);
        }

        /// <summary> The FooProperties. </summary>
        /// <param name="serviceUrl"> the service url. </param>
        /// <param name="something"> something. </param>
        /// <param name="boolValue"> boolean value. </param>
        /// <param name="floatValue"> float value. </param>
        /// <param name="doubleValue"> double value. </param>
        /// <returns> A new <see cref="Models.FooProperties"/> instance for mocking. </returns>
        public static FooProperties FooProperties(Uri serviceUrl = default, string something = default, bool? boolValue = default, float? floatValue = default, double? doubleValue = default)
        {

            return new FooProperties(
                serviceUrl,
                something,
                boolValue,
                floatValue,
                doubleValue,
                additionalBinaryDataProperties: null);
        }

        /// <summary> The complex type of the extended location. </summary>
        /// <param name="name"> The name of the extended location. </param>
        /// <param name="type"> The type of the extended location. </param>
        /// <returns> A new <see cref="Models.ExtendedLocation"/> instance for mocking. </returns>
        public static ExtendedLocation ExtendedLocation(string name = default, ExtendedLocationType @type = default)
        {

            return new ExtendedLocation(name, @type, additionalBinaryDataProperties: null);
        }

        /// <summary> The resource model definition for an Azure Resource Manager tracked top level resource which has 'tags' and a 'location'. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="Models.TrackedResource"/> instance for mocking. </returns>
        public static TrackedResource TrackedResource(ResourceIdentifier id = default, string name = default, string @type = default, SystemData systemData = default, IDictionary<string, string> tags = default, string location = default)
        {
            tags ??= new ChangeTrackingDictionary<string, string>();

            return new TrackedResource(
                id,
                name,
                @type,
                systemData,
                additionalBinaryDataProperties: null,
                tags,
                location);
        }

        /// <summary> Common fields that are returned in the response for all Azure Resource Manager resources. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <returns> A new <see cref="Models.Resource"/> instance for mocking. </returns>
        public static Resource Resource(ResourceIdentifier id = default, string name = default, string @type = default, SystemData systemData = default)
        {

            return new Resource(id, name, @type, systemData, additionalBinaryDataProperties: null);
        }

        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        /// <param name="createdBy"> The identity that created the resource. </param>
        /// <param name="createdByType"> The type of identity that created the resource. </param>
        /// <param name="createdAt"> The timestamp of resource creation (UTC). </param>
        /// <param name="lastModifiedBy"> The identity that last modified the resource. </param>
        /// <param name="lastModifiedByType"> The type of identity that last modified the resource. </param>
        /// <param name="lastModifiedAt"> The timestamp of resource last modification (UTC). </param>
        /// <returns> A new <see cref="Models.SystemData"/> instance for mocking. </returns>
        public static SystemData SystemData(string createdBy = default, CreatedByType? createdByType = default, DateTimeOffset? createdAt = default, string lastModifiedBy = default, CreatedByType? lastModifiedByType = default, DateTimeOffset? lastModifiedAt = default)
        {

            return new SystemData(
                createdBy,
                createdByType,
                createdAt,
                lastModifiedBy,
                lastModifiedByType,
                lastModifiedAt,
                additionalBinaryDataProperties: null);
        }

        /// <summary> The response of a Foo list operation. </summary>
        /// <param name="value"> The Foo items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        /// <returns> A new <see cref="Models.FooListResult"/> instance for mocking. </returns>
        public static FooListResult FooListResult(IEnumerable<Foo> value = default, Uri nextLink = default)
        {
            value ??= new ChangeTrackingList<Foo>();

            return new FooListResult(value?.ToList(), nextLink, additionalBinaryDataProperties: null);
        }

        /// <summary> The response of a PrivateLinkResource list operation. </summary>
        /// <param name="value"> The PrivateLinkResource items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        /// <returns> A new <see cref="Models.PrivateLinkResourceListResult"/> instance for mocking. </returns>
        public static PrivateLinkResourceListResult PrivateLinkResourceListResult(IEnumerable<PrivateLinkResource> value = default, Uri nextLink = default)
        {
            value ??= new ChangeTrackingList<PrivateLinkResource>();

            return new PrivateLinkResourceListResult(value?.ToList(), nextLink, additionalBinaryDataProperties: null);
        }

        /// <summary> Concrete proxy resource types can be created by aliasing this type using a specific property type. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <returns> A new <see cref="Models.PrivateLinkResource"/> instance for mocking. </returns>
        public static PrivateLinkResource PrivateLinkResource(ResourceIdentifier id = default, string name = default, string @type = default, SystemData systemData = default, PrivateLinkResourceProperties properties = default, ManagedServiceIdentity identity = default)
        {

            return new PrivateLinkResource(
                id,
                name,
                @type,
                systemData,
                additionalBinaryDataProperties: null,
                properties,
                identity);
        }

        /// <summary> Properties of a private link resource. </summary>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource private link DNS zone name. </param>
        /// <returns> A new <see cref="Models.PrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static PrivateLinkResourceProperties PrivateLinkResourceProperties(string groupId = default, IEnumerable<string> requiredMembers = default, IEnumerable<string> requiredZoneNames = default)
        {
            requiredMembers ??= new ChangeTrackingList<string>();
            requiredZoneNames ??= new ChangeTrackingList<string>();

            return new PrivateLinkResourceProperties(groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), additionalBinaryDataProperties: null);
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        /// <param name="principalId"> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="type"> The type of managed identity assigned to this resource. </param>
        /// <param name="userAssignedIdentities"> The identities assigned to this resource by the user. </param>
        /// <returns> A new <see cref="Models.ManagedServiceIdentity"/> instance for mocking. </returns>
        public static ManagedServiceIdentity ManagedServiceIdentity(Guid? principalId = default, Guid? tenantId = default, ManagedServiceIdentityType @type = default, IDictionary<string, UserAssignedIdentity> userAssignedIdentities = default)
        {
            userAssignedIdentities ??= new ChangeTrackingDictionary<string, UserAssignedIdentity>();

            return new ManagedServiceIdentity(principalId, tenantId, @type, userAssignedIdentities, additionalBinaryDataProperties: null);
        }

        /// <summary> User assigned identity properties. </summary>
        /// <param name="principalId"> The principal ID of the assigned identity. </param>
        /// <param name="clientId"> The client ID of the assigned identity. </param>
        /// <returns> A new <see cref="Models.UserAssignedIdentity"/> instance for mocking. </returns>
        public static UserAssignedIdentity UserAssignedIdentity(Guid? principalId = default, Guid? clientId = default)
        {

            return new UserAssignedIdentity(principalId, clientId, additionalBinaryDataProperties: null);
        }

        /// <summary> The resource model definition for a Azure Resource Manager proxy resource. It will not have tags and a location. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <returns> A new <see cref="Models.ProxyResource"/> instance for mocking. </returns>
        public static ProxyResource ProxyResource(ResourceIdentifier id = default, string name = default, string @type = default, SystemData systemData = default)
        {

            return new ProxyResource(id, name, @type, systemData, additionalBinaryDataProperties: null);
        }

        /// <summary> Start SAP instance(s) request body. </summary>
        /// <param name="startVm"> The boolean value indicates whether to start the virtual machines before starting the SAP instances. </param>
        /// <returns> A new <see cref="Models.StartRequest"/> instance for mocking. </returns>
        public static StartRequest StartRequest(bool? startVm = default)
        {

            return new StartRequest(startVm, additionalBinaryDataProperties: null);
        }

        /// <summary> A list of REST API operations supported by an Azure Resource Provider. It contains an URL link to get the next set of results. </summary>
        /// <param name="value"> The Operation items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        /// <returns> A new <see cref="Models.OperationListResult"/> instance for mocking. </returns>
        public static OperationListResult OperationListResult(IEnumerable<Operation> value = default, Uri nextLink = default)
        {
            value ??= new ChangeTrackingList<Operation>();

            return new OperationListResult(value?.ToList(), nextLink, additionalBinaryDataProperties: null);
        }

        /// <summary> Details of a REST API operation, returned from the Resource Provider Operations API. </summary>
        /// <param name="name"> The name of the operation, as per Resource-Based Access Control (RBAC). Examples: "Microsoft.Compute/virtualMachines/write", "Microsoft.Compute/virtualMachines/capture/action". </param>
        /// <param name="isDataAction"> Whether the operation applies to data-plane. This is "true" for data-plane operations and "false" for Azure Resource Manager/control-plane operations. </param>
        /// <param name="display"> Localized display information for this particular operation. </param>
        /// <param name="origin"> The intended executor of the operation; as in Resource Based Access Control (RBAC) and audit logs UX. Default value is "user,system". </param>
        /// <param name="actionType"> Extensible enum. Indicates the action type. "Internal" refers to actions that are for internal only APIs. </param>
        /// <returns> A new <see cref="Models.Operation"/> instance for mocking. </returns>
        public static Operation Operation(string name = default, bool? isDataAction = default, OperationDisplay display = default, Origin? origin = default, ActionType? actionType = default)
        {

            return new Operation(
                name,
                isDataAction,
                display,
                origin,
                actionType,
                additionalBinaryDataProperties: null);
        }

        /// <summary> Localized display information for and operation. </summary>
        /// <param name="provider"> The localized friendly form of the resource provider name, e.g. "Microsoft Monitoring Insights" or "Microsoft Compute". </param>
        /// <param name="resource"> The localized friendly name of the resource type related to this operation. E.g. "Virtual Machines" or "Job Schedule Collections". </param>
        /// <param name="operation"> The concise, localized friendly name for the operation; suitable for dropdowns. E.g. "Create or Update Virtual Machine", "Restart Virtual Machine". </param>
        /// <param name="description"> The short, localized friendly description of the operation; suitable for tool tips and detailed views. </param>
        /// <returns> A new <see cref="Models.OperationDisplay"/> instance for mocking. </returns>
        public static OperationDisplay OperationDisplay(string provider = default, string resource = default, string operation = default, string description = default)
        {

            return new OperationDisplay(provider, resource, operation, description, additionalBinaryDataProperties: null);
        }
    }
}
