using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMaterialImageUploadResponse.
    /// </summary>
    public class AlipayOfflineMaterialImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片/视频在商家中心的唯一标识
        /// </summary>
        [XmlElement("image_id")]
		[JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 图片/视频的访问地址（为了防止盗链，该地址不允许嵌在其他页面展示，只能在新页面展示）
        /// </summary>
        [XmlElement("image_url")]
		[JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }
    }
}
