using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashStatusModifyModel : AopObject
    {
        /// <summary>
        /// 修改后的活动状态, PAUSE或者READY
        /// </summary>
        [XmlElement("camp_status")]
		[JsonProperty("camp_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CampStatus { get; set; }

        /// <summary>
        /// 要修改的现金红包活动号
        /// </summary>
        [XmlElement("crowd_no")]
		[JsonProperty("crowd_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdNo { get; set; }
    }
}
