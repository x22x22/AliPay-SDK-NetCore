using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     CodeNOList Data Structure.
    /// </summary>
    [Serializable]
    public class CodeNOList : AopObject
    {
        /// <summary>
        ///     金额
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     对应TP活动码
        /// </summary>
        [XmlElement("code_no")]
        [JsonProperty("code_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeNo { get; set; }

        /// <summary>
        ///     如果ticket_type为油券，则该字段1:石化，2:石油
        /// </summary>
        [XmlElement("sub_type")]
        [JsonProperty("sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubType { get; set; }

        /// <summary>
        ///     券类型,1:油券
        /// </summary>
        [XmlElement("ticket_type")]
        [JsonProperty("ticket_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TicketType { get; set; }

        /// <summary>
        ///     有效期
        /// </summary>
        [XmlElement("valid_date")]
        [JsonProperty("valid_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidDate { get; set; }
    }
}