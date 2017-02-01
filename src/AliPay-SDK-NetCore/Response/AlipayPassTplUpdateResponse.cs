using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPassTplUpdateResponse.
    /// </summary>
    public class AlipayPassTplUpdateResponse : AopResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("error_code")]
		[JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 业务结果信息：包含模版id、动态参数集合和操作类型
        /// </summary>
        [XmlElement("result")]
		[JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 操作成功与否标识：T标识成功，F标识失败
        /// </summary>
        [XmlElement("success")]
		[JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public string Success { get; set; }
    }
}
