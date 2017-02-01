using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayMarketingCdpAdvertiseReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCdpAdvertiseReportQueryModel : AopObject
    {
        /// <summary>
        ///     广告Id，唯一标识一条广告
        /// </summary>
        [XmlElement("ad_id")]
        [JsonProperty("ad_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AdId { get; set; }
    }
}