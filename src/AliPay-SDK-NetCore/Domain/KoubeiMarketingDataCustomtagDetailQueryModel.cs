using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiMarketingDataCustomtagDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomtagDetailQueryModel : AopObject
    {
        /// <summary>
        ///     标签code，自定义标签保存时返回的tag_code值
        /// </summary>
        [XmlElement("tag_code")]
        [JsonProperty("tag_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TagCode { get; set; }
    }
}