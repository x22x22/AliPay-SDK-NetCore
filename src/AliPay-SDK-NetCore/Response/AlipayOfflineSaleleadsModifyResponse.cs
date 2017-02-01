using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOfflineSaleleadsModifyResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsModifyResponse : AopResponse
    {
        /// <summary>
        ///     被修改leadsId
        /// </summary>
        [XmlElement("leads_id")]
        [JsonProperty("leads_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsId { get; set; }
    }
}