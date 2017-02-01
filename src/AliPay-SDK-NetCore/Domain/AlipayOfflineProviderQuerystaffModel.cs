using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineProviderQuerystaffModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderQuerystaffModel : AopObject
    {
        /// <summary>
        ///     操作人PID
        /// </summary>
        [XmlElement("ope_pid")]
        [JsonProperty("ope_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string OpePid { get; set; }

        /// <summary>
        ///     页码
        /// </summary>
        [XmlElement("page_no")]
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PageNo { get; set; }

        /// <summary>
        ///     分页大小，<=100
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }

        /// <summary>
        ///     全局唯一的流水号
        /// </summary>
        [XmlElement("request_id")]
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }
    }
}