using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOpenAuthIndustryPlatformCreateTokenResponse.
    /// </summary>
    public class AlipayOpenAuthIndustryPlatformCreateTokenResponse : AopResponse
    {
        /// <summary>
        ///     授权码
        /// </summary>
        [XmlElement("auth_code")]
        [JsonProperty("auth_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCode { get; set; }

        /// <summary>
        ///     appid
        /// </summary>
        [XmlElement("requst_app_id")]
        [JsonProperty("requst_app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequstAppId { get; set; }

        /// <summary>
        ///     scope
        /// </summary>
        [XmlElement("scope")]
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }
    }
}