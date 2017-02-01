using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenServicemarketOrderItemCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderItemCancelModel : AopObject
    {
        /// <summary>
        ///     当前门店区域不支持实施
        /// </summary>
        [XmlElement("cancel_reason")]
        [JsonProperty("cancel_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelReason { get; set; }

        /// <summary>
        ///     订购服务订单ID
        /// </summary>
        [XmlElement("commodity_order_id")]
        [JsonProperty("commodity_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityOrderId { get; set; }

        /// <summary>
        ///     订购服务门店ID
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}