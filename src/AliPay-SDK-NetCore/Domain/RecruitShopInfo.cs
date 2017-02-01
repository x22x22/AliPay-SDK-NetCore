using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitShopInfo : AopObject
    {
        /// <summary>
        /// 已确认还是未确认
        /// </summary>
        [XmlElement("confirm_status")]
		[JsonProperty("confirm_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfirmStatus { get; set; }

        /// <summary>
        /// 一级和二级类目名称
        /// </summary>
        [XmlElement("shop_category")]
		[JsonProperty("shop_category", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
		[JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
		[JsonProperty("shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopName { get; set; }
    }
}
