using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiItemDescription Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemDescription : AopObject
    {
        /// <summary>
        ///     标题下的描述列表，列表类型，每项不得超过100个中文字符,最多10项
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("string")]
        public List<string> Details { get; set; }

        /// <summary>
        ///     描述标题，不得超过15个中文字符
        /// </summary>
        [XmlElement("title")]
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }
}