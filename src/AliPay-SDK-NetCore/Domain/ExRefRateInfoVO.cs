using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExRefRateInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ExRefRateInfoVO : AopObject
    {
        /// <summary>
        /// 货币对
        /// </summary>
        [XmlElement("currency_pair")]
		[JsonProperty("currency_pair", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// 基础币种
        /// </summary>
        [XmlElement("datum_currency")]
		[JsonProperty("datum_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string DatumCurrency { get; set; }

        /// <summary>
        /// 牌价类型，表示站在用户角度，对目标币种的交易方向，01表示买入，02表示卖出
        /// </summary>
        [XmlElement("price_type")]
		[JsonProperty("price_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceType { get; set; }

        /// <summary>
        /// 报价日期，格式为YYYYMMDD
        /// </summary>
        [XmlElement("pub_date")]
		[JsonProperty("pub_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PubDate { get; set; }

        /// <summary>
        /// 报价时间
        /// </summary>
        [XmlElement("pub_time")]
		[JsonProperty("pub_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PubTime { get; set; }

        /// <summary>
        /// 汇率，表示一单位基准币种等于多少目标币种，小数点后最多精确到8位
        /// </summary>
        [XmlElement("rate")]
		[JsonProperty("rate", NullValueHandling = NullValueHandling.Ignore)]
        public string Rate { get; set; }

        /// <summary>
        /// 目标币种
        /// </summary>
        [XmlElement("target_currency")]
		[JsonProperty("target_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetCurrency { get; set; }
    }
}
