using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiCraftsmanDataProviderBatchqueryResponse.
    /// </summary>
    public class KoubeiCraftsmanDataProviderBatchqueryResponse : AopResponse
    {
        /// <summary>
        ///     craftsmans:手艺人信息
        /// </summary>
        [XmlArray("craftsmans")]
        [XmlArrayItem("craftsman_open_model")]
        public List<CraftsmanOpenModel> Craftsmans { get; set; }

        /// <summary>
        ///     当前页码
        /// </summary>
        [XmlElement("current_page_no")]
        [JsonProperty("current_page_no", NullValueHandling = NullValueHandling.Ignore)]
        public long CurrentPageNo { get; set; }

        /// <summary>
        ///     每页记录数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long PageSize { get; set; }

        /// <summary>
        ///     门店下共手艺人数目
        /// </summary>
        [XmlElement("total_craftsmans")]
        [JsonProperty("total_craftsmans", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalCraftsmans { get; set; }

        /// <summary>
        ///     总页码数目
        /// </summary>
        [XmlElement("total_page_no")]
        [JsonProperty("total_page_no", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalPageNo { get; set; }
    }
}