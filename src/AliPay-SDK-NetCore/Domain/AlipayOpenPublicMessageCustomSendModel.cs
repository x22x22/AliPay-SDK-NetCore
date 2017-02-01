using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenPublicMessageCustomSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageCustomSendModel : AopObject
    {
        /// <summary>
        ///     图文消息，当msg_type为image-text时，必须存在相对应的值
        /// </summary>
        [XmlArray("articles")]
        [XmlArrayItem("article")]
        public List<Article> Articles { get; set; }

        /// <summary>
        ///     消息类型，text：文本消息，image-text：图文消息
        /// </summary>
        [XmlElement("msg_type")]
        [JsonProperty("msg_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MsgType { get; set; }

        /// <summary>
        ///     当msg_type为text时，必须设置相对应的值
        /// </summary>
        [XmlElement("text")]
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text Text { get; set; }

        /// <summary>
        ///     消息接收用户的userid
        /// </summary>
        [XmlElement("to_user_id")]
        [JsonProperty("to_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ToUserId { get; set; }
    }
}