using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobilePublicContactFollowListResponse.
    /// </summary>
    public class AlipayMobilePublicContactFollowListResponse : AopResponse
    {
        /// <summary>
        ///     返回结果码，如200，标识成功
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public new string Code { get; set; }

        /// <summary>
        ///     联系人关注者列表
        /// </summary>
        [XmlArray("contact_follow_list")]
        [XmlArrayItem("string")]
        public List<string> ContactFollowList { get; set; }
    }
}