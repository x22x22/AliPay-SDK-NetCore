using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipaySystemOauthTokenResponse.
    /// </summary>
    public class AlipaySystemOauthTokenResponse : AopResponse
    {
        /// <summary>
        ///     访问令牌。通过该令牌调用需要授权类接口
        /// </summary>
        [XmlElement("access_token")]
        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        ///     已废弃，请勿使用
        /// </summary>
        [XmlElement("alipay_user_id")]
        [JsonProperty("alipay_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayUserId { get; set; }

        /// <summary>
        ///     访问令牌的有效时间，单位是秒。
        /// </summary>
        [XmlElement("expires_in")]
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresIn { get; set; }

        /// <summary>
        ///     刷新令牌的有效时间，单位是秒。
        /// </summary>
        [XmlElement("re_expires_in")]
        [JsonProperty("re_expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public string ReExpiresIn { get; set; }

        /// <summary>
        ///     刷新令牌。通过该令牌可以刷新access_token
        /// </summary>
        [XmlElement("refresh_token")]
        [JsonProperty("refresh_token", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <summary>
        ///     支付宝用户的唯一userId
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}