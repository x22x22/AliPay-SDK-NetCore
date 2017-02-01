using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AreaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AreaInfo : AopObject
    {
        /// <summary>
        ///     城市
        /// </summary>
        [XmlElement("city")]
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        ///     省份
        /// </summary>
        [XmlElement("province")]
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }
    }
}