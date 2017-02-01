using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     GradeDiscountPoint Data Structure.
    /// </summary>
    [Serializable]
    public class GradeDiscountPoint : AopObject
    {
        /// <summary>
        ///     蚂蚁会员权益配置的ID
        /// </summary>
        [XmlElement("benefit_id")]
        [JsonProperty("benefit_id", NullValueHandling = NullValueHandling.Ignore)]
        public long BenefitId { get; set; }

        /// <summary>
        ///     各个等级的等级折扣后的积分
        /// </summary>
        [XmlElement("discount_point")]
        [JsonProperty("discount_point", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountPoint { get; set; }

        /// <summary>
        ///     蚂蚁会员等级
        /// </summary>
        [XmlElement("grade")]
        [JsonProperty("grade", NullValueHandling = NullValueHandling.Ignore)]
        public string Grade { get; set; }
    }
}