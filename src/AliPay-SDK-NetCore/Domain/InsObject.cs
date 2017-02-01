using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsObject Data Structure.
    /// </summary>
    [Serializable]
    public class InsObject : AopObject
    {
        /// <summary>
        ///     标的物的标识id
        /// </summary>
        [XmlElement("insured_object_id")]
        [JsonProperty("insured_object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InsuredObjectId { get; set; }

        /// <summary>
        ///     标的信息;标准json 格式
        /// </summary>
        [XmlElement("insured_object_info")]
        [JsonProperty("insured_object_info", NullValueHandling = NullValueHandling.Ignore)]
        public string InsuredObjectInfo { get; set; }

        /// <summary>
        ///     标的类型;0:财产所在地;1:其它;2:车;3:资金债务;4:电商订单
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public long Type { get; set; }
    }
}