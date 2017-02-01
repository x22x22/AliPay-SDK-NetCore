using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayDataDataserviceCodeRecoModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceCodeRecoModel : AopObject
    {
        /// <summary>
        ///     参数配置：内容包括验证码之类，长度，是否可分割等
        /// </summary>
        [XmlElement("config")]
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public string Config { get; set; }

        /// <summary>
        ///     图片的内容(以base64位编码)，大小不超过10k
        /// </summary>
        [XmlElement("content")]
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        ///     策略，目前有2种，机器识别与人工打码（机器：machine；人工打码：manual）
        /// </summary>
        [XmlElement("strategy")]
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string Strategy { get; set; }
    }
}