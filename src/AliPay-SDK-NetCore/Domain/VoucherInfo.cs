using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     VoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherInfo : AopObject
    {
        /// <summary>
        ///     是否可转赠。默认true
        /// </summary>
        [XmlElement("can_give_friend")]
        [JsonProperty("can_give_friend", NullValueHandling = NullValueHandling.Ignore)]
        public bool CanGiveFriend { get; set; }

        /// <summary>
        ///     使用规则
        /// </summary>
        [XmlElement("use_rule")]
        [JsonProperty("use_rule", NullValueHandling = NullValueHandling.Ignore)]
        public UseRuleInfo UseRule { get; set; }

        /// <summary>
        ///     有效期
        /// </summary>
        [XmlElement("valid_date")]
        [JsonProperty("valid_date", NullValueHandling = NullValueHandling.Ignore)]
        public ValidDateInfo ValidDate { get; set; }

        /// <summary>
        ///     券详情描述
        /// </summary>
        [XmlElement("voucher_desc")]
        [JsonProperty("voucher_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherDesc { get; set; }

        /// <summary>
        ///     券背景图。该值调用接口:alipay.offline.material.image.upload生成
        /// </summary>
        [XmlElement("voucher_img")]
        [JsonProperty("voucher_img", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherImg { get; set; }

        /// <summary>
        ///     logo图片id。该值调用接口:alipay.offline.material.image.upload生成
        /// </summary>
        [XmlElement("voucher_logo")]
        [JsonProperty("voucher_logo", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherLogo { get; set; }

        /// <summary>
        ///     券名称
        /// </summary>
        [XmlElement("voucher_name")]
        [JsonProperty("voucher_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherName { get; set; }

        /// <summary>
        ///     券上的详情描述信息
        /// </summary>
        [XmlArray("voucher_terms")]
        [XmlArrayItem("voucher_term_info")]
        public List<VoucherTermInfo> VoucherTerms { get; set; }

        /// <summary>
        ///     券类型
        /// </summary>
        [XmlElement("voucher_type")]
        [JsonProperty("voucher_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherType { get; set; }
    }
}