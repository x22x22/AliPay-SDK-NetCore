using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketLeadsQrcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketLeadsQrcodeQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝leads ID，后续的增删改查接口都使用该ID作为主键
        /// </summary>
        [XmlElement("leads_id")]
		[JsonProperty("leads_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsId { get; set; }

        /// <summary>
        /// 操作用户的支付账号id
        /// </summary>
        [XmlElement("op_id")]
		[JsonProperty("op_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OpId { get; set; }
    }
}
