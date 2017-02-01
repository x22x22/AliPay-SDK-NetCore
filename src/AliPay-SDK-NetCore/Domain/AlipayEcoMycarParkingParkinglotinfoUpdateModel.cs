using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarParkingParkinglotinfoUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingParkinglotinfoUpdateModel : AopObject
    {
        /// <summary>
        ///     城市编号（国家统一标准编码）
        /// </summary>
        [XmlElement("city_id")]
        [JsonProperty("city_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CityId { get; set; }

        /// <summary>
        ///     停车场联系人支付宝账户，如果有则填入
        /// </summary>
        [XmlElement("contact_alipay")]
        [JsonProperty("contact_alipay", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactAlipay { get; set; }

        /// <summary>
        ///     停车场联系人邮箱，如果有则填入
        /// </summary>
        [XmlElement("contact_email")]
        [JsonProperty("contact_email", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactEmail { get; set; }

        /// <summary>
        ///     停车场联系人手机，如果有则填入
        /// </summary>
        [XmlElement("contact_mobile")]
        [JsonProperty("contact_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactMobile { get; set; }

        /// <summary>
        ///     停车场联系人，如果有则填入
        /// </summary>
        [XmlElement("contact_name")]
        [JsonProperty("contact_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        /// <summary>
        ///     停车场联系人座机，如果有则填入
        /// </summary>
        [XmlElement("contact_tel")]
        [JsonProperty("contact_tel", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactTel { get; set; }

        /// <summary>
        ///     停车场联系人微信，如果有则填入
        /// </summary>
        [XmlElement("contact_weixin")]
        [JsonProperty("contact_weixin", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactWeixin { get; set; }

        /// <summary>
        ///     设备商名称
        /// </summary>
        [XmlElement("equipment_name")]
        [JsonProperty("equipment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentName { get; set; }

        /// <summary>
        ///     纬度，最长15位字符(包括小数点)，注：高德坐标系。经纬度是门店搜索和活动推荐的重要参数，录入时请确保经纬度参数的准确。高德经纬度查询：http://lbs.amap.com/console/show/picker
        /// </summary>
        [XmlElement("latitude")]
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }

        /// <summary>
        ///     经度，最长15位字符(包括小数点)，注：高德坐标系。经纬度是门店搜索和活动推荐的重要参数，录入时请确保经纬度参数的准确。高德经纬度查询：http://lbs.amap.com/console/show/picker
        /// </summary>
        [XmlElement("longitude")]
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }

        /// <summary>
        ///     ISV停车场ID，由ISV提供，同一个ISV或商户范围内唯一
        /// </summary>
        [XmlElement("out_parking_id")]
        [JsonProperty("out_parking_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OutParkingId { get; set; }

        /// <summary>
        ///     停车场地址
        /// </summary>
        [XmlElement("parking_address")]
        [JsonProperty("parking_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingAddress { get; set; }

        /// <summary>
        ///     停车场结束营业时间，格式 "HH:mm:ss"
        /// </summary>
        [XmlElement("parking_end_time")]
        [JsonProperty("parking_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingEndTime { get; set; }

        /// <summary>
        ///     收费说明
        /// </summary>
        [XmlElement("parking_fee_description")]
        [JsonProperty("parking_fee_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingFeeDescription { get; set; }

        /// <summary>
        ///     支付宝返回停车场id，系统唯一
        /// </summary>
        [XmlElement("parking_id ")]
        public string ParkingId { get; set; }

        /// <summary>
        ///     停车场类型，1为小区停车场、2为商圈停车场、3为路面停车场、4为园区停车场、5为写字楼停车场、6为私人停车场
        /// </summary>
        [XmlElement("parking_lot_type")]
        [JsonProperty("parking_lot_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingLotType { get; set; }

        /// <summary>
        ///     停车场名称，由ISV定义，尽量与高德地图上的一致
        /// </summary>
        [XmlElement("parking_name")]
        [JsonProperty("parking_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingName { get; set; }

        /// <summary>
        ///     停车位数目
        /// </summary>
        [XmlElement("parking_number")]
        [JsonProperty("parking_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingNumber { get; set; }

        /// <summary>
        ///     停车场开始营业时间，格式 "HH:mm:ss"
        /// </summary>
        [XmlElement("parking_start_time")]
        [JsonProperty("parking_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingStartTime { get; set; }

        /// <summary>
        ///     停车场类型(1为地面，2为地下，3为路边)（多个类型，中间用,隔开
        /// </summary>
        [XmlElement("parking_type")]
        [JsonProperty("parking_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingType { get; set; }

        /// <summary>
        ///     支付方式（1为支付宝在线缴费，2为支付宝代扣缴费，3当面付)，如支持多种方式以','进行间隔
        /// </summary>
        [XmlElement("pay_type")]
        [JsonProperty("pay_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PayType { get; set; }

        /// <summary>
        ///     缴费模式（1为停车卡缴费，2为物料缴费，3为中央缴费机）
        /// </summary>
        [XmlElement("payment_mode")]
        [JsonProperty("payment_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMode { get; set; }

        /// <summary>
        ///     商圈id
        /// </summary>
        [XmlElement("shopingmall_id")]
        [JsonProperty("shopingmall_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopingmallId { get; set; }
    }
}