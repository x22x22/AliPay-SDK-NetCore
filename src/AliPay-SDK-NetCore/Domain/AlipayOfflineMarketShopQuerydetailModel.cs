using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopQuerydetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketShopQuerydetailModel : AopObject
    {
        /// <summary>
        /// 服务商及商户调用情况下务必传递。操作人角色，默认商户操作:MERCHANT；服务商操作：PROVIDER；ISV: 不需要填写
        /// </summary>
        [XmlElement("op_role")]
		[JsonProperty("op_role", NullValueHandling = NullValueHandling.Ignore)]
        public string OpRole { get; set; }

        /// <summary>
        /// 支付宝门店ID
        /// </summary>
        [XmlElement("shop_id")]
		[JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}
