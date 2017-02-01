using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     EduSourceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduSourceInfo : AopObject
    {
        /// <summary>
        ///     供应商的LOGO
        /// </summary>
        [XmlElement("logo")]
        [JsonProperty("logo", NullValueHandling = NullValueHandling.Ignore)]
        public string Logo { get; set; }

        /// <summary>
        ///     供应商电话
        /// </summary>
        [XmlElement("mobile")]
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }

        /// <summary>
        ///     供应商名字
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}