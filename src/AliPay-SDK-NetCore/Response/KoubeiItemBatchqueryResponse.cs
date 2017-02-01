using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiItemBatchqueryResponse.
    /// </summary>
    public class KoubeiItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        ///     当前页码
        /// </summary>
        [XmlElement("current_page_no")]
        [JsonProperty("current_page_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentPageNo { get; set; }

        /// <summary>
        ///     商品信息
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("item_query_response")]
        public List<ItemQueryResponse> ItemInfos { get; set; }

        /// <summary>
        ///     每页记录数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }

        /// <summary>
        ///     总共商品数目
        /// </summary>
        [XmlElement("total_items")]
        [JsonProperty("total_items", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalItems { get; set; }

        /// <summary>
        ///     总页码数目
        /// </summary>
        [XmlElement("total_page_no")]
        [JsonProperty("total_page_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPageNo { get; set; }
    }
}