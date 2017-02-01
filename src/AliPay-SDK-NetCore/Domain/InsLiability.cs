using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsLiability Data Structure.
    /// </summary>
    [Serializable]
    public class InsLiability : AopObject
    {
        /// <summary>
        /// 责任描述
        /// </summary>
        [XmlElement("liability_desc")]
		[JsonProperty("liability_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string LiabilityDesc { get; set; }

        /// <summary>
        /// 责任名称
        /// </summary>
        [XmlElement("liability_name")]
		[JsonProperty("liability_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LiabilityName { get; set; }

        /// <summary>
        /// 保额
        /// </summary>
        [XmlElement("sum_insured")]
		[JsonProperty("sum_insured", NullValueHandling = NullValueHandling.Ignore)]
        public InsSumInsured SumInsured { get; set; }
    }
}
