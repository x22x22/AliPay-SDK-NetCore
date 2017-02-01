using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppPackagetestResponse.
    /// </summary>
    public class AlipayOpenAppPackagetestResponse : AopResponse
    {
        /// <summary>
        /// testtest
        /// </summary>
        [XmlElement("testtesttesttest")]
		[JsonProperty("testtesttesttest", NullValueHandling = NullValueHandling.Ignore)]
        public string Testtesttesttest { get; set; }
    }
}
