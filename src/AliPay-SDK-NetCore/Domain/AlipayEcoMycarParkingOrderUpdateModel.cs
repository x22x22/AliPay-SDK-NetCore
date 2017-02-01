using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingOrderUpdateModel : AopObject
    {
        /// <summary>
        /// 支付宝支付流水号，系统唯一
        /// </summary>
        [XmlElement("order_no")]
		[JsonProperty("order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 用户停车订单状态，0：成功，1：失败
        /// </summary>
        [XmlElement("order_status")]
		[JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 停车缴费支付宝用户的ID，请ISV保证用户ID的正确性，以免导致用户在停车平台查询不到相关的订单信息
        /// </summary>
        [XmlElement("user_id")]
		[JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}
