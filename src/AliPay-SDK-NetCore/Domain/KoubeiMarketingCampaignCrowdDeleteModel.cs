using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignCrowdDeleteModel : AopObject
    {
        /// <summary>
        /// 人群组的唯一标识ID
        /// </summary>
        [XmlElement("crowd_group_id")]
		[JsonProperty("crowd_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdGroupId { get; set; }
    }
}
