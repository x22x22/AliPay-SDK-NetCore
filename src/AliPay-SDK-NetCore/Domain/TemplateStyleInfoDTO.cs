using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     TemplateStyleInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateStyleInfoDTO : AopObject
    {
        /// <summary>
        ///     背景图片Id，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：2M以内，格式：bmp、png、jpeg、jpg、gif；  尺寸不小于1020*643px；
        ///     图片不得有圆角，不得拉伸变形
        /// </summary>
        [XmlElement("background_id")]
        [JsonProperty("background_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundId { get; set; }

        /// <summary>
        ///     背景色
        /// </summary>
        [XmlElement("bg_color")]
        [JsonProperty("bg_color", NullValueHandling = NullValueHandling.Ignore)]
        public string BgColor { get; set; }

        /// <summary>
        ///     品牌商名称
        /// </summary>
        [XmlElement("brand_name")]
        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        ///     钱包端显示名称（字符串长度）
        /// </summary>
        [XmlElement("card_show_name")]
        [JsonProperty("card_show_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CardShowName { get; set; }

        /// <summary>
        ///     卡片颜色
        /// </summary>
        [XmlElement("color")]
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        ///     特色信息，用于领卡预览
        /// </summary>
        [XmlArray("feature_descriptions")]
        [XmlArrayItem("string")]
        public List<string> FeatureDescriptions { get; set; }

        /// <summary>
        ///     logo的图片ID，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；  尺寸不小于500*500px的正方形；
        ///     请优先使用商家LOGO；
        /// </summary>
        [XmlElement("logo_id")]
        [JsonProperty("logo_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoId { get; set; }

        /// <summary>
        ///     标语
        /// </summary>
        [XmlElement("slogan")]
        [JsonProperty("slogan", NullValueHandling = NullValueHandling.Ignore)]
        public string Slogan { get; set; }

        /// <summary>
        ///     标语图片， 通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        [XmlElement("slogan_img_id")]
        [JsonProperty("slogan_img_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SloganImgId { get; set; }
    }
}