using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTitleModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTitleModel : AopObject
    {
        /// <summary>
        /// 是否默认  可选值：  false：非默认  true：默认抬头
        /// </summary>
        [XmlElement("is_default")]
		[JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// 开户行账号
        /// </summary>
        [XmlElement("open_bank_account")]
		[JsonProperty("open_bank_account", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        [XmlElement("open_bank_name")]
		[JsonProperty("open_bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenBankName { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement("tax_register_no")]
		[JsonProperty("tax_register_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 发票抬头名称
        /// </summary>
        [XmlElement("title_name")]
		[JsonProperty("title_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleName { get; set; }

        /// <summary>
        /// 发票类型  可选值：  PERSONAL（个人抬头）  CORPORATION（公司抬头）
        /// </summary>
        [XmlElement("title_type")]
		[JsonProperty("title_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleType { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("user_address")]
		[JsonProperty("user_address", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAddress { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [XmlElement("user_email")]
		[JsonProperty("user_email", NullValueHandling = NullValueHandling.Ignore)]
        public string UserEmail { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
		[JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("user_mobile")]
		[JsonProperty("user_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string UserMobile { get; set; }
    }
}
