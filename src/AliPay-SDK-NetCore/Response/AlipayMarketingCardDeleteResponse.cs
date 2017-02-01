using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMarketingCardDeleteResponse.
    /// </summary>
    public class AlipayMarketingCardDeleteResponse : AopResponse
    {
        /// <summary>
        ///     支付宝端删卡业务流水号
        /// </summary>
        [XmlElement("biz_serial_no")]
        [JsonProperty("biz_serial_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizSerialNo { get; set; }
    }
}