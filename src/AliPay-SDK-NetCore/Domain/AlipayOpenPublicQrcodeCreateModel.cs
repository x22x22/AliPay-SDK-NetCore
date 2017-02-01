using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenPublicQrcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicQrcodeCreateModel : AopObject
    {
        /// <summary>
        ///     服务窗创建带参二维码接口，开发者自定义信息
        /// </summary>
        [XmlElement("code_info")]
        [JsonProperty("code_info", NullValueHandling = NullValueHandling.Ignore)]
        public CodeInfo CodeInfo { get; set; }

        /// <summary>
        ///     二维码类型，目前只支持两种类型：  TEMP：临时的（默认）；  PERM：永久的
        /// </summary>
        [XmlElement("code_type")]
        [JsonProperty("code_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeType { get; set; }

        /// <summary>
        ///     临时码过期时间，以秒为单位，最大不超过1800秒；  永久码置空
        /// </summary>
        [XmlElement("expire_second")]
        [JsonProperty("expire_second", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireSecond { get; set; }

        /// <summary>
        ///     二维码中间是否显示服务窗logo，Y：显示；N：不显示（默认）
        /// </summary>
        [XmlElement("show_logo")]
        [JsonProperty("show_logo", NullValueHandling = NullValueHandling.Ignore)]
        public string ShowLogo { get; set; }
    }
}