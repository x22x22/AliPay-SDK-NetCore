using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingToolPointsQueryResponse.
    /// </summary>
    public class KoubeiMarketingToolPointsQueryResponse : AopResponse
    {
        /// <summary>
        /// 可用集点
        /// </summary>
        [XmlElement("available_points")]
		[JsonProperty("available_points", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailablePoints { get; set; }

        /// <summary>
        /// 冻结集点
        /// </summary>
        [XmlElement("freezed_points")]
		[JsonProperty("freezed_points", NullValueHandling = NullValueHandling.Ignore)]
        public string FreezedPoints { get; set; }

        /// <summary>
        /// 累计集点
        /// </summary>
        [XmlElement("total_points")]
		[JsonProperty("total_points", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPoints { get; set; }
    }
}
