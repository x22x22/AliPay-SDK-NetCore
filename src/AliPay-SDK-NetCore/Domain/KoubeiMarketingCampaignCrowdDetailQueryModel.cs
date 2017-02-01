using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiMarketingCampaignCrowdDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignCrowdDetailQueryModel : AopObject
    {
        /// <summary>
        ///     人群组ID，人群组创建成功时返回的ID
        /// </summary>
        [XmlElement("crowd_group_id")]
        [JsonProperty("crowd_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdGroupId { get; set; }
    }
}