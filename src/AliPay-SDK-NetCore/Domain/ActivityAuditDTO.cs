using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityAuditDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityAuditDTO : AopObject
    {
        /// <summary>
        /// 审核id
        /// </summary>
        [XmlElement("audit_id")]
		[JsonProperty("audit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditId { get; set; }

        /// <summary>
        /// INIT:初始化;AUDITING:审核中;REJECT:审核驳回;PASS:审核通过;CANCEL:审核撤销;FAIL:审核失败
        /// </summary>
        [XmlElement("audit_status")]
		[JsonProperty("audit_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("creator_id")]
		[JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// SALES:口碑内部小二;PROVIDER:外部服务商;PROVIDER_STAFF:外部服务商员工
        /// </summary>
        [XmlElement("creator_type")]
		[JsonProperty("creator_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorType { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operation_time")]
		[JsonProperty("operation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTime { get; set; }

        /// <summary>
        /// 审核通过或者审核驳回的原因
        /// </summary>
        [XmlElement("reason")]
		[JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }
    }
}
