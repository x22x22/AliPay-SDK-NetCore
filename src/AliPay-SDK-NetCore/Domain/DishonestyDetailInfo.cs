using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DishonestyDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DishonestyDetailInfo : AopObject
    {
        /// <summary>
        /// 被执行人行为具体情况
        /// </summary>
        [XmlElement("behavior")]
		[JsonProperty("behavior", NullValueHandling = NullValueHandling.Ignore)]
        public string Behavior { get; set; }

        /// <summary>
        /// 案号
        /// </summary>
        [XmlElement("case_code")]
		[JsonProperty("case_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseCode { get; set; }

        /// <summary>
        /// 执行法院
        /// </summary>
        [XmlElement("enforce_court")]
		[JsonProperty("enforce_court", NullValueHandling = NullValueHandling.Ignore)]
        public string EnforceCourt { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_number")]
		[JsonProperty("id_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IdNumber { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 被执行人履行情况
        /// </summary>
        [XmlElement("performance")]
		[JsonProperty("performance", NullValueHandling = NullValueHandling.Ignore)]
        public string Performance { get; set; }

        /// <summary>
        /// 发布日期
        /// </summary>
        [XmlElement("publish_date")]
		[JsonProperty("publish_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDate { get; set; }

        /// <summary>
        /// 所在区域
        /// </summary>
        [XmlElement("region")]
		[JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }
    }
}
