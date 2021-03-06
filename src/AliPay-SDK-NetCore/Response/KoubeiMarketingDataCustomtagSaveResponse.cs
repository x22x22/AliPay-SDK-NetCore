using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiMarketingDataCustomtagSaveResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomtagSaveResponse : AopResponse
    {
        /// <summary>
        ///     自定义标签CODE
        /// </summary>
        [XmlElement("tag_code")]
        [JsonProperty("tag_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TagCode { get; set; }
    }
}