using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopCommentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopCommentInfo : AopObject
    {
        /// <summary>
        /// 门店评分，评分越高，门店质量越高
        /// </summary>
        [XmlElement("score")]
		[JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public string Score { get; set; }

        /// <summary>
        /// 门店星级，0~5,越高，店铺质量越高
        /// </summary>
        [XmlElement("star")]
		[JsonProperty("star", NullValueHandling = NullValueHandling.Ignore)]
        public string Star { get; set; }
    }
}
