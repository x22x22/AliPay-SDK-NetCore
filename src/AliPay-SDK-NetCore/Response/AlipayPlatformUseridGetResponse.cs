using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPlatformUseridGetResponse.
    /// </summary>
    public class AlipayPlatformUseridGetResponse : AopResponse
    {
        /// <summary>
        /// id字典，key为openId，value为userId
        /// </summary>
        [XmlElement("dict")]
		[JsonProperty("dict", NullValueHandling = NullValueHandling.Ignore)]
        public string Dict { get; set; }
    }
}
