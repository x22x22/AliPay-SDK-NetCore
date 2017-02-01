using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduWorkAddress Data Structure.
    /// </summary>
    [Serializable]
    public class EduWorkAddress : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
		[JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
		[JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("district_name")]
		[JsonProperty("district_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DistrictName { get; set; }

        /// <summary>
        /// 北京市
        /// </summary>
        [XmlElement("province")]
		[JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [XmlElement("street_name")]
		[JsonProperty("street_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetName { get; set; }
    }
}
