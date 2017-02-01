using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublicLabel Data Structure.
    /// </summary>
    [Serializable]
    public class PublicLabel : AopObject
    {
        /// <summary>
        /// 标签用户量
        /// </summary>
        [XmlElement("count")]
		[JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long Count { get; set; }

        /// <summary>
        /// 标签编号
        /// </summary>
        [XmlElement("id")]
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
