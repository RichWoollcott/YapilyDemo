﻿using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// AuthorisationEmbeddedRequestResponse
    /// </summary>    
    public class AuthorisationEmbeddedRequestResponse
    {

        /// <summary>
        /// Id
        /// </summary> 

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// UserUuid
        /// </summary> 

        [AliasAs("userUuid")]
        public string UserUuid { get; set; }


        /// <summary>
        /// ApplicationUserId
        /// </summary> 

        [AliasAs("applicationUserId")]
        public string ApplicationUserId { get; set; }


        /// <summary>
        /// ReferenceId
        /// </summary> 

        [AliasAs("referenceId")]
        public string ReferenceId { get; set; }


        /// <summary>
        /// InstitutionId
        /// </summary> 

        [AliasAs("institutionId")]
        public string InstitutionId { get; set; }


        /// <summary>
        /// Status
        /// </summary> 

        [AliasAs("status")]
        public AuthorisationEmbeddedRequestResponseStatus? Status { get; set; }


        /// <summary>
        /// CreatedAt
        /// </summary> 

        [AliasAs("createdAt")]
        public System.DateTimeOffset? CreatedAt { get; set; }


        /// <summary>
        /// TransactionFrom
        /// </summary> 

        [AliasAs("transactionFrom")]
        public System.DateTimeOffset? TransactionFrom { get; set; }


        /// <summary>
        /// TransactionTo
        /// </summary> 

        [AliasAs("transactionTo")]
        public System.DateTimeOffset? TransactionTo { get; set; }


        /// <summary>
        /// ExpiresAt
        /// </summary> 

        [AliasAs("expiresAt")]
        public System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// Deprecated. Use `timeToExpire` instead.
        /// </summary>
        [AliasAs("timeToExpireInMillis")]
        public long? TimeToExpireInMillis { get; set; }

        /// <summary>
        /// ISO 8601 duration
        /// </summary>
        [AliasAs("timeToExpire")]
        public string TimeToExpire { get; set; }


        /// <summary>
        /// FeatureScope
        /// </summary> 

        [AliasAs("featureScope")]
        public List<FeatureScope2> FeatureScope { get; set; }


        /// <summary>
        /// AuthorisationUrl
        /// </summary> 

        [AliasAs("authorisationUrl")]
        public string AuthorisationUrl { get; set; }


        /// <summary>
        /// ConsentToken
        /// </summary> 

        [AliasAs("consentToken")]
        public string ConsentToken { get; set; }


        /// <summary>
        /// QrCodeUrl
        /// </summary> 

        [AliasAs("qrCodeUrl")]
        public string QrCodeUrl { get; set; }


        /// <summary>
        /// ScaMethods
        /// </summary> 

        [AliasAs("scaMethods")]
        public List<ScaMethod> ScaMethods { get; set; }


        /// <summary>
        /// State
        /// </summary> 

        [AliasAs("state")]
        public string State { get; set; }


        /// <summary>
        /// SelectedScaMethod
        /// </summary> 

        [AliasAs("selectedScaMethod")]
        public ScaMethod SelectedScaMethod { get; set; }


        /// <summary>
        /// AuthorizedAt
        /// </summary> 

        [AliasAs("authorizedAt")]
        public System.DateTimeOffset? AuthorizedAt { get; set; }


        /// <summary>
        /// InstitutionConsentId
        /// </summary> 

        [AliasAs("institutionConsentId")]
        public string InstitutionConsentId { get; set; }

    }
}