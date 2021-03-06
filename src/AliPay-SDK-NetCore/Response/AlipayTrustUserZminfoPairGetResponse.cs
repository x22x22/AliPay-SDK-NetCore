using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayTrustUserZminfoPairGetResponse.
    /// </summary>
    public class AlipayTrustUserZminfoPairGetResponse : AopResponse
    {
        /// <summary>
        ///     申请者芝麻信用信息JSON串
        /// </summary>
        [XmlElement("apply_zm_info")]
        [JsonProperty("apply_zm_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyZmInfo { get; set; }

        /// <summary>
        ///     信息失效时间
        /// </summary>
        [XmlElement("expire_time")]
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        ///     被申请者芝麻信用信息JSON串
        /// </summary>
        [XmlElement("owner_zm_info")]
        [JsonProperty("owner_zm_info", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerZmInfo { get; set; }
    }
}