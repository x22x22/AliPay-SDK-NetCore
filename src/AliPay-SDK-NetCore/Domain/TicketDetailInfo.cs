using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TicketDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TicketDetailInfo : AopObject
    {
        /// <summary>
        /// 总金额，元为单位
        /// </summary>
        [XmlElement("amount")]
		[JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 终点站编码
        /// </summary>
        [XmlElement("end_station")]
		[JsonProperty("end_station", NullValueHandling = NullValueHandling.Ignore)]
        public string EndStation { get; set; }

        /// <summary>
        /// 终点站中文名称
        /// </summary>
        [XmlElement("end_station_name")]
		[JsonProperty("end_station_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EndStationName { get; set; }

        /// <summary>
        /// 票数量
        /// </summary>
        [XmlElement("quantity")]
		[JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantity { get; set; }

        /// <summary>
        /// 起点站编码
        /// </summary>
        [XmlElement("start_station")]
		[JsonProperty("start_station", NullValueHandling = NullValueHandling.Ignore)]
        public string StartStation { get; set; }

        /// <summary>
        /// 起点站中文名称
        /// </summary>
        [XmlElement("start_station_name")]
		[JsonProperty("start_station_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StartStationName { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 单价，元为单位
        /// </summary>
        [XmlElement("ticket_price")]
		[JsonProperty("ticket_price", NullValueHandling = NullValueHandling.Ignore)]
        public string TicketPrice { get; set; }

        /// <summary>
        /// 票类型
        /// </summary>
        [XmlElement("ticket_type")]
		[JsonProperty("ticket_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TicketType { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
		[JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}
