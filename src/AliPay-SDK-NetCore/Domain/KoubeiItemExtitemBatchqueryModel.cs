using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiItemExtitemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemBatchqueryModel : AopObject
    {
        /// <summary>
        ///     品牌编码
        /// </summary>
        [XmlElement("brand_code")]
        [JsonProperty("brand_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandCode { get; set; }

        /// <summary>
        ///     品类编码
        /// </summary>
        [XmlElement("category_code")]
        [JsonProperty("category_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }

        /// <summary>
        ///     当前页码。
        /// </summary>
        [XmlElement("page_num")]
        [JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PageNum { get; set; }

        /// <summary>
        ///     分页大小。最大50条，超过限制默认50
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }

        /// <summary>
        ///     商品名称（仅支持前缀匹配）
        /// </summary>
        [XmlElement("title")]
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }
}