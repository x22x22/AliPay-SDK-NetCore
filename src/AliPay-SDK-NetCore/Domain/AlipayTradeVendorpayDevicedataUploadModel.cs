using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayTradeVendorpayDevicedataUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeVendorpayDevicedataUploadModel : AopObject
    {
        /// <summary>
        ///     客户端应用包标识
        /// </summary>
        [XmlElement("app_package_name")]
        [JsonProperty("app_package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppPackageName { get; set; }

        /// <summary>
        ///     扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        ///     国际移动设备标识
        /// </summary>
        [XmlElement("imei")]
        [JsonProperty("imei", NullValueHandling = NullValueHandling.Ignore)]
        public string Imei { get; set; }

        /// <summary>
        ///     国际移动用户识别码
        /// </summary>
        [XmlElement("imsi")]
        [JsonProperty("imsi", NullValueHandling = NullValueHandling.Ignore)]
        public string Imsi { get; set; }

        /// <summary>
        ///     mac地址
        /// </summary>
        [XmlElement("mac")]
        [JsonProperty("mac", NullValueHandling = NullValueHandling.Ignore)]
        public string Mac { get; set; }

        /// <summary>
        ///     手机机型
        /// </summary>
        [XmlElement("machine_type")]
        [JsonProperty("machine_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineType { get; set; }

        /// <summary>
        ///     手机系统版本
        /// </summary>
        [XmlElement("phone_sys_version")]
        [JsonProperty("phone_sys_version", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneSysVersion { get; set; }

        /// <summary>
        ///     厂商公钥、base64编码
        /// </summary>
        [XmlElement("public_key")]
        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }

        /// <summary>
        ///     设备应用来源，厂商支付标记
        /// </summary>
        [XmlElement("tidsource")]
        [JsonProperty("tidsource", NullValueHandling = NullValueHandling.Ignore)]
        public string Tidsource { get; set; }

        /// <summary>
        ///     设备标识符
        /// </summary>
        [XmlElement("uuid")]
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        ///     厂商名字
        /// </summary>
        [XmlElement("vendor")]
        [JsonProperty("vendor", NullValueHandling = NullValueHandling.Ignore)]
        public string Vendor { get; set; }
    }
}