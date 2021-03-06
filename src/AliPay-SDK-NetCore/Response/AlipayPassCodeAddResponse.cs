using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayPassCodeAddResponse.
    /// </summary>
    public class AlipayPassCodeAddResponse : AopResponse
    {
        /// <summary>
        ///     成功时返回业务参数
        /// </summary>
        [XmlArray("biz_result")]
        [XmlArrayItem("string")]
        public List<string> BizResult { get; set; }

        /// <summary>
        ///     返回码.
        /// </summary>
        [XmlElement("error_code")]
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        ///     是否发码成功的标识。
        /// </summary>
        [XmlElement("success")]
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; }
    }
}