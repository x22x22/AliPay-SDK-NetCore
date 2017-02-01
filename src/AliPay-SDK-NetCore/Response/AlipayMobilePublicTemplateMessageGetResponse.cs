using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicTemplateMessageGetResponse.
    /// </summary>
    public class AlipayMobilePublicTemplateMessageGetResponse : AopResponse
    {
        /// <summary>
        /// 消息模板id--商户领取母版后生成的唯一模板id
        /// </summary>
        [XmlElement("msg_template_id")]
		[JsonProperty("msg_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MsgTemplateId { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [XmlElement("template")]
		[JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public string Template { get; set; }
    }
}
