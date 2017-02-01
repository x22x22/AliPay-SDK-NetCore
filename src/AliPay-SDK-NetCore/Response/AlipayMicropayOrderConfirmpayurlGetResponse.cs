using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMicropayOrderConfirmpayurlGetResponse.
    /// </summary>
    public class AlipayMicropayOrderConfirmpayurlGetResponse : AopResponse
    {
        /// <summary>
        ///     SinglePayDetail信息
        /// </summary>
        [XmlElement("single_pay_detail")]
        [JsonProperty("single_pay_detail", NullValueHandling = NullValueHandling.Ignore)]
        public SinglePayDetail SinglePayDetail { get; set; }
    }
}