using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertContentPassword Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentPassword : AopObject
    {
        /// <summary>
        /// 红包口令
        /// </summary>
        [XmlElement("password")]
		[JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 红包口令分享地址
        /// </summary>
        [XmlElement("share_page_url")]
		[JsonProperty("share_page_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SharePageUrl { get; set; }
    }
}
