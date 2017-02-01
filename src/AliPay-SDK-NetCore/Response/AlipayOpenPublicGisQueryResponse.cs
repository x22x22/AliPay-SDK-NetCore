using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicGisQueryResponse.
    /// </summary>
    public class AlipayOpenPublicGisQueryResponse : AopResponse
    {
        /// <summary>
        /// 精确度
        /// </summary>
        [XmlElement("accuracy")]
		[JsonProperty("accuracy", NullValueHandling = NullValueHandling.Ignore)]
        public string Accuracy { get; set; }

        /// <summary>
        /// 经纬度所在位置
        /// </summary>
        [XmlElement("city")]
		[JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// 纬度信息
        /// </summary>
        [XmlElement("latitude")]
		[JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度信息
        /// </summary>
        [XmlElement("longitude")]
		[JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }

        /// <summary>
        /// 经纬度对应位置所在的省份
        /// </summary>
        [XmlElement("province")]
		[JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }
    }
}
