using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsMktCouponCmpgnBaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCouponCmpgnBaseDTO : AopObject
    {
        /// <summary>
        ///     活动id
        /// </summary>
        [XmlElement("campaign_id")]
        [JsonProperty("campaign_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampaignId { get; set; }

        /// <summary>
        ///     权益类型
        /// </summary>
        [XmlElement("coupon_type")]
        [JsonProperty("coupon_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponType { get; set; }

        /// <summary>
        ///     权益盖帽值
        /// </summary>
        [XmlElement("coupon_upper_value")]
        [JsonProperty("coupon_upper_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponUpperValue { get; set; }

        /// <summary>
        ///     权益值
        /// </summary>
        [XmlElement("coupon_value")]
        [JsonProperty("coupon_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponValue { get; set; }
    }
}