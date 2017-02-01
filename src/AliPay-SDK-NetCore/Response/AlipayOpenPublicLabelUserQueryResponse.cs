using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicLabelUserQueryResponse.
    /// </summary>
    public class AlipayOpenPublicLabelUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户标签id列表，以英文逗号分隔
        /// </summary>
        [XmlElement("label_ids")]
		[JsonProperty("label_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelIds { get; set; }
    }
}
