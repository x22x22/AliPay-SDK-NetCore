using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEcoMycarPromoTicketPushResponse.
    /// </summary>
    public class AlipayEcoMycarPromoTicketPushResponse : AopResponse
    {
        /// <summary>
        ///     处理结果返回码
        /// </summary>
        [XmlElement("sp_apply_no")]
        [JsonProperty("sp_apply_no", NullValueHandling = NullValueHandling.Ignore)]
        public string SpApplyNo { get; set; }
    }
}