using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     NewsfeedMediaLinkInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaLinkInfo : AopObject
    {
        /// <summary>
        ///     资源ID
        /// </summary>
        [XmlElement("content_id")]
        [JsonProperty("content_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentId { get; set; }

        /// <summary>
        ///     资源的来源
        /// </summary>
        [XmlElement("content_source")]
        [JsonProperty("content_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentSource { get; set; }

        /// <summary>
        ///     资源类型
        /// </summary>
        [XmlElement("content_type")]
        [JsonProperty("content_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        /// <summary>
        ///     描述
        /// </summary>
        [XmlElement("desc")]
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        ///     链接的缩略图
        /// </summary>
        [XmlElement("thumb")]
        [JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
        public string Thumb { get; set; }

        /// <summary>
        ///     标题
        /// </summary>
        [XmlElement("title")]
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        ///     linkurl
        /// </summary>
        [XmlElement("url")]
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }
}