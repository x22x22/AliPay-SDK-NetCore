using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenServicemarketCommodityShopOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketCommodityShopOfflineModel : AopObject
    {
        /// <summary>
        ///     服务商户ID
        /// </summary>
        [XmlElement("commodity_id")]
        [JsonProperty("commodity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityId { get; set; }

        /// <summary>
        ///     门店ID
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}