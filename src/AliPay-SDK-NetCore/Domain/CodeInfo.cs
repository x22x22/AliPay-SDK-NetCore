using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CodeInfo : AopObject
    {
        /// <summary>
        /// 跳转URL，扫码关注服务窗后会直接跳转到此URL
        /// </summary>
        [XmlElement("goto_url")]
		[JsonProperty("goto_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        [XmlElement("scene")]
		[JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public Scene Scene { get; set; }
    }
}
