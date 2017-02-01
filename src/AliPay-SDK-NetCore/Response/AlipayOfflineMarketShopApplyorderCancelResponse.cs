using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOfflineMarketShopApplyorderCancelResponse.
    /// </summary>
    public class AlipayOfflineMarketShopApplyorderCancelResponse : AopResponse
    {
        /// <summary>
        ///     申请撤销成功接口同步返回的支付宝申请流水号。
        /// </summary>
        [XmlElement("apply_id")]
        [JsonProperty("apply_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyId { get; set; }
    }
}