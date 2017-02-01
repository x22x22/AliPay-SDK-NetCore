using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     VoucherUserExternalTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUserExternalTradeInfo : AopObject
    {
        /// <summary>
        ///     核销金额
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     核销时间
        /// </summary>
        [XmlElement("consume_date")]
        [JsonProperty("consume_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeDate { get; set; }

        /// <summary>
        ///     券核销的门店id
        /// </summary>
        [XmlElement("consume_shop_id")]
        [JsonProperty("consume_shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeShopId { get; set; }

        /// <summary>
        ///     外部交易号
        /// </summary>
        [XmlElement("external_trade_no")]
        [JsonProperty("external_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalTradeNo { get; set; }
    }
}