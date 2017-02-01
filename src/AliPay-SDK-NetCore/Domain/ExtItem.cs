using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ExtItem Data Structure.
    /// </summary>
    [Serializable]
    public class ExtItem : AopObject
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
        ///     入数，必须为整数
        /// </summary>
        [XmlElement("count")]
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long Count { get; set; }

        /// <summary>
        ///     产地
        /// </summary>
        [XmlElement("country")]
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        ///     商品描述
        /// </summary>
        [XmlElement("description")]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        ///     商品id
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; set; }

        /// <summary>
        ///     商品条码
        /// </summary>
        [XmlElement("item_code")]
        [JsonProperty("item_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemCode { get; set; }

        /// <summary>
        ///     商品图片url
        /// </summary>
        [XmlElement("picture")]
        [JsonProperty("picture", NullValueHandling = NullValueHandling.Ignore)]
        public string Picture { get; set; }

        /// <summary>
        ///     参考价格，单位（分），必须为整数
        /// </summary>
        [XmlElement("price")]
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public long Price { get; set; }

        /// <summary>
        ///     商品规格
        /// </summary>
        [XmlElement("specification")]
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        ///     商品名称
        /// </summary>
        [XmlElement("title")]
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }
}