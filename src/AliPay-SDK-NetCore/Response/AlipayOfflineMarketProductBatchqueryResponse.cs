using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOfflineMarketProductBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineMarketProductBatchqueryResponse : AopResponse
    {
        /// <summary>
        ///     当前页码
        /// </summary>
        [XmlElement("current_pageno")]
        [JsonProperty("current_pageno", NullValueHandling = NullValueHandling.Ignore)]
        public long CurrentPageno { get; set; }

        /// <summary>
        ///     商品列表ID，逗号分隔
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        ///     总页码数
        /// </summary>
        [XmlElement("total_pageno")]
        [JsonProperty("total_pageno", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalPageno { get; set; }
    }
}