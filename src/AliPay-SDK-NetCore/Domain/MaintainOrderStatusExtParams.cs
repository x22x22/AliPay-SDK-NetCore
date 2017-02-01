using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MaintainOrderStatusExtParams Data Structure.
    /// </summary>
    [Serializable]
    public class MaintainOrderStatusExtParams : AopObject
    {
        /// <summary>
        /// 编码
        /// </summary>
        [XmlElement("logistics_code")]
		[JsonProperty("logistics_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 快递发货商
        /// </summary>
        [XmlElement("logistics_company")]
		[JsonProperty("logistics_company", NullValueHandling = NullValueHandling.Ignore)]
        public string LogisticsCompany { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("logistics_no")]
		[JsonProperty("logistics_no", NullValueHandling = NullValueHandling.Ignore)]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 4S订单状态
        /// </summary>
        [XmlElement("order_status_txt")]
		[JsonProperty("order_status_txt", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatusTxt { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("receiver_addr")]
		[JsonProperty("receiver_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverAddr { get; set; }

        /// <summary>
        /// 发货地址
        /// </summary>
        [XmlElement("sender_addr")]
		[JsonProperty("sender_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderAddr { get; set; }
    }
}
