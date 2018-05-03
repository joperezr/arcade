// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobDetails class.
        /// </summary>
        public JobDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobDetails class.
        /// </summary>
        /// <param name="jobList">URI to the job list this job used</param>
        /// <param name="workItems">List of work item counts in various
        /// stages</param>
        /// <param name="name">Name of the job</param>
        /// <param name="waitUrl">Url that can be queried to wait for job
        /// completion</param>
        /// <param name="creator">User ID of the creator of the job</param>
        /// <param name="created">    Time the job was created, using the "O"
        /// DateTimeOffset format specifier.
        /// ("yyyy-MM-ddTHH:mm:ss.fffffffK")</param>
        /// <param name="finished">Time the job was finished, if it was
        /// finished.</param>
        /// <param name="initialWorkItemCount">Number of work items present in
        /// initial upload. Note that additional work items may be created
        /// during execution, so the final "finished" number may be higher than
        /// this.</param>
        public JobDetails(string jobList, JobWorkItemCounts workItems, string name, string waitUrl, string source, string type, string build, FailureReason failureReason = default(FailureReason), string queueId = default(string), string creator = default(string), string created = default(string), string finished = default(string), int? initialWorkItemCount = default(int?), object properties = default(object), IList<WorkItemError> errors = default(IList<WorkItemError>))
        {
            FailureReason = failureReason;
            QueueId = queueId;
            JobList = jobList;
            WorkItems = workItems;
            Name = name;
            Creator = creator;
            Created = created;
            Finished = finished;
            InitialWorkItemCount = initialWorkItemCount;
            WaitUrl = waitUrl;
            Source = source;
            Type = type;
            Build = build;
            Properties = properties;
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FailureReason")]
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueId")]
        public string QueueId { get; set; }

        /// <summary>
        /// Gets or sets URI to the job list this job used
        /// </summary>
        [JsonProperty(PropertyName = "JobList")]
        public string JobList { get; set; }

        /// <summary>
        /// Gets or sets list of work item counts in various stages
        /// </summary>
        [JsonProperty(PropertyName = "WorkItems")]
        public JobWorkItemCounts WorkItems { get; set; }

        /// <summary>
        /// Gets or sets name of the job
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets user ID of the creator of the job
        /// </summary>
        [JsonProperty(PropertyName = "Creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or sets     Time the job was created, using the "O"
        /// DateTimeOffset format specifier.
        /// ("yyyy-MM-ddTHH:mm:ss.fffffffK")
        /// </summary>
        [JsonProperty(PropertyName = "Created")]
        public string Created { get; set; }

        /// <summary>
        /// Gets or sets time the job was finished, if it was finished.
        /// </summary>
        [JsonProperty(PropertyName = "Finished")]
        public string Finished { get; set; }

        /// <summary>
        /// Gets or sets number of work items present in initial upload. Note
        /// that additional work items may be created
        /// during execution, so the final "finished" number may be higher than
        /// this.
        /// </summary>
        [JsonProperty(PropertyName = "InitialWorkItemCount")]
        public int? InitialWorkItemCount { get; set; }

        /// <summary>
        /// Gets or sets url that can be queried to wait for job completion
        /// </summary>
        [JsonProperty(PropertyName = "WaitUrl")]
        public string WaitUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Source")]
        public string Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Build")]
        public string Build { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Properties")]
        public object Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Errors")]
        public IList<WorkItemError> Errors { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (JobList == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JobList");
            }
            if (WorkItems == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkItems");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (WaitUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WaitUrl");
            }
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Build == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Build");
            }
            if (WorkItems != null)
            {
                WorkItems.Validate();
            }
            if (Errors != null)
            {
                foreach (var element in Errors)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
