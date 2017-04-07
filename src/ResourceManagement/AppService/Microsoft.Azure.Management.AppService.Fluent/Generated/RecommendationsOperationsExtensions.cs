// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RecommendationsOperations.
    /// </summary>
    public static partial class RecommendationsOperationsExtensions
    {
            /// <summary>
            /// List all recommendations for a subscription.
            /// </summary>
            /// <remarks>
            /// List all recommendations for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='featured'>
            /// Specify &lt;code&gt;true&lt;/code&gt; to return only the most critical
            /// recommendations. The default is &lt;code&gt;false&lt;/code&gt;, which
            /// returns all recommendations.
            /// </param>
            /// <param name='filter'>
            /// Filter is specified by using OData syntax. Example: $filter=channels eq
            /// 'Api' or channel eq 'Notification' and startTime eq '2014-01-01T00:00:00Z'
            /// and endTime eq '2014-12-31T23:59:59Z' and timeGrain eq
            /// duration'[PT1H|PT1M|P1D]
            /// </param>
            public static IList<RecommendationInner> List(this IRecommendationsOperations operations, bool? featured = default(bool?), string filter = default(string))
            {
                return operations.ListAsync(featured, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all recommendations for a subscription.
            /// </summary>
            /// <remarks>
            /// List all recommendations for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='featured'>
            /// Specify &lt;code&gt;true&lt;/code&gt; to return only the most critical
            /// recommendations. The default is &lt;code&gt;false&lt;/code&gt;, which
            /// returns all recommendations.
            /// </param>
            /// <param name='filter'>
            /// Filter is specified by using OData syntax. Example: $filter=channels eq
            /// 'Api' or channel eq 'Notification' and startTime eq '2014-01-01T00:00:00Z'
            /// and endTime eq '2014-12-31T23:59:59Z' and timeGrain eq
            /// duration'[PT1H|PT1M|P1D]
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RecommendationInner>> ListAsync(this IRecommendationsOperations operations, bool? featured = default(bool?), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(featured, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Reset all recommendation opt-out settings for a subscription.
            /// </summary>
            /// <remarks>
            /// Reset all recommendation opt-out settings for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void ResetAllFilters(this IRecommendationsOperations operations)
            {
                operations.ResetAllFiltersAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reset all recommendation opt-out settings for a subscription.
            /// </summary>
            /// <remarks>
            /// Reset all recommendation opt-out settings for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResetAllFiltersAsync(this IRecommendationsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ResetAllFiltersWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get past recommendations for an app, optionally specified by the time
            /// range.
            /// </summary>
            /// <remarks>
            /// Get past recommendations for an app, optionally specified by the time
            /// range.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='siteName'>
            /// Name of the app.
            /// </param>
            /// <param name='filter'>
            /// Filter is specified by using OData syntax. Example: $filter=channels eq
            /// 'Api' or channel eq 'Notification' and startTime eq '2014-01-01T00:00:00Z'
            /// and endTime eq '2014-12-31T23:59:59Z' and timeGrain eq
            /// duration'[PT1H|PT1M|P1D]
            /// </param>
            public static IList<RecommendationInner> ListHistoryForWebApp(this IRecommendationsOperations operations, string resourceGroupName, string siteName, string filter = default(string))
            {
                return operations.ListHistoryForWebAppAsync(resourceGroupName, siteName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get past recommendations for an app, optionally specified by the time
            /// range.
            /// </summary>
            /// <remarks>
            /// Get past recommendations for an app, optionally specified by the time
            /// range.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='siteName'>
            /// Name of the app.
            /// </param>
            /// <param name='filter'>
            /// Filter is specified by using OData syntax. Example: $filter=channels eq
            /// 'Api' or channel eq 'Notification' and startTime eq '2014-01-01T00:00:00Z'
            /// and endTime eq '2014-12-31T23:59:59Z' and timeGrain eq
            /// duration'[PT1H|PT1M|P1D]
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RecommendationInner>> ListHistoryForWebAppAsync(this IRecommendationsOperations operations, string resourceGroupName, string siteName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListHistoryForWebAppWithHttpMessagesAsync(resourceGroupName, siteName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all recommendations for an app.
            /// </summary>
            /// <remarks>
            /// Get all recommendations for an app.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='siteName'>
            /// Name of the app.
            /// </param>
            /// <param name='featured'>
            /// Specify &lt;code&gt;true&lt;/code&gt; to return only the most critical
            /// recommendations. The default is &lt;code&gt;false&lt;/code&gt;, which
            /// returns all recommendations.
            /// </param>
            /// <param name='filter'>
            /// Return only channels specified in the filter. Filter is specified by using
            /// OData syntax. Example: $filter=channels eq 'Api' or channel eq
            /// 'Notification'
            /// </param>
            public static IList<RecommendationInner> ListRecommendedRulesForWebApp(this IRecommendationsOperations operations, string resourceGroupName, string siteName, bool? featured = default(bool?), string filter = default(string))
            {
                return operations.ListRecommendedRulesForWebAppAsync(resourceGroupName, siteName, featured, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all recommendations for an app.
            /// </summary>
            /// <remarks>
            /// Get all recommendations for an app.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='siteName'>
            /// Name of the app.
            /// </param>
            /// <param name='featured'>
            /// Specify &lt;code&gt;true&lt;/code&gt; to return only the most critical
            /// recommendations. The default is &lt;code&gt;false&lt;/code&gt;, which
            /// returns all recommendations.
            /// </param>
            /// <param name='filter'>
            /// Return only channels specified in the filter. Filter is specified by using
            /// OData syntax. Example: $filter=channels eq 'Api' or channel eq
            /// 'Notification'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RecommendationInner>> ListRecommendedRulesForWebAppAsync(this IRecommendationsOperations operations, string resourceGroupName, string siteName, bool? featured = default(bool?), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRecommendedRulesForWebAppWithHttpMessagesAsync(resourceGroupName, siteName, featured, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Disable all recommendations for an app.
            /// </summary>
            /// <remarks>
            /// Disable all recommendations for an app.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='siteName'>
            /// Name of the app.
            /// </param>
            public static void DisableAllForWebApp(this IRecommendationsOperations operations, string resourceGroupName, string siteName)
            {
                operations.DisableAllForWebAppAsync(resourceGroupName, siteName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disable all recommendations for an app.
            /// </summary>
            /// <remarks>
            /// Disable all recommendations for an app.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='siteName'>
            /// Name of the app.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DisableAllForWebAppAsync(this IRecommendationsOperations operations, string resourceGroupName, string siteName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DisableAllForWebAppWithHttpMessagesAsync(resourceGroupName, siteName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Reset all recommendation opt-out settings for an app.
            /// </summary>
            /// <remarks>
            /// Reset all recommendation opt-out settings for an app.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='siteName'>
            /// Name of the app.
            /// </param>
            public static void ResetAllFiltersForWebApp(this IRecommendationsOperations operations, string resourceGroupName, string siteName)
            {
                operations.ResetAllFiltersForWebAppAsync(resourceGroupName, siteName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reset all recommendation opt-out settings for an app.
            /// </summary>
            /// <remarks>
            /// Reset all recommendation opt-out settings for an app.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='siteName'>
            /// Name of the app.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResetAllFiltersForWebAppAsync(this IRecommendationsOperations operations, string resourceGroupName, string siteName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ResetAllFiltersForWebAppWithHttpMessagesAsync(resourceGroupName, siteName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get a recommendation rule for an app.
            /// </summary>
            /// <remarks>
            /// Get a recommendation rule for an app.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='siteName'>
            /// Name of the app.
            /// </param>
            /// <param name='name'>
            /// Name of the recommendation.
            /// </param>
            /// <param name='updateSeen'>
            /// Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of
            /// the recommendation object.
            /// </param>
            public static RecommendationRuleInner GetRuleDetailsByWebApp(this IRecommendationsOperations operations, string resourceGroupName, string siteName, string name, bool? updateSeen = default(bool?))
            {
                return operations.GetRuleDetailsByWebAppAsync(resourceGroupName, siteName, name, updateSeen).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a recommendation rule for an app.
            /// </summary>
            /// <remarks>
            /// Get a recommendation rule for an app.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='siteName'>
            /// Name of the app.
            /// </param>
            /// <param name='name'>
            /// Name of the recommendation.
            /// </param>
            /// <param name='updateSeen'>
            /// Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of
            /// the recommendation object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecommendationRuleInner> GetRuleDetailsByWebAppAsync(this IRecommendationsOperations operations, string resourceGroupName, string siteName, string name, bool? updateSeen = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRuleDetailsByWebAppWithHttpMessagesAsync(resourceGroupName, siteName, name, updateSeen, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
