using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingOrderSyncModel : AopObject
    {
        /// <summary>
        /// 车牌
        /// </summary>
        [XmlElement("car_number")]
		[JsonProperty("car_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CarNumber { get; set; }

        /// <summary>
        /// 如果是停车卡缴费，则填入停车卡卡号，否则为'*'
        /// </summary>
        [XmlElement("card_number")]
		[JsonProperty("card_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CardNumber { get; set; }

        /// <summary>
        /// 停车时长（以分为单位）
        /// </summary>
        [XmlElement("in_duration")]
		[JsonProperty("in_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string InDuration { get; set; }

        /// <summary>
        /// 入场时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [XmlElement("in_time")]
		[JsonProperty("in_time", NullValueHandling = NullValueHandling.Ignore)]
        public string InTime { get; set; }

        /// <summary>
        /// 支付宝支付流水，系统唯一
        /// </summary>
        [XmlElement("order_no")]
		[JsonProperty("order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 设备商订单状态，0：成功，1：失败
        /// </summary>
        [XmlElement("order_status")]
		[JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单创建时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [XmlElement("order_time")]
		[JsonProperty("order_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderTime { get; set; }

        /// <summary>
        /// 设备商订单号，由ISV系统生成
        /// </summary>
        [XmlElement("out_order_no")]
		[JsonProperty("out_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// ISV停车场ID，由ISV提供，同一个isv或商户范围内唯一
        /// </summary>
        [XmlElement("out_parking_id")]
		[JsonProperty("out_parking_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 支付宝停车场id，系统唯一
        /// </summary>
        [XmlElement("parking_id")]
		[JsonProperty("parking_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场名称，由ISV定义，尽量与高德地图上的一致
        /// </summary>
        [XmlElement("parking_name")]
		[JsonProperty("parking_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingName { get; set; }

        /// <summary>
        /// 缴费金额，保留小数点后两位
        /// </summary>
        [XmlElement("pay_money")]
		[JsonProperty("pay_money", NullValueHandling = NullValueHandling.Ignore)]
        public string PayMoney { get; set; }

        /// <summary>
        /// 缴费时间, 格式"YYYYMM-DD HH:mm:ss"，24小时制
        /// </summary>
        [XmlElement("pay_time")]
		[JsonProperty("pay_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PayTime { get; set; }

        /// <summary>
        /// 付款方式，1：支付宝在线缴费 ，2：支付宝代扣缴费
        /// </summary>
        [XmlElement("pay_type")]
		[JsonProperty("pay_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PayType { get; set; }

        /// <summary>
        /// 停车缴费支付宝用户的ID，请ISV保证用户ID的正确性，以免导致用户在停车平台查询不到相关的订单信息
        /// </summary>
        [XmlElement("user_id")]
		[JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}
