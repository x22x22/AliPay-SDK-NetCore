using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     Keyword Data Structure.
    /// </summary>
    [Serializable]
    public class Keyword : AopObject
    {
        /// <summary>
        ///     当前文字颜色
        /// </summary>
        [XmlElement("color")]
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        ///     模板中占位符的值
        /// </summary>
        [XmlElement("value")]
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}