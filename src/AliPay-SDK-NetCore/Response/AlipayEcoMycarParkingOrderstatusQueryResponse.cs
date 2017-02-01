using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEcoMycarParkingOrderstatusQueryResponse.
    /// </summary>
    public class AlipayEcoMycarParkingOrderstatusQueryResponse : AopResponse
    {
        /// <summary>
        ///     支付宝交易流水号订单
        /// </summary>
        [XmlElement("alipay_order_id")]
        [JsonProperty("alipay_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayOrderId { get; set; }

        /// <summary>
        ///     车平台订单
        /// </summary>
        [XmlElement("car_order_id")]
        [JsonProperty("car_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CarOrderId { get; set; }

        /// <summary>
        ///     设备商订单id
        /// </summary>
        [XmlElement("equipment_order_id")]
        [JsonProperty("equipment_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentOrderId { get; set; }

        /// <summary>
        ///     支付金额
        /// </summary>
        [XmlElement("pay_money")]
        [JsonProperty("pay_money", NullValueHandling = NullValueHandling.Ignore)]
        public string PayMoney { get; set; }

        /// <summary>
        ///     支付状态
        /// </summary>
        [XmlElement("pay_status")]
        [JsonProperty("pay_status", NullValueHandling = NullValueHandling.Ignore)]
        public string PayStatus { get; set; }

        /// <summary>
        ///     支付的时间
        /// </summary>
        [XmlElement("pay_time")]
        [JsonProperty("pay_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PayTime { get; set; }

        /// <summary>
        ///     支付方式（1为支付宝在线缴费，2为支付宝代扣缴费）
        /// </summary>
        [XmlElement("pay_type")]
        [JsonProperty("pay_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PayType { get; set; }

        /// <summary>
        ///     返回状态(1为成功,0为失败)
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}