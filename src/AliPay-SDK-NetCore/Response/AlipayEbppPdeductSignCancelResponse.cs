using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppPdeductSignCancelResponse.
    /// </summary>
    public class AlipayEbppPdeductSignCancelResponse : AopResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [XmlElement("agreement_id")]
		[JsonProperty("agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝协议状态。解约成功则返回success
        /// </summary>
        [XmlElement("agreement_status")]
		[JsonProperty("agreement_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 商户代扣协议ID
        /// </summary>
        [XmlElement("out_agreement_id")]
		[JsonProperty("out_agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OutAgreementId { get; set; }
    }
}
