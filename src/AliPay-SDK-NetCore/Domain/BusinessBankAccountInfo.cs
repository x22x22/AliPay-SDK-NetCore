using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     BusinessBankAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessBankAccountInfo : AopObject
    {
        /// <summary>
        ///     企业对公账户名称
        /// </summary>
        [XmlElement("business_bank_account_name")]
        [JsonProperty("business_bank_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessBankAccountName { get; set; }

        /// <summary>
        ///     企业对公银行账户号
        /// </summary>
        [XmlElement("business_bank_card_no")]
        [JsonProperty("business_bank_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessBankCardNo { get; set; }

        /// <summary>
        ///     企业对公账户开户行名称
        /// </summary>
        [XmlElement("business_bank_name")]
        [JsonProperty("business_bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessBankName { get; set; }

        /// <summary>
        ///     企业对公账户开户行支行全称
        /// </summary>
        [XmlElement("business_bank_sub")]
        [JsonProperty("business_bank_sub", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessBankSub { get; set; }
    }
}