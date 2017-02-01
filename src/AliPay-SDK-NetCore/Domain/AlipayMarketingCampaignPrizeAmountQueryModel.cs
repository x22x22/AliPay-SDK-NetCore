using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeAmountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPrizeAmountQueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
		[JsonProperty("camp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampId { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
		[JsonProperty("prize_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrizeId { get; set; }
    }
}
