using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayUserGetResponse.
    /// </summary>
    public class AlipayUserGetResponse : AopResponse
    {
        /// <summary>
        ///     支付宝用户信息
        /// </summary>
        [XmlElement("alipay_user_detail")]
        [JsonProperty("alipay_user_detail", NullValueHandling = NullValueHandling.Ignore)]
        public AlipayUserDetail AlipayUserDetail { get; set; }
    }
}