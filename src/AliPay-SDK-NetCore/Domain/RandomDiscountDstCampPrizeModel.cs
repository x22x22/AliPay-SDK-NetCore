using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     RandomDiscountDstCampPrizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class RandomDiscountDstCampPrizeModel : AopObject
    {
        /// <summary>
        ///     折扣预算ID
        /// </summary>
        [XmlElement("budget_id")]
        [JsonProperty("budget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetId { get; set; }

        /// <summary>
        ///     随机立减折扣幅度列表
        /// </summary>
        [XmlArray("discount_random_model_list")]
        [XmlArrayItem("discount_random_model")]
        public List<DiscountRandomModel> DiscountRandomModelList { get; set; }

        /// <summary>
        ///     奖品id
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        ///     最高优惠金额=订单金额X(1-封顶折扣)  折扣幅度必须为0.3到1之间的小数(保留小数点后2位)
        /// </summary>
        [XmlElement("max_random_discount_rate")]
        [JsonProperty("max_random_discount_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxRandomDiscountRate { get; set; }
    }
}