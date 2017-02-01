using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenActivity Data Structure.
    /// </summary>
    [Serializable]
    public class OpenActivity : AopObject
    {
        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("activity_end_date")]
		[JsonProperty("activity_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityEndDate { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
		[JsonProperty("activity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
		[JsonProperty("activity_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("activity_start_date")]
		[JsonProperty("activity_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityStartDate { get; set; }

        /// <summary>
        /// 活动验证状态  0，未检测  1，未通过  2，已通过
        /// </summary>
        [XmlElement("activity_status")]
		[JsonProperty("activity_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("store_id")]
		[JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreId { get; set; }
    }
}
