using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineProviderStaffUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderStaffUpdateModel : AopObject
    {
        /// <summary>
        ///     支付宝账号
        /// </summary>
        [XmlElement("alipay_no")]
        [JsonProperty("alipay_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayNo { get; set; }

        /// <summary>
        ///     行业类型
        /// </summary>
        [XmlElement("biz_type")]
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        ///     客户端请求IP
        /// </summary>
        [XmlElement("client_ip")]
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        ///     新增员工的备注信息
        /// </summary>
        [XmlElement("description")]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        ///     要同步员工的邮箱
        /// </summary>
        [XmlElement("email")]
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        ///     登录用户的staff_id
        /// </summary>
        [XmlElement("login_staff_id")]
        [JsonProperty("login_staff_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginStaffId { get; set; }

        /// <summary>
        ///     服务商pid
        /// </summary>
        [XmlElement("merchant_id")]
        [JsonProperty("merchant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantId { get; set; }

        /// <summary>
        ///     服务商id的类型
        /// </summary>
        [XmlElement("merchant_id_type")]
        [JsonProperty("merchant_id_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantIdType { get; set; }

        /// <summary>
        ///     云纵登录人员pid
        /// </summary>
        [XmlElement("ope_pid")]
        [JsonProperty("ope_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string OpePid { get; set; }

        /// <summary>
        ///     同步云纵员工操作类型
        /// </summary>
        [XmlElement("operate_type")]
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        ///     流水号参数
        /// </summary>
        [XmlElement("request_id")]
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        ///     角色类型
        /// </summary>
        [XmlElement("role_type")]
        [JsonProperty("role_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleType { get; set; }

        /// <summary>
        ///     修改删除员工的主键id
        /// </summary>
        [XmlElement("staff_id")]
        [JsonProperty("staff_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StaffId { get; set; }

        /// <summary>
        ///     要同步员工的电话号码
        /// </summary>
        [XmlElement("staff_mobile")]
        [JsonProperty("staff_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string StaffMobile { get; set; }

        /// <summary>
        ///     新增员工姓名
        /// </summary>
        [XmlElement("staff_name")]
        [JsonProperty("staff_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StaffName { get; set; }

        /// <summary>
        ///     员工类型
        /// </summary>
        [XmlElement("staff_type")]
        [JsonProperty("staff_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StaffType { get; set; }
    }
}