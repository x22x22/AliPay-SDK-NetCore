using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobileShakeUserQueryResponse.
    /// </summary>
    public class AlipayMobileShakeUserQueryResponse : AopResponse
    {
        /// <summary>
        ///     对应的业务信息
        /// </summary>
        [XmlElement("bizdata")]
        [JsonProperty("bizdata", NullValueHandling = NullValueHandling.Ignore)]
        public string Bizdata { get; set; }

        /// <summary>
        ///     支付宝用户登录账户，可能是email或者手机号码
        /// </summary>
        [XmlElement("logon_id")]
        [JsonProperty("logon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogonId { get; set; }

        /// <summary>
        ///     对应的核销数据
        /// </summary>
        [XmlElement("pass_id")]
        [JsonProperty("pass_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PassId { get; set; }

        /// <summary>
        ///     支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}