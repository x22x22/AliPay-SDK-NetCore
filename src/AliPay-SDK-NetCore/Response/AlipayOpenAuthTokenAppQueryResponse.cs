using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthTokenAppQueryResponse.
    /// </summary>
    public class AlipayOpenAuthTokenAppQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权商户的appid
        /// </summary>
        [XmlElement("auth_app_id")]
		[JsonProperty("auth_app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 授权失效时间
        /// </summary>
        [XmlElement("auth_end")]
		[JsonProperty("auth_end", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthEnd { get; set; }

        /// <summary>
        /// 当前app_auth_token的授权接口列表
        /// </summary>
        [XmlArray("auth_methods")]
        [XmlArrayItem("string")]
        public List<string> AuthMethods { get; set; }

        /// <summary>
        /// 授权生效时间
        /// </summary>
        [XmlElement("auth_start")]
		[JsonProperty("auth_start", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthStart { get; set; }

        /// <summary>
        /// 应用授权令牌失效时间，单位到秒
        /// </summary>
        [XmlElement("expires_in")]
		[JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// valid：有效状态；invalid：无效状态
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 授权商户的user_id
        /// </summary>
        [XmlElement("user_id")]
		[JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}
