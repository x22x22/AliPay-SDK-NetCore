using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     IndividualInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndividualInfo : AopObject
    {
        /// <summary>
        ///     生日
        /// </summary>
        [XmlElement("date_of_birth")]
        [JsonProperty("date_of_birth", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfBirth { get; set; }

        /// <summary>
        ///     证件号码
        /// </summary>
        [XmlElement("id_number")]
        [JsonProperty("id_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IdNumber { get; set; }

        /// <summary>
        ///     个人名字
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///     国籍
        /// </summary>
        [XmlElement("nationality")]
        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        /// <summary>
        ///     个人居住地
        /// </summary>
        [XmlElement("residential_address")]
        [JsonProperty("residential_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ResidentialAddress { get; set; }

        /// <summary>
        ///     该个体的类型
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}