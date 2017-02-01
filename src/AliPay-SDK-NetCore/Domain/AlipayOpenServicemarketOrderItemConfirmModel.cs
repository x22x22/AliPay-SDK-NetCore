using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenServicemarketOrderItemConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderItemConfirmModel : AopObject
    {
        /// <summary>
        ///     商品订单ID
        /// </summary>
        [XmlElement("commodity_order_id")]
        [JsonProperty("commodity_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityOrderId { get; set; }

        /// <summary>
        ///     商家订购服务选择的某一门店的ID
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}