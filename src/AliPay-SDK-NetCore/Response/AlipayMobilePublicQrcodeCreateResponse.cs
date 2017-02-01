using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobilePublicQrcodeCreateResponse.
    /// </summary>
    public class AlipayMobilePublicQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        ///     返回结果码，如200，标识成功
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public new string Code { get; set; }

        /// <summary>
        ///     图片地址
        /// </summary>
        [XmlElement("code_img")]
        [JsonProperty("code_img", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeImg { get; set; }

        /// <summary>
        ///     码过期时间，单位：秒
        /// </summary>
        [XmlElement("expire_second")]
        [JsonProperty("expire_second", NullValueHandling = NullValueHandling.Ignore)]
        public long ExpireSecond { get; set; }

        /// <summary>
        ///     结果吗描述信息
        /// </summary>
        [XmlElement("msg")]
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public new string Msg { get; set; }
    }
}