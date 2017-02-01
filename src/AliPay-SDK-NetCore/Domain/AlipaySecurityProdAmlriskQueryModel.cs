using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipaySecurityProdAmlriskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAmlriskQueryModel : AopObject
    {
        /// <summary>
        ///     办公地址
        /// </summary>
        [XmlElement("business_address")]
        [JsonProperty("business_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessAddress { get; set; }

        /// <summary>
        ///     标识该次反洗钱风险分析事件请求的id，商户应保证此id唯一。
        /// </summary>
        [XmlElement("event_id")]
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        ///     与商户相关个体的信息列表，可以有0个到多个。
        /// </summary>
        [XmlArray("individual_list")]
        [XmlArrayItem("individual_info")]
        public List<IndividualInfo> IndividualList { get; set; }

        /// <summary>
        ///     公司名称、类型、性质
        /// </summary>
        [XmlElement("legal_name")]
        [JsonProperty("legal_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalName { get; set; }

        /// <summary>
        ///     商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        [JsonProperty("merchant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantId { get; set; }

        /// <summary>
        ///     该商户准入申请的id
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        ///     公司注册地址
        /// </summary>
        [XmlElement("registered_address")]
        [JsonProperty("registered_address", NullValueHandling = NullValueHandling.Ignore)]
        public string RegisteredAddress { get; set; }

        /// <summary>
        ///     公司注册号
        /// </summary>
        [XmlElement("registration_number")]
        [JsonProperty("registration_number", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistrationNumber { get; set; }
    }
}