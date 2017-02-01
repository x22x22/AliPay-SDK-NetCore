using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     MerchantScreenHit Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantScreenHit : AopObject
    {
        /// <summary>
        ///     送检的实体类型，如CEO，控股人，等
        /// </summary>
        [XmlElement("input_type")]
        [JsonProperty("input_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InputType { get; set; }

        /// <summary>
        ///     命中详情
        /// </summary>
        [XmlElement("risk_detail")]
        [JsonProperty("risk_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskDetail { get; set; }
    }
}