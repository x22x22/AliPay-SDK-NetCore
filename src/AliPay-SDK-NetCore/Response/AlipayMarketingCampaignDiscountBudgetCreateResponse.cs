using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMarketingCampaignDiscountBudgetCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetCreateResponse : AopResponse
    {
        /// <summary>
        ///     预算ID
        /// </summary>
        [XmlElement("budget_id")]
        [JsonProperty("budget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetId { get; set; }
    }
}