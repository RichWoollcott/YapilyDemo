﻿using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// MerchantInfo
    /// </summary>    
    public class MerchantInfo
    {

        /// <summary>
        /// CategoryCode
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("categoryCode")]
        public string CategoryCode { get; set; }


        /// <summary>
        /// CustomerId
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("customerId")]
        public string CustomerId { get; set; }


        /// <summary>
        /// Address
        /// </summary> 
        [Required]
        [AliasAs("address")]
        public Address Address { get; set; } = new Address();

    }
}