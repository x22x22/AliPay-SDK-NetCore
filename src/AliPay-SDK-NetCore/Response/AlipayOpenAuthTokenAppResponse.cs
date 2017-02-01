using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOpenAuthTokenAppResponse.
    /// </summary>
    public class AlipayOpenAuthTokenAppResponse : AopResponse
    {
        /// <summary>
        ///     应用授权令牌
        /// </summary>
        [XmlElement("app_auth_token")]
        [JsonProperty("app_auth_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AppAuthToken { get; set; }

        /// <summary>
        ///     刷新令牌
        /// </summary>
        [XmlElement("app_refresh_token")]
        [JsonProperty("app_refresh_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AppRefreshToken { get; set; }

        /// <summary>
        ///     授权商户的appid
        /// </summary>
        [XmlElement("auth_app_id")]
        [JsonProperty("auth_app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthAppId { get; set; }

        /// <summary>
        ///     应用授权令牌的有效时间（从接口调用时间作为起始时间），单位到秒
        /// </summary>
        [XmlElement("expires_in")]
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresIn { get; set; }

        /// <summary>
        ///     刷新令牌的有效时间（从接口调用时间作为起始时间），单位到秒
        /// </summary>
        [XmlElement("re_expires_in")]
        [JsonProperty("re_expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public string ReExpiresIn { get; set; }

        /// <summary>
        ///     授权商户的user_id
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}