using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContract Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContract : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
		[JsonProperty("alipay_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 订购的应用名称，有效时间。
        /// </summary>
        [XmlElement("contract_content")]
		[JsonProperty("contract_content", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractContent { get; set; }

        /// <summary>
        /// 订购的失效时间
        /// </summary>
        [XmlElement("end_time")]
		[JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 订购URL。在sign返回false时返回应用的订购地址，可以引导用户订购。
        /// </summary>
        [XmlElement("page_url")]
		[JsonProperty("page_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PageUrl { get; set; }

        /// <summary>
        /// 订购的生效时间
        /// </summary>
        [XmlElement("start_time")]
		[JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 是否订购的标识。true：代表已订购。
        /// </summary>
        [XmlElement("subscribe")]
		[JsonProperty("subscribe", NullValueHandling = NullValueHandling.Ignore)]
        public bool Subscribe { get; set; }
    }
}
