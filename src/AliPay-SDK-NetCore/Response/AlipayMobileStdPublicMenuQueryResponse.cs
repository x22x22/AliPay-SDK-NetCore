using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobileStdPublicMenuQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicMenuQueryResponse : AopResponse
    {
        /// <summary>
        ///     所有菜单列表json串
        /// </summary>
        [XmlElement("all_menu_list")]
        [JsonProperty("all_menu_list", NullValueHandling = NullValueHandling.Ignore)]
        public string AllMenuList { get; set; }
    }
}