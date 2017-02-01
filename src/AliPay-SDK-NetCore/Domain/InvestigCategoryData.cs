using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InvestigCategoryData Data Structure.
    /// </summary>
    [Serializable]
    public class InvestigCategoryData : AopObject
    {
        /// <summary>
        ///     数据项
        /// </summary>
        [XmlElement("category")]
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        ///     实体code
        /// </summary>
        [XmlElement("entity_code")]
        [JsonProperty("entity_code", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityCode { get; set; }

        /// <summary>
        ///     实体名
        /// </summary>
        [XmlElement("entity_name")]
        [JsonProperty("entity_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityName { get; set; }

        /// <summary>
        ///     实体类别
        /// </summary>
        [XmlElement("entity_type")]
        [JsonProperty("entity_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityType { get; set; }

        /// <summary>
        ///     模型结果,不同数据项,对应的模型结果对象不同,以JSON格式输出
        /// </summary>
        [XmlElement("model_result_object")]
        [JsonProperty("model_result_object", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelResultObject { get; set; }

        /// <summary>
        ///     采集状态
        /// </summary>
        [XmlElement("state")]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }
    }
}