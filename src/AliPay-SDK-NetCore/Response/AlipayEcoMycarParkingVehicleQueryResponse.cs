using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEcoMycarParkingVehicleQueryResponse.
    /// </summary>
    public class AlipayEcoMycarParkingVehicleQueryResponse : AopResponse
    {
        /// <summary>
        ///     车牌信息（utf-8编码）
        /// </summary>
        [XmlElement("car_number")]
        [JsonProperty("car_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CarNumber { get; set; }
    }
}