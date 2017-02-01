using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppBillBatchPayurlGetResponse.
    /// </summary>
    public class AlipayEbppBillBatchPayurlGetResponse : AopResponse
    {
        /// <summary>
        /// 收银台链接
        /// </summary>
        [XmlElement("pay_url")]
		[JsonProperty("pay_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PayUrl { get; set; }
    }
}
