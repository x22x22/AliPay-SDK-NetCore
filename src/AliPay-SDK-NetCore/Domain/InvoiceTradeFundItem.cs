using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTradeFundItem Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTradeFundItem : AopObject
    {
        /// <summary>
        /// 当前支付工具支付的金额
        /// </summary>
        [XmlElement("amount")]
		[JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝支付工具描述
        /// </summary>
        [XmlElement("payment_tool_name")]
		[JsonProperty("payment_tool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentToolName { get; set; }

        /// <summary>
        /// 支付宝支付工具类型
        /// </summary>
        [XmlElement("payment_tool_type")]
		[JsonProperty("payment_tool_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentToolType { get; set; }
    }
}
