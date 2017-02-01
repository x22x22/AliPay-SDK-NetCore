using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     QRcode Data Structure.
    /// </summary>
    [Serializable]
    public class QRcode : AopObject
    {
        /// <summary>
        ///     用户ID
        /// </summary>
        [XmlElement("card_id")]
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        ///     qrcode地址
        /// </summary>
        [XmlElement("qrcode_url")]
        [JsonProperty("qrcode_url", NullValueHandling = NullValueHandling.Ignore)]
        public string QrcodeUrl { get; set; }
    }
}