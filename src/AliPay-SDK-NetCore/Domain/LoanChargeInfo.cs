using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     LoanChargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LoanChargeInfo : AopObject
    {
        /// <summary>
        ///     费用编码
        /// </summary>
        [XmlElement("charge_code")]
        [JsonProperty("charge_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeCode { get; set; }

        /// <summary>
        ///     费用名称
        /// </summary>
        [XmlElement("charge_name")]
        [JsonProperty("charge_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeName { get; set; }

        /// <summary>
        ///     分段费率
        /// </summary>
        [XmlElement("instal_chrg_rate")]
        [JsonProperty("instal_chrg_rate", NullValueHandling = NullValueHandling.Ignore)]
        public InstallmentValue InstalChrgRate { get; set; }
    }
}