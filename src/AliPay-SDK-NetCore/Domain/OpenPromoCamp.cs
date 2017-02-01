using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenPromoCamp Data Structure.
    /// </summary>
    [Serializable]
    public class OpenPromoCamp : AopObject
    {
        /// <summary>
        /// 简短活动名，默认和活动名称相同
        /// </summary>
        [XmlElement("camp_alias")]
		[JsonProperty("camp_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string CampAlias { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("camp_desc")]
		[JsonProperty("camp_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string CampDesc { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("camp_end_time")]
		[JsonProperty("camp_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CampEndTime { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("camp_name")]
		[JsonProperty("camp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CampName { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("camp_start_time")]
		[JsonProperty("camp_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CampStartTime { get; set; }

        /// <summary>
        /// 活动类型，现在支持DRAW_PRIZE：表示领奖活动
        /// </summary>
        [XmlElement("camp_type")]
		[JsonProperty("camp_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CampType { get; set; }
    }
}
