using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayPointOrderGetResponse.
    /// </summary>
    public class AlipayPointOrderGetResponse : AopResponse
    {
        /// <summary>
        ///     支付宝集分宝发放流水号
        /// </summary>
        [XmlElement("alipay_order_no")]
        [JsonProperty("alipay_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        ///     发放时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        ///     支付宝集分宝发放者用户ID
        /// </summary>
        [XmlElement("dispatch_user_id")]
        [JsonProperty("dispatch_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DispatchUserId { get; set; }

        /// <summary>
        ///     向用户展示集分宝发放备注
        /// </summary>
        [XmlElement("memo")]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        ///     isv提供的发放号订单号，由数字和字母组成，最大长度为32为，需要保证每笔发放的唯一性，支付宝会对该参数做唯一性控制。如果使用同样的订单号，支付宝将返回订单号已经存在的错误
        /// </summary>
        [XmlElement("merchant_order_no")]
        [JsonProperty("merchant_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        ///     集分宝发放流水状态，I表示处理中，S表示成功，F表示失败
        /// </summary>
        [XmlElement("order_status")]
        [JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        ///     发放集分宝的数量
        /// </summary>
        [XmlElement("point_count")]
        [JsonProperty("point_count", NullValueHandling = NullValueHandling.Ignore)]
        public long PointCount { get; set; }

        /// <summary>
        ///     支付宝集分宝接收者用户ID
        /// </summary>
        [XmlElement("receive_user_id")]
        [JsonProperty("receive_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiveUserId { get; set; }
    }
}