using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderStaffUpdateResponse.
    /// </summary>
    public class AlipayOfflineProviderStaffUpdateResponse : AopResponse
    {
        /// <summary>
        /// 同步失败错误原因信息
        /// </summary>
        [XmlElement("error_msg")]
		[JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 同步操作完成后的结果
        /// </summary>
        [XmlElement("operate_result")]
		[JsonProperty("operate_result", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateResult { get; set; }

        /// <summary>
        /// 同步员工的操作类型
        /// </summary>
        [XmlElement("operate_type")]
		[JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        /// 员工pid
        /// </summary>
        [XmlElement("pid")]
		[JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public string Pid { get; set; }

        /// <summary>
        /// 服务商员工staff_id
        /// </summary>
        [XmlElement("staff_id")]
		[JsonProperty("staff_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StaffId { get; set; }
    }
}
