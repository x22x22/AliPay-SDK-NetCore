using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertSubjectVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertSubjectVoucher : AopObject
    {
        /// <summary>
        /// 品牌名称(支持模糊匹配)
        /// </summary>
        [XmlElement("brand_name")]
		[JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        /// 适用城市(命中一个即可搜出)
        /// </summary>
        [XmlArray("city_ids")]
        [XmlArrayItem("string")]
        public List<string> CityIds { get; set; }

        /// <summary>
        /// 商家名称(支持模糊匹配)
        /// </summary>
        [XmlElement("merchant_name")]
		[JsonProperty("merchant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantName { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [XmlElement("voucher_id")]
		[JsonProperty("voucher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券名称(支持模糊匹配)
        /// </summary>
        [XmlElement("voucher_name")]
		[JsonProperty("voucher_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券类型  LIMIT-单品券  NO_LIMIT_DISCOUNT-全场折扣券  NO_LIMIT_CASH-全场代金券
        /// </summary>
        [XmlElement("voucher_type")]
		[JsonProperty("voucher_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherType { get; set; }
    }
}
