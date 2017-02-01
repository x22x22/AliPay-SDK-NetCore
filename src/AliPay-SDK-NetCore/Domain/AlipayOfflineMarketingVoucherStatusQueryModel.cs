using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineMarketingVoucherStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherStatusQueryModel : AopObject
    {
        /// <summary>
        ///     外部流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        [JsonProperty("out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutBizNo { get; set; }

        /// <summary>
        ///     券模板id
        /// </summary>
        [XmlElement("voucher_id")]
        [JsonProperty("voucher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherId { get; set; }
    }
}