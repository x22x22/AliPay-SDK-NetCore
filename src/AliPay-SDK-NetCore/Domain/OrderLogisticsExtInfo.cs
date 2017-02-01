using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderLogisticsExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderLogisticsExtInfo : AopObject
    {
        /// <summary>
        /// 服务结束时间，格式为yyyy-MM-dd HH:mm（到分）
        /// </summary>
        [XmlElement("gmt_end")]
		[JsonProperty("gmt_end", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 服务开始时间，格式为yyyy-MM-dd HH:mm（到分）
        /// </summary>
        [XmlElement("gmt_start")]
		[JsonProperty("gmt_start", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtStart { get; set; }
    }
}
