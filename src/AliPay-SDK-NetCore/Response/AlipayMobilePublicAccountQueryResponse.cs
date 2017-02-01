using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobilePublicAccountQueryResponse.
    /// </summary>
    public class AlipayMobilePublicAccountQueryResponse : AopResponse
    {
        /// <summary>
        ///     结果码
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public new string Code { get; set; }

        /// <summary>
        ///     菜单唯一标识
        /// </summary>
        [XmlElement("menu_key")]
        [JsonProperty("menu_key", NullValueHandling = NullValueHandling.Ignore)]
        public string MenuKey { get; set; }

        /// <summary>
        ///     结果描述
        /// </summary>
        [XmlElement("msg")]
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public new string Msg { get; set; }

        /// <summary>
        ///     绑定账户列表
        /// </summary>
        [XmlArray("public_bind_accounts")]
        [XmlArrayItem("public_bind_account")]
        public List<PublicBindAccount> PublicBindAccounts { get; set; }

        /// <summary>
        ///     备注信息
        /// </summary>
        [XmlElement("remark")]
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }
    }
}