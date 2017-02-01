using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogVoiceMediaaudioUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogVoiceMediaaudioUploadModel : AopObject
    {
        /// <summary>
        /// base64编码的声音数据
        /// </summary>
        [XmlElement("data")]
		[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

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
        /// 扩展字段
        /// </summary>
        [XmlElement("extinfo_c")]
		[JsonProperty("extinfo_c", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtinfoC { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extinfo_d")]
		[JsonProperty("extinfo_d", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtinfoD { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("labeltime")]
		[JsonProperty("labeltime", NullValueHandling = NullValueHandling.Ignore)]
        public string Labeltime { get; set; }

        /// <summary>
        /// 媒体名称
        /// </summary>
        [XmlElement("vname")]
		[JsonProperty("vname", NullValueHandling = NullValueHandling.Ignore)]
        public string Vname { get; set; }

        /// <summary>
        /// 媒体类型
        /// </summary>
        [XmlElement("vtype")]
		[JsonProperty("vtype", NullValueHandling = NullValueHandling.Ignore)]
        public string Vtype { get; set; }
    }
}
