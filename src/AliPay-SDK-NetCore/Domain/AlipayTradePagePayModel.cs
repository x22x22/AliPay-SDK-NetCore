using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayTradePagePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePagePayModel : AopObject
    {
        /// <summary>
        ///     订单描述
        /// </summary>
        [XmlElement("body")]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        ///     禁用渠道,用户不可用指定渠道支付  注，与enable_pay_channels互斥
        /// </summary>
        [XmlElement("disable_pay_channels")]
        [JsonProperty("disable_pay_channels", NullValueHandling = NullValueHandling.Ignore)]
        public string DisablePayChannels { get; set; }

        /// <summary>
        ///     可用渠道,用户只能在指定渠道范围内支付  注，与disable_pay_channels互斥
        /// </summary>
        [XmlElement("enable_pay_channels")]
        [JsonProperty("enable_pay_channels", NullValueHandling = NullValueHandling.Ignore)]
        public string EnablePayChannels { get; set; }

        /// <summary>
        ///     业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        [JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        ///     订单包含的商品列表信息，Json格式，其它说明详见商品明细说明
        /// </summary>
        [XmlArray("goods_detail")]
        [XmlArrayItem("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        ///     商品主类型 :0-虚拟类商品,1-实物类商品  注：虚拟类商品不支持使用花呗渠道
        /// </summary>
        [XmlElement("goods_type")]
        [JsonProperty("goods_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodsType { get; set; }

        /// <summary>
        ///     商户订单号,64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [XmlElement("out_trade_no")]
        [JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        ///     公用回传参数，如果请求时传递了该参数，则返回给商户时会回传该参数。支付宝只会在同步返回（包括跳转回商户网站）和异步通知时将该参数原样返回。本参数必须进行UrlEncode之后才可以发送给支付宝。
        /// </summary>
        [XmlElement("passback_params")]
        [JsonProperty("passback_params", NullValueHandling = NullValueHandling.Ignore)]
        public string PassbackParams { get; set; }

        /// <summary>
        ///     销售产品码，与支付宝签约的产品码名称。  注：目前仅支持FAST_INSTANT_TRADE_PAY
        /// </summary>
        [XmlElement("product_code")]
        [JsonProperty("product_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        /// <summary>
        ///     优惠参数  注：仅与支付宝协商后可用
        /// </summary>
        [XmlElement("promo_params")]
        [JsonProperty("promo_params", NullValueHandling = NullValueHandling.Ignore)]
        public string PromoParams { get; set; }

        /// <summary>
        ///     描述分账信息，Json格式，详见分账参数说明
        /// </summary>
        [XmlElement("royalty_info")]
        [JsonProperty("royalty_info", NullValueHandling = NullValueHandling.Ignore)]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        ///     商户门店编号
        /// </summary>
        [XmlElement("store_id")]
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreId { get; set; }

        /// <summary>
        ///     订单标题
        /// </summary>
        [XmlElement("subject")]
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        ///     绝对超时时间，格式为yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("time_expire")]
        [JsonProperty("time_expire", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeExpire { get; set; }

        /// <summary>
        ///     该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m
        /// </summary>
        [XmlElement("timeout_express")]
        [JsonProperty("timeout_express", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeoutExpress { get; set; }

        /// <summary>
        ///     订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。
        /// </summary>
        [XmlElement("total_amount")]
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }
    }
}