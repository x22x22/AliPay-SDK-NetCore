using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayItemOperationContext Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayItemOperationContext : AopObject
    {
        /// <summary>
        /// 商品创建者，商户授权模式此值不需要填写。
        /// </summary>
        [XmlElement("creator")]
		[JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// 操作角色类型，授权授权模式下此值不需要填写。
        /// </summary>
        [XmlElement("op_role")]
		[JsonProperty("op_role", NullValueHandling = NullValueHandling.Ignore)]
        public string OpRole { get; set; }

        /// <summary>
        /// 商户ID，如果商户传入此值，将以此商户ID作为业务主体，商户授权模式此值不需要填写。
        /// </summary>
        [XmlElement("partner_id")]
		[JsonProperty("partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerId { get; set; }
    }
}
