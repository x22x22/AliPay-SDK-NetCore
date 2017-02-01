using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEcoMycarDataserviceMaintainvehicleShareResponse.
    /// </summary>
    public class AlipayEcoMycarDataserviceMaintainvehicleShareResponse : AopResponse
    {
        /// <summary>
        ///     车辆详细信息
        /// </summary>
        [XmlElement("info")]
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public MaintainVehicleInfo Info { get; set; }
    }
}