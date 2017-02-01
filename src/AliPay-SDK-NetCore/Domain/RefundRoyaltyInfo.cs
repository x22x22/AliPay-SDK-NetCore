using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundRoyaltyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RefundRoyaltyInfo : AopObject
    {
        /// <summary>
        /// 退分润备注
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 退分润金额
        /// </summary>
        [XmlElement("refund_amount")]
		[JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 转入人支付宝账号对应用户ID[2088开头16位纯数字]；  trans_in和trans_in_email不能同时为空。
        /// </summary>
        [XmlElement("trans_in")]
		[JsonProperty("trans_in", NullValueHandling = NullValueHandling.Ignore)]
        public string TransIn { get; set; }

        /// <summary>
        /// 转入人支付宝账号[原付出分润金额的账户]  trans_in和trans_in_email不能同时为空。
        /// </summary>
        [XmlElement("trans_in_email")]
		[JsonProperty("trans_in_email", NullValueHandling = NullValueHandling.Ignore)]
        public string TransInEmail { get; set; }

        /// <summary>
        /// 转出人支付宝账号对应用户ID[2088开头16位纯数字]；  trans_out和trans_out_email不能同时为空
        /// </summary>
        [XmlElement("trans_out")]
		[JsonProperty("trans_out", NullValueHandling = NullValueHandling.Ignore)]
        public string TransOut { get; set; }

        /// <summary>
        /// 转出人支付宝账号[原收到分润金额的账户]；  trans_out和trans_out_email不能同时为空。
        /// </summary>
        [XmlElement("trans_out_email")]
		[JsonProperty("trans_out_email", NullValueHandling = NullValueHandling.Ignore)]
        public string TransOutEmail { get; set; }
    }
}
