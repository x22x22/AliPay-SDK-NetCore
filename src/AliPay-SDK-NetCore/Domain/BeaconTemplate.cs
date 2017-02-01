using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     BeaconTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class BeaconTemplate : AopObject
    {
        /// <summary>
        ///     模板参数信息
        /// </summary>
        [XmlElement("context")]
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public string Context { get; set; }

        /// <summary>
        ///     模板ID
        /// </summary>
        [XmlElement("templateid")]
        [JsonProperty("templateid", NullValueHandling = NullValueHandling.Ignore)]
        public string Templateid { get; set; }
    }
}