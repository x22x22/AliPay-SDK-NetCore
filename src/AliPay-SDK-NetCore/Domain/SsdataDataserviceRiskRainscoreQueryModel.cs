using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     SsdataDataserviceRiskRainscoreQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskRainscoreQueryModel : AopObject
    {
        /// <summary>
        ///     帐号内容，目前为中国大陆手机号（11位阿拉伯数字，不包含特殊符号或空格）
        /// </summary>
        [XmlElement("account")]
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        ///     账号类型，目前仅支持手机号（MOBILE_NO）
        /// </summary>
        [XmlElement("account_type")]
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountType { get; set; }

        /// <summary>
        ///     “蚁盾”风险评分服务版本号，当前版本为2.0
        /// </summary>
        [XmlElement("version")]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }
}