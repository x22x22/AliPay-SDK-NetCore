using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorDepositQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorDepositQueryModel : AopObject
    {
        /// <summary>
        /// 交通卡号
        /// </summary>
        [XmlElement("card_no")]
		[JsonProperty("card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CardNo { get; set; }

        /// <summary>
        /// 和渠道定义的卡类型，一个城市支持一种卡类型
        /// </summary>
        [XmlElement("card_type")]
		[JsonProperty("card_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CardType { get; set; }

        /// <summary>
        /// transfer：待圈存 success：圈存成功 fail：圈存失败
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}
