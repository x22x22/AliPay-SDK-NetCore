using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiItemStateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemStateModel : AopObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为《koubei.member.data.oauth.query》中的auth_code，有效期24小时；
        /// </summary>
        [XmlElement("auth_code")]
		[JsonProperty("auth_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCode { get; set; }

        /// <summary>
        /// 口碑体系内部商品的唯一标识，后续的增删改查接口都使用该ID作为主键
        /// </summary>
        [XmlElement("item_id")]
		[JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 操作上下文 ISV角色操作时必填；其他角色不需填写
        /// </summary>
        [XmlElement("operation_context")]
		[JsonProperty("operation_context", NullValueHandling = NullValueHandling.Ignore)]
        public KoubeiOperationContext OperationContext { get; set; }

        /// <summary>
        /// 支持英文字母和数字，由开发者自行定义（不允许重复），在商品notify消息中也会带有该参数，以此标明本次notify消息是对哪个请求的回应
        /// </summary>
        [XmlElement("request_id")]
		[JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 控制商品的售卖状态，RESUME：恢复售卖；PAUSE：暂停售卖,C端不可见;
        /// </summary>
        [XmlElement("state_type")]
		[JsonProperty("state_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StateType { get; set; }
    }
}
