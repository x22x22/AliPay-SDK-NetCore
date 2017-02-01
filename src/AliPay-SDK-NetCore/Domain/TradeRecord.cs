using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeRecord Data Structure.
    /// </summary>
    [Serializable]
    public class TradeRecord : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
		[JsonProperty("alipay_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
		[JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 资金流入流程类型,in表示收入,out表示支出
        /// </summary>
        [XmlElement("in_out_type")]
		[JsonProperty("in_out_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InOutType { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
		[JsonProperty("merchant_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单最后修改时间
        /// </summary>
        [XmlElement("modified_time")]
		[JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 对方支付宝登录号，需要隐藏
        /// </summary>
        [XmlElement("opposite_logon_id")]
		[JsonProperty("opposite_logon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeLogonId { get; set; }

        /// <summary>
        /// 对方姓名，需要隐藏
        /// </summary>
        [XmlElement("opposite_name")]
		[JsonProperty("opposite_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeName { get; set; }

        /// <summary>
        /// 对方支付宝账号
        /// </summary>
        [XmlElement("opposite_user_id")]
		[JsonProperty("opposite_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeUserId { get; set; }

        /// <summary>
        /// 订单来源，为空查询所有来源。淘宝(taobao)，支付宝(alipay)，其它(other)
        /// </summary>
        [XmlElement("order_from")]
		[JsonProperty("order_from", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderFrom { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
		[JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单的名称，描述订单的摘要信息，如交易的商品名称
        /// </summary>
        [XmlElement("order_title")]
		[JsonProperty("order_title", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
		[JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderType { get; set; }

        /// <summary>
        /// 本方支付宝登录号，需要隐藏
        /// </summary>
        [XmlElement("owner_logon_id")]
		[JsonProperty("owner_logon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerLogonId { get; set; }

        /// <summary>
        /// 本方姓名，需要隐藏
        /// </summary>
        [XmlElement("owner_name")]
		[JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 本方支付宝账号
        /// </summary>
        [XmlElement("owner_user_id")]
		[JsonProperty("owner_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("partner_id")]
		[JsonProperty("partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 订单服务费
        /// </summary>
        [XmlElement("service_charge")]
		[JsonProperty("service_charge", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceCharge { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("total_amount")]
		[JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }
    }
}
