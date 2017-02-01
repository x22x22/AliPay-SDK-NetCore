using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayMarketingCampaignCashTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashTriggerModel : AopObject
    {
        /// <summary>
        ///     现金活动号
        /// </summary>
        [XmlElement("crowd_no")]
        [JsonProperty("crowd_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdNo { get; set; }

        /// <summary>
        ///     用户登录账号名：邮箱或手机号。user_id与login_id至少有一个非空，都非空时，以user_id为准。
        /// </summary>
        [XmlElement("login_id")]
        [JsonProperty("login_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginId { get; set; }

        /// <summary>
        ///     用户唯一标识userId。user_id与login_id至少有一个非空；都非空时，以user_id为准。
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}