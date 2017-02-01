using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayPointOrderAddResponse.
    /// </summary>
    public class AlipayPointOrderAddResponse : AopResponse
    {
        /// <summary>
        ///     支付宝集分宝发放流水号
        /// </summary>
        [XmlElement("alipay_order_no")]
        [JsonProperty("alipay_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        ///     此参数已废弃。
        /// </summary>
        [XmlElement("result_code")]
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public bool ResultCode { get; set; }
    }
}