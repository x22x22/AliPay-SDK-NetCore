using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ContactFollower Data Structure.
    /// </summary>
    [Serializable]
    public class ContactFollower : AopObject
    {
        /// <summary>
        ///     支付宝头像
        /// </summary>
        [XmlElement("avatar")]
        [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public string Avatar { get; set; }

        /// <summary>
        ///     默认头像
        /// </summary>
        [XmlElement("default_avatar")]
        [JsonProperty("default_avatar", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultAvatar { get; set; }

        /// <summary>
        ///     false
        /// </summary>
        [XmlElement("each_record_flag")]
        [JsonProperty("each_record_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string EachRecordFlag { get; set; }

        /// <summary>
        ///     用户id
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}