using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportBatchqueryModel : AopObject
    {
        /// <summary>
        /// 当前页号，默认为1
        /// </summary>
        [XmlElement("page_no")]
		[JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条目数，默认为20,最大为30
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }
    }
}
