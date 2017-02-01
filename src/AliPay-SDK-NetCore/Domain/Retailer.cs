using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Retailer Data Structure.
    /// </summary>
    [Serializable]
    public class Retailer : AopObject
    {
        /// <summary>
        /// 零售商名称
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 零售商pid
        /// </summary>
        [XmlElement("partner_id")]
		[JsonProperty("partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerId { get; set; }
    }
}
