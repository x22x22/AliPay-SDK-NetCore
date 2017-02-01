using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiMarketingDataMemberReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMemberReportQueryResponse : AopResponse
    {
        /// <summary>
        ///     查询成功时返回json格式数据
        /// </summary>
        [XmlElement("report_data")]
        [JsonProperty("report_data", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportData { get; set; }
    }
}