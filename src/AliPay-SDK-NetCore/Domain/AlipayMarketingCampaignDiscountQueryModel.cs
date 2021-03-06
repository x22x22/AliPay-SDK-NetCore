using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayMarketingCampaignDiscountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountQueryModel : AopObject
    {
        /// <summary>
        ///     活动id
        /// </summary>
        [XmlElement("camp_id")]
        [JsonProperty("camp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampId { get; set; }
    }
}