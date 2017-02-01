using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignActivityOfflineCreateModel : AopObject
    {
        /// <summary>
        /// 预算信息
        /// </summary>
        [XmlElement("budget")]
		[JsonProperty("budget", NullValueHandling = NullValueHandling.Ignore)]
        public OpenPromoBudget Budget { get; set; }

        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlElement("camp")]
		[JsonProperty("camp", NullValueHandling = NullValueHandling.Ignore)]
        public OpenPromoCamp Camp { get; set; }

        /// <summary>
        /// 活动创建单号
        /// </summary>
        [XmlElement("out_biz_no")]
		[JsonProperty("out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 奖品信息
        /// </summary>
        [XmlElement("prize")]
		[JsonProperty("prize", NullValueHandling = NullValueHandling.Ignore)]
        public OpenPromoPrize Prize { get; set; }
    }
}
