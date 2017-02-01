using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasPromotionCpainfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasPromotionCpainfoCreateModel : AopObject
    {
        /// <summary>
        /// 唯一应用
        /// </summary>
        [XmlElement("app_id")]
		[JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 应用版本
        /// </summary>
        [XmlElement("app_version")]
		[JsonProperty("app_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AppVersion { get; set; }

        /// <summary>
        /// bundle_id
        /// </summary>
        [XmlElement("bundle_id")]
		[JsonProperty("bundle_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BundleId { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("channel_id")]
		[JsonProperty("channel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelId { get; set; }

        /// <summary>
        /// 调试数据
        /// </summary>
        [XmlElement("debug")]
		[JsonProperty("debug", NullValueHandling = NullValueHandling.Ignore)]
        public string Debug { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend")]
		[JsonProperty("extend", NullValueHandling = NullValueHandling.Ignore)]
        public string Extend { get; set; }

        /// <summary>
        /// IDFA
        /// </summary>
        [XmlElement("idfa")]
		[JsonProperty("idfa", NullValueHandling = NullValueHandling.Ignore)]
        public string Idfa { get; set; }

        /// <summary>
        /// IOS版本
        /// </summary>
        [XmlElement("ios_version")]
		[JsonProperty("ios_version", NullValueHandling = NullValueHandling.Ignore)]
        public string IosVersion { get; set; }

        /// <summary>
        /// MAC
        /// </summary>
        [XmlElement("mac")]
		[JsonProperty("mac", NullValueHandling = NullValueHandling.Ignore)]
        public string Mac { get; set; }
    }
}
