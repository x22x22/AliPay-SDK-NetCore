using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InvoiceItemContent Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceItemContent : AopObject
    {
        /// <summary>
        ///     价税合计。(等于sumPrice和tax之和)
        /// </summary>
        [XmlElement("item_amount")]
        [JsonProperty("item_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemAmount { get; set; }

        /// <summary>
        ///     发票项目名称（或商品名称）
        /// </summary>
        [XmlElement("item_name")]
        [JsonProperty("item_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemName { get; set; }

        /// <summary>
        ///     商品编号
        /// </summary>
        [XmlElement("item_no")]
        [JsonProperty("item_no", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemNo { get; set; }

        /// <summary>
        ///     单价，格式：100.00。新版电子发票，折扣行此参数不能传，非折扣行必传
        /// </summary>
        [XmlElement("item_price")]
        [JsonProperty("item_price", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemPrice { get; set; }

        /// <summary>
        ///     数量。新版电子发票，折扣行此参数不能传，非折扣行必传
        /// </summary>
        [XmlElement("item_quantity")]
        [JsonProperty("item_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public long ItemQuantity { get; set; }

        /// <summary>
        ///     单项总价，格式：100.00
        /// </summary>
        [XmlElement("item_sum_price")]
        [JsonProperty("item_sum_price", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemSumPrice { get; set; }

        /// <summary>
        ///     税额
        /// </summary>
        [XmlElement("item_tax_price")]
        [JsonProperty("item_tax_price", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemTaxPrice { get; set; }

        /// <summary>
        ///     税率
        /// </summary>
        [XmlElement("item_tax_rate")]
        [JsonProperty("item_tax_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemTaxRate { get; set; }

        /// <summary>
        ///     台
        /// </summary>
        [XmlElement("item_unit")]
        [JsonProperty("item_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemUnit { get; set; }

        /// <summary>
        ///     发票行性质。0表示正常行，1表示折扣行，2表示被折扣行。比如充电器单价100元，折扣10元，则明细为2行，充电器行性质为2，折扣行性质为1。如果充电器没有折扣，则值应为0
        /// </summary>
        [XmlElement("row_type")]
        [JsonProperty("row_type", NullValueHandling = NullValueHandling.Ignore)]
        public long RowType { get; set; }
    }
}