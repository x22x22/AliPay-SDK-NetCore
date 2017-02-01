using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsAddressee Data Structure.
    /// </summary>
    [Serializable]
    public class InsAddressee : AopObject
    {
        /// <summary>
        ///     收件人详细地址
        /// </summary>
        [XmlElement("address")]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        ///     区域编码
        /// </summary>
        [XmlElement("address_code")]
        [JsonProperty("address_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressCode { get; set; }

        /// <summary>
        ///     联系地址-城区
        /// </summary>
        [XmlElement("area")]
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        ///     联系地址-城市
        /// </summary>
        [XmlElement("city")]
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        ///     联系方式(mobile登录号)
        /// </summary>
        [XmlElement("mobile")]
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }

        /// <summary>
        ///     收件人姓名
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///     联系地址-电话
        /// </summary>
        [XmlElement("phone")]
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        ///     联系地址-省份
        /// </summary>
        [XmlElement("province")]
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        ///     联系地址-邮编
        /// </summary>
        [XmlElement("zip")]
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }
    }
}