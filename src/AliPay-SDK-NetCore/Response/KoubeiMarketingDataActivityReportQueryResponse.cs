using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiMarketingDataActivityReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataActivityReportQueryResponse : AopResponse
    {
        /// <summary>
        ///     报表
        /// </summary>
        [XmlElement("report_data")]
        [JsonProperty("report_data", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportData { get; set; }
    }
}