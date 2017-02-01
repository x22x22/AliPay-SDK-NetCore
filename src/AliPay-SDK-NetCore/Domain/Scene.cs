using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     Scene Data Structure.
    /// </summary>
    [Serializable]
    public class Scene : AopObject
    {
        /// <summary>
        ///     场景Id，最长32位，英文字母、数字以及下划线，开发者自定义
        /// </summary>
        [XmlElement("scene_id")]
        [JsonProperty("scene_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SceneId { get; set; }
    }
}