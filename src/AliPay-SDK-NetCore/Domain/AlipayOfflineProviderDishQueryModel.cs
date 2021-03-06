using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineProviderDishQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderDishQueryModel : AopObject
    {
        /// <summary>
        ///     商家分类名称，商家自定义的菜品分类的名称，非必填
        /// </summary>
        [XmlElement("dish_type_name")]
        [JsonProperty("dish_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DishTypeName { get; set; }

        /// <summary>
        ///     order_by：1，菜品热度升序查询，order_by：2，菜品热度降序查询。非必填，为空时默认为2
        /// </summary>
        [XmlElement("order_by")]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderBy { get; set; }

        /// <summary>
        ///     菜品ID，当需要查询指定菜品的时候传递，非必填
        /// </summary>
        [XmlElement("outer_dish_id")]
        [JsonProperty("outer_dish_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OuterDishId { get; set; }

        /// <summary>
        ///     需要查询的第几页信息。非必填。默认为1
        /// </summary>
        [XmlElement("page")]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public long Page { get; set; }

        /// <summary>
        ///     分页查询每页的条数，默认为20条，非必填
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long PageSize { get; set; }

        /// <summary>
        ///     外部商户ID（必填）需要查询的商家名下的门店/子商户的ID
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}