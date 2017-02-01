using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     GroupSetting Data Structure.
    /// </summary>
    [Serializable]
    public class GroupSetting : AopObject
    {
        /// <summary>
        ///     群名称
        /// </summary>
        [XmlElement("group_name")]
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        ///     是否开放群成员邀请
        /// </summary>
        [XmlElement("is_openinv")]
        [JsonProperty("is_openinv", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsOpeninv { get; set; }

        /// <summary>
        ///     群公告
        /// </summary>
        [XmlElement("public_notice")]
        [JsonProperty("public_notice", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicNotice { get; set; }
    }
}