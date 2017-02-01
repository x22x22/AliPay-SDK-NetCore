using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMarketingCampaignDrawcampStatusUpdateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampStatusUpdateResponse : AopResponse
    {
        /// <summary>
        ///     修改状态操作结果状态，业务维度，网关返回成功状态码并且业务维度返回true才成功
        /// </summary>
        [XmlElement("camp_result")]
        [JsonProperty("camp_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool CampResult { get; set; }
    }
}