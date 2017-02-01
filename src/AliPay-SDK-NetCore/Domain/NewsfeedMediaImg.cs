using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsfeedMediaImg Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaImg : AopObject
    {
        /// <summary>
        /// 图片高度
        /// </summary>
        [XmlElement("height")]
		[JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("src")]
		[JsonProperty("src", NullValueHandling = NullValueHandling.Ignore)]
        public string Src { get; set; }

        /// <summary>
        /// 图片宽度
        /// </summary>
        [XmlElement("width")]
		[JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public string Width { get; set; }
    }
}
