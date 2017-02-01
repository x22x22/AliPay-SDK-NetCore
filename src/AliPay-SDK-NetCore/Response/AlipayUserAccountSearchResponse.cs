using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayUserAccountSearchResponse.
    /// </summary>
    public class AlipayUserAccountSearchResponse : AopResponse
    {
        /// <summary>
        ///     支付宝用户账务明细信息
        /// </summary>
        [XmlArray("account_records")]
        [XmlArrayItem("account_record")]
        public List<AccountRecord> AccountRecords { get; set; }

        /// <summary>
        ///     总页面数
        /// </summary>
        [XmlElement("total_pages")]
        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalPages { get; set; }

        /// <summary>
        ///     总记录数
        /// </summary>
        [XmlElement("total_results")]
        [JsonProperty("total_results", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalResults { get; set; }
    }
}