using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiQualityTestCloudacptCheckresultSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiQualityTestCloudacptCheckresultSubmitModel : AopObject
    {
        /// <summary>
        ///     活动id
        /// </summary>
        [XmlElement("activity_id")]
        [JsonProperty("activity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityId { get; set; }

        /// <summary>
        ///     付款码
        /// </summary>
        [XmlElement("auth_code")]
        [JsonProperty("auth_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCode { get; set; }

        /// <summary>
        ///     批次ID
        /// </summary>
        [XmlElement("batch_id")]
        [JsonProperty("batch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchId { get; set; }

        /// <summary>
        ///     结束时间
        /// </summary>
        [XmlElement("end_time")]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        ///     partenter id
        /// </summary>
        [XmlElement("pid")]
        [JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public string Pid { get; set; }

        /// <summary>
        ///     开始时间
        /// </summary>
        [XmlElement("start_time")]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        ///     user id
        /// </summary>
        [XmlElement("uid")]
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }
    }
}