using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataExternalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataExternalQueryModel : AopObject
    {
        /// <summary>
        /// external_system_name
        /// </summary>
        [XmlElement("external_system_name")]
		[JsonProperty("external_system_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// is_transfer_uid
        /// </summary>
        [XmlElement("is_transfer_uid")]
		[JsonProperty("is_transfer_uid", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsTransferUid { get; set; }

        /// <summary>
        /// operate_type
        /// </summary>
        [XmlElement("operate_type")]
		[JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        /// query_condition
        /// </summary>
        [XmlElement("query_condition")]
		[JsonProperty("query_condition", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryCondition { get; set; }
    }
}
