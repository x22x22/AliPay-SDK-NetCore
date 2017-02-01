using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipaySecurityProdFacerepoSearchResponse.
    /// </summary>
    public class AlipaySecurityProdFacerepoSearchResponse : AopResponse
    {
        /// <summary>
        ///     扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        ///     从入参指定的人脸库分组中搜索出来的相似度最高的人脸id
        /// </summary>
        [XmlElement("face_id")]
        [JsonProperty("face_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceId { get; set; }
    }
}