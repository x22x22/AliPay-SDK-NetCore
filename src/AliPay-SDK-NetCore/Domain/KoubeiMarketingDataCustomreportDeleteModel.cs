using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportDeleteModel : AopObject
    {
        /// <summary>
        /// 自定义报表规则的KEY
        /// </summary>
        [XmlElement("condition_key")]
		[JsonProperty("condition_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionKey { get; set; }
    }
}
