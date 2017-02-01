using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ReduceToDiscountDstCampPrizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ReduceToDiscountDstCampPrizeModel : AopObject
    {
        /// <summary>
        ///     折扣预算ID
        /// </summary>
        [XmlElement("budget_id")]
        [JsonProperty("budget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetId { get; set; }

        /// <summary>
        ///     奖品id
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        ///     单次优惠上限(元)
        /// </summary>
        [XmlElement("max_discount_amt")]
        [JsonProperty("max_discount_amt", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxDiscountAmt { get; set; }

        /// <summary>
        ///     折扣幅度减至必须为0.3到1之间的小数(保留小数点后2位)
        /// </summary>
        [XmlElement("reduce_to_discount_rate")]
        [JsonProperty("reduce_to_discount_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string ReduceToDiscountRate { get; set; }
    }
}