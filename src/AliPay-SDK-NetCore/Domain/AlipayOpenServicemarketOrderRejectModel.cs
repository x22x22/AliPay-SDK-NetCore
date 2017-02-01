using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderRejectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderRejectModel : AopObject
    {
        /// <summary>
        /// 订购服务商品订单ID
        /// </summary>
        [XmlElement("commodity_order_id")]
		[JsonProperty("commodity_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 拒绝接单原因
        /// </summary>
        [XmlElement("reject_reason")]
		[JsonProperty("reject_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string RejectReason { get; set; }
    }
}
