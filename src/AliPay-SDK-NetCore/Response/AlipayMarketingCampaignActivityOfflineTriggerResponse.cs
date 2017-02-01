using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMarketingCampaignActivityOfflineTriggerResponse.
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineTriggerResponse : AopResponse
    {
        /// <summary>
        ///     外部奖品ID
        /// </summary>
        [XmlElement("out_prize_id")]
        [JsonProperty("out_prize_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OutPrizeId { get; set; }
    }
}