using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayFundAuthOrderFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAuthOrderFreezeModel : AopObject
    {
        /// <summary>
        ///     需要冻结的金额，单位为：元（人民币），精确到小数点后两位  取值范围：[0.01,100000000.00]
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     付款条码
        /// </summary>
        [XmlElement("auth_code")]
        [JsonProperty("auth_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCode { get; set; }

        /// <summary>
        ///     授权码类型  目前仅支持"bar_code"
        /// </summary>
        [XmlElement("auth_code_type")]
        [JsonProperty("auth_code_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCodeType { get; set; }

        /// <summary>
        ///     业务扩展参数，用于商户的特定业务信息的传递，json格式
        /// </summary>
        [XmlElement("extra_param")]
        [JsonProperty("extra_param", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraParam { get; set; }

        /// <summary>
        ///     业务订单的简单描述，如商品名称等  长度不超过100个字母或50个汉字
        /// </summary>
        [XmlElement("order_title")]
        [JsonProperty("order_title", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderTitle { get; set; }

        /// <summary>
        ///     商户授权资金订单号 ,不能包含除中文、英文、数字以外的字符，创建后不能修改，需要保证在商户端不重复。
        /// </summary>
        [XmlElement("out_order_no")]
        [JsonProperty("out_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutOrderNo { get; set; }

        /// <summary>
        ///     商户本次资金操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        [JsonProperty("out_request_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRequestNo { get; set; }

        /// <summary>
        ///     该笔订单允许的最晚付款时间，逾期将关闭该笔订单  取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m  如果为空，默认15m
        /// </summary>
        [XmlElement("pay_timeout")]
        [JsonProperty("pay_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public string PayTimeout { get; set; }

        /// <summary>
        ///     收款方支付宝账号（Email或手机号），如果收款方支付宝登录号(payee_logon_id)和用户号(payee_user_id)同时传递，则以用户号(payee_user_id)为准，如果商户有勾选花呗渠道，收款方支付宝登录号(payee_logon_id)和用户号(payee_user_id)不能同时为空。
        /// </summary>
        [XmlElement("payee_logon_id")]
        [JsonProperty("payee_logon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayeeLogonId { get; set; }

        /// <summary>
        ///     收款方的支付宝唯一用户号,以2088开头的16位纯数字组成，如果非空则会在支付时校验交易的的收款方与此是否一致，如果商户有勾选花呗渠道，收款方支付宝登录号(payee_logon_id)和用户号(payee_user_id)不能同时为空。
        /// </summary>
        [XmlElement("payee_user_id")]
        [JsonProperty("payee_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayeeUserId { get; set; }
    }
}