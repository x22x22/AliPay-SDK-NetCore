using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ExtBrand Data Structure.
    /// </summary>
    [Serializable]
    public class ExtBrand : AopObject
    {
        /// <summary>
        ///     品牌编码
        /// </summary>
        [XmlElement("brand_code")]
        [JsonProperty("brand_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandCode { get; set; }

        /// <summary>
        ///     品牌名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}