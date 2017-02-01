using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeMsgSendResponse.
    /// </summary>
    public class AlipayOpenPublicLifeMsgSendResponse : AopResponse
    {
        /// <summary>
        /// 生活号消息唯一标识
        /// </summary>
        [XmlElement("alipay_msg_id")]
		[JsonProperty("alipay_msg_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayMsgId { get; set; }
    }
}
