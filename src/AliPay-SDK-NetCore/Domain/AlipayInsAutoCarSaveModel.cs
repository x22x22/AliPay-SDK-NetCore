using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayInsAutoCarSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoCarSaveModel : AopObject
    {
        /// <summary>
        ///     车牌号
        /// </summary>
        [XmlElement("car_no")]
        [JsonProperty("car_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CarNo { get; set; }

        /// <summary>
        ///     用户ID,车主会员ID
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}