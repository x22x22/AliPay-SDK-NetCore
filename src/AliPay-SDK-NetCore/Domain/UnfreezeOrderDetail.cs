using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     UnfreezeOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UnfreezeOrderDetail : AopObject
    {
        /// <summary>
        ///     支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        [JsonProperty("alipay_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        ///     订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        [XmlElement("memo")]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        ///     冻结订单的商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        [JsonProperty("merchant_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        ///     订单的最近修改时间
        /// </summary>
        [XmlElement("modified_time")]
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        ///     冻结金额（含服务费）
        /// </summary>
        [XmlElement("order_amount")]
        [JsonProperty("order_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderAmount { get; set; }

        /// <summary>
        ///     订单状态：I：初始，S：成功，F：失败
        /// </summary>
        [XmlElement("order_status")]
        [JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        ///     解冻金额（含服务费）
        /// </summary>
        [XmlElement("unfreeze_amount")]
        [JsonProperty("unfreeze_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string UnfreezeAmount { get; set; }
    }
}