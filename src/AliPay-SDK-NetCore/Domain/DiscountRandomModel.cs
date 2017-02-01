using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountRandomModel Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountRandomModel : AopObject
    {
        /// <summary>
        /// 最高优惠金额
        /// </summary>
        [XmlElement("max_amount")]
		[JsonProperty("max_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 最低优惠金额
        /// </summary>
        [XmlElement("min_amount")]
		[JsonProperty("min_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string MinAmount { get; set; }

        /// <summary>
        /// 概率 金额区间、占比支持小数点后两位  区间为前闭、后闭，最多可以设置10种金额区间，所有区间占比和需要等于100%
        /// </summary>
        [XmlElement("probability")]
		[JsonProperty("probability", NullValueHandling = NullValueHandling.Ignore)]
        public string Probability { get; set; }
    }
}
