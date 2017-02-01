using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenPublicMessageSingleSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageSingleSendModel : AopObject
    {
        /// <summary>
        ///     消息模板相关参数，其中包括templateId模板ID和context模板上下文
        /// </summary>
        [XmlElement("template")]
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public Template Template { get; set; }

        /// <summary>
        ///     消息接收用户的userid
        /// </summary>
        [XmlElement("to_user_id")]
        [JsonProperty("to_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ToUserId { get; set; }
    }
}