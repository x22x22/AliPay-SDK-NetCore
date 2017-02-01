using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarPromoVoucherVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarPromoVoucherVerifyModel : AopObject
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_no")]
		[JsonProperty("order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态 1. 待支付 4. 交易关闭 6. 待发货 53. 已评价 55. 已核销 56. 交易完成
        /// </summary>
        [XmlElement("order_status")]
		[JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 核销码
        /// </summary>
        [XmlElement("sms_code")]
		[JsonProperty("sms_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsCode { get; set; }
    }
}
