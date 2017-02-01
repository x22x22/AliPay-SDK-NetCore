using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMicropayOrderFreezepayurlGetResponse.
    /// </summary>
    public class AlipayMicropayOrderFreezepayurlGetResponse : AopResponse
    {
        /// <summary>
        ///     支付冻结金的地址
        /// </summary>
        [XmlElement("pay_freeze_url")]
        [JsonProperty("pay_freeze_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PayFreezeUrl { get; set; }
    }
}