using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportQueryModel : AopObject
    {
        /// <summary>
        /// 规则KEY
        /// </summary>
        [XmlElement("condition_key")]
		[JsonProperty("condition_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionKey { get; set; }

        /// <summary>
        /// 额外增加的查询过滤条件
        /// </summary>
        [XmlArray("filter_tags")]
        [XmlArrayItem("filter_tag")]
        public List<FilterTag> FilterTags { get; set; }

        /// <summary>
        /// 一次拉多少条
        /// </summary>
        [XmlElement("max_count")]
		[JsonProperty("max_count", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxCount { get; set; }
    }
}
