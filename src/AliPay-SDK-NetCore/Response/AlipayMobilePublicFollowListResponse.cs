using System;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicFollowListResponse.
    /// </summary>
    public class AlipayMobilePublicFollowListResponse : AopResponse
    {
        /// <summary>
        /// 返回结果码，如200，标识成功
        /// </summary>
        [XmlElement("code")]
		[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public new string Code { get; set; }

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
