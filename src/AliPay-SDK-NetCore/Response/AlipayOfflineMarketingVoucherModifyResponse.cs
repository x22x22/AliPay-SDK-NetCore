using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOfflineMarketingVoucherModifyResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherModifyResponse : AopResponse
    {
        /// <summary>
        ///     券id
        /// </summary>
        [XmlElement("voucher_id")]
        [JsonProperty("voucher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherId { get; set; }

        /// <summary>
        ///     券模板状态,EFFECTIVE=生效，INVALID=失效
        /// </summary>
        [XmlElement("voucher_status")]
        [JsonProperty("voucher_status", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherStatus { get; set; }
    }
}