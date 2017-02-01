using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayHighValueCustomerResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayHighValueCustomerResult : AopObject
    {
        /// <summary>
        /// Z0-Z7
        /// </summary>
        [XmlElement("level")]
		[JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }
    }
}
