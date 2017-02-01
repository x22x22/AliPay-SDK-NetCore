using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayCommerceCityfacilitatorVoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorVoucherQueryModel : AopObject
    {
        /// <summary>
        ///     城市标准码
        /// </summary>
        [XmlElement("city_code")]
        [JsonProperty("city_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CityCode { get; set; }

        /// <summary>
        ///     8位核销码
        /// </summary>
        [XmlElement("ticket_no")]
        [JsonProperty("ticket_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TicketNo { get; set; }

        /// <summary>
        ///     支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}