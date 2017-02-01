using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InstallmentMetaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentMetaInfo : AopObject
    {
        /// <summary>
        ///     结束期数，包含此值
        /// </summary>
        [XmlElement("end_term")]
        [JsonProperty("end_term", NullValueHandling = NullValueHandling.Ignore)]
        public long EndTerm { get; set; }

        /// <summary>
        ///     开始期数，包含此值
        /// </summary>
        [XmlElement("start_term")]
        [JsonProperty("start_term", NullValueHandling = NullValueHandling.Ignore)]
        public long StartTerm { get; set; }

        /// <summary>
        ///     数值
        /// </summary>
        [XmlElement("value")]
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}