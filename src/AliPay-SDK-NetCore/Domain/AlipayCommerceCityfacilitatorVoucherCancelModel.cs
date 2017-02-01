using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayCommerceCityfacilitatorVoucherCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorVoucherCancelModel : AopObject
    {
        /// <summary>
        ///     渠道商提供的其它信息
        /// </summary>
        [XmlElement("biz_info_ext")]
        [JsonProperty("biz_info_ext", NullValueHandling = NullValueHandling.Ignore)]
        public string BizInfoExt { get; set; }

        /// <summary>
        ///     城市标准码
        /// </summary>
        [XmlElement("city_code")]
        [JsonProperty("city_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CityCode { get; set; }

        /// <summary>
        ///     商户退款时间
        /// </summary>
        [XmlElement("operate_time")]
        [JsonProperty("operate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateTime { get; set; }

        /// <summary>
        ///     核销号
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