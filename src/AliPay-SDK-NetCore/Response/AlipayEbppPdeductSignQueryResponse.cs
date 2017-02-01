using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppPdeductSignQueryResponse.
    /// </summary>
    public class AlipayEbppPdeductSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 协议ID
        /// </summary>
        [XmlElement("agreement_id")]
		[JsonProperty("agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [XmlElement("bill_key")]
		[JsonProperty("bill_key", NullValueHandling = NullValueHandling.Ignore)]
        public string BillKey { get; set; }

        /// <summary>
        /// 出账机构
        /// </summary>
        [XmlElement("charge_inst")]
		[JsonProperty("charge_inst", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 朗新协议ID
        /// </summary>
        [XmlElement("out_agreement_id")]
		[JsonProperty("out_agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_date")]
		[JsonProperty("sign_date", NullValueHandling = NullValueHandling.Ignore)]
        public string SignDate { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
		[JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}
