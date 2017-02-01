using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiItemExtitemBatchqueryResponse.
    /// </summary>
    public class KoubeiItemExtitemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("model_list")]
        [XmlArrayItem("ext_item")]
        public List<ExtItem> ModelList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
		[JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
		[JsonProperty("total_size", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalSize { get; set; }
    }
}
