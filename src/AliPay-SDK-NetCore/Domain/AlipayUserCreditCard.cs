using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCreditCard Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCreditCard : AopObject
    {
        /// <summary>
        /// 信用卡卡号，显示前6后2
        /// </summary>
        [XmlElement("card_no")]
		[JsonProperty("card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CardNo { get; set; }

        /// <summary>
        /// 开户行代码
        /// </summary>
        [XmlElement("inst_id")]
		[JsonProperty("inst_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstId { get; set; }
    }
}
