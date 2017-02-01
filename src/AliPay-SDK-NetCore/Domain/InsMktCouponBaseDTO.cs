using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsMktCouponBaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCouponBaseDTO : AopObject
    {
        /// <summary>
        ///     权益Id
        /// </summary>
        [XmlElement("coupon_id")]
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponId { get; set; }

        /// <summary>
        ///     权益类型
        /// </summary>
        [XmlElement("coupon_type")]
        [JsonProperty("coupon_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponType { get; set; }

        /// <summary>
        ///     权益值
        /// </summary>
        [XmlElement("coupon_value")]
        [JsonProperty("coupon_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponValue { get; set; }
    }
}