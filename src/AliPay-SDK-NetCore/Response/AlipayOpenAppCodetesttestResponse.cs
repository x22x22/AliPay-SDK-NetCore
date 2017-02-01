using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppCodetesttestResponse.
    /// </summary>
    public class AlipayOpenAppCodetesttestResponse : AopResponse
    {
        /// <summary>
        /// 测试测试测试
        /// </summary>
        [XmlElement("testtesttest")]
		[JsonProperty("testtesttest", NullValueHandling = NullValueHandling.Ignore)]
        public string Testtesttest { get; set; }
    }
}
