using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarOrderRefundModel : AopObject
    {
        /// <summary>
        /// 退款交易编号
        /// </summary>
        [XmlElement("order_no")]
		[JsonProperty("order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
		[JsonProperty("refund_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundReason { get; set; }
    }
}
