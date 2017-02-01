using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayMarketingCampaignCashDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashDetailQueryModel : AopObject
    {
        /// <summary>
        ///     要查询的现金红包活动号
        /// </summary>
        [XmlElement("crowd_no")]
        [JsonProperty("crowd_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdNo { get; set; }
    }
}