using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertCommissionClausePercentageResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertCommissionClausePercentageResponse : AopObject
    {
        /// <summary>
        /// 分佣比例(100以内精度2位的非负小数)
        /// </summary>
        [XmlElement("commission_rate")]
		[JsonProperty("commission_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CommissionRate { get; set; }

        /// <summary>
        /// 封顶金额(精度2位的非负小数)
        /// </summary>
        [XmlElement("max_limit")]
		[JsonProperty("max_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxLimit { get; set; }
    }
}
