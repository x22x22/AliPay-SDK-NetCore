using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayMarketingCampaignDiscountBudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountBudgetQueryModel : AopObject
    {
        /// <summary>
        ///     预算名称
        /// </summary>
        [XmlElement("budget_id")]
        [JsonProperty("budget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetId { get; set; }
    }
}