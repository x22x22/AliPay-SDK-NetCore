using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     TradeFundBill Data Structure.
    /// </summary>
    [Serializable]
    public class TradeFundBill : AopObject
    {
        /// <summary>
        ///     该支付工具类型所使用的金额
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     交易使用的资金渠道，详见 <a href="https://doc.open.alipay.com/doc2/detail?treeId=26&articleId=103259&docType=1">支付渠道列表</a>
        /// </summary>
        [XmlElement("fund_channel")]
        [JsonProperty("fund_channel", NullValueHandling = NullValueHandling.Ignore)]
        public string FundChannel { get; set; }

        /// <summary>
        ///     渠道实际付款金额
        /// </summary>
        [XmlElement("real_amount")]
        [JsonProperty("real_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RealAmount { get; set; }
    }
}