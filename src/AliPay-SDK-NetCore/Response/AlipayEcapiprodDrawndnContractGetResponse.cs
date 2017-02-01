using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnContractGetResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnContractGetResponse : AopResponse
    {
        /// <summary>
        /// 合同的内容文本 String 合同的内容文本，为HTML格式
        /// </summary>
        [XmlElement("contract_content")]
		[JsonProperty("contract_content", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractContent { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
		[JsonProperty("contract_no", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractNo { get; set; }

        /// <summary>
        /// 唯一标识这次请求
        /// </summary>
        [XmlElement("request_id")]
		[JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }
    }
}
