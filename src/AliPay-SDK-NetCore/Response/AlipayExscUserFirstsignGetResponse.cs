using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayExscUserFirstsignGetResponse.
    /// </summary>
    public class AlipayExscUserFirstsignGetResponse : AopResponse
    {
        /// <summary>
        /// 返回结果的业务类型。首次快捷绑卡业务类型 （first_sign）
        /// </summary>
        [XmlElement("biz_type")]
		[JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        /// 业务处理结果   true 无绑卡记录，本次是首次绑卡   false 曾经绑过快捷卡，本次不是首次绑卡
        /// </summary>
        [XmlElement("success")]
		[JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; }
    }
}
