using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarParkingOrderstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingOrderstatusQueryModel : AopObject
    {
        /// <summary>
        ///     如果商户订单号为空，停车场id和车牌号不能为空，商户订单号优先查询
        /// </summary>
        [XmlElement("car_number")]
        [JsonProperty("car_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CarNumber { get; set; }

        /// <summary>
        ///     如果商户订单号为空，停车场id和车牌号不能为空，商户订单号优先查询
        /// </summary>
        [XmlElement("parking_id")]
        [JsonProperty("parking_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingId { get; set; }

        /// <summary>
        ///     查询订单时间（不传值为当日时间），格式"yyyy-MM-dd “
        /// </summary>
        [XmlElement("sel_time")]
        [JsonProperty("sel_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SelTime { get; set; }

        /// <summary>
        ///     车主平台交易号，不能跟停车场编号和车牌号同时为空
        /// </summary>
        [XmlElement("transaction_no")]
        [JsonProperty("transaction_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionNo { get; set; }
    }
}