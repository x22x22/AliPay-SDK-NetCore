using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountExrateAdviceAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateAdviceAcceptModel : AopObject
    {
        /// <summary>
        /// 交易请求对象内容
        /// </summary>
        [XmlElement("advice")]
		[JsonProperty("advice", NullValueHandling = NullValueHandling.Ignore)]
        public AdviceVO Advice { get; set; }
    }
}
