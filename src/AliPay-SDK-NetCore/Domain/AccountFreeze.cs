using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AccountFreeze Data Structure.
    /// </summary>
    [Serializable]
    public class AccountFreeze : AopObject
    {
        /// <summary>
        ///     冻结金额
        /// </summary>
        [XmlElement("freeze_amount")]
        [JsonProperty("freeze_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string FreezeAmount { get; set; }

        /// <summary>
        ///     冻结类型名称
        /// </summary>
        [XmlElement("freeze_name")]
        [JsonProperty("freeze_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FreezeName { get; set; }

        /// <summary>
        ///     冻结类型值
        /// </summary>
        [XmlElement("freeze_type")]
        [JsonProperty("freeze_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FreezeType { get; set; }
    }
}