using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderEquipmentAuthQuerybypageModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderEquipmentAuthQuerybypageModel : AopObject
    {
        /// <summary>
        /// 解绑起始时间
        /// </summary>
        [XmlElement("begin_time")]
		[JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 机具类型
        /// </summary>
        [XmlElement("device_type")]
		[JsonProperty("device_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceType { get; set; }

        /// <summary>
        /// 解绑截止时间
        /// </summary>
        [XmlElement("end_time")]
		[JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息，传json格式的字符串，包含operator=操作人；operator_id =操作人ID
        /// </summary>
        [XmlElement("ext_info")]
		[JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 机具厂商PID
        /// </summary>
        [XmlElement("merchant_pid")]
		[JsonProperty("merchant_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 当前页，***注意页数从1开始***
        /// </summary>
        [XmlElement("page_num")]
		[JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页容量：最小1，最大100
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }
    }
}
