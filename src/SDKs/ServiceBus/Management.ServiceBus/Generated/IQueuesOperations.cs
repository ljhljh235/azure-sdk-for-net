// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// QueuesOperations operations.
    /// </summary>
    public partial interface IQueuesOperations
    {
        /// <summary>
        /// Gets the queues within a namespace.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639415.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SBQueue>>> ListByNamespaceWithHttpMessagesAsync(string resourceGroupName, string namespaceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a Service Bus queue. This operation is
        /// idempotent.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639395.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create or update a queue resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SBQueue>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string queueName, SBQueue parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a queue from the specified namespace in a resource group.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639411.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string queueName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a description for the specified queue.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639380.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SBQueue>> GetWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string queueName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all authorization rules for a queue.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705607.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SBAuthorizationRule>>> ListAuthorizationRulesWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string queueName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an authorization rule for a queue.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// The authorizationrule name.
        /// </param>
        /// <param name='parameters'>
        /// The shared access authorization rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SBAuthorizationRule>> CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, SBAuthorizationRule parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a queue authorization rule.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705609.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// The authorizationrule name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteAuthorizationRuleWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets an authorization rule for a queue by rule name.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705611.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// The authorizationrule name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SBAuthorizationRule>> GetAuthorizationRuleWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Primary and secondary connection strings to the queue.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705608.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// The authorizationrule name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AccessKeys>> ListKeysWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Regenerates the primary or secondary connection strings to the
        /// queue.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705606.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// The authorizationrule name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to regenerate the authorization rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AccessKeys>> RegenerateKeysWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, RegenerateAccessKeyParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the queues within a namespace.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639415.aspx" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SBQueue>>> ListByNamespaceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all authorization rules for a queue.
        /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705607.aspx" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SBAuthorizationRule>>> ListAuthorizationRulesNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}