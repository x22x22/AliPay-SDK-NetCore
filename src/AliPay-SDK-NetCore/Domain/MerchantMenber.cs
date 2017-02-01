using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantMenber Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantMenber : AopObject
    {
        /// <summary>
        /// 生日 yyyy-MM-dd
        /// </summary>
        [XmlElement("birth")]
		[JsonProperty("birth", NullValueHandling = NullValueHandling.Ignore)]
        public string Birth { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("cell")]
		[JsonProperty("cell", NullValueHandling = NullValueHandling.Ignore)]
        public string Cell { get; set; }

        /// <summary>
        /// 性别（男：MALE；女：FEMALE）
        /// </summary>
        [XmlElement("gende")]
		[JsonProperty("gende", NullValueHandling = NullValueHandling.Ignore)]
        public string Gende { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
