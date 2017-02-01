using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherCreateResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherCreateResponse : AopResponse
    {
        /// <summary>
        /// 活动id，过渡方案的兼容字段
        /// </summary>
        [XmlElement("activity_id")]
		[JsonProperty("activity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("voucher_id")]
		[JsonProperty("voucher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherId { get; set; }
    }
}
