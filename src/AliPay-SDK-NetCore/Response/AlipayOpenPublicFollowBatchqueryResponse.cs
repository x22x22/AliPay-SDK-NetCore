using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicFollowBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicFollowBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 本次调用获取的userId个数，最大值为10000
        /// </summary>
        [XmlElement("count")]
		[JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public string Count { get; set; }

        /// <summary>
        /// 查询分组的userid
        /// </summary>
        [XmlElement("next_user_id")]
		[JsonProperty("next_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NextUserId { get; set; }

        /// <summary>
        /// 用户的userId列表
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
