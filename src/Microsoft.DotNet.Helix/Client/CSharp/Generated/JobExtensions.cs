// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Job.
    /// </summary>
    public static partial class JobExtensions
    {
            /// <summary>
            /// List most recent set of jobs matching specified criteria
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='count'>
            /// The maximum number of jobs to return.
            /// </param>
            /// <param name='filtercreator'>
            /// The job creator.
            /// </param>
            /// <param name='filtersource'>
            /// The job source.
            /// </param>
            /// <param name='filtertype'>
            /// The job type.
            /// </param>
            /// <param name='filterbuild'>
            /// The build number.
            /// </param>
            /// <param name='filtername'>
            /// The Name/CorrelationId number.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<JobSummary>> ListAsync(this IJob operations, int? count = default(int?), string filtercreator = default(string), string filtersource = default(string), string filtertype = default(string), string filterbuild = default(string), string filtername = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(count, filtercreator, filtersource, filtertype, filterbuild, filtername, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='newJob'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobCreationResult> NewOperationAsync(this IJob operations, JobCreationRequest newJob, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.NewOperationWithHttpMessagesAsync(newJob, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> JenkinsAsync(this IJob operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.JenkinsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Provide a summary about a job, not including any work item statistics
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// Name of job
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobSummary> SummaryAsync(this IJob operations, string job, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.SummaryWithHttpMessagesAsync(job, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Provide the same data in the summary, but also include aggregated work item
            /// statistics,
            /// including counts at each stage in the pipeline
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// Name of job
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobDetails> DetailsAsync(this IJob operations, string job, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DetailsWithHttpMessagesAsync(job, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Wait for job completion. If the server has to abandon the request, a 503
            /// with a Retry-After will
            /// be returned (as well as a "{ retryAfter: 30}", with the number of seconds
            /// to wait until retrying.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// Job to wait for
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> WaitAsync(this IJob operations, string job, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.WaitWithHttpMessagesAsync(job, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
