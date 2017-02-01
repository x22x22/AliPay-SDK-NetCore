using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonDescInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommonDescInfo : AopObject
    {
        /// <summary>
        /// 图片URL地址，最大不超过60K，必须使用https
        /// </summary>
        [XmlElement("img")]
		[JsonProperty("img", NullValueHandling = NullValueHandling.Ignore)]
        public string Img { get; set; }

        /// <summary>
        /// 文本描述
        /// </summary>
        [XmlElement("text")]
		[JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
    }
}
