using System;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayZmscoreZrankGetResponse.
    /// </summary>
    public class AlipayZmscoreZrankGetResponse : AopResponse
    {
        /// <summary>
        /// 芝麻分分段
        /// </summary>
        [XmlElement("zm_score_zrank")]
		[JsonProperty("zm_score_zrank", NullValueHandling = NullValueHandling.Ignore)]
        public AlipayZmScoreZrankResult ZmScoreZrank { get; set; }
    }
}
