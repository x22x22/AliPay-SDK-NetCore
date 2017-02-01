using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalHospitalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHospitalInfo : AopObject
    {
        /// <summary>
        /// 医院唯一标识，编码开发者生成并保证唯一
        /// </summary>
        [XmlElement("code")]
		[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 医院联系电话
        /// </summary>
        [XmlElement("phone")]
		[JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }
    }
}
