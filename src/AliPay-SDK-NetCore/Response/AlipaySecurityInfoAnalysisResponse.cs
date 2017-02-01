using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityInfoAnalysisResponse.
    /// </summary>
    public class AlipaySecurityInfoAnalysisResponse : AopResponse
    {
        /// <summary>
        /// 风险标签
        /// </summary>
        [XmlElement("risk_code")]
		[JsonProperty("risk_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskCode { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [XmlElement("risk_level")]
		[JsonProperty("risk_level", NullValueHandling = NullValueHandling.Ignore)]
        public long RiskLevel { get; set; }
    }
}
