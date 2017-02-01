using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPromorulecenterRuleAnalyzeResponse.
    /// </summary>
    public class AlipayPromorulecenterRuleAnalyzeResponse : AopResponse
    {
        /// <summary>
        /// 未通过条件描述信息
        /// </summary>
        [XmlElement("fail_condition_msg")]
		[JsonProperty("fail_condition_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string FailConditionMsg { get; set; }

        /// <summary>
        /// 未通过的条件
        /// </summary>
        [XmlElement("fail_condition_name")]
		[JsonProperty("fail_condition_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FailConditionName { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
		[JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 服务调用是否成功
        /// </summary>
        [XmlElement("success")]
		[JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public string Success { get; set; }

        /// <summary>
        /// 规则是否通过
        /// </summary>
        [XmlElement("triggered")]
		[JsonProperty("triggered", NullValueHandling = NullValueHandling.Ignore)]
        public string Triggered { get; set; }
    }
}
