using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertContentShareCode Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentShareCode : AopObject
    {
        /// <summary>
        /// 吱口令内容详情
        /// </summary>
        [XmlElement("share_code_desc")]
		[JsonProperty("share_code_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareCodeDesc { get; set; }
    }
}
