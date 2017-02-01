using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsMktCouponConfigDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCouponConfigDTO : AopObject
    {
        /// <summary>
        ///     权益配置Id
        /// </summary>
        [XmlElement("coupon_conf_id")]
        [JsonProperty("coupon_conf_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponConfId { get; set; }

        /// <summary>
        ///     权益类型
        /// </summary>
        [XmlElement("coupon_type")]
        [JsonProperty("coupon_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponType { get; set; }

        /// <summary>
        ///     200元优惠券
        /// </summary>
        [XmlElement("coupon_value")]
        [JsonProperty("coupon_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponValue { get; set; }

        /// <summary>
        ///     核销结束时间
        /// </summary>
        [XmlElement("use_end_time")]
        [JsonProperty("use_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UseEndTime { get; set; }

        /// <summary>
        ///     核销使用规则
        /// </summary>
        [XmlElement("use_rule")]
        [JsonProperty("use_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string UseRule { get; set; }

        /// <summary>
        ///     核销开始时间
        /// </summary>
        [XmlElement("use_start_time")]
        [JsonProperty("use_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UseStartTime { get; set; }
    }
}