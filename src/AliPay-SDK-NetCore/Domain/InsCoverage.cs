using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsCoverage Data Structure.
    /// </summary>
    [Serializable]
    public class InsCoverage : AopObject
    {
        /// <summary>
        /// 险种名称
        /// </summary>
        [XmlElement("coverage_name")]
		[JsonProperty("coverage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverageName { get; set; }

        /// <summary>
        /// 险种编号
        /// </summary>
        [XmlElement("coverage_no")]
		[JsonProperty("coverage_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverageNo { get; set; }

        /// <summary>
        /// 险种失效时间
        /// </summary>
        [XmlElement("effect_end_time")]
		[JsonProperty("effect_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 险种生效时间
        /// </summary>
        [XmlElement("effect_start_time")]
		[JsonProperty("effect_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 不计免赔;0：默认不投保;  1：默认投保。
        /// </summary>
        [XmlElement("iop")]
		[JsonProperty("iop", NullValueHandling = NullValueHandling.Ignore)]
        public long Iop { get; set; }

        /// <summary>
        /// 不计免赔的保费
        /// </summary>
        [XmlElement("iop_premium")]
		[JsonProperty("iop_premium", NullValueHandling = NullValueHandling.Ignore)]
        public long IopPremium { get; set; }

        /// <summary>
        /// 保费;单位分
        /// </summary>
        [XmlElement("premium")]
		[JsonProperty("premium", NullValueHandling = NullValueHandling.Ignore)]
        public long Premium { get; set; }

        /// <summary>
        /// 保额;单位分
        /// </summary>
        [XmlElement("sum_insured")]
		[JsonProperty("sum_insured", NullValueHandling = NullValueHandling.Ignore)]
        public long SumInsured { get; set; }
    }
}
