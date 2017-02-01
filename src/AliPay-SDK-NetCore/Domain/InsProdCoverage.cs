using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsProdCoverage Data Structure.
    /// </summary>
    [Serializable]
    public class InsProdCoverage : AopObject
    {
        /// <summary>
        ///     险种描述
        /// </summary>
        [XmlElement("coverage_desc")]
        [JsonProperty("coverage_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverageDesc { get; set; }

        /// <summary>
        ///     险种名称
        /// </summary>
        [XmlElement("coverage_name")]
        [JsonProperty("coverage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverageName { get; set; }

        /// <summary>
        ///     险种编号
        /// </summary>
        [XmlElement("coverage_no")]
        [JsonProperty("coverage_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverageNo { get; set; }

        /// <summary>
        ///     是否定期险种
        /// </summary>
        [XmlElement("is_fixed_period")]
        [JsonProperty("is_fixed_period", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsFixedPeriod { get; set; }

        /// <summary>
        ///     险种责任列表
        /// </summary>
        [XmlArray("liabilities")]
        [XmlArrayItem("ins_liability")]
        public List<InsLiability> Liabilities { get; set; }

        /// <summary>
        ///     可用的保障期限列表;约定“1D”代表一天，“1M”代表一个月,"1Y"代表一年
        /// </summary>
        [XmlArray("periods")]
        [XmlArrayItem("string")]
        public List<string> Periods { get; set; }

        /// <summary>
        ///     保额
        /// </summary>
        [XmlElement("sum_insured")]
        [JsonProperty("sum_insured", NullValueHandling = NullValueHandling.Ignore)]
        public InsSumInsured SumInsured { get; set; }
    }
}