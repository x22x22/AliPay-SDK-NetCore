using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmWatchListExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmWatchListExtendInfo : AopObject
    {
        /// <summary>
        /// 对于这个key的描述
        /// </summary>
        [XmlElement("description")]
		[JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 对应的字段名
        /// </summary>
        [XmlElement("key")]
		[JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 对应的值
        /// </summary>
        [XmlElement("value")]
		[JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
