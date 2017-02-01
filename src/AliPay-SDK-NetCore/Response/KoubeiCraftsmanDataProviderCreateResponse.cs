using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiCraftsmanDataProviderCreateResponse.
    /// </summary>
    public class KoubeiCraftsmanDataProviderCreateResponse : AopResponse
    {
        /// <summary>
        ///     手艺人id
        /// </summary>
        [XmlElement("craftsman_id")]
        [JsonProperty("craftsman_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CraftsmanId { get; set; }
    }
}