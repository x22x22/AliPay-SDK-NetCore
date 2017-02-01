using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CashCampaignInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CashCampaignInfo : AopObject
    {
        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("camp_status")]
		[JsonProperty("camp_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CampStatus { get; set; }

        /// <summary>
        /// 现金红包名称
        /// </summary>
        [XmlElement("coupon_name")]
		[JsonProperty("coupon_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponName { get; set; }

        /// <summary>
        /// 现金红包活动号
        /// </summary>
        [XmlElement("crowd_no")]
		[JsonProperty("crowd_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 原始活动号,商户进行问题排查时提供
        /// </summary>
        [XmlElement("origin_crowd_no")]
		[JsonProperty("origin_crowd_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginCrowdNo { get; set; }
    }
}
