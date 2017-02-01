using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbOrderActivityModel Data Structure.
    /// </summary>
    [Serializable]
    public class KbOrderActivityModel : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
		[JsonProperty("activity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
		[JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }
    }
}
