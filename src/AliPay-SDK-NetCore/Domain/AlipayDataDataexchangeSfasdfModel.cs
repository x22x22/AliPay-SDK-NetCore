using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayDataDataexchangeSfasdfModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeSfasdfModel : AopObject
    {
        /// <summary>
        ///     sdafsdfsaf
        /// </summary>
        [XmlElement("adsfghjf")]
        [JsonProperty("adsfghjf", NullValueHandling = NullValueHandling.Ignore)]
        public AlipayItemVoucherTemplete Adsfghjf { get; set; }

        /// <summary>
        ///     ghjffdssfghj
        /// </summary>
        [XmlArray("easadasfd")]
        [XmlArrayItem("string")]
        public List<string> Easadasfd { get; set; }

        /// <summary>
        ///     dsfghdsagfhd
        /// </summary>
        [XmlArray("gdfsa")]
        [XmlArrayItem("string")]
        public List<string> Gdfsa { get; set; }

        /// <summary>
        ///     ghjkhg
        /// </summary>
        [XmlElement("hjgdfs")]
        [JsonProperty("hjgdfs", NullValueHandling = NullValueHandling.Ignore)]
        public string Hjgdfs { get; set; }

        /// <summary>
        ///     sdgfjhkg
        /// </summary>
        [XmlArray("sdfgsdfg")]
        [XmlArrayItem("string")]
        public List<string> Sdfgsdfg { get; set; }

        /// <summary>
        ///     ASGFDGASaaf
        /// </summary>
        [XmlArray("wehtegf")]
        [XmlArrayItem("string")]
        public List<string> Wehtegf { get; set; }
    }
}