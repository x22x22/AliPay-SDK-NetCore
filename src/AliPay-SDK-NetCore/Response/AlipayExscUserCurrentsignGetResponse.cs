using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayExscUserCurrentsignGetResponse.
    /// </summary>
    public class AlipayExscUserCurrentsignGetResponse : AopResponse
    {
        /// <summary>
        /// 返回结果的业务类型。当前签约绑卡业务类型 （current_sign）
        /// </summary>
        [XmlElement("biz_type")]
		[JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        /// 业务处理结果   true 无资金流入记录，本次是首次交易   false 已有资金流入记录，本次不是首次交易
        /// </summary>
        [XmlElement("success")]
		[JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; }
    }
}
