using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobileBeaconDeviceAddResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceAddResponse : AopResponse
    {
        /// <summary>
        ///     请求操作成功与否，200为成功
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public new string Code { get; set; }

        /// <summary>
        ///     请求的处理结果
        /// </summary>
        [XmlElement("msg")]
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public new string Msg { get; set; }
    }
}