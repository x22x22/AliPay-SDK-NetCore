using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampStatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDrawcampStatusUpdateModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
		[JsonProperty("camp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampId { get; set; }

        /// <summary>
        /// 修改的活动状态，CAMP_PAUSED  暂停状态, CAMP_ENDED  结束状态, CAMP_GOING启动状态，只支持以上3种状态变更。结束状态的活动不允许在修改活动状态。
        /// </summary>
        [XmlElement("camp_status")]
		[JsonProperty("camp_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CampStatus { get; set; }
    }
}
