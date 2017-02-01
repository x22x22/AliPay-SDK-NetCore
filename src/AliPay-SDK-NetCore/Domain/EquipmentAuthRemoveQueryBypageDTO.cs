using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     EquipmentAuthRemoveQueryBypageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EquipmentAuthRemoveQueryBypageDTO : AopObject
    {
        /// <summary>
        ///     机具编号
        /// </summary>
        [XmlElement("device_id")]
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        ///     解绑时间
        /// </summary>
        [XmlElement("unbind_time")]
        [JsonProperty("unbind_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UnbindTime { get; set; }
    }
}