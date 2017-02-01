using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomReportCondition Data Structure.
    /// </summary>
    [Serializable]
    public class CustomReportCondition : AopObject
    {
        /// <summary>
        /// 规则KEY-为空则为创建规则，否则更新规则
        /// </summary>
        [XmlElement("condition_key")]
		[JsonProperty("condition_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionKey { get; set; }

        /// <summary>
        /// 明细数据标签
        /// </summary>
        [XmlArray("data_tags")]
        [XmlArrayItem("data_tag")]
        public List<DataTag> DataTags { get; set; }

        /// <summary>
        /// 分组过滤条件
        /// </summary>
        [XmlArray("filter_tags")]
        [XmlArrayItem("filter_tag")]
        public List<FilterTag> FilterTags { get; set; }

        /// <summary>
        /// 分组数据标签集合  注意：这个是JSON数组，必须以[开头，以]结尾，[]外层不能加双引号"",正确案例["orpt_ubase_age","orpt_ubase_birthday_mm"]，错误案例："["orpt_ubase_age","orpt_ubase_birthday_mm"]"
        /// </summary>
        [XmlElement("group_tags")]
		[JsonProperty("group_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupTags { get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 自定义报表名称
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 排序数据标签集合  注意：这个是JSON数组，必须以[开头，以]结尾，[]外层不能加双引号"",正确案例[{"code":"orpt_ubase_age","sortBy":"DESC"}]，错误案例："[{"code":"orpt_ubase_age","sortBy":"DESC"}]"
        /// </summary>
        [XmlElement("sort_tags")]
		[JsonProperty("sort_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string SortTags { get; set; }
    }
}
