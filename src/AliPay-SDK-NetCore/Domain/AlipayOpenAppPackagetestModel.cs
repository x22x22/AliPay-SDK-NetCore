using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenAppPackagetestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppPackagetestModel : AopObject
    {
        /// <summary>
        ///     testtest
        /// </summary>
        [XmlElement("testparam")]
        [JsonProperty("testparam", NullValueHandling = NullValueHandling.Ignore)]
        public string Testparam { get; set; }

        /// <summary>
        ///     testtest
        /// </summary>
        [XmlElement("testtest")]
        [JsonProperty("testtest", NullValueHandling = NullValueHandling.Ignore)]
        public string Testtest { get; set; }
    }
}