using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineSaleleadsClaimstatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSaleleadsClaimstatusModel : AopObject
    {
        /// <summary>
        ///     商机(或者销售机会)
        /// </summary>
        [XmlElement("leads_id")]
        [JsonProperty("leads_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsId { get; set; }

        /// <summary>
        ///     操作人PID
        /// </summary>
        [XmlElement("ope_pid")]
        [JsonProperty("ope_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string OpePid { get; set; }

        /// <summary>
        ///     原操作员工pid
        /// </summary>
        [XmlElement("ope_pid_orig")]
        [JsonProperty("ope_pid_orig", NullValueHandling = NullValueHandling.Ignore)]
        public string OpePidOrig { get; set; }

        /// <summary>
        ///     CLAIM(认领);ALLOCATE(分配);RELEASE(释放).全是大写字母
        /// </summary>
        [XmlElement("oper_type")]
        [JsonProperty("oper_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperType { get; set; }

        /// <summary>
        ///     全局唯一的流水号
        /// </summary>
        [XmlElement("request_id")]
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }
    }
}