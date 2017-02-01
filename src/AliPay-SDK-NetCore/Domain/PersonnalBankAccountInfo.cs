using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PersonnalBankAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PersonnalBankAccountInfo : AopObject
    {
        /// <summary>
        /// 填入的银行账号对应的银行预留手机号
        /// </summary>
        [XmlElement("personal_bank_account_mobile")]
		[JsonProperty("personal_bank_account_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonalBankAccountMobile { get; set; }

        /// <summary>
        /// 个人或个体工商户的银行账号，在商户确认环节用来作为认证的一种材料。
        /// </summary>
        [XmlElement("personal_bank_card_no")]
		[JsonProperty("personal_bank_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonalBankCardNo { get; set; }

        /// <summary>
        /// 填入的银行账号对应的持卡人的身份证号码
        /// </summary>
        [XmlElement("personal_bank_holder_certno")]
		[JsonProperty("personal_bank_holder_certno", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonalBankHolderCertno { get; set; }

        /// <summary>
        /// 填入的银行账号对应的持卡人名称
        /// </summary>
        [XmlElement("personal_bank_holder_name")]
		[JsonProperty("personal_bank_holder_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonalBankHolderName { get; set; }
    }
}
