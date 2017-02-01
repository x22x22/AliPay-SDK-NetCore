using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMdataTagGetResponse.
    /// </summary>
    public class AlipayMdataTagGetResponse : AopResponse
    {
        /// <summary>
        /// 查询到的标签值, JSON字符串
        /// </summary>
        [XmlElement("tag_values")]
		[JsonProperty("tag_values", NullValueHandling = NullValueHandling.Ignore)]
        public string TagValues { get; set; }
    }
}
