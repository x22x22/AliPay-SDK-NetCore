using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     StationDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StationDetailInfo : AopObject
    {
        /// <summary>
        ///     站点编码
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        ///     站点外部编码
        /// </summary>
        [XmlElement("ext_code")]
        [JsonProperty("ext_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtCode { get; set; }

        /// <summary>
        ///     站点中文名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}