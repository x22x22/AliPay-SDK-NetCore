using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsMktObjectDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktObjectDTO : AopObject
    {
        /// <summary>
        /// 活动标的id
        /// </summary>
        [XmlElement("obj_id")]
		[JsonProperty("obj_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjId { get; set; }

        /// <summary>
        /// 标的类型
        /// </summary>
        [XmlElement("type")]
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public long Type { get; set; }
    }
}
