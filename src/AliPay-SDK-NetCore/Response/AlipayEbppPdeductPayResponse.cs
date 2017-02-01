using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppPdeductPayResponse.
    /// </summary>
    public class AlipayEbppPdeductPayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [XmlElement("agreement_id")]
		[JsonProperty("agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        [XmlElement("bill_no")]
		[JsonProperty("bill_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BillNo { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("extend_field")]
		[JsonProperty("extend_field", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendField { get; set; }

        /// <summary>
        /// 商户代扣业务流水
        /// </summary>
        [XmlElement("out_order_no")]
		[JsonProperty("out_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单支付状态。  0：未知  1：成功  2：失败
        /// </summary>
        [XmlElement("result_status")]
		[JsonProperty("result_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultStatus { get; set; }
    }
}
