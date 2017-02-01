using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CraftsmanSubAssessment Data Structure.
    /// </summary>
    [Serializable]
    public class CraftsmanSubAssessment : AopObject
    {
        /// <summary>
        /// 子评分
        /// </summary>
        [XmlElement("score")]
		[JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long Score { get; set; }

        /// <summary>
        /// 子评分项名
        /// </summary>
        [XmlElement("title")]
		[JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }
}
