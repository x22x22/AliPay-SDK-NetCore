using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsCreateCertificateRequest Data Structure.
    /// </summary>
    [Serializable]
    public class InsCreateCertificateRequest : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("biz_data")]
		[JsonProperty("biz_data", NullValueHandling = NullValueHandling.Ignore)]
        public string BizData { get; set; }

        /// <summary>
        /// 保险凭证类型
        /// </summary>
        [XmlElement("certificate_type")]
		[JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateType { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("effect_time")]
		[JsonProperty("effect_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectTime { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("expire_time")]
		[JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 面值
        /// </summary>
        [XmlElement("face_value")]
		[JsonProperty("face_value", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceValue { get; set; }

        /// <summary>
        /// 电子保单号
        /// </summary>
        [XmlElement("ins_policy_no")]
		[JsonProperty("ins_policy_no", NullValueHandling = NullValueHandling.Ignore)]
        public string InsPolicyNo { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
		[JsonProperty("inst_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstId { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
		[JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [XmlElement("order_source")]
		[JsonProperty("order_source", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderSource { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
		[JsonProperty("out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拥有人uid
        /// </summary>
        [XmlElement("owner_uid")]
		[JsonProperty("owner_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerUid { get; set; }
    }
}
