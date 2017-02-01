using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarCarlibInfoPushModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCarlibInfoPushModel : AopObject
    {
        /// <summary>
        ///     品牌
        /// </summary>
        [XmlElement("brand")]
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        ///     排量
        /// </summary>
        [XmlElement("cc")]
        [JsonProperty("cc", NullValueHandling = NullValueHandling.Ignore)]
        public string Cc { get; set; }

        /// <summary>
        ///     厂商
        /// </summary>
        [XmlElement("company")]
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }

        /// <summary>
        ///     发动机型号
        /// </summary>
        [XmlElement("engine")]
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        ///     销售名字
        /// </summary>
        [XmlElement("marker")]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        ///     生产年份
        /// </summary>
        [XmlElement("prod_year")]
        [JsonProperty("prod_year", NullValueHandling = NullValueHandling.Ignore)]
        public string ProdYear { get; set; }

        /// <summary>
        ///     车系
        /// </summary>
        [XmlElement("serie")]
        [JsonProperty("serie", NullValueHandling = NullValueHandling.Ignore)]
        public string Serie { get; set; }

        /// <summary>
        ///     车款
        /// </summary>
        [XmlElement("style")]
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public string Style { get; set; }
    }
}