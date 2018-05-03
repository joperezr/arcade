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
    using System.Linq;

    public partial class WorkItemLog
    {
        /// <summary>
        /// Initializes a new instance of the WorkItemLog class.
        /// </summary>
        public WorkItemLog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkItemLog class.
        /// </summary>
        /// <param name="module">Module that log was sent from</param>
        /// <param name="uri">Uri to log data</param>
        public WorkItemLog(string module, string uri)
        {
            Module = module;
            Uri = uri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets module that log was sent from
        /// </summary>
        [JsonProperty(PropertyName = "Module")]
        public string Module { get; set; }

        /// <summary>
        /// Gets or sets uri to log data
        /// </summary>
        [JsonProperty(PropertyName = "Uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Module == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Module");
            }
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
        }
    }
}
