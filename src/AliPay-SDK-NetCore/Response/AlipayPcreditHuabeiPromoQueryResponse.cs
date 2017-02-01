using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayPcreditHuabeiPromoQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPromoQueryResponse : AopResponse
    {
        /// <summary>
        ///     花呗颜值分
        /// </summary>
        [XmlElement("facescore")]
        [JsonProperty("facescore", NullValueHandling = NullValueHandling.Ignore)]
        public string Facescore { get; set; }
    }
}