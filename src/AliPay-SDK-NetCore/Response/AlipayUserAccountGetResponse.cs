using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayUserAccountGetResponse.
    /// </summary>
    public class AlipayUserAccountGetResponse : AopResponse
    {
        /// <summary>
        ///     支付宝用户账户信息
        /// </summary>
        [XmlElement("alipay_account")]
        [JsonProperty("alipay_account", NullValueHandling = NullValueHandling.Ignore)]
        public AlipayAccount AlipayAccount { get; set; }
    }
}