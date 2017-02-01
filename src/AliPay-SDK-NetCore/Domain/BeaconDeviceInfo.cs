using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BeaconDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BeaconDeviceInfo : AopObject
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("actiontype")]
		[JsonProperty("actiontype", NullValueHandling = NullValueHandling.Ignore)]
        public string Actiontype { get; set; }

        /// <summary>
        /// 设备是否可用
        /// </summary>
        [XmlElement("inuse")]
		[JsonProperty("inuse", NullValueHandling = NullValueHandling.Ignore)]
        public bool Inuse { get; set; }

        /// <summary>
        /// 设备说明
        /// </summary>
        [XmlElement("remark")]
		[JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [XmlElement("sn")]
		[JsonProperty("sn", NullValueHandling = NullValueHandling.Ignore)]
        public string Sn { get; set; }

        /// <summary>
        /// 蓝牙设备关联的模板信息
        /// </summary>
        [XmlElement("template")]
		[JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public BeaconTemplate Template { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("uuid")]
		[JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }
    }
}
