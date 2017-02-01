using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     IsvShopDishModel Data Structure.
    /// </summary>
    [Serializable]
    public class IsvShopDishModel : AopObject
    {
        /// <summary>
        ///     菜品的描述内容
        /// </summary>
        [XmlElement("content")]
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        ///     菜品分类ID(商家自定义)
        /// </summary>
        [XmlElement("dish_type_id")]
        [JsonProperty("dish_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DishTypeId { get; set; }

        /// <summary>
        ///     商家定义菜品的分类名称
        /// </summary>
        [XmlElement("dish_type_name")]
        [JsonProperty("dish_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DishTypeName { get; set; }

        /// <summary>
        ///     菜品热度等级（0/0.5/1/1.5/2/2.5/3/3.5/4/4.5/5）该字段是对sort_col做离散化。
        /// </summary>
        [XmlElement("good_level")]
        [JsonProperty("good_level", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodLevel { get; set; }

        /// <summary>
        ///     merchant最近7天销量（份）
        /// </summary>
        [XmlElement("merchant_sold_cnt_seven_d")]
        [JsonProperty("merchant_sold_cnt_seven_d", NullValueHandling = NullValueHandling.Ignore)]
        public long MerchantSoldCntSevenD { get; set; }

        /// <summary>
        ///     merchant最近30天销量（份）
        /// </summary>
        [XmlElement("merchant_sold_cnt_thirty_d")]
        [JsonProperty("merchant_sold_cnt_thirty_d", NullValueHandling = NullValueHandling.Ignore)]
        public long MerchantSoldCntThirtyD { get; set; }

        /// <summary>
        ///     merchant最近30天购买2次及以上的支付宝用户数
        /// </summary>
        [XmlElement("merchant_sold_reusercnt_thirty_d")]
        [JsonProperty("merchant_sold_reusercnt_thirty_d", NullValueHandling = NullValueHandling.Ignore)]
        public long MerchantSoldReusercntThirtyD { get; set; }

        /// <summary>
        ///     merchant最近30天消费支付宝用户数
        /// </summary>
        [XmlElement("merchant_sold_usercnt_thirty_d")]
        [JsonProperty("merchant_sold_usercnt_thirty_d", NullValueHandling = NullValueHandling.Ignore)]
        public long MerchantSoldUsercntThirtyD { get; set; }

        /// <summary>
        ///     菜品名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///     菜品id
        /// </summary>
        [XmlElement("outer_dish_id")]
        [JsonProperty("outer_dish_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OuterDishId { get; set; }

        /// <summary>
        ///     多图路径分割
        /// </summary>
        [XmlElement("pict")]
        [JsonProperty("pict", NullValueHandling = NullValueHandling.Ignore)]
        public string Pict { get; set; }

        /// <summary>
        ///     平台类型（二维火，mike)
        /// </summary>
        [XmlElement("platform")]
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        ///     菜品价格
        /// </summary>
        [XmlElement("price")]
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string Price { get; set; }

        /// <summary>
        ///     菜品库存
        /// </summary>
        [XmlElement("quantity")]
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public long Quantity { get; set; }

        /// <summary>
        ///     外部商户ID/或者门店ID
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }

        /// <summary>
        ///     shopid最近7天销量（份）
        /// </summary>
        [XmlElement("sold_cnt_seven_d")]
        [JsonProperty("sold_cnt_seven_d", NullValueHandling = NullValueHandling.Ignore)]
        public long SoldCntSevenD { get; set; }

        /// <summary>
        ///     shopid最近30天销量（份）
        /// </summary>
        [XmlElement("sold_cnt_thirty_d")]
        [JsonProperty("sold_cnt_thirty_d", NullValueHandling = NullValueHandling.Ignore)]
        public long SoldCntThirtyD { get; set; }

        /// <summary>
        ///     shopid最近30天购买2次及以上的支付宝用户数
        /// </summary>
        [XmlElement("sold_reusercnt_thirty_d")]
        [JsonProperty("sold_reusercnt_thirty_d", NullValueHandling = NullValueHandling.Ignore)]
        public long SoldReusercntThirtyD { get; set; }

        /// <summary>
        ///     shopid最近30天消费支付宝用户数
        /// </summary>
        [XmlElement("sold_usercnt_thirty_d")]
        [JsonProperty("sold_usercnt_thirty_d", NullValueHandling = NullValueHandling.Ignore)]
        public long SoldUsercntThirtyD { get; set; }

        /// <summary>
        ///     菜品热度值（分数越高表示热度越高）
        /// </summary>
        [XmlArray("sort_col")]
        [XmlArrayItem("number")]
        public List<long> SortCol { get; set; }

        /// <summary>
        ///     菜品显示的单位（份/斤/杯）
        /// </summary>
        [XmlElement("unit")]
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }
    }
}