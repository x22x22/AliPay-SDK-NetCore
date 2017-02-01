using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     CustomerTag Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerTag : AopObject
    {
        /// <summary>
        ///     字段名称
        /// </summary>
        [XmlElement("col_name")]
        [JsonProperty("col_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ColName { get; set; }

        /// <summary>
        ///     column_type字段类型
        /// </summary>
        [XmlElement("column_type")]
        [JsonProperty("column_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnType { get; set; }

        /// <summary>
        ///     id
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        ///     标签名
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}