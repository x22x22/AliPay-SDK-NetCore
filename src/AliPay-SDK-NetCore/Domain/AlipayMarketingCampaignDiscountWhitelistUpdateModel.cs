using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountWhitelistUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountWhitelistUpdateModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
		[JsonProperty("camp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampId { get; set; }

        /// <summary>
        /// 白名单。逗号分隔开
        /// </summary>
        [XmlElement("user_white_list")]
		[JsonProperty("user_white_list", NullValueHandling = NullValueHandling.Ignore)]
        public string UserWhiteList { get; set; }
    }
}
