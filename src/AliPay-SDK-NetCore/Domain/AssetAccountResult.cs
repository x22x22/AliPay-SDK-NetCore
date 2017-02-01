using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AssetAccountResult Data Structure.
    /// </summary>
    [Serializable]
    public class AssetAccountResult : AopObject
    {
        /// <summary>
        ///     用户的支付宝账号对应的支付宝唯一用户标识，不可变更。
        /// </summary>
        [XmlElement("alipay_user_id")]
        [JsonProperty("alipay_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayUserId { get; set; }

        /// <summary>
        ///     账户绑定关系唯一标识
        /// </summary>
        [XmlElement("consumer_id")]
        [JsonProperty("consumer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerId { get; set; }

        /// <summary>
        ///     使用该app提供用户信息的商户，可以和app相同。
        /// </summary>
        [XmlElement("provider_id")]
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        ///     用户在商户网站的会员标识。商户需确保其唯一性，不可变更。
        /// </summary>
        [XmlElement("provider_user_id")]
        [JsonProperty("provider_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderUserId { get; set; }

        /// <summary>
        ///     用户在商户网站的会员名（登录号或昵称）。
        /// </summary>
        [XmlElement("provider_user_name")]
        [JsonProperty("provider_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderUserName { get; set; }
    }
}