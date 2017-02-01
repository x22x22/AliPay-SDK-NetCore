using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenItem Data Structure.
    /// </summary>
    [Serializable]
    public class OpenItem : AopObject
    {
        /// <summary>
        /// 单品编号
        /// </summary>
        [XmlElement("item_id")]
		[JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        /// <summary>
        /// 单品检测状态  0，未检测  1，未通过  2，已通过
        /// </summary>
        [XmlElement("item_status")]
		[JsonProperty("item_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("store_id")]
		[JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreId { get; set; }
    }
}
