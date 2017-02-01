using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayUserDeliverAddress Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDeliverAddress : AopObject
    {
        /// <summary>
        ///     地址
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
        ///     是否默认收货地址
        /// </summary>
        [XmlElement("default_deliver_address")]
        [JsonProperty("default_deliver_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultDeliverAddress { get; set; }

        /// <summary>
        ///     区/县
        /// </summary>
        [XmlElement("deliver_area")]
        [JsonProperty("deliver_area", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverArea { get; set; }

        /// <summary>
        ///     市
        /// </summary>
        [XmlElement("deliver_city")]
        [JsonProperty("deliver_city", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverCity { get; set; }

        /// <summary>
        ///     收货人全名
        /// </summary>
        [XmlElement("deliver_fullname")]
        [JsonProperty("deliver_fullname", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverFullname { get; set; }

        /// <summary>
        ///     收货地址的联系人移动电话
        /// </summary>
        [XmlElement("deliver_mobile")]
        [JsonProperty("deliver_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverMobile { get; set; }

        /// <summary>
        ///     收货地址的联系人固定电话
        /// </summary>
        [XmlElement("deliver_phone")]
        [JsonProperty("deliver_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverPhone { get; set; }

        /// <summary>
        ///     省
        /// </summary>
        [XmlElement("deliver_province")]
        [JsonProperty("deliver_province", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverProvince { get; set; }

        /// <summary>
        ///     邮编
        /// </summary>
        [XmlElement("zip")]
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }
    }
}