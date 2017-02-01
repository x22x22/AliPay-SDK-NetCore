using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayExscUserFirstfundinpourGetResponse.
    /// </summary>
    public class AlipayExscUserFirstfundinpourGetResponse : AopResponse
    {
        /// <summary>
        ///     返回结果的业务类型。首次资金流入业务类型 （first_fund_inpour）
        /// </summary>
        [XmlElement("biz_type")]
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        ///     业务处理结果   true 无资金流入记录，本次是首次交易   false 已有资金流入记录，本次不是首次交易
        /// </summary>
        [XmlElement("success")]
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; }
    }
}