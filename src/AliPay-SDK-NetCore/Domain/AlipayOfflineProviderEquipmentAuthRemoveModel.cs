using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineProviderEquipmentAuthRemoveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderEquipmentAuthRemoveModel : AopObject
    {
        /// <summary>
        ///     机具编号
        /// </summary>
        [XmlElement("device_id")]
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        ///     机具类型
        /// </summary>
        [XmlElement("device_type")]
        [JsonProperty("device_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceType { get; set; }

        /// <summary>
        ///     扩展信息，传json格式的字符串，包含auth_alipay_card_no =授权的商户支付宝卡号
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        ///     机具厂商PID
        /// </summary>
        [XmlElement("merchant_pid")]
        [JsonProperty("merchant_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantPid { get; set; }

        /// <summary>
        ///     操作人名称
        /// </summary>
        [XmlElement("operator")]
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        ///     操作人ID
        /// </summary>
        [XmlElement("operator_id")]
        [JsonProperty("operator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorId { get; set; }
    }
}