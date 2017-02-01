using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeFastpayRefundQueryResponse.
    /// </summary>
    public class AlipayTradeFastpayRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 本笔退款对应的退款请求号
        /// </summary>
        [XmlElement("out_request_no")]
		[JsonProperty("out_request_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 创建交易传入的商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
		[JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次退款请求，对应的退款金额
        /// </summary>
        [XmlElement("refund_amount")]
		[JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 发起退款时，传入的退款原因
        /// </summary>
        [XmlElement("refund_reason")]
		[JsonProperty("refund_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundReason { get; set; }

        /// <summary>
        /// 该笔退款所对应的交易的订单金额
        /// </summary>
        [XmlElement("total_amount")]
		[JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
		[JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}
