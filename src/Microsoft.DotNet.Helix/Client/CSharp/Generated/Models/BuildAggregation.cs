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

    public partial class BuildAggregation
    {
        /// <summary>
        /// Initializes a new instance of the BuildAggregation class.
        /// </summary>
        public BuildAggregation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildAggregation class.
        /// </summary>
        public BuildAggregation(string buildNumber, IDictionary<string, BuildAggregationSource> sources = default(IDictionary<string, BuildAggregationSource>))
        {
            BuildNumber = buildNumber;
            Sources = sources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BuildNumber")]
        public string BuildNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Sources")]
        public IDictionary<string, BuildAggregationSource> Sources { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BuildNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BuildNumber");
            }
        }
    }
}
