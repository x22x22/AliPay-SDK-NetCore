using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMarketingCampaignActivityOfflineCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineCreateResponse : AopResponse
    {
        /// <summary>
        ///     创建成功的活动id
        /// </summary>
        [XmlElement("camp_id")]
        [JsonProperty("camp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampId { get; set; }

        /// <summary>
        ///     创建成功的券模版id
        /// </summary>
        [XmlElement("prize_id")]
        [JsonProperty("prize_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrizeId { get; set; }
    }
}