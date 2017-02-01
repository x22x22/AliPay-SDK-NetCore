using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitInfo : AopObject
    {
        /// <summary>
        /// 招商结束时间
        /// </summary>
        [XmlElement("end_time")]
		[JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否参与门店参与了招商
        /// </summary>
        [XmlElement("exclude_constraint_shops")]
		[JsonProperty("exclude_constraint_shops", NullValueHandling = NullValueHandling.Ignore)]
        public bool ExcludeConstraintShops { get; set; }

        /// <summary>
        /// 招商方案id
        /// </summary>
        [XmlElement("plan_id")]
		[JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 招商开始时间
        /// </summary>
        [XmlElement("start_time")]
		[JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 招商状态
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}
