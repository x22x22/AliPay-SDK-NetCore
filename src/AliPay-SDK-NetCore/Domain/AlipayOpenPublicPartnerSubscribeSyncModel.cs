using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenPublicPartnerSubscribeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPartnerSubscribeSyncModel : AopObject
    {
        /// <summary>
        ///     是否接受服务窗消息
        /// </summary>
        [XmlElement("accept_msg")]
        [JsonProperty("accept_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptMsg { get; set; }

        /// <summary>
        ///     关注的服务窗id
        /// </summary>
        [XmlElement("follow_object_id")]
        [JsonProperty("follow_object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowObjectId { get; set; }

        /// <summary>
        ///     操作类型，添加关注或取消关注
        /// </summary>
        [XmlElement("operate_type")]
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        ///     是否打开接收公众号PUSH提醒开关 ON:打开 OFF:关闭
        /// </summary>
        [XmlElement("push_switch")]
        [JsonProperty("push_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string PushSwitch { get; set; }

        /// <summary>
        ///     关注来源
        /// </summary>
        [XmlElement("source_id")]
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        ///     关注服务窗的用户id
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}