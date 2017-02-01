using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InvoiceTradeGoodsItem Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTradeGoodsItem : AopObject
    {
        /// <summary>
        ///     商品类目
        /// </summary>
        [XmlElement("category")]
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        ///     商品名称
        /// </summary>
        [XmlElement("goods_name")]
        [JsonProperty("goods_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodsName { get; set; }

        /// <summary>
        ///     商户设置的商品编号
        /// </summary>
        [XmlElement("goods_no")]
        [JsonProperty("goods_no", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodsNo { get; set; }

        /// <summary>
        ///     商品项支付金额
        /// </summary>
        [XmlElement("goods_sum_amount")]
        [JsonProperty("goods_sum_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodsSumAmount { get; set; }

        /// <summary>
        ///     商品单价，单位元，精确到小数点后两位
        /// </summary>
        [XmlElement("price")]
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string Price { get; set; }

        /// <summary>
        ///     购买数量
        /// </summary>
        [XmlElement("quantity")]
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantity { get; set; }

        /// <summary>
        ///     购买商品规格型号描述
        /// </summary>
        [XmlElement("specification")]
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        ///     购买商品单位描述
        /// </summary>
        [XmlElement("unit")]
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }
    }
}