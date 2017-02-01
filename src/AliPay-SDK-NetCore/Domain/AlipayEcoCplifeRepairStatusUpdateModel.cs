using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoCplifeRepairStatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeRepairStatusUpdateModel : AopObject
    {
        /// <summary>
        ///     报修单状态明细
        /// </summary>
        [XmlElement("biz_details")]
        [JsonProperty("biz_details", NullValueHandling = NullValueHandling.Ignore)]
        public string BizDetails { get; set; }

        /// <summary>
        ///     当前报修单状态
        /// </summary>
        [XmlElement("biz_state")]
        [JsonProperty("biz_state", NullValueHandling = NullValueHandling.Ignore)]
        public string BizState { get; set; }

        /// <summary>
        ///     报修单ID
        /// </summary>
        [XmlElement("req_id")]
        [JsonProperty("req_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReqId { get; set; }
    }
}