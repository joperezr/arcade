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

    public partial class AnalysisCount
    {
        /// <summary>
        /// Initializes a new instance of the AnalysisCount class.
        /// </summary>
        public AnalysisCount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AnalysisCount class.
        /// </summary>
        public AnalysisCount(string name, IDictionary<string, int?> status)
        {
            Name = name;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public IDictionary<string, int?> Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}
