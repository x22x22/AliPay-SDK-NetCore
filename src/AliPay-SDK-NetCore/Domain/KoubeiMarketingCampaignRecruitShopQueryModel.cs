using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiMarketingCampaignRecruitShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignRecruitShopQueryModel : AopObject
    {
        /// <summary>
        ///     活动id
        /// </summary>
        [XmlElement("camp_id")]
        [JsonProperty("camp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampId { get; set; }

        /// <summary>
        ///     参与的商户Id
        /// </summary>
        [XmlElement("invitee")]
        [JsonProperty("invitee", NullValueHandling = NullValueHandling.Ignore)]
        public string Invitee { get; set; }

        /// <summary>
        ///     操作人id
        /// </summary>
        [XmlElement("operator_id")]
        [JsonProperty("operator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorId { get; set; }

        /// <summary>
        ///     操作人类型
        /// </summary>
        [XmlElement("operator_type")]
        [JsonProperty("operator_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorType { get; set; }

        /// <summary>
        ///     页码
        /// </summary>
        [XmlElement("page_num")]
        [JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PageNum { get; set; }

        /// <summary>
        ///     每页大小
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }
    }
}