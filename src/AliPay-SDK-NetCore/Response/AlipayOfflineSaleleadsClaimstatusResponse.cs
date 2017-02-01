using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOfflineSaleleadsClaimstatusResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsClaimstatusResponse : AopResponse
    {
        /// <summary>
        ///     success(成功);fail(失败)
        /// </summary>
        [XmlElement("res_msg")]
        [JsonProperty("res_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ResMsg { get; set; }
    }
}