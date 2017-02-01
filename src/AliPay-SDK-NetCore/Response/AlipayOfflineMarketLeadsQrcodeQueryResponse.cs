using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketLeadsQrcodeQueryResponse.
    /// </summary>
    public class AlipayOfflineMarketLeadsQrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 开店二维码URL地址
        /// </summary>
        [XmlElement("qr_code")]
		[JsonProperty("qr_code", NullValueHandling = NullValueHandling.Ignore)]
        public string QrCode { get; set; }
    }
}
