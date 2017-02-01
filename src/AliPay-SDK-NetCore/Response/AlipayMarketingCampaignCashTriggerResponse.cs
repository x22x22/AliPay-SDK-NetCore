using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCashTriggerResponse.
    /// </summary>
    public class AlipayMarketingCampaignCashTriggerResponse : AopResponse
    {
        /// <summary>
        /// 红包名称,创建活动时设置，用于账单列表和详情、红包列表和详情的展示
        /// </summary>
        [XmlElement("coupon_name")]
		[JsonProperty("coupon_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponName { get; set; }

        /// <summary>
        /// 用户领取失败的错误信息描述
        /// </summary>
        [XmlElement("error_msg")]
		[JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 商户头像logo的图片url地址，用于账单和红包列表、详情的展示
        /// </summary>
        [XmlElement("merchant_logo")]
		[JsonProperty("merchant_logo", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 发送红包商户签约pid，发奖成功时非空
        /// </summary>
        [XmlElement("partner_id")]
		[JsonProperty("partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 现金红包金额，发奖成功时非空，千分位格式，保留两位小数
        /// </summary>
        [XmlElement("prize_amount")]
		[JsonProperty("prize_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PrizeAmount { get; set; }

        /// <summary>
        /// 活动文案,用于账单的备注展示、红包详情页的文案展示
        /// </summary>
        [XmlElement("prize_msg")]
		[JsonProperty("prize_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string PrizeMsg { get; set; }

        /// <summary>
        /// 用户是否重复领取，如果重复领取，返回的是之前的中奖结果，如果是首次领取，则走发奖流程
        /// </summary>
        [XmlElement("repeat_trigger_flag")]
		[JsonProperty("repeat_trigger_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string RepeatTriggerFlag { get; set; }

        /// <summary>
        /// 是否中奖结果状态，如果为true时返回的结果中的其他字段非空，否则返回的其他字段为空
        /// </summary>
        [XmlElement("trigger_result")]
		[JsonProperty("trigger_result", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerResult { get; set; }
    }
}
