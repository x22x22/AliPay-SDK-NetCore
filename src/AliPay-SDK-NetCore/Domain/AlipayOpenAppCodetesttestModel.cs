using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenAppCodetesttestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppCodetesttestModel : AopObject
    {
        /// <summary>
        ///     测试参数1
        /// </summary>
        [XmlElement("testparam")]
        [JsonProperty("testparam", NullValueHandling = NullValueHandling.Ignore)]
        public string Testparam { get; set; }

        /// <summary>
        ///     测试测试
        /// </summary>
        [XmlElement("testtestparam")]
        [JsonProperty("testtestparam", NullValueHandling = NullValueHandling.Ignore)]
        public string Testtestparam { get; set; }
    }
}