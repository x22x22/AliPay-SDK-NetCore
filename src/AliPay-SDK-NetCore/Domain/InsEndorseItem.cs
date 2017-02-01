using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsEndorseItem Data Structure.
    /// </summary>
    [Serializable]
    public class InsEndorseItem : AopObject
    {
        /// <summary>
        ///     批单项新值
        /// </summary>
        [XmlElement("new_value")]
        [JsonProperty("new_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }

        /// <summary>
        ///     批单项旧值
        /// </summary>
        [XmlElement("old_value")]
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }

        /// <summary>
        ///     批单类型;303:保单改期;311:批改保单标的
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public long Type { get; set; }
    }
}