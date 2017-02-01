using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     TemplateOpenCardConfDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateOpenCardConfDTO : AopObject
    {
        /// <summary>
        ///     配置，预留字段，暂时不用
        /// </summary>
        [XmlElement("conf")]
        [JsonProperty("conf", NullValueHandling = NullValueHandling.Ignore)]
        public string Conf { get; set; }

        /// <summary>
        ///     ISV：外部系统  MER：直连商户
        /// </summary>
        [XmlElement("open_card_source_type")]
        [JsonProperty("open_card_source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenCardSourceType { get; set; }

        /// <summary>
        ///     开卡连接，必须http、https开头
        /// </summary>
        [XmlElement("open_card_url")]
        [JsonProperty("open_card_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenCardUrl { get; set; }

        /// <summary>
        ///     渠道APPID，提供领卡页面的服务提供方
        /// </summary>
        [XmlElement("source_app_id")]
        [JsonProperty("source_app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceAppId { get; set; }
    }
}