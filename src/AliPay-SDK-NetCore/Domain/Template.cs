using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Template Data Structure.
    /// </summary>
    [Serializable]
    public class Template : AopObject
    {
        /// <summary>
        /// 消息模板上下文，即模板中定义的参数及参数值
        /// </summary>
        [XmlElement("context")]
		[JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public Context Context { get; set; }

        /// <summary>
        /// 消息模板ID
        /// </summary>
        [XmlElement("template_id")]
		[JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }
    }
}
