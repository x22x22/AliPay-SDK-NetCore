using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkBatchqueryResponse.
    /// </summary>
    public class KoubeiCraftsmanDataWorkBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page_no")]
		[JsonProperty("current_page_no", NullValueHandling = NullValueHandling.Ignore)]
        public long CurrentPageNo { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [XmlElement("total_page_no")]
		[JsonProperty("total_page_no", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalPageNo { get; set; }

        /// <summary>
        /// 总共手艺人作品数目
        /// </summary>
        [XmlElement("total_works")]
		[JsonProperty("total_works", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalWorks { get; set; }

        /// <summary>
        /// 作品信息列表
        /// </summary>
        [XmlArray("works")]
        [XmlArrayItem("craftsman_work_open_model")]
        public List<CraftsmanWorkOpenModel> Works { get; set; }
    }
}
