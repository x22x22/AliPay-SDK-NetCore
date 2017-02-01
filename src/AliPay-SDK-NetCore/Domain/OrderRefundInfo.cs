using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderRefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderRefundInfo : AopObject
    {
        /// <summary>
        /// 服务订单的退款金额，单位为元
        /// </summary>
        [XmlElement("refund_amount")]
		[JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 服务订单号，当商家退款时，可能包含多个服务订单
        /// </summary>
        [XmlElement("service_order_no")]
		[JsonProperty("service_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceOrderNo { get; set; }
    }
}
