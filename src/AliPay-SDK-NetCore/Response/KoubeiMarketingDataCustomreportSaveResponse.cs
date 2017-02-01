using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportSaveResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportSaveResponse : AopResponse
    {
        /// <summary>
        /// 自定义报表的规则ID
        /// </summary>
        [XmlElement("condition_key")]
		[JsonProperty("condition_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionKey { get; set; }
    }
}
