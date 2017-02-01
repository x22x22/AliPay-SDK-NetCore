using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInstcardCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInstcardCreateandpayModel : AopObject
    {
        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("bill_no")]
		[JsonProperty("bill_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BillNo { get; set; }

        /// <summary>
        /// 对交易或者商品的描述
        /// </summary>
        [XmlElement("body")]
		[JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_id")]
		[JsonProperty("buyer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerId { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
		[JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 外部下单时间。 格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_out_create")]
		[JsonProperty("gmt_out_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtOutCreate { get; set; }

        /// <summary>
        /// 支付行业：  医院：HOSPITAL  药店：STORE
        /// </summary>
        [XmlElement("industry")]
		[JsonProperty("industry", NullValueHandling = NullValueHandling.Ignore)]
        public string Industry { get; set; }

        /// <summary>
        /// 外部机构业务上是否允许这笔单订单使用医保支付  允许使用：T  不允许使用：F
        /// </summary>
        [XmlElement("is_insurance")]
		[JsonProperty("is_insurance", NullValueHandling = NullValueHandling.Ignore)]
        public string IsInsurance { get; set; }

        /// <summary>
        /// 医疗机构名称
        /// </summary>
        [XmlElement("org_name")]
		[JsonProperty("org_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgName { get; set; }

        /// <summary>
        /// 医疗机构编码(医保局分配)
        /// </summary>
        [XmlElement("org_no")]
		[JsonProperty("org_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgNo { get; set; }

        /// <summary>
        /// 商户订单号，64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
		[JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 患者证件号码
        /// </summary>
        [XmlElement("patient_card_no")]
		[JsonProperty("patient_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PatientCardNo { get; set; }

        /// <summary>
        /// 患者证件号码
        /// </summary>
        [XmlElement("patient_card_type")]
		[JsonProperty("patient_card_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PatientCardType { get; set; }

        /// <summary>
        /// 患者手机号
        /// </summary>
        [XmlElement("patient_mobile")]
		[JsonProperty("patient_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string PatientMobile { get; set; }

        /// <summary>
        /// 患者姓名  患者姓名&患者证件和医保卡信息全部匹配才能使用医保，否则认为套保嫌疑不允许医保只能自费
        /// </summary>
        [XmlElement("patient_name")]
		[JsonProperty("patient_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PatientName { get; set; }

        /// <summary>
        /// 如果需要医保支付这个字段必传。业务报文，报文中可包含多条业务数据
        /// </summary>
        [XmlElement("request_content")]
		[JsonProperty("request_content", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestContent { get; set; }

        /// <summary>
        /// 支付场景，取值：REGISTRATION(挂号)  TREATMENT(诊间)  HOSPITALIZATION(住院)  COMMON(非医院类)
        /// </summary>
        [XmlElement("scene")]
		[JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID，如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [XmlElement("seller_id")]
		[JsonProperty("seller_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerId { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("serial_no")]
		[JsonProperty("serial_no", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNo { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("subject")]
		[JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m
        /// </summary>
        [XmlElement("timeout_express")]
		[JsonProperty("timeout_express", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额，单位为分，不能小于0，取值范围[0,100000000]。
        /// </summary>
        [XmlElement("total_amount")]
		[JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }
    }
}
