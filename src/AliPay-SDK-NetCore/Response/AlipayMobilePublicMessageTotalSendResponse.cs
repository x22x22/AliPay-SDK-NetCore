using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobilePublicMessageTotalSendResponse.
    /// </summary>
    public class AlipayMobilePublicMessageTotalSendResponse : AopResponse
    {
        /// <summary>
        ///     结果码
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public new string Code { get; set; }

        /// <summary>
        ///     消息ID
        /// </summary>
        [XmlElement("data")]
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        /// <summary>
        ///     结果描述
        /// </summary>
        [XmlElement("msg")]
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public new string Msg { get; set; }
    }
}