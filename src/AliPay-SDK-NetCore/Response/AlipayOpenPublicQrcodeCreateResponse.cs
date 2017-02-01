using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicQrcodeCreateResponse.
    /// </summary>
    public class AlipayOpenPublicQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 二维码图片地址，可跳转到实际图片
        /// </summary>
        [XmlElement("code_img")]
		[JsonProperty("code_img", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeImg { get; set; }

        /// <summary>
        /// 二维码有效时间，单位（秒）。永久码暂时忽略该信息
        /// </summary>
        [XmlElement("expire_second")]
		[JsonProperty("expire_second", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireSecond { get; set; }
    }
}
