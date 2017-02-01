using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarDataExternalSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataExternalSendModel : AopObject
    {
        /// <summary>
        ///     external_system_name
        /// </summary>
        [XmlElement("external_system_name")]
        [JsonProperty("external_system_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalSystemName { get; set; }

        /// <summary>
        ///     is_transfer_uid
        /// </summary>
        [XmlElement("is_transfer_uid")]
        [JsonProperty("is_transfer_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string IsTransferUid { get; set; }

        /// <summary>
        ///     operate_type
        /// </summary>
        [XmlElement("operate_type")]
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        ///     send_data
        /// </summary>
        [XmlElement("send_data")]
        [JsonProperty("send_data", NullValueHandling = NullValueHandling.Ignore)]
        public string SendData { get; set; }
    }
}