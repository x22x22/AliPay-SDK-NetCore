using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     TemplateCardLevelConfDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateCardLevelConfDTO : AopObject
    {
        /// <summary>
        ///     会员级别 该级别和开卡接口中的levle要一致
        /// </summary>
        [XmlElement("level")]
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        ///     会员级别描述
        /// </summary>
        [XmlElement("level_desc")]
        [JsonProperty("level_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string LevelDesc { get; set; }

        /// <summary>
        ///     会员级别对应icon， 通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        [XmlElement("level_icon")]
        [JsonProperty("level_icon", NullValueHandling = NullValueHandling.Ignore)]
        public string LevelIcon { get; set; }

        /// <summary>
        ///     会员级别显示名称
        /// </summary>
        [XmlElement("level_show_name")]
        [JsonProperty("level_show_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LevelShowName { get; set; }
    }
}