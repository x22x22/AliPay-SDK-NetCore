using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     BenefitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitInfo : AopObject
    {
        /// <summary>
        ///     权益信息id
        /// </summary>
        [XmlElement("benefit_info_id")]
        [JsonProperty("benefit_info_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BenefitInfoId { get; set; }

        /// <summary>
        ///     权益名称
        /// </summary>
        [XmlElement("benefit_name")]
        [JsonProperty("benefit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BenefitName { get; set; }

        /// <summary>
        ///     权益中文名称
        /// </summary>
        [XmlElement("benefit_name_cn")]
        [JsonProperty("benefit_name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string BenefitNameCn { get; set; }

        /// <summary>
        ///     权益类型(会员等级: MemberGrade)
        /// </summary>
        [XmlElement("benefit_type")]
        [JsonProperty("benefit_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BenefitType { get; set; }

        /// <summary>
        ///     权益发放时间
        /// </summary>
        [XmlElement("dispatch_dt")]
        [JsonProperty("dispatch_dt", NullValueHandling = NullValueHandling.Ignore)]
        public string DispatchDt { get; set; }

        /// <summary>
        ///     权益失效时间
        /// </summary>
        [XmlElement("end_dt")]
        [JsonProperty("end_dt", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDt { get; set; }

        /// <summary>
        ///     权益生效时间
        /// </summary>
        [XmlElement("start_dt")]
        [JsonProperty("start_dt", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDt { get; set; }

        /// <summary>
        ///     权益当前状态       * 待生效：WAIT  * 生效：VALID  * 失效：INVALID
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}