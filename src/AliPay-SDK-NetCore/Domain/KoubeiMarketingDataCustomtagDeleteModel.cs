using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiMarketingDataCustomtagDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomtagDeleteModel : AopObject
    {
        /// <summary>
        ///     标签code，创建自定义标签时返回的
        /// </summary>
        [XmlElement("tag_code")]
        [JsonProperty("tag_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TagCode { get; set; }
    }
}