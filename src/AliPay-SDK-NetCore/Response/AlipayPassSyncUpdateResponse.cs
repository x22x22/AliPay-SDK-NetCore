using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPassSyncUpdateResponse.
    /// </summary>
    public class AlipayPassSyncUpdateResponse : AopResponse
    {
        /// <summary>
        /// 更新成功时的业务信息
        /// </summary>
        [XmlElement("biz_result")]
		[JsonProperty("biz_result", NullValueHandling = NullValueHandling.Ignore)]
        public string BizResult { get; set; }

        /// <summary>
        /// 当新增alipass不成功时，产生的错误码.
        /// </summary>
        [XmlElement("error_code")]
		[JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否更新成功的标识。
        /// </summary>
        [XmlElement("success")]
		[JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; }
    }
}
