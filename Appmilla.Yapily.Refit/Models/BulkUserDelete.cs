﻿using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// BulkUserDelete
    /// </summary>    
    public class BulkUserDelete
    {

        /// <summary>
        /// Id
        /// </summary> 

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// Status
        /// </summary> 

        [AliasAs("status")]
        public BulkUserDeleteStatus? Status { get; set; }


        /// <summary>
        /// StartedAt
        /// </summary> 

        [AliasAs("startedAt")]
        public System.DateTimeOffset? StartedAt { get; set; }


        /// <summary>
        /// Links
        /// </summary> 

        [AliasAs("links")]
        public System.Collections.Generic.IDictionary<string, string> Links { get; set; }

    }
}