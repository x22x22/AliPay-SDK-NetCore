using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     MedicalHospitalDoctorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHospitalDoctorInfo : AopObject
    {
        /// <summary>
        ///     医生唯一标识，编码开发者生成并保证唯一
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        ///     医生名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///     性别  女性：F  男性：M  未知：U
        /// </summary>
        [XmlElement("sex")]
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }
    }
}