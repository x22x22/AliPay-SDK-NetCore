using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayTrustUserRiskSummaryGetResponse.
    /// </summary>
    public class AlipayTrustUserRiskSummaryGetResponse : AopResponse
    {
        /// <summary>
        ///     是否在风险名单
        /// </summary>
        [XmlElement("risk_code")]
        [JsonProperty("risk_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskCode { get; set; }
    }
}