using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEbppBillPayurlGetResponse.
    /// </summary>
    public class AlipayEbppBillPayurlGetResponse : AopResponse
    {
        /// <summary>
        ///     付款页面地址
        /// </summary>
        [XmlElement("pay_url")]
        [JsonProperty("pay_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PayUrl { get; set; }
    }
}