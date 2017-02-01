using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiMarketingDataMessageDeliverModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataMessageDeliverModel : AopObject
    {
        /// <summary>
        ///     消息内容，json格式， KEY值编号递增
        /// </summary>
        [XmlElement("content")]
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        ///     扩展信息， json格式，  key值：  REDIRECT_URL跳转地址;   CHANNEL发送渠道，对应value值为：MSGBOX消息盒子，PUSH手机消息通知
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        ///     消息业务类型  活动推荐消息：PROMO_RECOMMEND;  活动效果消息: PROMO_STAT
        /// </summary>
        [XmlElement("msg_type")]
        [JsonProperty("msg_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MsgType { get; set; }
    }
}