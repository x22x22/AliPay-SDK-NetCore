using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiTradeOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeOrderQueryModel : AopObject
    {
        /// <summary>
        ///     口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        [JsonProperty("order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNo { get; set; }
    }
}