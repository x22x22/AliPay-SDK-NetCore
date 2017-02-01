using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOpenPublicThirdCustomerServiceResponse.
    /// </summary>
    public class AlipayOpenPublicThirdCustomerServiceResponse : AopResponse
    {
        /// <summary>
        ///     授权给第三方渠道商的服务窗名称
        /// </summary>
        [XmlElement("public_name")]
        [JsonProperty("public_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicName { get; set; }
    }
}