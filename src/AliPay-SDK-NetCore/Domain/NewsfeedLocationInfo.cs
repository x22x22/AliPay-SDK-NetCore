using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsfeedLocationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedLocationInfo : AopObject
    {
        /// <summary>
        /// 地理信息
        /// </summary>
        [XmlElement("ad_code")]
		[JsonProperty("ad_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AdCode { get; set; }

        /// <summary>
        /// 纬度 latitude（填写非0非1）
        /// </summary>
        [XmlElement("lat")]
		[JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public string Lat { get; set; }

        /// <summary>
        /// 经度 longitude（填写非0非1）
        /// </summary>
        [XmlElement("lon")]
		[JsonProperty("lon", NullValueHandling = NullValueHandling.Ignore)]
        public string Lon { get; set; }
    }
}
