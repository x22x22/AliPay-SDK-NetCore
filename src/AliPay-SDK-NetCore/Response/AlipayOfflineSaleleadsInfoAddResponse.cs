using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOfflineSaleleadsInfoAddResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsInfoAddResponse : AopResponse
    {
        /// <summary>
        ///     添加leads成功后返回
        /// </summary>
        [XmlElement("leads_id")]
        [JsonProperty("leads_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsId { get; set; }

        /// <summary>
        ///     说明
        /// </summary>
        [XmlElement("message")]
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }
}