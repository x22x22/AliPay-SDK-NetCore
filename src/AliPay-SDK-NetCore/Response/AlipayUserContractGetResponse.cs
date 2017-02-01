using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayUserContractGetResponse.
    /// </summary>
    public class AlipayUserContractGetResponse : AopResponse
    {
        /// <summary>
        ///     支付宝用户订购信息
        /// </summary>
        [XmlElement("alipay_contract")]
        [JsonProperty("alipay_contract", NullValueHandling = NullValueHandling.Ignore)]
        public AlipayContract AlipayContract { get; set; }
    }
}