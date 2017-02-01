using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbOrderShopModel Data Structure.
    /// </summary>
    [Serializable]
    public class KbOrderShopModel : AopObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
		[JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [XmlElement("shop_name")]
		[JsonProperty("shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopName { get; set; }

        /// <summary>
        /// 外部门店ID
        /// </summary>
        [XmlElement("store_id")]
		[JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreId { get; set; }
    }
}
