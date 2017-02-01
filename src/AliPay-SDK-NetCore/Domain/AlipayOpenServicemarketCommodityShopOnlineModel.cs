using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenServicemarketCommodityShopOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketCommodityShopOnlineModel : AopObject
    {
        /// <summary>
        ///     服务插件ID
        /// </summary>
        [XmlElement("commodity_id")]
        [JsonProperty("commodity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityId { get; set; }

        /// <summary>
        ///     店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}