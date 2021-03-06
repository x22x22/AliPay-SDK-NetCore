using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayDataBillDownloadurlGetResponse.
    /// </summary>
    public class AlipayDataBillDownloadurlGetResponse : AopResponse
    {
        /// <summary>
        ///     账单下载地址链接，获取连接后30秒后未下载，链接地址失效。
        /// </summary>
        [XmlElement("bill_download_url")]
        [JsonProperty("bill_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BillDownloadUrl { get; set; }
    }
}