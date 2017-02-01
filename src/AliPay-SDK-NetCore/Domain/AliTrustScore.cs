using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AliTrustScore Data Structure.
    /// </summary>
    [Serializable]
    public class AliTrustScore : AopObject
    {
        /// <summary>
        /// 芝麻分
        /// </summary>
        [XmlElement("score")]
		[JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long Score { get; set; }
    }
}
