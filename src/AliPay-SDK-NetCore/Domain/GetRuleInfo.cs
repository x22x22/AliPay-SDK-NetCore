using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     GetRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GetRuleInfo : AopObject
    {
        /// <summary>
        ///     截至时间
        /// </summary>
        [XmlElement("end_time")]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        ///     发放次数限制
        /// </summary>
        [XmlElement("get_count_limit")]
        [JsonProperty("get_count_limit", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodInfo GetCountLimit { get; set; }

        /// <summary>
        ///     开始时间
        /// </summary>
        [XmlElement("start_time")]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }
    }
}