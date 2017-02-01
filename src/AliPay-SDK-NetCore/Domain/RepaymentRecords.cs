using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     RepaymentRecords Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymentRecords : AopObject
    {
        /// <summary>
        ///     交易时间
        /// </summary>
        [XmlElement("date")]
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        ///     正常本金利息，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("interest")]
        [JsonProperty("interest", NullValueHandling = NullValueHandling.Ignore)]
        public string Interest { get; set; }

        /// <summary>
        ///     逾期本金利息，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("overdue_interest")]
        [JsonProperty("overdue_interest", NullValueHandling = NullValueHandling.Ignore)]
        public string OverdueInterest { get; set; }

        /// <summary>
        ///     逾期利息罚息，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("overdue_interest_penalty")]
        [JsonProperty("overdue_interest_penalty", NullValueHandling = NullValueHandling.Ignore)]
        public string OverdueInterestPenalty { get; set; }

        /// <summary>
        ///     逾期本金，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("overdue_principal")]
        [JsonProperty("overdue_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string OverduePrincipal { get; set; }

        /// <summary>
        ///     逾期本金罚息，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("overdue_principal_penalty")]
        [JsonProperty("overdue_principal_penalty", NullValueHandling = NullValueHandling.Ignore)]
        public string OverduePrincipalPenalty { get; set; }

        /// <summary>
        ///     正常本金，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("principal")]
        [JsonProperty("principal", NullValueHandling = NullValueHandling.Ignore)]
        public string Principal { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        [XmlElement("remarks")]
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        /// <summary>
        ///     交易总金额
        /// </summary>
        [XmlElement("total_amount")]
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }
    }
}