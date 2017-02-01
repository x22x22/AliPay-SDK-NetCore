using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobileBeaconDeviceQueryResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceQueryResponse : AopResponse
    {
        /// <summary>
        ///     蓝牙设备信息
        /// </summary>
        [XmlElement("beacon_device_info")]
        [JsonProperty("beacon_device_info", NullValueHandling = NullValueHandling.Ignore)]
        public BeaconDeviceInfo BeaconDeviceInfo { get; set; }

        /// <summary>
        ///     操作返回码，200为成功
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public new string Code { get; set; }

        /// <summary>
        ///     请求处理结果
        /// </summary>
        [XmlElement("msg")]
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public new string Msg { get; set; }
    }
}