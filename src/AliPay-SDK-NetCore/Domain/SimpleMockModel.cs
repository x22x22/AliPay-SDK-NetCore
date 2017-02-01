using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     SimpleMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleMockModel : AopObject
    {
        /// <summary>
        ///     11
        /// </summary>
        [XmlElement("count_items")]
        [JsonProperty("count_items", NullValueHandling = NullValueHandling.Ignore)]
        public long CountItems { get; set; }

        /// <summary>
        ///     111
        /// </summary>
        [XmlElement("happen_time")]
        [JsonProperty("happen_time", NullValueHandling = NullValueHandling.Ignore)]
        public string HappenTime { get; set; }

        /// <summary>
        ///     1.2f
        /// </summary>
        [XmlElement("price_num")]
        [JsonProperty("price_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceNum { get; set; }

        /// <summary>
        ///     false
        /// </summary>
        [XmlElement("right")]
        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public bool Right { get; set; }

        /// <summary>
        ///     trade_no
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}