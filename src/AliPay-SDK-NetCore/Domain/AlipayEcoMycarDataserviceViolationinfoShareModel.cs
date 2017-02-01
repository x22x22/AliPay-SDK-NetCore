using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataserviceViolationinfoShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataserviceViolationinfoShareModel : AopObject
    {
        /// <summary>
        /// 支付宝app_id
        /// </summary>
        [XmlElement("app_id")]
		[JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [XmlElement("vehicle_id")]
		[JsonProperty("vehicle_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleId { get; set; }
    }
}
