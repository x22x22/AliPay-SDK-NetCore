using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarTradeRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarTradeRefundModel : AopObject
    {
        /// <summary>
        ///     渠道平台
        /// </summary>
        [XmlElement("isv")]
        [JsonProperty("isv", NullValueHandling = NullValueHandling.Ignore)]
        public string Isv { get; set; }

        /// <summary>
        ///     退款金额(分)
        /// </summary>
        [XmlElement("refund_fee")]
        [JsonProperty("refund_fee", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundFee { get; set; }

        /// <summary>
        ///     退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        [JsonProperty("refund_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundReason { get; set; }

        /// <summary>
        ///     退款交易编号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}