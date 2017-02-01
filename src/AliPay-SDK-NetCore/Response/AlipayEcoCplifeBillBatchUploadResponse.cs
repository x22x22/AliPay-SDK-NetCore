using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCplifeBillBatchUploadResponse.
    /// </summary>
    public class AlipayEcoCplifeBillBatchUploadResponse : AopResponse
    {
        /// <summary>
        /// 成功导入所有条目集合中的条目，则回传请求中的批次号
        /// </summary>
        [XmlElement("batch_id")]
		[JsonProperty("batch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchId { get; set; }
    }
}
