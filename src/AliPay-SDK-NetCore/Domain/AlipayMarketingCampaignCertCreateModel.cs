using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayMarketingCampaignCertCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCertCreateModel : AopObject
    {
        /// <summary>
        ///     凭证批次名称
        /// </summary>
        [XmlElement("cert_name")]
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        ///     拓展信息
        /// </summary>
        [XmlElement("extend_info")]
        [JsonProperty("extend_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendInfo { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        [XmlElement("memo")]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        ///     凭证有效次数，数值(最大为10000)
        /// </summary>
        [XmlElement("valid_count")]
        [JsonProperty("valid_count", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidCount { get; set; }
    }
}