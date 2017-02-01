using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ContactPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContactPersonInfo : AopObject
    {
        /// <summary>
        ///     联系人邮箱地址，入驻申请审核结果会发送至该邮箱
        /// </summary>
        [XmlElement("contact_email")]
        [JsonProperty("contact_email", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactEmail { get; set; }

        /// <summary>
        ///     联系人手机号，入驻申请结果会通过短信的形式发送至该手机号码
        /// </summary>
        [XmlElement("contact_mobile")]
        [JsonProperty("contact_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactMobile { get; set; }

        /// <summary>
        ///     企业联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        [JsonProperty("contact_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        /// <summary>
        ///     联系人类型，MERCHANT_CONTACT (普通联系人),DATA_RETURN (数据反馈联系人),PROT_CONTACT(客服人员),OBJECTION_HANDLE
        ///     (异议处理联系人)，如不填默认为MERCHANT_CONTACT
        /// </summary>
        [XmlElement("contact_type")]
        [JsonProperty("contact_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactType { get; set; }
    }
}