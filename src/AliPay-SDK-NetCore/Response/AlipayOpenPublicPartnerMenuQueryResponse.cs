using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOpenPublicPartnerMenuQueryResponse.
    /// </summary>
    public class AlipayOpenPublicPartnerMenuQueryResponse : AopResponse
    {
        /// <summary>
        ///     服务窗菜单
        /// </summary>
        [XmlElement("public_menu")]
        [JsonProperty("public_menu", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicMenu { get; set; }
    }
}