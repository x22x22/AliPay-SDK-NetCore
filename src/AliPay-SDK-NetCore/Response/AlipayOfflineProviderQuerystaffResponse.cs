using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderQuerystaffResponse.
    /// </summary>
    public class AlipayOfflineProviderQuerystaffResponse : AopResponse
    {
        /// <summary>
        /// 当前分页数
        /// </summary>
        [XmlElement("current_page")]
		[JsonProperty("current_page", NullValueHandling = NullValueHandling.Ignore)]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页分页条数
        /// </summary>
        [XmlElement("items_per_page")]
		[JsonProperty("items_per_page", NullValueHandling = NullValueHandling.Ignore)]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 员工信息列表
        /// </summary>
        [XmlArray("query_result")]
        [XmlArrayItem("staff_d_t_o")]
        public List<StaffDTO> QueryResult { get; set; }

        /// <summary>
        /// 总员工数
        /// </summary>
        [XmlElement("total_count")]
		[JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总分页数
        /// </summary>
        [XmlElement("total_pages")]
		[JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalPages { get; set; }
    }
}
