using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DishTag Data Structure.
    /// </summary>
    [Serializable]
    public class DishTag : AopObject
    {
        /// <summary>
        /// 标签类型 : 如"菜属性"，"菜推荐"
        /// </summary>
        [XmlElement("type")]
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 标签值：如"重辣","中辣","招牌菜","创意菜"
        /// </summary>
        [XmlElement("value")]
		[JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
