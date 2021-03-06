using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoCplifeNoticePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeNoticePublishModel : AopObject
    {
        /// <summary>
        ///     待发布通知的目标物业小区ID列表，使用支付宝平台统一的小区ID编码。
        /// </summary>
        [XmlArray("community_id_set")]
        [XmlArrayItem("string")]
        public List<string> CommunityIdSet { get; set; }

        /// <summary>
        ///     待发送的通知内容
        /// </summary>
        [XmlElement("notice_details")]
        [JsonProperty("notice_details", NullValueHandling = NullValueHandling.Ignore)]
        public CplifeNoticeDetail NoticeDetails { get; set; }
    }
}