using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOfflineMarketingVoucherStatusQueryResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherStatusQueryResponse : AopResponse
    {
        /// <summary>
        ///     扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        ///     券模板id
        /// </summary>
        [XmlElement("voucher_id")]
        [JsonProperty("voucher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherId { get; set; }

        /// <summary>
        ///     券模板状态。EFFECTIVE=生效，INVALID=失效。
        /// </summary>
        [XmlElement("voucher_status")]
        [JsonProperty("voucher_status", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherStatus { get; set; }
    }
}