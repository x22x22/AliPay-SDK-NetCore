using System;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicFollowListResponse.
    /// </summary>
    public class AlipayMobileStdPublicFollowListResponse : AopResponse
    {
        /// <summary>
        /// 当前组的值
        /// </summary>
        [XmlElement("count")]
		[JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public string Count { get; set; }

        /// <summary>
        /// 用户数据
        /// </summary>
        [XmlElement("data")]
		[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }

        /// <summary>
        /// 与nextUserId对应，标准Alipay UserId
        /// </summary>
        [XmlElement("next_alipay_user_id")]
		[JsonProperty("next_alipay_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NextAlipayUserId { get; set; }

        /// <summary>
        /// 查询分组的userid
        /// </summary>
        [XmlElement("next_user_id")]
		[JsonProperty("next_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NextUserId { get; set; }
    }
}
