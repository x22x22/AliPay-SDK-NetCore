using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     XXXXsdasdasd Data Structure.
    /// </summary>
    [Serializable]
    public class XXXXsdasdasd : AopObject
    {
        /// <summary>
        ///     sdfghsgafds
        /// </summary>
        [XmlElement("wasfdasdf")]
        [JsonProperty("wasfdasdf", NullValueHandling = NullValueHandling.Ignore)]
        public string Wasfdasdf { get; set; }
    }
}