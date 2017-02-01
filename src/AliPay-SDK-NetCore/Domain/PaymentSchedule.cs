using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     PaymentSchedule Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentSchedule : AopObject
    {
        /// <summary>
        ///     还款日
        /// </summary>
        [XmlElement("date")]
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        ///     已还利息总和，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("repaid_interest_total")]
        [JsonProperty("repaid_interest_total", NullValueHandling = NullValueHandling.Ignore)]
        public string RepaidInterestTotal { get; set; }

        /// <summary>
        ///     已还罚息总和，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("repaid_penalty_total")]
        [JsonProperty("repaid_penalty_total", NullValueHandling = NullValueHandling.Ignore)]
        public string RepaidPenaltyTotal { get; set; }

        /// <summary>
        ///     已还本金总和，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("repaid_principal_total")]
        [JsonProperty("repaid_principal_total", NullValueHandling = NullValueHandling.Ignore)]
        public string RepaidPrincipalTotal { get; set; }

        /// <summary>
        ///     期初时间
        /// </summary>
        [XmlElement("start_date")]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        ///     期次
        /// </summary>
        [XmlElement("term")]
        [JsonProperty("term", NullValueHandling = NullValueHandling.Ignore)]
        public long Term { get; set; }

        /// <summary>
        ///     应还利息总和，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("unpaid_interest_total")]
        [JsonProperty("unpaid_interest_total", NullValueHandling = NullValueHandling.Ignore)]
        public string UnpaidInterestTotal { get; set; }

        /// <summary>
        ///     应还罚息总和，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("unpaid_penalty_total")]
        [JsonProperty("unpaid_penalty_total", NullValueHandling = NullValueHandling.Ignore)]
        public string UnpaidPenaltyTotal { get; set; }

        /// <summary>
        ///     应还本金总和，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("unpaid_principal_total")]
        [JsonProperty("unpaid_principal_total", NullValueHandling = NullValueHandling.Ignore)]
        public string UnpaidPrincipalTotal { get; set; }
    }
}