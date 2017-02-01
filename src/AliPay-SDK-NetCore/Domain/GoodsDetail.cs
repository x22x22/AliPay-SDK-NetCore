using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsDetail : AopObject
    {
        /// <summary>
        /// 支付宝定义的统一商品编号
        /// </summary>
        [XmlElement("alipay_goods_id")]
		[JsonProperty("alipay_goods_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayGoodsId { get; set; }

        /// <summary>
        /// 商品描述信息
        /// </summary>
        [XmlElement("body")]
		[JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [XmlElement("goods_category")]
		[JsonProperty("goods_category", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商品的编号
        /// </summary>
        [XmlElement("goods_id")]
		[JsonProperty("goods_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
		[JsonProperty("goods_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品单价，单位为元
        /// </summary>
        [XmlElement("price")]
		[JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
		[JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品的展示地址
        /// </summary>
        [XmlElement("show_url")]
		[JsonProperty("show_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ShowUrl { get; set; }
    }
}
