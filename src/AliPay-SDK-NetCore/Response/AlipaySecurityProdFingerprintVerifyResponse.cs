using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipaySecurityProdFingerprintVerifyResponse.
    /// </summary>
    public class AlipaySecurityProdFingerprintVerifyResponse : AopResponse
    {
        /// <summary>
        ///     IFAA服务端校验结果，true为通过，false为未通过
        /// </summary>
        [XmlElement("auth_result")]
        [JsonProperty("auth_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool AuthResult { get; set; }

        /// <summary>
        ///     IFAA标准中用于关联IFAA Server和业务方Server开通状态的token，此token用于提供给业务方关联校验结果。
        /// </summary>
        [XmlElement("token")]
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }
    }
}