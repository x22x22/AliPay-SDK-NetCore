using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KbAdvertSubjectVoucherResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertSubjectVoucherResponse : AopObject
    {
        /// <summary>
        ///     品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        ///     适用城市ID列表
        /// </summary>
        [XmlArray("city_ids")]
        [XmlArrayItem("string")]
        public List<string> CityIds { get; set; }

        /// <summary>
        ///     背景图片
        /// </summary>
        [XmlElement("cover")]
        [JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
        public string Cover { get; set; }

        /// <summary>
        ///     日库存
        /// </summary>
        [XmlElement("daily_inventory")]
        [JsonProperty("daily_inventory", NullValueHandling = NullValueHandling.Ignore)]
        public string DailyInventory { get; set; }

        /// <summary>
        ///     结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        [JsonProperty("gmt_end", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtEnd { get; set; }

        /// <summary>
        ///     上架时间
        /// </summary>
        [XmlElement("gmt_start")]
        [JsonProperty("gmt_start", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtStart { get; set; }

        /// <summary>
        ///     logo图片
        /// </summary>
        [XmlElement("logo")]
        [JsonProperty("logo", NullValueHandling = NullValueHandling.Ignore)]
        public string Logo { get; set; }

        /// <summary>
        ///     商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        [JsonProperty("merchant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantName { get; set; }

        /// <summary>
        ///     商户ID
        /// </summary>
        [XmlElement("partner_id")]
        [JsonProperty("partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerId { get; set; }

        /// <summary>
        ///     门店ID列表
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        ///     总库存
        /// </summary>
        [XmlElement("total_inventory")]
        [JsonProperty("total_inventory", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalInventory { get; set; }

        /// <summary>
        ///     券ID
        /// </summary>
        [XmlElement("voucher_id")]
        [JsonProperty("voucher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherId { get; set; }

        /// <summary>
        ///     券名称
        /// </summary>
        [XmlElement("voucher_name")]
        [JsonProperty("voucher_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherName { get; set; }

        /// <summary>
        ///     券类型  LIMIT-单品券  NO_LIMIT_DISCOUNT-全场折扣券  NO_LIMIT_CASH-全场代金券
        /// </summary>
        [XmlElement("voucher_type")]
        [JsonProperty("voucher_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherType { get; set; }

        /// <summary>
        ///     券价值
        /// </summary>
        [XmlElement("voucher_value")]
        [JsonProperty("voucher_value", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherValue { get; set; }
    }
}