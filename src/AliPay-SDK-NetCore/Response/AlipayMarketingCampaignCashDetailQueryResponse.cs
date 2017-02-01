using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCashDetailQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignCashDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动状态，CREATED: 已创建未打款  PAID:已打款  READY:活动已开始  PAUSE:活动已暂停  CLOSED:活动已结束  SETTLE:活动已清算
        /// </summary>
        [XmlElement("camp_status")]
		[JsonProperty("camp_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CampStatus { get; set; }

        /// <summary>
        /// 红包名称
        /// </summary>
        [XmlElement("coupon_name")]
		[JsonProperty("coupon_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponName { get; set; }

        /// <summary>
        /// 活动号
        /// </summary>
        [XmlElement("crowd_no")]
		[JsonProperty("crowd_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
		[JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 原始活动号,商户排查问题时提供的活动依据
        /// </summary>
        [XmlElement("origin_crowd_no")]
		[JsonProperty("origin_crowd_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginCrowdNo { get; set; }

        /// <summary>
        /// 活动文案,用户在账单中看到的红包描述
        /// </summary>
        [XmlElement("prize_msg")]
		[JsonProperty("prize_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string PrizeMsg { get; set; }

        /// <summary>
        /// 现金红包的发放形式, fixed为固定金额,random为随机金额
        /// </summary>
        [XmlElement("prize_type")]
		[JsonProperty("prize_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PrizeType { get; set; }

        /// <summary>
        /// 活动已发放金额
        /// </summary>
        [XmlElement("send_amount")]
		[JsonProperty("send_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string SendAmount { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
		[JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动总金额
        /// </summary>
        [XmlElement("total_amount")]
		[JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 红包总个数
        /// </summary>
        [XmlElement("total_num")]
		[JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalNum { get; set; }
    }
}
