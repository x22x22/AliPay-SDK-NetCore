using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     DiscountDstCampPrizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountDstCampPrizeModel : AopObject
    {
        /// <summary>
        ///     预算id,商户先调预算创建接口得到预算id,传入
        /// </summary>
        [XmlElement("budget_id")]
        [JsonProperty("budget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetId { get; set; }

        /// <summary>
        ///     折扣幅度必须为0.1到1之间的小数(保留小数点后2位)
        /// </summary>
        [XmlElement("discount_rate")]
        [JsonProperty("discount_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountRate { get; set; }

        /// <summary>
        ///     奖品id  修改传值 ，新增可以不传
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        ///     单次优惠上限(元),单笔上限金额只能填写数字，大于等于0，小数点后最多2位，整数部分不能超过10位
        /// </summary>
        [XmlElement("max_discount_amt")]
        [JsonProperty("max_discount_amt", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxDiscountAmt { get; set; }
    }
}