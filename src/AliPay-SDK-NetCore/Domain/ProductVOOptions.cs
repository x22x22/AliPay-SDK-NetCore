using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductVOOptions Data Structure.
    /// </summary>
    [Serializable]
    public class ProductVOOptions : AopObject
    {
        /// <summary>
        /// 是否包括产品条件组信息，默认为false
        /// </summary>
        [XmlElement("include_condition_group")]
		[JsonProperty("include_condition_group", NullValueHandling = NullValueHandling.Ignore)]
        public bool IncludeConditionGroup { get; set; }

        /// <summary>
        /// 是否包括产品基本信息，默认为false
        /// </summary>
        [XmlElement("include_prod_base")]
		[JsonProperty("include_prod_base", NullValueHandling = NullValueHandling.Ignore)]
        public bool IncludeProdBase { get; set; }

        /// <summary>
        /// 是否包括产品参与者信息，默认为false
        /// </summary>
        [XmlElement("include_prod_ip")]
		[JsonProperty("include_prod_ip", NullValueHandling = NullValueHandling.Ignore)]
        public bool IncludeProdIp { get; set; }

        /// <summary>
        /// 是否包括产品区域信息
        /// </summary>
        [XmlElement("include_prod_lo")]
		[JsonProperty("include_prod_lo", NullValueHandling = NullValueHandling.Ignore)]
        public bool IncludeProdLo { get; set; }

        /// <summary>
        /// 是否包括产品外标信息
        /// </summary>
        [XmlElement("include_prod_mark")]
		[JsonProperty("include_prod_mark", NullValueHandling = NullValueHandling.Ignore)]
        public bool IncludeProdMark { get; set; }

        /// <summary>
        /// 产品关联关系
        /// </summary>
        [XmlElement("include_prod_rel")]
		[JsonProperty("include_prod_rel", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeProdRel { get; set; }

        /// <summary>
        /// 是否包括产品资源项信息
        /// </summary>
        [XmlElement("include_prod_ri")]
		[JsonProperty("include_prod_ri", NullValueHandling = NullValueHandling.Ignore)]
        public bool IncludeProdRi { get; set; }
    }
}
