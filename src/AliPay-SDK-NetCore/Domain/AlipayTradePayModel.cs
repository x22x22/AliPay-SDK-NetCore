using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayTradePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePayModel : AopObject
    {
        /// <summary>
        ///     支付宝的店铺编号
        /// </summary>
        [XmlElement("alipay_store_id")]
        [JsonProperty("alipay_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayStoreId { get; set; }

        /// <summary>
        ///     支付授权码
        /// </summary>
        [XmlElement("auth_code")]
        [JsonProperty("auth_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCode { get; set; }

        /// <summary>
        ///     预授权号，预授权转交易请求中传入
        /// </summary>
        [XmlElement("auth_no")]
        [JsonProperty("auth_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthNo { get; set; }

        /// <summary>
        ///     订单描述
        /// </summary>
        [XmlElement("body")]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        ///     参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果该值未传入，但传入了【订单总金额】和【不可打折金额】，则该值默认为【订单总金额】-【不可打折金额】
        /// </summary>
        [XmlElement("discountable_amount")]
        [JsonProperty("discountable_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountableAmount { get; set; }

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
        ///     商户的原始订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        [JsonProperty("merchant_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        ///     商户操作员编号
        /// </summary>
        [XmlElement("operator_id")]
        [JsonProperty("operator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorId { get; set; }

        /// <summary>
        ///     商户订单号,64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [XmlElement("out_trade_no")]
        [JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        ///     描述分账信息，Json格式，其它说明详见分账说明
        /// </summary>
        [XmlElement("royalty_info")]
        [JsonProperty("royalty_info", NullValueHandling = NullValueHandling.Ignore)]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        ///     支付场景  条码支付，取值：bar_code  声波支付，取值：wave_code
        /// </summary>
        [XmlElement("scene")]
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }

        /// <summary>
        ///     如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [XmlElement("seller_id")]
        [JsonProperty("seller_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerId { get; set; }

        /// <summary>
        ///     商户门店编号
        /// </summary>
        [XmlElement("store_id")]
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreId { get; set; }

        /// <summary>
        ///     二级商户信息,当前只对特殊银行机构特定场景下使用此字段
        /// </summary>
        [XmlElement("sub_merchant")]
        [JsonProperty("sub_merchant", NullValueHandling = NullValueHandling.Ignore)]
        public SubMerchant SubMerchant { get; set; }

        /// <summary>
        ///     订单标题
        /// </summary>
        [XmlElement("subject")]
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        ///     商户机具终端编号
        /// </summary>
        [XmlElement("terminal_id")]
        [JsonProperty("terminal_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalId { get; set; }

        /// <summary>
        ///     该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m
        /// </summary>
        [XmlElement("timeout_express")]
        [JsonProperty("timeout_express", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeoutExpress { get; set; }

        /// <summary>
        ///     订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入【可打折金额】和【不可打折金额】，该参数可以不用传入；
        ///     如果同时传入了【可打折金额】，【不可打折金额】，【订单总金额】三者，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】
        /// </summary>
        [XmlElement("total_amount")]
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        ///     不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。如果该值未传入，但传入了【订单总金额】和【可打折金额】，则该值默认为【订单总金额】-【可打折金额】
        /// </summary>
        [XmlElement("undiscountable_amount")]
        [JsonProperty("undiscountable_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string UndiscountableAmount { get; set; }
    }
}