using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcardEduPublicBindResponse.
    /// </summary>
    public class AlipayEcardEduPublicBindResponse : AopResponse
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("agent_code")]
		[JsonProperty("agent_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentCode { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
		[JsonProperty("card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CardNo { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("return_code")]
		[JsonProperty("return_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnCode { get; set; }
    }
}
