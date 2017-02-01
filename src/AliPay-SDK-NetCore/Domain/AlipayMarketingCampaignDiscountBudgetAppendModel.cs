using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetAppendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountBudgetAppendModel : AopObject
    {
        /// <summary>
        /// 预算ID
        /// </summary>
        [XmlElement("budget_id")]
		[JsonProperty("budget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetId { get; set; }

        /// <summary>
        /// 追加后的预算总金额（注意：是追加后的预算总金额，不是在原基础上追加的金额），单位：元
        /// </summary>
        [XmlElement("total_amount")]
		[JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }
    }
}
