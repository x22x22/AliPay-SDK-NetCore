using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     SinglePayDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SinglePayDetail : AopObject
    {
        /// <summary>
        ///     支付宝冻结订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        [JsonProperty("alipay_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        ///     本次支付金额
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     创建时间
        /// </summary>
        [XmlElement("create_time")]
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        ///     最近修改时间
        /// </summary>
        [XmlElement("modified_time")]
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        ///     本次支付url地址
        /// </summary>
        [XmlElement("pay_url")]
        [JsonProperty("pay_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PayUrl { get; set; }

        /// <summary>
        ///     收款人的userId
        /// </summary>
        [XmlElement("receive_user_id")]
        [JsonProperty("receive_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiveUserId { get; set; }

        /// <summary>
        ///     本次支付的支付宝流水号
        /// </summary>
        [XmlElement("transfer_order_no")]
        [JsonProperty("transfer_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferOrderNo { get; set; }

        /// <summary>
        ///     本次支付的外部单据号
        /// </summary>
        [XmlElement("transfer_out_order_no")]
        [JsonProperty("transfer_out_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferOutOrderNo { get; set; }
    }
}