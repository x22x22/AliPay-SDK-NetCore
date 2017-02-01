using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PricingVO Data Structure.
    /// </summary>
    [Serializable]
    public class PricingVO : AopObject
    {
        /// <summary>
        /// 买入价
        /// </summary>
        [XmlElement("bid")]
		[JsonProperty("bid", NullValueHandling = NullValueHandling.Ignore)]
        public string Bid { get; set; }

        /// <summary>
        /// 基准币种
        /// </summary>
        [XmlElement("currency")]
		[JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 基本币种单位
        /// </summary>
        [XmlElement("currency_unit")]
		[JsonProperty("currency_unit", NullValueHandling = NullValueHandling.Ignore)]
        public long CurrencyUnit { get; set; }

        /// <summary>
        /// 汇率失效时间yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("expiry_timestamp")]
		[JsonProperty("expiry_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryTimestamp { get; set; }

        /// <summary>
        /// 汇率生成时间 用来做幂等 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("generate_timestamp")]
		[JsonProperty("generate_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string GenerateTimestamp { get; set; }

        /// <summary>
        /// 远期或者掉期到期时间 yyyyMMdd
        /// </summary>
        [XmlElement("maturity_date")]
		[JsonProperty("maturity_date", NullValueHandling = NullValueHandling.Ignore)]
        public string MaturityDate { get; set; }

        /// <summary>
        /// 该价格的最大买入量
        /// </summary>
        [XmlElement("maximum_bid_amount")]
		[JsonProperty("maximum_bid_amount", NullValueHandling = NullValueHandling.Ignore)]
        public long MaximumBidAmount { get; set; }

        /// <summary>
        /// 该价格的最大卖出量
        /// </summary>
        [XmlElement("maximum_offer_amount")]
		[JsonProperty("maximum_offer_amount", NullValueHandling = NullValueHandling.Ignore)]
        public long MaximumOfferAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 中间价
        /// </summary>
        [XmlElement("mid")]
		[JsonProperty("mid", NullValueHandling = NullValueHandling.Ignore)]
        public string Mid { get; set; }

        /// <summary>
        /// 该价格的最小买入量
        /// </summary>
        [XmlElement("minimum_bid_amount")]
		[JsonProperty("minimum_bid_amount", NullValueHandling = NullValueHandling.Ignore)]
        public long MinimumBidAmount { get; set; }

        /// <summary>
        /// 该价格的最小卖出量
        /// </summary>
        [XmlElement("minimum_offer_amount")]
		[JsonProperty("minimum_offer_amount", NullValueHandling = NullValueHandling.Ignore)]
        public long MinimumOfferAmount { get; set; }

        /// <summary>
        /// 卖出价
        /// </summary>
        [XmlElement("offer")]
		[JsonProperty("offer", NullValueHandling = NullValueHandling.Ignore)]
        public string Offer { get; set; }

        /// <summary>
        /// 标准期限TODAY TOM SPOT 1D 1W 1M 1Y
        /// </summary>
        [XmlElement("period")]
		[JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 源汇率参考id 唯一id
        /// </summary>
        [XmlElement("rate_reference_id")]
		[JsonProperty("rate_reference_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RateReferenceId { get; set; }

        /// <summary>
        /// 汇率类型 SPOT FORWARD
        /// </summary>
        [XmlElement("rate_type")]
		[JsonProperty("rate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RateType { get; set; }

        /// <summary>
        /// 即期买入价
        /// </summary>
        [XmlElement("spot_bid")]
		[JsonProperty("spot_bid", NullValueHandling = NullValueHandling.Ignore)]
        public string SpotBid { get; set; }

        /// <summary>
        /// 即期中间价
        /// </summary>
        [XmlElement("spot_mid")]
		[JsonProperty("spot_mid", NullValueHandling = NullValueHandling.Ignore)]
        public string SpotMid { get; set; }

        /// <summary>
        /// 即期卖出价
        /// </summary>
        [XmlElement("spot_offer")]
		[JsonProperty("spot_offer", NullValueHandling = NullValueHandling.Ignore)]
        public string SpotOffer { get; set; }

        /// <summary>
        /// 汇率生效时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_timestamp")]
		[JsonProperty("start_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTimestamp { get; set; }

        /// <summary>
        /// 货币对
        /// </summary>
        [XmlElement("symbol")]
		[JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        /// <summary>
        /// 汇率缓冲时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("threshold_timestamp")]
		[JsonProperty("threshold_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string ThresholdTimestamp { get; set; }

        /// <summary>
        /// 锁汇失效时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_timestamp")]
		[JsonProperty("valid_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidTimestamp { get; set; }
    }
}
