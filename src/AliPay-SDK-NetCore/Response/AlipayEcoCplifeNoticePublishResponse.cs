using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCplifeNoticePublishResponse.
    /// </summary>
    public class AlipayEcoCplifeNoticePublishResponse : AopResponse
    {
        /// <summary>
        /// 支付宝平台统一生产的通知公告唯一ID标示.
        /// </summary>
        [XmlElement("notice_id")]
		[JsonProperty("notice_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NoticeId { get; set; }
    }
}
