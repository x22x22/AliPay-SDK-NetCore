using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     YLBTransDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YLBTransDetailInfo : AopObject
    {
        /// <summary>
        ///     余利宝交易金额，单位为元
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     交易流水号
        /// </summary>
        [XmlElement("biz_no")]
        [JsonProperty("biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizNo { get; set; }

        /// <summary>
        ///     备注信息
        /// </summary>
        [XmlElement("memo")]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        ///     交易到账时间
        /// </summary>
        [XmlElement("trans_account_date")]
        [JsonProperty("trans_account_date", NullValueHandling = NullValueHandling.Ignore)]
        public string TransAccountDate { get; set; }

        /// <summary>
        ///     交易时间
        /// </summary>
        [XmlElement("trans_date")]
        [JsonProperty("trans_date", NullValueHandling = NullValueHandling.Ignore)]
        public string TransDate { get; set; }

        /// <summary>
        ///     交易名称，如正常申购、正常赎回、收益发放、份额强增、份额强减
        /// </summary>
        [XmlElement("trans_name")]
        [JsonProperty("trans_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TransName { get; set; }

        /// <summary>
        ///     交易状态，如success-成功、failure-失败、inprocess-进行中等
        /// </summary>
        [XmlElement("trans_status")]
        [JsonProperty("trans_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TransStatus { get; set; }

        /// <summary>
        ///     交易类型，如正常申购、正常赎回、收益发放、份额强增、份额强减
        /// </summary>
        [XmlElement("trans_type")]
        [JsonProperty("trans_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TransType { get; set; }
    }
}