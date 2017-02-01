using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayBossProdArrangementOfflineQueryResponse.
    /// </summary>
    public class AlipayBossProdArrangementOfflineQueryResponse : AopResponse
    {
        /// <summary>
        ///     商户的签约状态
        /// </summary>
        [XmlElement("sign_status")]
        [JsonProperty("sign_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SignStatus { get; set; }
    }
}