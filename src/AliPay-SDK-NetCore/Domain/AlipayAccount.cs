using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayAccount Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccount : AopObject
    {
        /// <summary>
        ///     支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        [JsonProperty("alipay_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayUserId { get; set; }

        /// <summary>
        ///     可用余额
        /// </summary>
        [XmlElement("available_amount")]
        [JsonProperty("available_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailableAmount { get; set; }

        /// <summary>
        ///     不可用余额
        /// </summary>
        [XmlElement("freeze_amount")]
        [JsonProperty("freeze_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string FreezeAmount { get; set; }

        /// <summary>
        ///     余额总额
        /// </summary>
        [XmlElement("total_amount")]
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }
    }
}