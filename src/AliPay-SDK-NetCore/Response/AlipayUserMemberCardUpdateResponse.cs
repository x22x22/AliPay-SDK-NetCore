using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayUserMemberCardUpdateResponse.
    /// </summary>
    public class AlipayUserMemberCardUpdateResponse : AopResponse
    {
        /// <summary>
        ///     请求失败时，不存在本参数；
        /// </summary>
        [XmlElement("card")]
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public string Card { get; set; }

        /// <summary>
        ///     返回结果码
        /// </summary>
        [XmlElement("result_code")]
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        ///     处理结果描述
        /// </summary>
        [XmlElement("result_msg")]
        [JsonProperty("result_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultMsg { get; set; }
    }
}