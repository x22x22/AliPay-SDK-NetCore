using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMarketingCampaignPrizeAmountQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizeAmountQueryResponse : AopResponse
    {
        /// <summary>
        ///     奖品剩余数量，数值
        /// </summary>
        [XmlElement("remain_amount")]
        [JsonProperty("remain_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainAmount { get; set; }
    }
}