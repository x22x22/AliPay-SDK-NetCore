using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsfeedMediaGiftInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaGiftInfo : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("action")]
		[JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 安卓的高度
        /// </summary>
        [XmlElement("adr_height")]
		[JsonProperty("adr_height", NullValueHandling = NullValueHandling.Ignore)]
        public string AdrHeight { get; set; }

        /// <summary>
        /// 安卓缩略图
        /// </summary>
        [XmlElement("adr_thumb")]
		[JsonProperty("adr_thumb", NullValueHandling = NullValueHandling.Ignore)]
        public string AdrThumb { get; set; }

        /// <summary>
        /// 安卓宽度
        /// </summary>
        [XmlElement("adr_width")]
		[JsonProperty("adr_width", NullValueHandling = NullValueHandling.Ignore)]
        public string AdrWidth { get; set; }

        /// <summary>
        /// ios高度
        /// </summary>
        [XmlElement("ios_height")]
		[JsonProperty("ios_height", NullValueHandling = NullValueHandling.Ignore)]
        public string IosHeight { get; set; }

        /// <summary>
        /// ios缩略图
        /// </summary>
        [XmlElement("ios_thumb")]
		[JsonProperty("ios_thumb", NullValueHandling = NullValueHandling.Ignore)]
        public string IosThumb { get; set; }

        /// <summary>
        /// ios宽度
        /// </summary>
        [XmlElement("ios_width")]
		[JsonProperty("ios_width", NullValueHandling = NullValueHandling.Ignore)]
        public string IosWidth { get; set; }

        /// <summary>
        /// 大图
        /// </summary>
        [XmlElement("theme")]
		[JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public string Theme { get; set; }

        /// <summary>
        /// 红包类型all、f、m
        /// </summary>
        [XmlElement("type")]
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
