using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflinePayMasterKey Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflinePayMasterKey : AopObject
    {
        /// <summary>
        ///     秘钥id
        /// </summary>
        [XmlElement("key_id")]
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public long KeyId { get; set; }

        /// <summary>
        ///     支付宝脱机服务公钥
        /// </summary>
        [XmlElement("public_key")]
        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }
    }
}