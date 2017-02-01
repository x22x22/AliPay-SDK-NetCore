using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingToolPrizesendAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolPrizesendAuthModel : AopObject
    {
        /// <summary>
        /// 奖品ID
        /// </summary>
        [XmlElement("prize_id")]
		[JsonProperty("prize_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrizeId { get; set; }

        /// <summary>
        /// 外部流水号，保证业务幂等性
        /// </summary>
        [XmlElement("req_id")]
		[JsonProperty("req_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReqId { get; set; }

        /// <summary>
        /// 发奖用户ID
        /// </summary>
        [XmlElement("user_id")]
		[JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}
