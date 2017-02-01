using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEcapiprodDrawndnDrawndnlistQueryResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnDrawndnlistQueryResponse : AopResponse
    {
        /// <summary>
        ///     支用列表
        /// </summary>
        [XmlArray("drawndn_list")]
        [XmlArrayItem("drawndn_vo")]
        public List<DrawndnVo> DrawndnList { get; set; }

        /// <summary>
        ///     唯一一次请求标示
        /// </summary>
        [XmlElement("request_id")]
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }
    }
}