using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduAgeDemand Data Structure.
    /// </summary>
    [Serializable]
    public class EduAgeDemand : AopObject
    {
        /// <summary>
        /// 结束年龄
        /// </summary>
        [XmlElement("age_end")]
		[JsonProperty("age_end", NullValueHandling = NullValueHandling.Ignore)]
        public string AgeEnd { get; set; }

        /// <summary>
        /// 开始年龄
        /// </summary>
        [XmlElement("age_start")]
		[JsonProperty("age_start", NullValueHandling = NullValueHandling.Ignore)]
        public string AgeStart { get; set; }
    }
}
