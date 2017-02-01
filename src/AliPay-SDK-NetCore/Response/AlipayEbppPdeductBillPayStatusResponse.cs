using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEbppPdeductBillPayStatusResponse.
    /// </summary>
    public class AlipayEbppPdeductBillPayStatusResponse : AopResponse
    {
        /// <summary>
        ///     支付宝协议流水
        /// </summary>
        [XmlElement("agreement_id")]
        [JsonProperty("agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementId { get; set; }

        /// <summary>
        ///     支付宝流billNo
        /// </summary>
        [XmlElement("order_no")]
        [JsonProperty("order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNo { get; set; }

        /// <summary>
        ///     外部订单流水
        /// </summary>
        [XmlElement("out_order_no")]
        [JsonProperty("out_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutOrderNo { get; set; }

        /// <summary>
        ///     支付宝订单支付状态。  0：未知状态。  1：支付成功。  2：支付失败。
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}