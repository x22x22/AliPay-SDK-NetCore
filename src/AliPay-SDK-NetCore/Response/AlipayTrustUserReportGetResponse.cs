using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayTrustUserReportGetResponse.
    /// </summary>
    public class AlipayTrustUserReportGetResponse : AopResponse
    {
        /// <summary>
        ///     报告内容，格式详见示例代码
        /// </summary>
        [XmlElement("report")]
        [JsonProperty("report", NullValueHandling = NullValueHandling.Ignore)]
        public string Report { get; set; }
    }
}