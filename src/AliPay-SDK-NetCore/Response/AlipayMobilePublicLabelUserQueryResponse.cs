using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobilePublicLabelUserQueryResponse.
    /// </summary>
    public class AlipayMobilePublicLabelUserQueryResponse : AopResponse
    {
        /// <summary>
        ///     结果码
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public new string Code { get; set; }

        /// <summary>
        ///     标签编号，英文逗号分隔。
        /// </summary>
        [XmlElement("label_ids")]
        [JsonProperty("label_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelIds { get; set; }

        /// <summary>
        ///     结果信息
        /// </summary>
        [XmlElement("msg")]
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public new string Msg { get; set; }
    }
}