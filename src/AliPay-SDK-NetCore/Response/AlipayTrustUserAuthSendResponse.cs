using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayTrustUserAuthSendResponse.
    /// </summary>
    public class AlipayTrustUserAuthSendResponse : AopResponse
    {
        /// <summary>
        ///     当授权通知发送成功时，为T；否则用业务错误码表示
        /// </summary>
        [XmlElement("result")]
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }
    }
}