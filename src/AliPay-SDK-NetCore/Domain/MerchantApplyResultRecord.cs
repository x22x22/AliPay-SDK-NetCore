using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     MerchantApplyResultRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantApplyResultRecord : AopObject
    {
        /// <summary>
        ///     签约产品名称
        /// </summary>
        [XmlElement("prod_name")]
        [JsonProperty("prod_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProdName { get; set; }

        /// <summary>
        ///     如审核失败，表示该字段引发的审核失败
        /// </summary>
        [XmlElement("prop_input_key")]
        [JsonProperty("prop_input_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PropInputKey { get; set; }

        /// <summary>
        ///     认证、产品签约审核失败原因
        /// </summary>
        [XmlElement("result_msg")]
        [JsonProperty("result_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultMsg { get; set; }

        /// <summary>
        ///     认证审核、产品签约审核状态
        /// </summary>
        [XmlElement("result_status")]
        [JsonProperty("result_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultStatus { get; set; }

        /// <summary>
        ///     详情类型，CETIFY为认证，PROD为产品签约，COMMENT为认证审核批注
        /// </summary>
        [XmlElement("result_type")]
        [JsonProperty("result_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultType { get; set; }
    }
}