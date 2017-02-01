using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCashListQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignCashListQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlArray("camp_list")]
        [XmlArrayItem("cash_campaign_info")]
        public List<CashCampaignInfo> CampList { get; set; }

        /// <summary>
        /// 分页的页码,起始从1开始
        /// </summary>
        [XmlElement("page_index")]
		[JsonProperty("page_index", NullValueHandling = NullValueHandling.Ignore)]
        public string PageIndex { get; set; }

        /// <summary>
        /// 分页每页大小
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }

        /// <summary>
        /// 活动总个数
        /// </summary>
        [XmlElement("total_size")]
		[JsonProperty("total_size", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalSize { get; set; }
    }
}
