using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KbAdvertCommissionClausePercentage Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertCommissionClausePercentage : AopObject
    {
        /// <summary>
        ///     分佣比例结束范围(100以内精度2位的非负小数)
        /// </summary>
        [XmlElement("commission_rate_end")]
        [JsonProperty("commission_rate_end", NullValueHandling = NullValueHandling.Ignore)]
        public string CommissionRateEnd { get; set; }

        /// <summary>
        ///     分佣比例开始范围(100以内精度2位的非负小数)
        /// </summary>
        [XmlElement("commission_rate_start")]
        [JsonProperty("commission_rate_start", NullValueHandling = NullValueHandling.Ignore)]
        public string CommissionRateStart { get; set; }

        /// <summary>
        ///     封顶金额结束范围(精度2位的非负小数)
        /// </summary>
        [XmlElement("max_limit_end")]
        [JsonProperty("max_limit_end", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxLimitEnd { get; set; }

        /// <summary>
        ///     封顶金额开始范围(精度2位的非负小数)
        /// </summary>
        [XmlElement("max_limit_start")]
        [JsonProperty("max_limit_start", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxLimitStart { get; set; }
    }
}