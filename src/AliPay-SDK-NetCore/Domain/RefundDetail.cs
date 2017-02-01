using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     RefundDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RefundDetail : AopObject
    {
        /// <summary>
        ///     交易退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        [JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        ///     退款备注
        /// </summary>
        [XmlElement("refund_memo")]
        [JsonProperty("refund_memo", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundMemo { get; set; }

        /// <summary>
        ///     退分润列表
        /// </summary>
        [XmlArray("refund_royaltys")]
        [XmlArrayItem("refund_royalty_info")]
        public List<RefundRoyaltyInfo> RefundRoyaltys { get; set; }

        /// <summary>
        ///     退补差金额
        /// </summary>
        [XmlElement("refund_suppl_amount")]
        [JsonProperty("refund_suppl_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundSupplAmount { get; set; }

        /// <summary>
        ///     退补差备注
        /// </summary>
        [XmlElement("refund_suppl_memo")]
        [JsonProperty("refund_suppl_memo", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundSupplMemo { get; set; }

        /// <summary>
        ///     支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}