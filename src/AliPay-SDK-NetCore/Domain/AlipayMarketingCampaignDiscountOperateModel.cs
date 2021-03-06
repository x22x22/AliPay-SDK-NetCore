using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayMarketingCampaignDiscountOperateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountOperateModel : AopObject
    {
        /// <summary>
        ///     幂等控制code,控制重复新增，修改时候可以不设置。
        /// </summary>
        [XmlElement("camp_code")]
        [JsonProperty("camp_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CampCode { get; set; }

        /// <summary>
        ///     用于账户立减优惠,渠道立减优惠活动时,在收银台页面显示给会员看,最多512个字符，汉字、英文字母、数字都算一个，本输入框支持简单的html符号。
        /// </summary>
        [XmlElement("camp_desc")]
        [JsonProperty("camp_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string CampDesc { get; set; }

        /// <summary>
        ///     当operate_type=CAMP_MODIFIED 必设置camp_id
        /// </summary>
        [XmlElement("camp_id")]
        [JsonProperty("camp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampId { get; set; }

        /// <summary>
        ///     活动名称 不超过24个字符
        /// </summary>
        [XmlElement("camp_name")]
        [JsonProperty("camp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CampName { get; set; }

        /// <summary>
        ///     用于账户立减优惠,渠道立减优惠活动时,在收银台页面显示给会员看,请根据收银台可展示的实际字数填写,最多48个字符，汉字、英文字母、数字都算一个，只可输入中文、英文、数字、下划线以及中英文的双引号、逗号、句号、横杠、空格。
        /// </summary>
        [XmlElement("camp_slogan")]
        [JsonProperty("camp_slogan", NullValueHandling = NullValueHandling.Ignore)]
        public string CampSlogan { get; set; }

        /// <summary>
        ///     折扣方式模型 如果类型选了discount,则这个模型必须输入
        /// </summary>
        [XmlElement("discount_dst_camp_prize_model")]
        [JsonProperty("discount_dst_camp_prize_model", NullValueHandling = NullValueHandling.Ignore)]
        public DiscountDstCampPrizeModel DiscountDstCampPrizeModel { get; set; }

        /// <summary>
        ///     立减规则模型
        /// </summary>
        [XmlElement("dst_camp_rule_model")]
        [JsonProperty("dst_camp_rule_model", NullValueHandling = NullValueHandling.Ignore)]
        public DstCampRuleModel DstCampRuleModel { get; set; }

        /// <summary>
        ///     活动子时间，可以不传
        /// </summary>
        [XmlArray("dst_camp_sub_time_model_list")]
        [XmlArrayItem("date_area_model")]
        public List<DateAreaModel> DstCampSubTimeModelList { get; set; }

        /// <summary>
        ///     活动结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        [JsonProperty("gmt_end", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtEnd { get; set; }

        /// <summary>
        ///     活动开始时间
        /// </summary>
        [XmlElement("gmt_start")]
        [JsonProperty("gmt_start", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtStart { get; set; }

        /// <summary>
        ///     新增传CAMP_ADD，修改传CAMP_MODIFIED
        /// </summary>
        [XmlElement("operate_type")]
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        ///     奖品类型. 打折   满减   单笔减   阶梯优惠   抹零优惠    随机立减   订单金额减至       折扣方式      DISCOUNT("discount", "折扣方式"),
        ///     REDUCE("reduce", "满立减"),       SINGLE("single", "单笔减"),       STAGED_DISCOUNT("staged_discount", "阶梯优惠"),
        ///     RESET_ZERO_DISCOUNT("reset_zero_discount", "抹零优惠"),     RANDOM_DISCOUNT("random", "随机立减");
        ///     REDUCE_TO_DISCOUNT("reduce_to_discount","订单金额减至 ")
        /// </summary>
        [XmlElement("prize_type")]
        [JsonProperty("prize_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PrizeType { get; set; }

        /// <summary>
        ///     随机立减模型如果类型选了random,则这个模型必须输入
        /// </summary>
        [XmlElement("random_discount_dst_camp_prize_model")]
        [JsonProperty("random_discount_dst_camp_prize_model", NullValueHandling = NullValueHandling.Ignore)]
        public RandomDiscountDstCampPrizeModel RandomDiscountDstCampPrizeModel { get; set; }

        /// <summary>
        ///     满立减奖品模型 如果类型选了reduce,则这个模型必须输入
        /// </summary>
        [XmlElement("reduce_dst_camp_prize_model")]
        [JsonProperty("reduce_dst_camp_prize_model", NullValueHandling = NullValueHandling.Ignore)]
        public ReduceDstCampPrizeModel ReduceDstCampPrizeModel { get; set; }

        /// <summary>
        ///     订单金额减至模型如果类型选了reduce_to_discount,则这个模型必须输入
        /// </summary>
        [XmlElement("reduce_to_discount_dst_camp_prize_model")]
        [JsonProperty("reduce_to_discount_dst_camp_prize_model", NullValueHandling = NullValueHandling.Ignore)]
        public ReduceToDiscountDstCampPrizeModel ReduceToDiscountDstCampPrizeModel { get; set; }

        /// <summary>
        ///     抹零优惠模型如果类型选了reset_zero_discount,则这个模型必须输入
        /// </summary>
        [XmlElement("reset_zero_dst_camp_prize_model")]
        [JsonProperty("reset_zero_dst_camp_prize_model", NullValueHandling = NullValueHandling.Ignore)]
        public ResetZeroDstCampPrizeModel ResetZeroDstCampPrizeModel { get; set; }

        /// <summary>
        ///     单笔减奖品模型如果类型选了single,则这个模型必须输入
        /// </summary>
        [XmlElement("single_dst_camp_prize_model")]
        [JsonProperty("single_dst_camp_prize_model", NullValueHandling = NullValueHandling.Ignore)]
        public SingleDstCampPrizeModel SingleDstCampPrizeModel { get; set; }

        /// <summary>
        ///     阶梯优惠如果类型选了staged_discount,则这个模型必须输入
        /// </summary>
        [XmlElement("staged_discount_dst_camp_prize_model")]
        [JsonProperty("staged_discount_dst_camp_prize_model", NullValueHandling = NullValueHandling.Ignore)]
        public StagedDiscountDstCampPrizeModel StagedDiscountDstCampPrizeModel { get; set; }
    }
}