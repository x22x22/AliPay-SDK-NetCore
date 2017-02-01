using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayCommerceCityfacilitatorVoucherUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorVoucherUploadModel : AopObject
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
        ///     JSON字符串，包含出票的序列号，票号，出票时间，出票流水号
        /// </summary>
        [XmlElement("exchange_ids")]
        [JsonProperty("exchange_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeIds { get; set; }

        /// <summary>
        ///     操作时间
        /// </summary>
        [XmlElement("operate_time")]
        [JsonProperty("operate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateTime { get; set; }

        /// <summary>
        ///     核销码
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