using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     NewsfeedLabelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedLabelInfo : AopObject
    {
        /// <summary>
        ///     根据主谓宾的格式生成动态的标题，此字段为谓语
        /// </summary>
        [XmlElement("action")]
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        ///     label行的跳转链接
        /// </summary>
        [XmlElement("scheme")]
        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string Scheme { get; set; }

        /// <summary>
        ///     根据主谓宾的格式生成动态的标题，此字段为宾语
        /// </summary>
        [XmlElement("target")]
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }
    }
}