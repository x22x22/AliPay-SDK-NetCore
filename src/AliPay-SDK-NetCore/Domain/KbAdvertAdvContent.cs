using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertAdvContent Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertAdvContent : AopObject
    {
        /// <summary>
        /// 二维码
        /// </summary>
        [XmlElement("codec")]
		[JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public string Codec { get; set; }

        /// <summary>
        /// 访问地址
        /// </summary>
        [XmlElement("link_url")]
		[JsonProperty("link_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkUrl { get; set; }
    }
}
