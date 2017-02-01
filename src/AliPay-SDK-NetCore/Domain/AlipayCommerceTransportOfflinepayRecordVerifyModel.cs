using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayCommerceTransportOfflinepayRecordVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOfflinepayRecordVerifyModel : AopObject
    {
        /// <summary>
        ///     原始脱机记录信息
        /// </summary>
        [XmlElement("record")]
        [JsonProperty("record", NullValueHandling = NullValueHandling.Ignore)]
        public string Record { get; set; }
    }
}