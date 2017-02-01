using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayPassVerifyQueryResponse.
    /// </summary>
    public class AlipayPassVerifyQueryResponse : AopResponse
    {
        /// <summary>
        ///     查询成功时返回的结果信息
        /// </summary>
        [XmlElement("biz_result")]
        [JsonProperty("biz_result", NullValueHandling = NullValueHandling.Ignore)]
        public string BizResult { get; set; }

        /// <summary>
        ///     返回码。
        /// </summary>
        [XmlElement("error_code")]
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        ///     查询是否成功的标识
        /// </summary>
        [XmlElement("success")]
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; }
    }
}