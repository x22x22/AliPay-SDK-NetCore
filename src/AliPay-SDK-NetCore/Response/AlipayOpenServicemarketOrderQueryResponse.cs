using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOpenServicemarketOrderQueryResponse.
    /// </summary>
    public class AlipayOpenServicemarketOrderQueryResponse : AopResponse
    {
        /// <summary>
        ///     订购服务商品ID
        /// </summary>
        [XmlElement("commodity_id")]
        [JsonProperty("commodity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityId { get; set; }

        /// <summary>
        ///     当前查询页（本接口支持最多查询100条记录）
        /// </summary>
        [XmlElement("current_page")]
        [JsonProperty("current_page", NullValueHandling = NullValueHandling.Ignore)]
        public long CurrentPage { get; set; }

        /// <summary>
        ///     订单明细列表
        /// </summary>
        [XmlArray("order_items")]
        [XmlArrayItem("order_item")]
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        ///     MERCHANT_ORDED（待服务商接单）
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        ///     总记录数
        /// </summary>
        [XmlElement("total_size")]
        [JsonProperty("total_size", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalSize { get; set; }
    }
}