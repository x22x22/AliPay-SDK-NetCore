using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Coupon Data Structure.
    /// </summary>
    [Serializable]
    public class Coupon : AopObject
    {
        /// <summary>
        /// 当前可用面额
        /// </summary>
        [XmlElement("available_amount")]
		[JsonProperty("available_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 红包编号
        /// </summary>
        [XmlElement("coupon_no")]
		[JsonProperty("coupon_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponNo { get; set; }

        /// <summary>
        /// 可优惠面额
        /// </summary>
        [XmlElement("deduct_amount")]
		[JsonProperty("deduct_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [XmlElement("gmt_active")]
		[JsonProperty("gmt_active", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtActive { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
		[JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 有效期结束时间
        /// </summary>
        [XmlElement("gmt_expired")]
		[JsonProperty("gmt_expired", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 红包使用说明
        /// </summary>
        [XmlElement("instructions")]
		[JsonProperty("instructions", NullValueHandling = NullValueHandling.Ignore)]
        public string Instructions { get; set; }

        /// <summary>
        /// 红包详情说明
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_uniq_id")]
		[JsonProperty("merchant_uniq_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantUniqId { get; set; }

        /// <summary>
        /// 是否可叠加
        /// </summary>
        [XmlElement("multi_use_flag")]
		[JsonProperty("multi_use_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string MultiUseFlag { get; set; }

        /// <summary>
        /// 红包名称
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否可退款标识
        /// </summary>
        [XmlElement("refund_flag")]
		[JsonProperty("refund_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundFlag { get; set; }

        /// <summary>
        /// 红包状态信息
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 红包模板编号
        /// </summary>
        [XmlElement("template_no")]
		[JsonProperty("template_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateNo { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("user_id")]
		[JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}
