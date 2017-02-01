using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayCommerceCityfacilitatorFunctionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorFunctionQueryModel : AopObject
    {
        /// <summary>
        ///     城市国家标准编码
        /// </summary>
        [XmlElement("city_code")]
        [JsonProperty("city_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CityCode { get; set; }

        /// <summary>
        ///     终端设备编码，android可直接获取设备的devicecode值
        /// </summary>
        [XmlElement("device_code")]
        [JsonProperty("device_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceCode { get; set; }
    }
}