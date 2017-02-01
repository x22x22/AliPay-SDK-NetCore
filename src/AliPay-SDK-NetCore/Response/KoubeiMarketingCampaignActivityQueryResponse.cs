using System;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动详情
        /// </summary>
        [XmlElement("camp_detail")]
		[JsonProperty("camp_detail", NullValueHandling = NullValueHandling.Ignore)]
        public CampDetail CampDetail { get; set; }
    }
}
