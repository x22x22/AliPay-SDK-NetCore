using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StdPublicBindAccount Data Structure.
    /// </summary>
    [Serializable]
    public class StdPublicBindAccount : AopObject
    {
        /// <summary>
        /// 协议号是商户会员在支付宝公众账号中的唯一标识。
        /// </summary>
        [XmlElement("agreement_id")]
		[JsonProperty("agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        [XmlElement("app_id")]
		[JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 绑定的商户会员号
        /// </summary>
        [XmlElement("bind_account_no")]
		[JsonProperty("bind_account_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BindAccountNo { get; set; }

        /// <summary>
        /// 公众账号期望支付宝用户在公众账号首页看到的关于该用户的显示信息，最长10个汉字。
        /// </summary>
        [XmlElement("display_name")]
		[JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 绑定的商户会员对应的支付宝用户号，以2088 开头的16位数字。
        /// </summary>
        [XmlElement("from_user_id")]
		[JsonProperty("from_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FromUserId { get; set; }

        /// <summary>
        /// 绑定的商户会员的真实姓名，最长10个汉字。
        /// </summary>
        [XmlElement("real_name")]
		[JsonProperty("real_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RealName { get; set; }
    }
}
