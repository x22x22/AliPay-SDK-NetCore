using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayUserTestResponse.
    /// </summary>
    public class AlipayUserTestResponse : AopResponse
    {
        /// <summary>
        ///     返回值
        /// </summary>
        [XmlElement("ret1")]
        [JsonProperty("ret1", NullValueHandling = NullValueHandling.Ignore)]
        public string Ret1 { get; set; }
    }
}