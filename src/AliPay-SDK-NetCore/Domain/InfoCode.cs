using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InfoCode Data Structure.
    /// </summary>
    [Serializable]
    public class InfoCode : AopObject
    {
        /// <summary>
        ///     风险描述
        /// </summary>
        [XmlElement("risk_description")]
        [JsonProperty("risk_description", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskDescription { get; set; }

        /// <summary>
        ///     风险因素编码
        /// </summary>
        [XmlElement("risk_factor_code")]
        [JsonProperty("risk_factor_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskFactorCode { get; set; }

        /// <summary>
        ///     风险因素名称
        /// </summary>
        [XmlElement("risk_factor_name")]
        [JsonProperty("risk_factor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskFactorName { get; set; }

        /// <summary>
        ///     风险度量
        /// </summary>
        [XmlElement("risk_magnitude")]
        [JsonProperty("risk_magnitude", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskMagnitude { get; set; }
    }
}