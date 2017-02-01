using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignRecruitApplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignRecruitApplyQueryModel : AopObject
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [XmlElement("camp_id")]
		[JsonProperty("camp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampId { get; set; }

        /// <summary>
        /// 分页号
        /// </summary>
        [XmlElement("page_num")]
		[JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小,最大值200
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }
    }
}
