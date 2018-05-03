// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CancellationToken
    {
        /// <summary>
        /// Initializes a new instance of the CancellationToken class.
        /// </summary>
        public CancellationToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CancellationToken class.
        /// </summary>
        public CancellationToken(bool? isCancellationRequested = default(bool?), bool? canBeCanceled = default(bool?), WaitHandle waitHandle = default(WaitHandle))
        {
            IsCancellationRequested = isCancellationRequested;
            CanBeCanceled = canBeCanceled;
            WaitHandle = waitHandle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCancellationRequested")]
        public bool? IsCancellationRequested { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeCanceled")]
        public bool? CanBeCanceled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WaitHandle")]
        public WaitHandle WaitHandle { get; set; }

    }
}
