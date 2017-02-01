using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountWhitelistQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountWhitelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
		[JsonProperty("camp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampId { get; set; }

        /// <summary>
        /// 活动id.白名单,","隔开，最多100个
        /// </summary>
        [XmlElement("user_white_list")]
		[JsonProperty("user_white_list", NullValueHandling = NullValueHandling.Ignore)]
        public string UserWhiteList { get; set; }
    }
}
