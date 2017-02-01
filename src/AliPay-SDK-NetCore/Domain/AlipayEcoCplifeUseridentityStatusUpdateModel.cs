using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCplifeUseridentityStatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeUseridentityStatusUpdateModel : AopObject
    {
        /// <summary>
        /// 业务明细
        /// </summary>
        [XmlElement("biz_details")]
		[JsonProperty("biz_details", NullValueHandling = NullValueHandling.Ignore)]
        public string BizDetails { get; set; }

        /// <summary>
        /// 当前业务状态
        /// </summary>
        [XmlElement("biz_state")]
		[JsonProperty("biz_state", NullValueHandling = NullValueHandling.Ignore)]
        public string BizState { get; set; }

        /// <summary>
        /// 业务单据ID
        /// </summary>
        [XmlElement("req_id")]
		[JsonProperty("req_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReqId { get; set; }
    }
}
