using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceOrderInfo : AopObject
    {
        /// <summary>
        /// 服务总金额，单位为元
        /// </summary>
        [XmlElement("amount")]
		[JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 订单创建时间，格式为  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_create")]
		[JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间，格式为  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_modified")]
		[JsonProperty("gmt_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 订单最后支付时间，格式：  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_payment")]
		[JsonProperty("gmt_payment", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 订单最后退款时间，格式：  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_refund")]
		[JsonProperty("gmt_refund", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 消费者标注订单备注
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 第三方服务id
        /// </summary>
        [XmlElement("out_service_id")]
		[JsonProperty("out_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 第三方服务者id列表，例子：  [“2323”,…]，如果没有服务者，则为[]
        /// </summary>
        [XmlArray("out_sp_id")]
        [XmlArrayItem("string")]
        public List<string> OutSpId { get; set; }

        /// <summary>
        /// 服务已付金额，单位为元
        /// </summary>
        [XmlElement("payment_amount")]
		[JsonProperty("payment_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 单价，单位为元
        /// </summary>
        [XmlElement("price")]
		[JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string Price { get; set; }

        /// <summary>
        /// 份数
        /// </summary>
        [XmlElement("quantity")]
		[JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public long Quantity { get; set; }

        /// <summary>
        /// 服务实际金额，单位为元
        /// </summary>
        [XmlElement("real_amount")]
		[JsonProperty("real_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RealAmount { get; set; }

        /// <summary>
        /// 订单退款金额，单位为元
        /// </summary>
        [XmlElement("refund_amount")]
		[JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 到位的服务id
        /// </summary>
        [XmlElement("service_id")]
		[JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务订单号
        /// </summary>
        [XmlElement("service_order_no")]
		[JsonProperty("service_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceOrderNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
		[JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}
