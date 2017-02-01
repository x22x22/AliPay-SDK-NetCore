using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     BudgetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BudgetInfo : AopObject
    {
        /// <summary>
        ///     预算数量
        /// </summary>
        [XmlElement("budget_total")]
        [JsonProperty("budget_total", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetTotal { get; set; }

        /// <summary>
        ///     预算类型
        /// </summary>
        [XmlElement("budget_type")]
        [JsonProperty("budget_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetType { get; set; }
    }
}