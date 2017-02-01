using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMarketingCardConsumeSyncResponse.
    /// </summary>
    public class AlipayMarketingCardConsumeSyncResponse : AopResponse
    {
        /// <summary>
        ///     外部卡号
        /// </summary>
        [XmlElement("external_card_no")]
        [JsonProperty("external_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalCardNo { get; set; }
    }
}