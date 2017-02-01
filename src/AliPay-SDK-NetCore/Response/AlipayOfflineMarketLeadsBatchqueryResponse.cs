using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketLeadsBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineMarketLeadsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page_no")]
		[JsonProperty("current_page_no", NullValueHandling = NullValueHandling.Ignore)]
        public long CurrentPageNo { get; set; }

        /// <summary>
        /// 支付宝leads信息列表
        /// </summary>
        [XmlArray("leads_query_responses")]
        [XmlArrayItem("leads_query_response")]
        public List<LeadsQueryResponse> LeadsQueryResponses { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_items")]
		[JsonProperty("total_items", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [XmlElement("total_page_no")]
		[JsonProperty("total_page_no", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalPageNo { get; set; }
    }
}
