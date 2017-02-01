using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePrecreateResponse.
    /// </summary>
    public class AlipayTradePrecreateResponse : AopResponse
    {
        /// <summary>
        /// 商户的订单号
        /// </summary>
        [XmlElement("out_trade_no")]
		[JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 当前预下单请求生成的二维码码串，可以用二维码生成工具根据该码串值生成对应的二维码
        /// </summary>
        [XmlElement("qr_code")]
		[JsonProperty("qr_code", NullValueHandling = NullValueHandling.Ignore)]
        public string QrCode { get; set; }
    }
}
