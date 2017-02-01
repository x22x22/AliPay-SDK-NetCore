using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTransferThirdpartyBillCreateResponse.
    /// </summary>
    public class AlipayTransferThirdpartyBillCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝转账交易号
        /// </summary>
        [XmlElement("order_id")]
		[JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 交易类型，固定为transfer
        /// </summary>
        [XmlElement("order_type")]
		[JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部应用创建的交易ID
        /// </summary>
        [XmlElement("payment_id")]
		[JsonProperty("payment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentId { get; set; }
    }
}
