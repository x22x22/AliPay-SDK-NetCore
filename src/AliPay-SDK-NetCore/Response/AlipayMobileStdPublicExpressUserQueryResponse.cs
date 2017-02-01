using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicExpressUserQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicExpressUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
		[JsonProperty("cert_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，身份证
        /// </summary>
        [XmlElement("cert_type")]
		[JsonProperty("cert_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CertType { get; set; }
    }
}
