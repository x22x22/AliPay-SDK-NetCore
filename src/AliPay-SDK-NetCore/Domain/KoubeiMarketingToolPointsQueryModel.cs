using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiMarketingToolPointsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolPointsQueryModel : AopObject
    {
        /// <summary>
        ///     活动积分帐户
        /// </summary>
        [XmlElement("activity_account")]
        [JsonProperty("activity_account", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityAccount { get; set; }

        /// <summary>
        ///     用户ID
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}