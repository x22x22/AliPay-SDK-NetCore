using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     DataTag Data Structure.
    /// </summary>
    [Serializable]
    public class DataTag : AopObject
    {
        /// <summary>
        ///     聚合方式NONE,COUNT,COUNT_DISTINCT,DISTINCT,MIN,MAX,SUM
        /// </summary>
        [XmlElement("aggregate")]
        [JsonProperty("aggregate", NullValueHandling = NullValueHandling.Ignore)]
        public string Aggregate { get; set; }

        /// <summary>
        ///     列别名
        /// </summary>
        [XmlElement("alias")]
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        ///     标签CODE
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }
    }
}