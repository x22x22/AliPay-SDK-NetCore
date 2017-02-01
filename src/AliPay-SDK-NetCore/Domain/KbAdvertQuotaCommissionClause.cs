using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KbAdvertQuotaCommissionClause Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertQuotaCommissionClause : AopObject
    {
        /// <summary>
        ///     固定金额
        /// </summary>
        [XmlElement("quota_amount")]
        [JsonProperty("quota_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaAmount { get; set; }
    }
}