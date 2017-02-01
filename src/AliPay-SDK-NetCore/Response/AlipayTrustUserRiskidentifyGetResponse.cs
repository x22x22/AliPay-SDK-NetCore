using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayTrustUserRiskidentifyGetResponse.
    /// </summary>
    public class AlipayTrustUserRiskidentifyGetResponse : AopResponse
    {
        /// <summary>
        ///     行业关注名单识别结果
        /// </summary>
        [XmlElement("ali_trust_risk_identify")]
        [JsonProperty("ali_trust_risk_identify", NullValueHandling = NullValueHandling.Ignore)]
        public AliTrustRiskIdentify AliTrustRiskIdentify { get; set; }
    }
}