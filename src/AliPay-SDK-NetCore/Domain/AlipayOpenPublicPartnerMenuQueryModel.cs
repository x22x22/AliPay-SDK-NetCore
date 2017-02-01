using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenPublicPartnerMenuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPartnerMenuQueryModel : AopObject
    {
        /// <summary>
        ///     服务窗id
        /// </summary>
        [XmlElement("public_id")]
        [JsonProperty("public_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicId { get; set; }

        /// <summary>
        ///     用户id
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}