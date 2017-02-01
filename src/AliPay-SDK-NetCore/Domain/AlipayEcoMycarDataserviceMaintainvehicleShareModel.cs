using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarDataserviceMaintainvehicleShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataserviceMaintainvehicleShareModel : AopObject
    {
        /// <summary>
        ///     车辆ID
        /// </summary>
        [XmlElement("vid")]
        [JsonProperty("vid", NullValueHandling = NullValueHandling.Ignore)]
        public string Vid { get; set; }
    }
}