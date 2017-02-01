using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     OrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class OrderItem : AopObject
    {
        /// <summary>
        ///     店铺所在具体位置
        /// </summary>
        [XmlElement("address")]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        ///     品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        ///     店铺品类
        /// </summary>
        [XmlElement("category")]
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        ///     店铺所在的市
        /// </summary>
        [XmlElement("city")]
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        ///     订购的服务商品ID
        /// </summary>
        [XmlElement("commodity_id")]
        [JsonProperty("commodity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityId { get; set; }

        /// <summary>
        ///     订单联系人
        /// </summary>
        [XmlElement("contacts")]
        [JsonProperty("contacts", NullValueHandling = NullValueHandling.Ignore)]
        public string Contacts { get; set; }

        /// <summary>
        ///     门店创建人(已删除)
        /// </summary>
        [XmlElement("creator")]
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        ///     过期时间
        /// </summary>
        [XmlElement("expire_date")]
        [JsonProperty("expire_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireDate { get; set; }

        /// <summary>
        ///     上架时间
        /// </summary>
        [XmlElement("online_time")]
        [JsonProperty("online_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OnlineTime { get; set; }

        /// <summary>
        ///     TO_DO-未实施,DOING-实施中,TO_CONFIRM-待商户确认,DONE-已完成,MERCHANT_REJECTED-商户已回绝,MERCHANT_CANCELLED-商户已取消,ISV_REJECTED-服务商已回绝,ISV_CANCELLED-服务商已取消
        /// </summary>
        [XmlElement("order_status")]
        [JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        ///     订单所属人联系方式（手机或者座机）
        /// </summary>
        [XmlElement("phone_no")]
        [JsonProperty("phone_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneNo { get; set; }

        /// <summary>
        ///     店铺所在的省份
        /// </summary>
        [XmlElement("province")]
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        ///     店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }

        /// <summary>
        ///     店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        [JsonProperty("shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopName { get; set; }

        /// <summary>
        ///     店铺状态（ONLINE--已上架 OFFLINE--未上架 AVAILABLE--已开通 INIT--未开通 EXPIRED--已过期）
        /// </summary>
        [XmlElement("shop_status")]
        [JsonProperty("shop_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopStatus { get; set; }

        /// <summary>
        ///     待服务商接单
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}