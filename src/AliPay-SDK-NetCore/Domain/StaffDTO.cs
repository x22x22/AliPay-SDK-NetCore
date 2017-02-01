using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     StaffDTO Data Structure.
    /// </summary>
    [Serializable]
    public class StaffDTO : AopObject
    {
        /// <summary>
        ///     行业类型
        /// </summary>
        [XmlElement("biz_type")]
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        ///     职员部门Id
        /// </summary>
        [XmlElement("bizunit_id")]
        [JsonProperty("bizunit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BizunitId { get; set; }

        /// <summary>
        ///     员工邮箱
        /// </summary>
        [XmlElement("email")]
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        ///     服务商PID
        /// </summary>
        [XmlElement("merchant_id")]
        [JsonProperty("merchant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantId { get; set; }

        /// <summary>
        ///     商户唯一标识类型，与商户Id组合起来，唯一确定一个商户实体
        /// </summary>
        [XmlElement("merchant_id_type")]
        [JsonProperty("merchant_id_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantIdType { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        [XmlElement("remark")]
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        ///     员工PID
        /// </summary>
        [XmlElement("staff_biz_code")]
        [JsonProperty("staff_biz_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StaffBizCode { get; set; }

        /// <summary>
        ///     员工ID
        /// </summary>
        [XmlElement("staff_id")]
        [JsonProperty("staff_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StaffId { get; set; }

        /// <summary>
        ///     员工手机号
        /// </summary>
        [XmlElement("staff_mobile")]
        [JsonProperty("staff_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string StaffMobile { get; set; }

        /// <summary>
        ///     员工姓名
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