using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubMerchant Data Structure.
    /// </summary>
    [Serializable]
    public class SubMerchant : AopObject
    {
        /// <summary>
        /// 二级商户的支付宝id
        /// </summary>
        [XmlElement("merchant_id")]
		[JsonProperty("merchant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantId { get; set; }
    }
}
