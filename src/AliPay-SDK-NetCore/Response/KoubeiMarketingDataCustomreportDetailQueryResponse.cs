using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiMarketingDataCustomreportDetailQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportDetailQueryResponse : AopResponse
    {
        /// <summary>
        ///     自定义报表规则条件的详细信息
        /// </summary>
        [XmlElement("report_condition_info")]
        [JsonProperty("report_condition_info", NullValueHandling = NullValueHandling.Ignore)]
        public CustomReportCondition ReportConditionInfo { get; set; }
    }
}