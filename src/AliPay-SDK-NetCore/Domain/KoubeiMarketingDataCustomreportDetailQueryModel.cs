using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportDetailQueryModel : AopObject
    {
        /// <summary>
        /// 自定义报表的规则KEY
        /// </summary>
        [XmlElement("condition_key")]
		[JsonProperty("condition_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionKey { get; set; }
    }
}
