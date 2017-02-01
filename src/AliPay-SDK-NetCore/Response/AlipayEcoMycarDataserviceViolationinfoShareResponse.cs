using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarDataserviceViolationinfoShareResponse.
    /// </summary>
    public class AlipayEcoMycarDataserviceViolationinfoShareResponse : AopResponse
    {
        /// <summary>
        /// 车架号
        /// </summary>
        [XmlElement("body_num")]
		[JsonProperty("body_num", NullValueHandling = NullValueHandling.Ignore)]
        public string BodyNum { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        [XmlElement("engine_num")]
		[JsonProperty("engine_num", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineNum { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [XmlElement("vehicle_id")]
		[JsonProperty("vehicle_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleId { get; set; }

        /// <summary>
        /// 车牌
        /// </summary>
        [XmlElement("vi_number")]
		[JsonProperty("vi_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ViNumber { get; set; }
    }
}
