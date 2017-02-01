using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserTradeSearchResponse.
    /// </summary>
    public class AlipayUserTradeSearchResponse : AopResponse
    {
        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
		[JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_results")]
		[JsonProperty("total_results", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalResults { get; set; }

        /// <summary>
        /// 交易记录列表
        /// </summary>
        [XmlArray("trade_records")]
        [XmlArrayItem("trade_record")]
        public List<TradeRecord> TradeRecords { get; set; }
    }
}
