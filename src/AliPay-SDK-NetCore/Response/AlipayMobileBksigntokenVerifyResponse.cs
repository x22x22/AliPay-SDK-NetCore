using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileBksigntokenVerifyResponse.
    /// </summary>
    public class AlipayMobileBksigntokenVerifyResponse : AopResponse
    {
        /// <summary>
        /// 返回值创建时间
        /// </summary>
        [XmlElement("createtimestamp")]
		[JsonProperty("createtimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Createtimestamp { get; set; }

        /// <summary>
        /// 返回值logonId
        /// </summary>
        [XmlElement("loginid")]
		[JsonProperty("loginid", NullValueHandling = NullValueHandling.Ignore)]
        public string Loginid { get; set; }

        /// <summary>
        /// 结果说明
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 结果状态码
        /// </summary>
        [XmlElement("resultcode")]
		[JsonProperty("resultcode", NullValueHandling = NullValueHandling.Ignore)]
        public long Resultcode { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
		[JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; }

        /// <summary>
        /// 返回值userId
        /// </summary>
        [XmlElement("userid")]
		[JsonProperty("userid", NullValueHandling = NullValueHandling.Ignore)]
        public string Userid { get; set; }
    }
}
