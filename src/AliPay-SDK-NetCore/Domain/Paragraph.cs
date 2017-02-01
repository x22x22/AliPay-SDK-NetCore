using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     Paragraph Data Structure.
    /// </summary>
    [Serializable]
    public class Paragraph : AopObject
    {
        /// <summary>
        ///     图片列表
        /// </summary>
        [XmlArray("pictures")]
        [XmlArrayItem("picture")]
        public List<Picture> Pictures { get; set; }

        /// <summary>
        ///     正文介绍
        /// </summary>
        [XmlElement("text")]
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
    }
}