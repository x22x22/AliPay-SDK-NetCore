using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiQualityTestCloudacptItemQueryResponse.
    /// </summary>
    public class KoubeiQualityTestCloudacptItemQueryResponse : AopResponse
    {
        /// <summary>
        ///     活动id
        /// </summary>
        [XmlElement("activity_id")]
        [JsonProperty("activity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityId { get; set; }

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
        ///     失败单品书列表
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("open_item")]
        public List<OpenItem> FailList { get; set; }

        /// <summary>
        ///     失败数
        /// </summary>
        [XmlElement("fail_num")]
        [JsonProperty("fail_num", NullValueHandling = NullValueHandling.Ignore)]
        public string FailNum { get; set; }

        /// <summary>
        ///     单品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("open_item")]
        public List<OpenItem> ItemList { get; set; }

        /// <summary>
        ///     单品数
        /// </summary>
        [XmlElement("item_num")]
        [JsonProperty("item_num", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemNum { get; set; }

        /// <summary>
        ///     通过单品列表
        /// </summary>
        [XmlArray("pass_list")]
        [XmlArrayItem("open_item")]
        public List<OpenItem> PassList { get; set; }

        /// <summary>
        ///     通过数
        /// </summary>
        [XmlElement("pass_num")]
        [JsonProperty("pass_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PassNum { get; set; }
    }
}