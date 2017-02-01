using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEbppPdeductSignAddResponse.
    /// </summary>
    public class AlipayEbppPdeductSignAddResponse : AopResponse
    {
        /// <summary>
        ///     支付宝代扣协议ID
        /// </summary>
        [XmlElement("agreement_id")]
        [JsonProperty("agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementId { get; set; }

        /// <summary>
        ///     支付宝协议状态。签约成功则返回success
        /// </summary>
        [XmlElement("agreement_status")]
        [JsonProperty("agreement_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementStatus { get; set; }

        /// <summary>
        ///     扩展参数，可为空
        /// </summary>
        [XmlElement("extend_field")]
        [JsonProperty("extend_field", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendField { get; set; }

        /// <summary>
        ///     通知方式设置。
        /// </summary>
        [XmlElement("notify_config")]
        [JsonProperty("notify_config", NullValueHandling = NullValueHandling.Ignore)]
        public string NotifyConfig { get; set; }

        /// <summary>
        ///     商户生成的代扣协议ID
        /// </summary>
        [XmlElement("out_agreement_id")]
        [JsonProperty("out_agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OutAgreementId { get; set; }

        /// <summary>
        ///     支付方式设置
        /// </summary>
        [XmlArray("pay_config")]
        [XmlArrayItem("string")]
        public List<string> PayConfig { get; set; }

        /// <summary>
        ///     签约时间
        /// </summary>
        [XmlElement("sign_date")]
        [JsonProperty("sign_date", NullValueHandling = NullValueHandling.Ignore)]
        public string SignDate { get; set; }
    }
}