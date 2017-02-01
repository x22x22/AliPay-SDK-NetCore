using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAuthOrderFreezeResponse.
    /// </summary>
    public class AlipayFundAuthOrderFreezeResponse : AopResponse
    {
        /// <summary>
        /// 本次操作冻结的金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [XmlElement("amount")]
		[JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝的资金授权订单号
        /// </summary>
        [XmlElement("auth_no")]
		[JsonProperty("auth_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthNo { get; set; }

        /// <summary>
        /// 资金授权成功时间  格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("gmt_trans")]
		[JsonProperty("gmt_trans", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtTrans { get; set; }

        /// <summary>
        /// 支付宝的资金操作流水号
        /// </summary>
        [XmlElement("operation_id")]
		[JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户的授权资金订单号
        /// </summary>
        [XmlElement("out_order_no")]
		[JsonProperty("out_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户本次资金操作的请求流水号
        /// </summary>
        [XmlElement("out_request_no")]
		[JsonProperty("out_request_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 收款方支付宝账号（Email或手机号）
        /// </summary>
        [XmlElement("payer_logon_id")]
		[JsonProperty("payer_logon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerLogonId { get; set; }

        /// <summary>
        /// 付款方支付宝用户号
        /// </summary>
        [XmlElement("payer_user_id")]
		[JsonProperty("payer_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 资金预授权明细的状态  目前支持：  INIT：初始  SUCCESS: 成功  CLOSED：关闭
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}
