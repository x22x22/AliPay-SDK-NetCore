using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ISVLogSync Data Structure.
    /// </summary>
    [Serializable]
    public class ISVLogSync : AopObject
    {
        /// <summary>
        /// 应用名
        /// </summary>
        [XmlElement("application")]
		[JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        public string Application { get; set; }

        /// <summary>
        /// isv自定义错误码， 该值传了表示接口调用业务失败或发生异常
        /// </summary>
        [XmlElement("error_code")]
		[JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
		[JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 异常堆栈
        /// </summary>
        [XmlElement("exception_stack_trace")]
		[JsonProperty("exception_stack_trace", NullValueHandling = NullValueHandling.Ignore)]
        public string ExceptionStackTrace { get; set; }

        /// <summary>
        /// 执行时长，毫秒数。如果能取到尽量传入，涉及到接口耗时的监控
        /// </summary>
        [XmlElement("execution_millis")]
		[JsonProperty("execution_millis", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionMillis { get; set; }

        /// <summary>
        /// 接口全限定名 包含远程rpc和内部调用
        /// </summary>
        [XmlElement("interface_name")]
		[JsonProperty("interface_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// T 成功  F 失败
        /// </summary>
        [XmlElement("success")]
		[JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public string Success { get; set; }

        /// <summary>
        /// 回流数据类型
        /// </summary>
        [XmlElement("sync_type")]
		[JsonProperty("sync_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncType { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("timestamp")]
		[JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }
    }
}
