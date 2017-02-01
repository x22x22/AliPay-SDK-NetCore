using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopCategoryInfo : AopObject
    {
        /// <summary>
        /// 类目编号
        /// </summary>
        [XmlElement("category_id")]
		[JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }

        /// <summary>
        /// 类目层级,目前最多支持1、2、3三级
        /// </summary>
        [XmlElement("category_level")]
		[JsonProperty("category_level", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryLevel { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
		[JsonProperty("category_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }
    }
}
