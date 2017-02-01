using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertSubjectResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertSubjectResponse : AopObject
    {
        /// <summary>
        /// 分佣规则
        /// </summary>
        [XmlElement("commission_clause")]
		[JsonProperty("commission_clause", NullValueHandling = NullValueHandling.Ignore)]
        public KbAdvertCommissionClauseResponse CommissionClause { get; set; }

        /// <summary>
        /// 标的类型  voucher-券
        /// </summary>
        [XmlElement("type")]
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 券标的  只有type=voucher才会有值
        /// </summary>
        [XmlElement("voucher")]
		[JsonProperty("voucher", NullValueHandling = NullValueHandling.Ignore)]
        public KbAdvertSubjectVoucherResponse Voucher { get; set; }
    }
}
