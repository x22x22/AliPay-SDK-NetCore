using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayUserPicture Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPicture : AopObject
    {
        /// <summary>
        ///     图片类型，包括身份证正反面、营业执照等
        /// </summary>
        [XmlElement("picture_type")]
        [JsonProperty("picture_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PictureType { get; set; }

        /// <summary>
        ///     用于调用alipay.user.certify.image.fetch接口，获取图片资源
        /// </summary>
        [XmlElement("picture_url")]
        [JsonProperty("picture_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PictureUrl { get; set; }
    }
}