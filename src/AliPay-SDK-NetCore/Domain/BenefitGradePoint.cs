using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     BenefitGradePoint Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitGradePoint : AopObject
    {
        /// <summary>
        ///     蚂蚁会员权益配置的ID
        /// </summary>
        [XmlElement("benefit_id")]
        [JsonProperty("benefit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BenefitId { get; set; }

        /// <summary>
        ///     蚂蚁会员权益配置在各个用户等级下的折扣积分
        /// </summary>
        [XmlArray("grade_points")]
        [XmlArrayItem("grade_discount_point")]
        public List<GradeDiscountPoint> GradePoints { get; set; }

        /// <summary>
        ///     蚂蚁会员权益配置的原始积分
        /// </summary>
        [XmlElement("original_point")]
        [JsonProperty("original_point", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalPoint { get; set; }

        /// <summary>
        ///     蚂蚁会员权益的专享等级列表
        /// </summary>
        [XmlElement("own_grades")]
        [JsonProperty("own_grades", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnGrades { get; set; }
    }
}