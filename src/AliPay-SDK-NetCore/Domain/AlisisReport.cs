using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlisisReport Data Structure.
    /// </summary>
    [Serializable]
    public class AlisisReport : AopObject
    {
        /// <summary>
        /// 报表描述
        /// </summary>
        [XmlElement("report_desc")]
		[JsonProperty("report_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportDesc { get; set; }

        /// <summary>
        /// 报表名称
        /// </summary>
        [XmlElement("report_name")]
		[JsonProperty("report_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportName { get; set; }

        /// <summary>
        /// 报表唯一标识
        /// </summary>
        [XmlElement("report_uk")]
		[JsonProperty("report_uk", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportUk { get; set; }
    }
}
