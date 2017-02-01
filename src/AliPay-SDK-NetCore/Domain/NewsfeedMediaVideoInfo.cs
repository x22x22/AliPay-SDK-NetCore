using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     NewsfeedMediaVideoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaVideoInfo : AopObject
    {
        /// <summary>
        ///     高度
        /// </summary>
        [XmlElement("height")]
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        /// <summary>
        ///     视频缩略图的ID（支持djangoId）
        /// </summary>
        [XmlElement("img_id")]
        [JsonProperty("img_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImgId { get; set; }

        /// <summary>
        ///     视频的id（支持djangoId）
        /// </summary>
        [XmlElement("video_id")]
        [JsonProperty("video_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoId { get; set; }

        /// <summary>
        ///     宽度
        /// </summary>
        [XmlElement("width")]
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public string Width { get; set; }
    }
}