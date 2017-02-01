using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipaySecurityRiskHideDeviceidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskHideDeviceidQueryModel : AopObject
    {
        /// <summary>
        ///     商户的sdk客户端key
        /// </summary>
        [XmlElement("app_key_client")]
        [JsonProperty("app_key_client", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKeyClient { get; set; }

        /// <summary>
        ///     商户使用的设备指纹服务端key
        /// </summary>
        [XmlElement("app_key_server")]
        [JsonProperty("app_key_server", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKeyServer { get; set; }

        /// <summary>
        ///     商户应用名称
        /// </summary>
        [XmlElement("app_name")]
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        ///     设备指纹deviceid对应的token
        /// </summary>
        [XmlElement("deviceid_token")]
        [JsonProperty("deviceid_token", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceidToken { get; set; }
    }
}