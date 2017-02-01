using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEcoMycarDataExternalSendResponse.
    /// </summary>
    public class AlipayEcoMycarDataExternalSendResponse : AopResponse
    {
        /// <summary>
        ///     20
        /// </summary>
        [XmlElement("external_system_name")]
        [JsonProperty("external_system_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalSystemName { get; set; }

        /// <summary>
        ///     outter_response
        /// </summary>
        [XmlElement("process_result")]
        [JsonProperty("process_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessResult { get; set; }
    }
}