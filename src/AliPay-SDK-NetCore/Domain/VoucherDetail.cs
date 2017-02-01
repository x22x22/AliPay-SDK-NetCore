using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     VoucherDetail Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDetail : AopObject
    {
        /// <summary>
        ///     优惠券面额，它应该会等于商家出资加上其他出资方出资
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     券id
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        ///     优惠券备注信息
        /// </summary>
        [XmlElement("memo")]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        ///     商家出资（特指发起交易的商家出资金额）
        /// </summary>
        [XmlElement("merchant_contribute")]
        [JsonProperty("merchant_contribute", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantContribute { get; set; }

        /// <summary>
        ///     券名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///     其他出资方出资金额，可能是支付宝，可能是品牌商，或者其他方，也可能是他们的一起出资
        /// </summary>
        [XmlElement("other_contribute")]
        [JsonProperty("other_contribute", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherContribute { get; set; }

        /// <summary>
        ///     当前有三种类型：  ALIPAY_FIX_VOUCHER - 全场代金券  ALIPAY_DISCOUNT_VOUCHER - 折扣券  ALIPAY_ITEM_VOUCHER - 单品优惠
        ///     注：不排除将来新增其他类型的可能，商家接入时注意兼容性避免硬编码
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}