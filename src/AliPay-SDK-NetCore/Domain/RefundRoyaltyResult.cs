using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundRoyaltyResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundRoyaltyResult : AopObject
    {
        /// <summary>
        /// 退分润金额
        /// </summary>
        [XmlElement("refund_amount")]
		[JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退分润结果码
        /// </summary>
        [XmlElement("result_code")]
		[JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 转入人支付宝账号对应用户ID
        /// </summary>
        [XmlElement("trans_in")]
		[JsonProperty("trans_in", NullValueHandling = NullValueHandling.Ignore)]
        public string TransIn { get; set; }

        /// <summary>
        /// 转入人支付宝账号
        /// </summary>
        [XmlElement("trans_in_email")]
		[JsonProperty("trans_in_email", NullValueHandling = NullValueHandling.Ignore)]
        public string TransInEmail { get; set; }

        /// <summary>
        /// 转出人支付宝账号对应用户ID
        /// </summary>
        [XmlElement("trans_out")]
		[JsonProperty("trans_out", NullValueHandling = NullValueHandling.Ignore)]
        public string TransOut { get; set; }

        /// <summary>
        /// 转出人支付宝账号
        /// </summary>
        [XmlElement("trans_out_email")]
		[JsonProperty("trans_out_email", NullValueHandling = NullValueHandling.Ignore)]
        public string TransOutEmail { get; set; }
    }
}
