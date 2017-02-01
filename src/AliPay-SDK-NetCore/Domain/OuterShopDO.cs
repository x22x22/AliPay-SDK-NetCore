using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OuterShopDO Data Structure.
    /// </summary>
    [Serializable]
    public class OuterShopDO : AopObject
    {
        /// <summary>
        /// 合作商户ID
        /// </summary>
        [XmlElement("outer_id")]
		[JsonProperty("outer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OuterId { get; set; }

        /// <summary>
        /// 支付宝店铺ID
        /// </summary>
        [XmlElement("shop_id")]
		[JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }

        /// <summary>
        /// 合作商户类型 （mike、_2dFire）  iSV自己定义自己的类型，推荐使用自己的域名
        /// </summary>
        [XmlElement("type")]
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
