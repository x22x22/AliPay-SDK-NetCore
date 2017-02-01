using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiItemExtitemQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemQueryResponse : AopResponse
    {
        /// <summary>
        ///     商品信息
        /// </summary>
        [XmlElement("extitem")]
        [JsonProperty("extitem", NullValueHandling = NullValueHandling.Ignore)]
        public ExtItem Extitem { get; set; }
    }
}