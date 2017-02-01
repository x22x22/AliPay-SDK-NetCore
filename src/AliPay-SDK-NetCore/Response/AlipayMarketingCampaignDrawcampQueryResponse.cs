using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMarketingCampaignDrawcampQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampQueryResponse : AopResponse
    {
        /// <summary>
        ///     单用户以支付宝账号维度可参与当前营销活动的总次数，由开发者自定义此数值
        /// </summary>
        [XmlElement("account_count")]
        [JsonProperty("account_count", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountCount { get; set; }

        /// <summary>
        ///     以移动设备维度可参与当前营销活动的总次数，由开发者自定义此数值
        /// </summary>
        [XmlElement("appid_count")]
        [JsonProperty("appid_count", NullValueHandling = NullValueHandling.Ignore)]
        public string AppidCount { get; set; }

        /// <summary>
        ///     单个用户当前活动允许中奖的最大次数，最大值999999
        /// </summary>
        [XmlElement("award_count")]
        [JsonProperty("award_count", NullValueHandling = NullValueHandling.Ignore)]
        public string AwardCount { get; set; }

        /// <summary>
        ///     活动奖品总中奖几率，开发者需传入整数值，如：传入99支付宝默认为99%
        /// </summary>
        [XmlElement("award_rate")]
        [JsonProperty("award_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string AwardRate { get; set; }

        /// <summary>
        ///     活动唯一标识,不能包含除中文、英文、数字以外的字符，创建后不能修改，需要保证在商户端不重复。
        /// </summary>
        [XmlElement("camp_code")]
        [JsonProperty("camp_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CampCode { get; set; }

        /// <summary>
        ///     活动结束时间，yyyy-MM-dd HH:00:00格式(到小时)，需要大于活动开始时间
        /// </summary>
        [XmlElement("camp_end_time")]
        [JsonProperty("camp_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CampEndTime { get; set; }

        /// <summary>
        ///     抽奖活动id
        /// </summary>
        [XmlElement("camp_id")]
        [JsonProperty("camp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampId { get; set; }

        /// <summary>
        ///     活动名称，开发者自定义
        /// </summary>
        [XmlElement("camp_name")]
        [JsonProperty("camp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CampName { get; set; }

        /// <summary>
        ///     活动开始时间，yyyy-MM-dd HH:00:00格式（到小时），时间不能早于当前日期的0点
        /// </summary>
        [XmlElement("camp_start_time")]
        [JsonProperty("camp_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CampStartTime { get; set; }

        /// <summary>
        ///     活动状态，CAMP_CREATED(已创建状态)，CAMP_PAUSED(暂停状态)，CAMP_ENDED(结束状态)，CAMP_GOING(启动状态)，可由alipay.marketing.campaign.drawcamp.status.update
        ///     接口将已创建状态改为启动状态，将启动状态改为暂停/结束状态，将暂停状态置为结束状态
        /// </summary>
        [XmlElement("camp_status")]
        [JsonProperty("camp_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CampStatus { get; set; }

        /// <summary>
        ///     凭证验证规则id，通过alipay.marketing.campaign.cert.create 接口创建的凭证id
        /// </summary>
        [XmlElement("cert_rule_id")]
        [JsonProperty("cert_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertRuleId { get; set; }

        /// <summary>
        ///     单用户以账户证件号（如身份证号、护照、军官证等）维度可参与当前营销活动的总次数，由开发者自定义此数值
        /// </summary>
        [XmlElement("certification_count")]
        [JsonProperty("certification_count", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificationCount { get; set; }

        /// <summary>
        ///     签约商户的pid，系统默认获取当前接口调用者的签约pid
        /// </summary>
        [XmlElement("creator")]
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        ///     圈人规则id，通过alipay.marketing.campaign.rule.crowd.create 接口创建的规则id
        /// </summary>
        [XmlElement("crowd_rule_id")]
        [JsonProperty("crowd_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdRuleId { get; set; }

        /// <summary>
        ///     以认证手机号（与支付宝账号绑定的手机号）维度的可参与当前营销活动的总次数，由开发者自定义此数值
        /// </summary>
        [XmlElement("mobile_count")]
        [JsonProperty("mobile_count", NullValueHandling = NullValueHandling.Ignore)]
        public string MobileCount { get; set; }

        /// <summary>
        ///     奖品模型，至少有一个奖品模型
        /// </summary>
        [XmlArray("prize_list")]
        [XmlArrayItem("mp_prize_info_model")]
        public List<MpPrizeInfoModel> PrizeList { get; set; }

        /// <summary>
        ///     营销验证规则id，由支付宝配置
        /// </summary>
        [XmlElement("promo_rule_id")]
        [JsonProperty("promo_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromoRuleId { get; set; }

        /// <summary>
        ///     活动触发类型，目前支持  CAMP_USER_TRIGGER：用户触发（开发者调用alipay.marketing.campaign.drawcamp.trigger 接口触发）；
        ///     CAMP_SYS_TRIGGER：系统触发，必须配置实时人群验证规则（如：配置了监听用户支付事件，支付宝会根据活动规则自动发奖，无需用户手动触发）。
        /// </summary>
        [XmlElement("trigger_type")]
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        ///     实时人群验证规则id，由支付宝配置
        /// </summary>
        [XmlElement("trigger_user_rule_id")]
        [JsonProperty("trigger_user_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerUserRuleId { get; set; }

        /// <summary>
        ///     人群验证规则id，由支付宝配置
        /// </summary>
        [XmlElement("user_rule_id")]
        [JsonProperty("user_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserRuleId { get; set; }
    }
}