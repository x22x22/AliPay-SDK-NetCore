using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReduceDstCampPrizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ReduceDstCampPrizeModel : AopObject
    {
        /// <summary>
        /// 折扣预算ID
        /// </summary>
        [XmlElement("budget_id")]
		[JsonProperty("budget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetId { get; set; }

        /// <summary>
        /// 奖品id, 修改必输，新增不输入
        /// </summary>
        [XmlElement("id")]
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 单次优惠上限(元)
        /// </summary>
        [XmlElement("max_discount_amt")]
		[JsonProperty("max_discount_amt", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxDiscountAmt { get; set; }

        /// <summary>
        /// 满的金额只能填写正整数字，大于0，必须小于9位
        /// </summary>
        [XmlElement("reduce_amt_pre")]
		[JsonProperty("reduce_amt_pre", NullValueHandling = NullValueHandling.Ignore)]
        public string ReduceAmtPre { get; set; }

        /// <summary>
        /// 减的金额只能填写数字，大于0，小数点后最多2位，整数部分不能超过8位
        /// </summary>
        [XmlElement("reduce_amt_suf")]
		[JsonProperty("reduce_amt_suf", NullValueHandling = NullValueHandling.Ignore)]
        public string ReduceAmtSuf { get; set; }
    }
}
