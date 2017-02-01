using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDetail : AopObject
    {
        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [XmlElement("alipay_user_id")]
		[JsonProperty("alipay_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 是否通过实名认证
        /// </summary>
        [XmlElement("certified")]
		[JsonProperty("certified", NullValueHandling = NullValueHandling.Ignore)]
        public bool Certified { get; set; }

        /// <summary>
        /// 支付宝登录号
        /// </summary>
        [XmlElement("logon_id")]
		[JsonProperty("logon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogonId { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        [XmlElement("real_name")]
		[JsonProperty("real_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RealName { get; set; }

        /// <summary>
        /// 性别。可选值:m(男),f(女)
        /// </summary>
        [XmlElement("sex")]
		[JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 用户状态。可选:normal(正常), supervise (监管),delete(注销)
        /// </summary>
        [XmlElement("user_status")]
		[JsonProperty("user_status", NullValueHandling = NullValueHandling.Ignore)]
        public string UserStatus { get; set; }

        /// <summary>
        /// 用户类型。可选：personal（个人），company（公司）
        /// </summary>
        [XmlElement("user_type")]
		[JsonProperty("user_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserType { get; set; }
    }
}
