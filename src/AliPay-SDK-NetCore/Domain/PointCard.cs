using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     PointCard Data Structure.
    /// </summary>
    [Serializable]
    public class PointCard : AopObject
    {
        /// <summary>
        ///     工具的描述
        /// </summary>
        [XmlElement("desc")]
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        ///     工具的有效期的结束时间（必须晚于活动的结束时间）
        /// </summary>
        [XmlElement("end_time")]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        ///     工具的LOGO文件ID
        /// </summary>
        [XmlElement("logo")]
        [JsonProperty("logo", NullValueHandling = NullValueHandling.Ignore)]
        public string Logo { get; set; }

        /// <summary>
        ///     工具的名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///     工具的有效期的起始时间
        /// </summary>
        [XmlElement("start_time")]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        ///     工具类型，目前支持：  集点卡：POINT_CARD
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}