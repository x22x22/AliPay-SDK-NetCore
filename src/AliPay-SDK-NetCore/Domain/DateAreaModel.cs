using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DateAreaModel Data Structure.
    /// </summary>
    [Serializable]
    public class DateAreaModel : AopObject
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("begin_date")]
		[JsonProperty("begin_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_date")]
		[JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }
    }
}
