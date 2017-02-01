using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Video Data Structure.
    /// </summary>
    [Serializable]
    public class Video : AopObject
    {
        /// <summary>
        /// 调用alipay.offline.material.image.upload接口将视频上传到素材中心后，生成的ID
        /// </summary>
        [XmlElement("location")]
		[JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// 视频名称
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
