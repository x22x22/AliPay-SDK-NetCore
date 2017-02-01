using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ClaimProgress Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimProgress : AopObject
    {
        /// <summary>
        ///     更新内容
        /// </summary>
        [XmlElement("update_content")]
        [JsonProperty("update_content", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateContent { get; set; }

        /// <summary>
        ///     更新时间
        /// </summary>
        [XmlElement("update_time")]
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }
    }
}