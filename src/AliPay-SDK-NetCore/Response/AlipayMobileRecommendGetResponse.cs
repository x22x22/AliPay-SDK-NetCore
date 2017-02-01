using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobileRecommendGetResponse.
    /// </summary>
    public class AlipayMobileRecommendGetResponse : AopResponse
    {
        /// <summary>
        ///     推荐结果的扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        ///     推荐结果集合, json数组对象, 每个元素至少包含entity_id的属性,其他属性由推荐方案决定。
        /// </summary>
        [XmlElement("items")]
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public string Items { get; set; }

        /// <summary>
        ///     本次推荐的唯一标识
        /// </summary>
        [XmlElement("recommend_id")]
        [JsonProperty("recommend_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecommendId { get; set; }
    }
}