using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenAuthIndustryPlatformCreateTokenModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthIndustryPlatformCreateTokenModel : AopObject
    {
        /// <summary>
        ///     isv的appid
        /// </summary>
        [XmlElement("isv_appid")]
        [JsonProperty("isv_appid", NullValueHandling = NullValueHandling.Ignore)]
        public string IsvAppid { get; set; }

        /// <summary>
        ///     auth_mycar_violation
        /// </summary>
        [XmlElement("scope")]
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }
    }
}