using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSaleleadsContractconfirmResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsContractconfirmResponse : AopResponse
    {
        /// <summary>
        /// 当面付审核状态
        /// </summary>
        [XmlElement("ff_audit_status")]
		[JsonProperty("ff_audit_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FfAuditStatus { get; set; }

        /// <summary>
        /// 当面付审核通过时间
        /// </summary>
        [XmlElement("ff_audit_time")]
		[JsonProperty("ff_audit_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FfAuditTime { get; set; }

        /// <summary>
        /// 当面付生效时间
        /// </summary>
        [XmlElement("ff_online")]
		[JsonProperty("ff_online", NullValueHandling = NullValueHandling.Ignore)]
        public string FfOnline { get; set; }

        /// <summary>
        /// 是否开店
        /// </summary>
        [XmlElement("is_open_shop")]
		[JsonProperty("is_open_shop", NullValueHandling = NullValueHandling.Ignore)]
        public string IsOpenShop { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("is_sign")]
		[JsonProperty("is_sign", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSign { get; set; }

        /// <summary>
        /// leads id
        /// </summary>
        [XmlElement("leads_id")]
		[JsonProperty("leads_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsId { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("merchant_id")]
		[JsonProperty("merchant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantId { get; set; }
    }
}
