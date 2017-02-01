using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomsDeclareBuyerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CustomsDeclareBuyerInfo : AopObject
    {
        /// <summary>
        /// 订购人身份证号。即订购人留在商户处的身份证信息
        /// </summary>
        [XmlElement("buyer_cert_no")]
		[JsonProperty("buyer_cert_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerCertNo { get; set; }

        /// <summary>
        /// 订购人姓名。即订购人留在商户处的姓名信息
        /// </summary>
        [XmlElement("buyer_name")]
		[JsonProperty("buyer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerName { get; set; }
    }
}
