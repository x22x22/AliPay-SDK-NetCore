using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayCommerceCityfacilitatorVoucherGenerateResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherGenerateResponse : AopResponse
    {
        /// <summary>
        ///     核销码过期时间
        /// </summary>
        [XmlElement("expired_date")]
        [JsonProperty("expired_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiredDate { get; set; }

        /// <summary>
        ///     地铁购票二维码编码，可自定义
        /// </summary>
        [XmlElement("qr_code_no")]
        [JsonProperty("qr_code_no", NullValueHandling = NullValueHandling.Ignore)]
        public string QrCodeNo { get; set; }

        /// <summary>
        ///     地铁购票的核销码
        /// </summary>
        [XmlElement("ticket_no")]
        [JsonProperty("ticket_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TicketNo { get; set; }
    }
}