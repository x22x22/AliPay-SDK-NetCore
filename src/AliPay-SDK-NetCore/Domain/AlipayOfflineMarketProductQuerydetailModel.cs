using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketProductQuerydetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketProductQuerydetailModel : AopObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
		[JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        /// <summary>
        /// 操作人角色，默认商户操作:MERCHANT；服务商操作：PROVIDER。支付宝内部使用，外部商户不需填写此字段。
        /// </summary>
        [XmlElement("op_role")]
		[JsonProperty("op_role", NullValueHandling = NullValueHandling.Ignore)]
        public string OpRole { get; set; }

        /// <summary>
        /// 门店ID。支付宝内部使用，外部商户不需填写此字段。
        /// </summary>
        [XmlElement("shop_id")]
		[JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}
