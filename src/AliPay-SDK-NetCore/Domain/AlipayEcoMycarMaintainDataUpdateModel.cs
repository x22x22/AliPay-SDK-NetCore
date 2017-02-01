using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarMaintainDataUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMaintainDataUpdateModel : AopObject
    {
        /// <summary>
        ///     门店或者服务的编码
        /// </summary>
        [XmlElement("biz_id")]
        [JsonProperty("biz_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BizId { get; set; }

        /// <summary>
        ///     事件类型(1:上下线 2:服务价格)
        /// </summary>
        [XmlElement("event_id")]
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public long EventId { get; set; }

        /// <summary>
        ///     来源(1:汽车超人)
        /// </summary>
        [XmlElement("source")]
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        ///     类型(1:门店 2:服务)
        /// </summary>
        [XmlElement("type_id")]
        [JsonProperty("type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeId { get; set; }
    }
}