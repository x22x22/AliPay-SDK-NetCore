using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogVoiceMediaaudioUploadResponse.
    /// </summary>
    public class AlipayMsaasMediarecogVoiceMediaaudioUploadResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extinfo_a")]
		[JsonProperty("extinfo_a", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtinfoA { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extinfo_b")]
		[JsonProperty("extinfo_b", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtinfoB { get; set; }

        /// <summary>
        /// 结果memo
        /// </summary>
        [XmlElement("result_memo")]
		[JsonProperty("result_memo", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultMemo { get; set; }

        /// <summary>
        /// 结果状态
        /// </summary>
        [XmlElement("result_status")]
		[JsonProperty("result_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultStatus { get; set; }
    }
}
