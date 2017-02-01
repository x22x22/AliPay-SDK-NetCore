using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     OpenBatch Data Structure.
    /// </summary>
    [Serializable]
    public class OpenBatch : AopObject
    {
        /// <summary>
        ///     批次id
        /// </summary>
        [XmlElement("batch_id")]
        [JsonProperty("batch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchId { get; set; }

        /// <summary>
        ///     批次状态  0，未检测  1，检测中  2，未通过  3，已通过
        /// </summary>
        [XmlElement("batch_status")]
        [JsonProperty("batch_status", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchStatus { get; set; }

        /// <summary>
        ///     单品数
        /// </summary>
        [XmlElement("item_num")]
        [JsonProperty("item_num", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemNum { get; set; }
    }
}