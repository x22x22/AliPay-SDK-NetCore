using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataAlisisReportQueryModel : AopObject
    {
        /// <summary>
        /// 报表唯一标识
        /// </summary>
        [XmlElement("report_uk")]
		[JsonProperty("report_uk", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportUk { get; set; }
    }
}
