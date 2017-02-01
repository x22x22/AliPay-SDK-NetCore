using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenServicemarketOrderItemCompleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderItemCompleteModel : AopObject
    {
        /// <summary>
        ///     订购服务插件订单号
        /// </summary>
        [XmlElement("commodity_order_id")]
        [JsonProperty("commodity_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityOrderId { get; set; }

        /// <summary>
        ///     订购插件选择的某一店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}