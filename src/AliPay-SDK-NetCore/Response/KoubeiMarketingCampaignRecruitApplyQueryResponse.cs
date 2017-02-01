using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiMarketingCampaignRecruitApplyQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignRecruitApplyQueryResponse : AopResponse
    {
        /// <summary>
        ///     活动开始购买时间
        /// </summary>
        [XmlElement("bought_time")]
        [JsonProperty("bought_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BoughtTime { get; set; }

        /// <summary>
        ///     活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        ///     招商报名数据总数
        /// </summary>
        [XmlElement("item_count")]
        [JsonProperty("item_count", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemCount { get; set; }

        /// <summary>
        ///     招商报名数据
        /// </summary>
        [XmlArray("item_info")]
        [XmlArrayItem("recruit_item_apply_data")]
        public List<RecruitItemApplyData> ItemInfo { get; set; }

        /// <summary>
        ///     活动名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///     预热开始时间 2016-12-12 10:10:10
        /// </summary>
        [XmlElement("prehot_time")]
        [JsonProperty("prehot_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PrehotTime { get; set; }
    }
}