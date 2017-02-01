using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     Context Data Structure.
    /// </summary>
    [Serializable]
    public class Context : AopObject
    {
        /// <summary>
        ///     底部链接描述文字，如“查看详情”
        /// </summary>
        [XmlElement("action_name")]
        [JsonProperty("action_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionName { get; set; }

        /// <summary>
        ///     模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [XmlElement("first")]
        [JsonProperty("first", NullValueHandling = NullValueHandling.Ignore)]
        public Keyword First { get; set; }

        /// <summary>
        ///     顶部色条的色值
        /// </summary>
        [XmlElement("head_color")]
        [JsonProperty("head_color", NullValueHandling = NullValueHandling.Ignore)]
        public string HeadColor { get; set; }

        /// <summary>
        ///     模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [XmlElement("keyword1")]
        [JsonProperty("keyword1", NullValueHandling = NullValueHandling.Ignore)]
        public Keyword Keyword1 { get; set; }

        /// <summary>
        ///     模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [XmlElement("keyword2")]
        [JsonProperty("keyword2", NullValueHandling = NullValueHandling.Ignore)]
        public Keyword Keyword2 { get; set; }

        /// <summary>
        ///     模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [XmlElement("remark")]
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public Keyword Remark { get; set; }

        /// <summary>
        ///     点击消息后承接页的地址
        /// </summary>
        [XmlElement("url")]
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }
}