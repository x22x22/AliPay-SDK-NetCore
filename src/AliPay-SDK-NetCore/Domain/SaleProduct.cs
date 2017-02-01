using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleProduct Data Structure.
    /// </summary>
    [Serializable]
    public class SaleProduct : AopObject
    {
        /// <summary>
        /// 宝贝来源 例如：TAOBAO ALIPAY
        /// </summary>
        [XmlElement("channel_type")]
		[JsonProperty("channel_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelType { get; set; }

        /// <summary>
        /// 销售产品DB ID
        /// </summary>
        [XmlElement("id")]
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 面额
        /// </summary>
        [XmlElement("market_price")]
		[JsonProperty("market_price", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketPrice { get; set; }

        /// <summary>
        /// 充值产品提供商
        /// </summary>
        [XmlElement("product_provider")]
		[JsonProperty("product_provider", NullValueHandling = NullValueHandling.Ignore)]
        public ProductProvider ProductProvider { get; set; }

        /// <summary>
        /// 销售价格
        /// </summary>
        [XmlElement("sale_price")]
		[JsonProperty("sale_price", NullValueHandling = NullValueHandling.Ignore)]
        public string SalePrice { get; set; }

        /// <summary>
        /// 产品状态, 0为不可用，1为可用
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}
