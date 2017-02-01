using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     BenefitInfoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitInfoDetail : AopObject
    {
        /// <summary>
        ///     PRE_FUND：实际核销或者商户赠送的金额  DISCOUNT：实际折扣掉的金额（获取权益不支持该类型）  COUPON：实际核销或者商户赠送的券
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     权益类型  PRE_FUND（卡面额）  DISCOUNT：折扣金额  COUPON：券
        /// </summary>
        [XmlElement("benefit_type")]
        [JsonProperty("benefit_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BenefitType { get; set; }

        /// <summary>
        ///     COUPON：当核销或者赠送券时，可以设置该值
        /// </summary>
        [XmlElement("count")]
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public string Count { get; set; }

        /// <summary>
        ///     产生核销或者赠送权益的描述
        /// </summary>
        [XmlElement("description")]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
}