using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReduceToAmtDstCampPrizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ReduceToAmtDstCampPrizeModel : AopObject
    {
        /// <summary>
        /// 优惠后价格
        /// </summary>
        [XmlElement("reduct_to_amt")]
		[JsonProperty("reduct_to_amt", NullValueHandling = NullValueHandling.Ignore)]
        public string ReductToAmt { get; set; }
    }
}
