using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     NewsfeedWithMeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedWithMeInfo : AopObject
    {
        /// <summary>
        ///     登录ID
        /// </summary>
        [XmlElement("login_id")]
        [JsonProperty("login_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginId { get; set; }

        /// <summary>
        ///     用户id
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}