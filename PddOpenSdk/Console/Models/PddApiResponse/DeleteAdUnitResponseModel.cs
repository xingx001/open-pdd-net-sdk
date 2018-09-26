// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PddOpenSdk.Models.PddApiResponse
{

    public class AdUnitDeleteResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class DeleteAdUnitResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_unit_delete_response")]
        public AdUnitDeleteResponse AdUnitDeleteResponse { get; set; }
    }

}
