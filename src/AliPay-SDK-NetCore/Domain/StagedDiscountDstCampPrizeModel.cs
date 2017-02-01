using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     StagedDiscountDstCampPrizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class StagedDiscountDstCampPrizeModel : AopObject
    {
        /// <summary>
        ///     折扣预算ID
        /// </summary>
        [XmlElement("budget_id")]
        [JsonProperty("budget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetId { get; set; }

        /// <summary>
        ///     折扣幅度列表.
        /// </summary>
        [XmlArray("discount_rate_model_list")]
        [XmlArrayItem("discount_rate_model")]
        public List<DiscountRateModel> DiscountRateModelList { get; set; }

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
    }
}