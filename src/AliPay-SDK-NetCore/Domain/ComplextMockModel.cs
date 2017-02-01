using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComplextMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class ComplextMockModel : AopObject
    {
        /// <summary>
        /// biz_model
        /// </summary>
        [XmlElement("biz_model")]
		[JsonProperty("biz_model", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleMockModel BizModel { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("biz_num")]
		[JsonProperty("biz_num", NullValueHandling = NullValueHandling.Ignore)]
        public long BizNum { get; set; }

        /// <summary>
        /// 208xxx
        /// </summary>
        [XmlElement("biz_type")]
		[JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }
    }
}
