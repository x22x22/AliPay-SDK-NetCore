using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssuranceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssuranceInfo : AopObject
    {
        /// <summary>
        /// 服务保障的描述
        /// </summary>
        [XmlElement("description")]
		[JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 服务保障的标题
        /// </summary>
        [XmlElement("title")]
		[JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }
}
