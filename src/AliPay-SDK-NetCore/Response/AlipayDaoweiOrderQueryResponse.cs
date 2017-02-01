using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDaoweiOrderQueryResponse.
    /// </summary>
    public class AlipayDaoweiOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单创建时间，用户点击预约下单操作的时间，格式为yyyy-MM-dd HH:mm:ss（到秒）下单时间因早于服务预约时间
        /// </summary>
        [XmlElement("gmt_create")]
		[JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间，格式为yyyy-MM-dd HH:mm:ss(到秒，创建订单时，修改时间与创建时间相同)
        /// </summary>
        [XmlElement("gmt_modified")]
		[JsonProperty("gmt_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 订单最后支付时间，格式：yyyy-MM-dd HH:mm:ss（到秒）
        /// </summary>
        [XmlElement("gmt_payment")]
		[JsonProperty("gmt_payment", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 订单最后退款时间，格式：yyyy-MM-dd HH:mm:ss，订单产生退款时的最后操作时间
        /// </summary>
        [XmlElement("gmt_refund")]
		[JsonProperty("gmt_refund", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 物流信息，用户下订单填写的物流信息，包括服务地址的经纬度、联系人和手机号码以及扩展信息
        /// </summary>
        [XmlElement("logistics_info")]
		[JsonProperty("logistics_info", NullValueHandling = NullValueHandling.Ignore)]
        public OrderLogisticsInfo LogisticsInfo { get; set; }

        /// <summary>
        /// 备注信息，消费者下单时填写的订单备注信息，长度不超过2000字符
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 到位业务订单号，全局唯一，由32位数字组成，用户在到位下单时系统生成并消息同步给商家，商户只能查自己同步到的订单号
        /// </summary>
        [XmlElement("order_no")]
		[JsonProperty("order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 到位订单状态枚举值，用于描述订单的业务状态，入参时手动设置（枚举：WAIT_CONFIRM/WAIT_SERVICE/CONFIRMED_SERVICE/SERVICE_COMPLETE/ORDER_FINISHED/ORDER_CLOSE）
        /// </summary>
        [XmlElement("order_status")]
		[JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单已付款金额，不小于0的数，单位为元，单个订单金额小于10w。
        /// </summary>
        [XmlElement("payment_amount")]
		[JsonProperty("payment_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 订单实际金额，不小于0的数，单位为元，单个订单金额小于10w。
        /// </summary>
        [XmlElement("real_amount")]
		[JsonProperty("real_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RealAmount { get; set; }

        /// <summary>
        /// 订单已退款的金额，单位为元，若订单存在退款，则金额大于0，且小于等于实际支付的金额
        /// </summary>
        [XmlElement("refund_amount")]
		[JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 服务订单列表：包含订单所对应的服务，服务可能包含不止一个，每个服务对应自身的单价、总价、退款价格等
        /// </summary>
        [XmlArray("service_order_list")]
        [XmlArrayItem("service_order_info")]
        public List<ServiceOrderInfo> ServiceOrderList { get; set; }

        /// <summary>
        /// 订单总的金额，不小于0的数，单位为元，单个订单金额小于10w
        /// </summary>
        [XmlElement("total_amount")]
		[JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }
    }
}
