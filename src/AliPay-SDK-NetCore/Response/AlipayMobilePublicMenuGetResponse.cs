using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuGetResponse.
    /// </summary>
    public class AlipayMobilePublicMenuGetResponse : AopResponse
    {
        /// <summary>
        /// success
        /// </summary>
        [XmlElement("code")]
		[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public new string Code { get; set; }

        /// <summary>
        /// 菜单内容
        /// </summary>
        [XmlElement("menu_content")]
		[JsonProperty("menu_content", NullValueHandling = NullValueHandling.Ignore)]
        public string MenuContent { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("msg")]
		[JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public new string Msg { get; set; }
    }
}
