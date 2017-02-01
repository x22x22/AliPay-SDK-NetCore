using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     CraftsmanShopRelationOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class CraftsmanShopRelationOpenModel : AopObject
    {
        /// <summary>
        ///     推荐权重。整数。小于等于0表示不在口碑店铺页展示 大于0表示在口碑店铺页展示， 值越大，排序越靠前。
        /// </summary>
        [XmlElement("recommend_weight")]
        [JsonProperty("recommend_weight", NullValueHandling = NullValueHandling.Ignore)]
        public long RecommendWeight { get; set; }

        /// <summary>
        ///     口碑门店ID，可通过门店摘要信息批量查询接口 alipay.offline.market.shop.summary.batchquery获取。
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}