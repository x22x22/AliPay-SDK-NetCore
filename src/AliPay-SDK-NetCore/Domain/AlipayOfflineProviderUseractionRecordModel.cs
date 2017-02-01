using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineProviderUseractionRecordModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderUseractionRecordModel : AopObject
    {
        /// <summary>
        ///     行为描述 json格式，有特定的字段(太大的话可能会导致内部处理失败)
        /// </summary>
        [XmlElement("action_detail")]
        [JsonProperty("action_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionDetail { get; set; }

        /// <summary>
        ///     本次请求的唯一键（操作实体主键+平台字符串）
        /// </summary>
        [XmlElement("action_outer_id")]
        [JsonProperty("action_outer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionOuterId { get; set; }

        /// <summary>
        ///     行为类型（点菜ORDER_DISHES、点歌、领取号）
        /// </summary>
        [XmlElement("action_type")]
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionType { get; set; }

        /// <summary>
        ///     插件ID（用户在您的那个插件发生的行为）
        /// </summary>
        [XmlElement("alipay_app_id")]
        [JsonProperty("alipay_app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayAppId { get; set; }

        /// <summary>
        ///     行为发生时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("date_time")]
        [JsonProperty("date_time", NullValueHandling = NullValueHandling.Ignore)]
        public string DateTime { get; set; }

        /// <summary>
        ///     user用户实体
        /// </summary>
        [XmlElement("entity")]
        [JsonProperty("entity", NullValueHandling = NullValueHandling.Ignore)]
        public string Entity { get; set; }

        /// <summary>
        ///     所属行业 (餐饮：REPAST)
        /// </summary>
        [XmlElement("industry")]
        [JsonProperty("industry", NullValueHandling = NullValueHandling.Ignore)]
        public string Industry { get; set; }

        /// <summary>
        ///     电话号码
        /// </summary>
        [XmlElement("mobile")]
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }

        /// <summary>
        ///     合作店铺对象 信息
        /// </summary>
        [XmlElement("outer_shop_do")]
        [JsonProperty("outer_shop_do", NullValueHandling = NullValueHandling.Ignore)]
        public OuterShopDO OuterShopDo { get; set; }

        /// <summary>
        ///     Source对应平台用户ID
        /// </summary>
        [XmlElement("platform_user_id")]
        [JsonProperty("platform_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformUserId { get; set; }

        /// <summary>
        ///     平台来源域名
        /// </summary>
        [XmlElement("source")]
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        ///     source对应平台的id
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}