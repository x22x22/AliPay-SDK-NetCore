using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsCertificateApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsCertificateApiDTO : AopObject
    {
        /// <summary>
        ///     扩展字段
        /// </summary>
        [XmlElement("biz_data")]
        [JsonProperty("biz_data", NullValueHandling = NullValueHandling.Ignore)]
        public string BizData { get; set; }

        /// <summary>
        ///     保险凭证号
        /// </summary>
        [XmlElement("certificate_no")]
        [JsonProperty("certificate_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateNo { get; set; }

        /// <summary>
        ///     保险凭证类型
        /// </summary>
        [XmlElement("certificate_type")]
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateType { get; set; }

        /// <summary>
        ///     生效时间
        /// </summary>
        [XmlElement("effect_time")]
        [JsonProperty("effect_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectTime { get; set; }

        /// <summary>
        ///     失效时间
        /// </summary>
        [XmlElement("expire_time")]
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        ///     面值
        /// </summary>
        [XmlElement("face_value")]
        [JsonProperty("face_value", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceValue { get; set; }

        /// <summary>
        ///     机构保单号
        /// </summary>
        [XmlElement("ins_policy_no")]
        [JsonProperty("ins_policy_no", NullValueHandling = NullValueHandling.Ignore)]
        public string InsPolicyNo { get; set; }

        /// <summary>
        ///     机构id
        /// </summary>
        [XmlElement("inst_id")]
        [JsonProperty("inst_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstId { get; set; }

        /// <summary>
        ///     订单号
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        ///     订单来源
        /// </summary>
        [XmlElement("order_source")]
        [JsonProperty("order_source", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderSource { get; set; }

        /// <summary>
        ///     外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        [JsonProperty("out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutBizNo { get; set; }

        /// <summary>
        ///     拥有人uid
        /// </summary>
        [XmlElement("owner_uid")]
        [JsonProperty("owner_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerUid { get; set; }

        /// <summary>
        ///     保险凭证状态
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public long Status { get; set; }

        /// <summary>
        ///     使用时间
        /// </summary>
        [XmlElement("use_time")]
        [JsonProperty("use_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UseTime { get; set; }

        /// <summary>
        ///     使用人uid
        /// </summary>
        [XmlElement("user_uid")]
        [JsonProperty("user_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string UserUid { get; set; }
    }
}