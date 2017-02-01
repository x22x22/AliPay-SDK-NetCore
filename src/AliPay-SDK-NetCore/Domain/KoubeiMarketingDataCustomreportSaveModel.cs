using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiMarketingDataCustomreportSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportSaveModel : AopObject
    {
        /// <summary>
        ///     自定义报表规则条件信息
        /// </summary>
        [XmlElement("report_condition_info")]
        [JsonProperty("report_condition_info", NullValueHandling = NullValueHandling.Ignore)]
        public CustomReportCondition ReportConditionInfo { get; set; }
    }
}