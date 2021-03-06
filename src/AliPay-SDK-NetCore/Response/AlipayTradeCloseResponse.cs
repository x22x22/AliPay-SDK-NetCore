using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayTradeCloseResponse.
    /// </summary>
    public class AlipayTradeCloseResponse : AopResponse
    {
        /// <summary>
        ///     创建交易传入的商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        [JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        ///     支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}