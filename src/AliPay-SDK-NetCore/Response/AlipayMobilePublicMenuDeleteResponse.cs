using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobilePublicMenuDeleteResponse.
    /// </summary>
    public class AlipayMobilePublicMenuDeleteResponse : AopResponse
    {
        /// <summary>
        ///     结果码
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public new string Code { get; set; }

        /// <summary>
        ///     结果描述
        /// </summary>
        [XmlElement("msg")]
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public new string Msg { get; set; }
    }
}