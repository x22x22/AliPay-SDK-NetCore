using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEcapiprodCreditGetResponse.
    /// </summary>
    public class AlipayEcapiprodCreditGetResponse : AopResponse
    {
        /// <summary>
        ///     授信结果
        /// </summary>
        [XmlElement("credit_result")]
        [JsonProperty("credit_result", NullValueHandling = NullValueHandling.Ignore)]
        public CreditResult CreditResult { get; set; }

        /// <summary>
        ///     为了保持幂等性，返回唯一请求号
        /// </summary>
        [XmlElement("request_id")]
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }
    }
}