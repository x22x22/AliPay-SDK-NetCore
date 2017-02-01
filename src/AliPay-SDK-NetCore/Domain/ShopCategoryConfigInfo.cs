using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ShopCategoryConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopCategoryConfigInfo : AopObject
    {
        /// <summary>
        ///     类目ID
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        ///     是否是叶子节点
        /// </summary>
        [XmlElement("is_leaf")]
        [JsonProperty("is_leaf", NullValueHandling = NullValueHandling.Ignore)]
        public string IsLeaf { get; set; }

        /// <summary>
        ///     类目层级
        /// </summary>
        [XmlElement("level")]
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        ///     类目层级路径
        /// </summary>
        [XmlElement("link")]
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        ///     类目名称
        /// </summary>
        [XmlElement("nm")]
        [JsonProperty("nm", NullValueHandling = NullValueHandling.Ignore)]
        public string Nm { get; set; }
    }
}