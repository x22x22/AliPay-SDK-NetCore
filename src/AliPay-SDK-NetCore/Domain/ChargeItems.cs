using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ChargeItems Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeItems : AopObject
    {
        /// <summary>
        ///     缴费项名称
        /// </summary>
        [XmlElement("item_name")]
        [JsonProperty("item_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemName { get; set; }

        /// <summary>
        ///     缴费项金额
        /// </summary>
        [XmlElement("item_price")]
        [JsonProperty("item_price", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemPrice { get; set; }
    }
}