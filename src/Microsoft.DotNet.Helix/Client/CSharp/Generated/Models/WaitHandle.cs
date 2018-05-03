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

    public partial class WaitHandle
    {
        /// <summary>
        /// Initializes a new instance of the WaitHandle class.
        /// </summary>
        public WaitHandle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WaitHandle class.
        /// </summary>
        public WaitHandle(object handle = default(object), SafeWaitHandle safeWaitHandle = default(SafeWaitHandle))
        {
            Handle = handle;
            SafeWaitHandle = safeWaitHandle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Handle")]
        public object Handle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SafeWaitHandle")]
        public SafeWaitHandle SafeWaitHandle { get; set; }

    }
}
