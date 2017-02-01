using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppBillGetResponse.
    /// </summary>
    public class AlipayEbppBillGetResponse : AopResponse
    {
        /// <summary>
        /// 支付宝的业务订单号，具有唯一性。
        /// </summary>
        [XmlElement("alipay_order_no")]
		[JsonProperty("alipay_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 账单的账期，例如201203表示2012年3月的账单。
        /// </summary>
        [XmlElement("bill_date")]
		[JsonProperty("bill_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单单据号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。
        /// </summary>
        [XmlElement("bill_key")]
		[JsonProperty("bill_key", NullValueHandling = NullValueHandling.Ignore)]
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。
        /// </summary>
        [XmlElement("charge_inst")]
		[JsonProperty("charge_inst", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构中文名称。
        /// </summary>
        [XmlElement("charge_inst_name")]
		[JsonProperty("charge_inst_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性。
        /// </summary>
        [XmlElement("merchant_order_no")]
		[JsonProperty("merchant_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 账单的状态。 INIT:等待付款，SUCCESS:成功,FAILED:失败。
        /// </summary>
        [XmlElement("order_status")]
		[JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK
        /// </summary>
        [XmlElement("order_type")]
		[JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderType { get; set; }

        /// <summary>
        /// 拥有该账单的用户姓名
        /// </summary>
        [XmlElement("owner_name")]
		[JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 缴费金额。用户支付的总金额。单位为：RMB Yuan。取值范围为[0.01，100000000.00]，精确到小数点后两位。
        /// </summary>
        [XmlElement("pay_amount")]
		[JsonProperty("pay_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PayAmount { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [XmlElement("pay_time")]
		[JsonProperty("pay_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PayTime { get; set; }

        /// <summary>
        /// 账单的服务费
        /// </summary>
        [XmlElement("service_amount")]
		[JsonProperty("service_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 子业务类型是业务类型的下一级概念，例如：WATER表示JF下面的水费，ELECTRIC表示JF下面的电费，GAS表示JF下面的燃气费。
        /// </summary>
        [XmlElement("sub_order_type")]
		[JsonProperty("sub_order_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubOrderType { get; set; }

        /// <summary>
        /// 交通违章地点，sub_order_type=TRAFFIC时有值
        /// </summary>
        [XmlElement("traffic_location")]
		[JsonProperty("traffic_location", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficLocation { get; set; }

        /// <summary>
        /// 违章行为，sub_order_type=TRAFFIC时有值。
        /// </summary>
        [XmlElement("traffic_regulations")]
		[JsonProperty("traffic_regulations", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficRegulations { get; set; }
    }
}
