using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipaySecurityProdFingerprintVerifyInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFingerprintVerifyInitializeModel : AopObject
    {
        /// <summary>
        ///     IFAA协议的版本，目前为2.0
        /// </summary>
        [XmlElement("ifaa_version")]
        [JsonProperty("ifaa_version", NullValueHandling = NullValueHandling.Ignore)]
        public string IfaaVersion { get; set; }

        /// <summary>
        ///     IFAA标准中用于关联IFAA Server和业务方Server开通状态的token，此token为注册时保存的token，传入此token，用于生成服务端校验信息。
        /// </summary>
        [XmlElement("token")]
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }
    }
}