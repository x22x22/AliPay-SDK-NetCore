using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenServicemarketOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderQueryModel : AopObject
    {
        /// <summary>
        ///     商户订单ID号
        /// </summary>
        [XmlElement("commodity_order_id")]
        [JsonProperty("commodity_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityOrderId { get; set; }

        /// <summary>
        ///     从第几页开始查询
        /// </summary>
        [XmlElement("start_page")]
        [JsonProperty("start_page", NullValueHandling = NullValueHandling.Ignore)]
        public string StartPage { get; set; }
    }
}