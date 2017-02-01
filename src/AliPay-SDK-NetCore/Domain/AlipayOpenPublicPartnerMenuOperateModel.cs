using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenPublicPartnerMenuOperateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPartnerMenuOperateModel : AopObject
    {
        /// <summary>
        ///     行为参数
        /// </summary>
        [XmlElement("action_param")]
        [JsonProperty("action_param", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionParam { get; set; }

        /// <summary>
        ///     行为类型(in，out，api)
        /// </summary>
        [XmlElement("action_type")]
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionType { get; set; }

        /// <summary>
        ///     协议号
        /// </summary>
        [XmlElement("agreement_id")]
        [JsonProperty("agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementId { get; set; }

        /// <summary>
        ///     服务窗id
        /// </summary>
        [XmlElement("public_id")]
        [JsonProperty("public_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicId { get; set; }

        /// <summary>
        ///     第三方账号ID ,银行卡号/户号/手机号
        /// </summary>
        [XmlElement("third_account_id")]
        [JsonProperty("third_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdAccountId { get; set; }

        /// <summary>
        ///     支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}