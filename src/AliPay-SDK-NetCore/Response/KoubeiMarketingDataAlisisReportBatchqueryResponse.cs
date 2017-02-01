using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiMarketingDataAlisisReportBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingDataAlisisReportBatchqueryResponse : AopResponse
    {
        /// <summary>
        ///     报表列表信息
        /// </summary>
        [XmlArray("report_list")]
        [XmlArrayItem("alisis_report")]
        public List<AlisisReport> ReportList { get; set; }

        /// <summary>
        ///     总记录数
        /// </summary>
        [XmlElement("total_count")]
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalCount { get; set; }
    }
}