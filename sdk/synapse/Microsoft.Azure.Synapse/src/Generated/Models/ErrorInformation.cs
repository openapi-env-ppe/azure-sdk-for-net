// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ErrorInformation
    {
        /// <summary>
        /// Initializes a new instance of the ErrorInformation class.
        /// </summary>
        public ErrorInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorInformation class.
        /// </summary>
        /// <param name="source">Possible values include: 'System', 'User',
        /// 'Unknown', 'Dependency'</param>
        public ErrorInformation(string message = default(string), string errorCode = default(string), string source = default(string))
        {
            Message = message;
            ErrorCode = errorCode;
            Source = source;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'System', 'User', 'Unknown',
        /// 'Dependency'
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

    }
}
