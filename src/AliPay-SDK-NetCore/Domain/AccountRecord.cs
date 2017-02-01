using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountRecord Data Structure.
    /// </summary>
    [Serializable]
    public class AccountRecord : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
		[JsonProperty("alipay_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 当时账户的余额
        /// </summary>
        [XmlElement("balance")]
		[JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public string Balance { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("business_type")]
		[JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
		[JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 收入金额
        /// </summary>
        [XmlElement("in_amount")]
		[JsonProperty("in_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string InAmount { get; set; }

        /// <summary>
        /// 账务备注说明
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
		[JsonProperty("merchant_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 对方支付宝账户ID
        /// </summary>
        [XmlElement("opt_user_id")]
		[JsonProperty("opt_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OptUserId { get; set; }

        /// <summary>
        /// 支出金额
        /// </summary>
        [XmlElement("out_amount")]
		[JsonProperty("out_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OutAmount { get; set; }

        /// <summary>
        /// 本方支付宝账户ID
        /// </summary>
        [XmlElement("self_user_id")]
		[JsonProperty("self_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SelfUserId { get; set; }

        /// <summary>
        /// 账务类型
        /// </summary>
        [XmlElement("type")]
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
