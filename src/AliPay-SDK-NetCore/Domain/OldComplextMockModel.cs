using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OldComplextMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class OldComplextMockModel : AopObject
    {
        /// <summary>
        /// biz_num
        /// </summary>
        [XmlElement("biz_num")]
		[JsonProperty("biz_num", NullValueHandling = NullValueHandling.Ignore)]
        public long BizNum { get; set; }

        /// <summary>
        /// biz_type
        /// </summary>
        [XmlElement("biz_type")]
		[JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        /// 简单model
        /// </summary>
        [XmlElement("simple_mock_model")]
		[JsonProperty("simple_mock_model", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleMockModel SimpleMockModel { get; set; }
    }
}
