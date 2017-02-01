using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ArrangementInvolvedPartyQuerier Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementInvolvedPartyQuerier : AopObject
    {
        /// <summary>
        ///     参与者id
        /// </summary>
        [XmlElement("ip_id")]
        [JsonProperty("ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpId { get; set; }

        /// <summary>
        ///     用户uid/参与者角色id
        /// </summary>
        [XmlElement("ip_role_id")]
        [JsonProperty("ip_role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpRoleId { get; set; }

        /// <summary>
        ///     参与者角色类型，为空时表示所有类型都查询.  可选值：01 甲方 11 乙方 21丙方
        /// </summary>
        [XmlElement("ip_type")]
        [JsonProperty("ip_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IpType { get; set; }
    }
}