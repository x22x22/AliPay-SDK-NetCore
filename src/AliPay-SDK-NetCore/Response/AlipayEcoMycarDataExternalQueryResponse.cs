using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEcoMycarDataExternalQueryResponse.
    /// </summary>
    public class AlipayEcoMycarDataExternalQueryResponse : AopResponse
    {
        /// <summary>
        ///     30
        /// </summary>
        [XmlElement("external_system_name")]
        [JsonProperty("external_system_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalSystemName { get; set; }

        /// <summary>
        ///     outter_response
        /// </summary>
        [XmlElement("query_result")]
        [JsonProperty("query_result", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryResult { get; set; }
    }
}