using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardDomainVO Data Structure.
    /// </summary>
    [Serializable]
    public class CardDomainVO : AopObject
    {
        /// <summary>
        /// 值域域名的描述值，固定为”金融”
        /// </summary>
        [XmlElement("description")]
		[JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 值域域名，固定为“FINANCE”
        /// </summary>
        [XmlElement("domain_name")]
		[JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }
    }
}
