using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingCardbarcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingCardbarcodeCreateModel : AopObject
    {
        /// <summary>
        /// 设备商订单id
        /// </summary>
        [XmlElement("equipment_id")]
		[JsonProperty("equipment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentId { get; set; }

        /// <summary>
        /// 支付宝交易流水号订单
        /// </summary>
        [XmlElement("parking_id")]
		[JsonProperty("parking_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingId { get; set; }
    }
}
