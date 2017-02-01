using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarPromoTicketPushModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarPromoTicketPushModel : AopObject
    {
        /// <summary>
        ///     核销流水
        /// </summary>
        [XmlElement("apply_no")]
        [JsonProperty("apply_no", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyNo { get; set; }

        /// <summary>
        ///     核销状态，0：成功，1：失败
        /// </summary>
        [XmlElement("apply_status")]
        [JsonProperty("apply_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyStatus { get; set; }

        /// <summary>
        ///     对应TP活动码
        /// </summary>
        [XmlElement("code_no")]
        [JsonProperty("code_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeNo { get; set; }

        /// <summary>
        ///     券ID
        /// </summary>
        [XmlElement("ticket_id")]
        [JsonProperty("ticket_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TicketId { get; set; }
    }
}