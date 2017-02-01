using System;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTrustUserScoreGetResponse.
    /// </summary>
    public class AlipayTrustUserScoreGetResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用通过模型计算出的该用户的芝麻信用评分
        /// </summary>
        [XmlElement("ali_trust_score")]
		[JsonProperty("ali_trust_score", NullValueHandling = NullValueHandling.Ignore)]
        public AliTrustScore AliTrustScore { get; set; }
    }
}
