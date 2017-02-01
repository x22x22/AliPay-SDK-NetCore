using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiMarketingCampaignCrowdCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdCreateResponse : AopResponse
    {
        /// <summary>
        ///     返回的人群组的唯一标识
        /// </summary>
        [XmlElement("crowd_group_id")]
        [JsonProperty("crowd_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdGroupId { get; set; }
    }
}