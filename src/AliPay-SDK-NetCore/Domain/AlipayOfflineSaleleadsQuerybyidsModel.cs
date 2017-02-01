using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSaleleadsQuerybyidsModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSaleleadsQuerybyidsModel : AopObject
    {
        /// <summary>
        /// leadsid列表，多个以英文逗号隔开
        /// </summary>
        [XmlElement("leads_id")]
		[JsonProperty("leads_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsId { get; set; }

        /// <summary>
        /// 操作人PID
        /// </summary>
        [XmlElement("ope_pid")]
		[JsonProperty("ope_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string OpePid { get; set; }

        /// <summary>
        /// 全局唯一的流水号
        /// </summary>
        [XmlElement("request_id")]
		[JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }
    }
}
