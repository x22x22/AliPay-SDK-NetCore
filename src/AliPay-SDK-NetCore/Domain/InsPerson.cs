using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsPerson Data Structure.
    /// </summary>
    [Serializable]
    public class InsPerson : AopObject
    {
        /// <summary>
        ///     地址
        /// </summary>
        [XmlElement("address")]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        ///     生日
        /// </summary>
        [XmlElement("birthday")]
        [JsonProperty("birthday", NullValueHandling = NullValueHandling.Ignore)]
        public string Birthday { get; set; }

        /// <summary>
        ///     投保参数;标准json格式
        /// </summary>
        [XmlElement("biz_data")]
        [JsonProperty("biz_data", NullValueHandling = NullValueHandling.Ignore)]
        public string BizData { get; set; }

        /// <summary>
        ///     证件上名称;如果渠道账号字段没填则必填
        /// </summary>
        [XmlElement("cert_name")]
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        ///     证件号码;如果渠道账号字段没填则必填
        /// </summary>
        [XmlElement("cert_no")]
        [JsonProperty("cert_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CertNo { get; set; }

        /// <summary>
        ///     证件类型;如果渠道账号字段没填则必填   100:居民身份证;102:护照;103:军官证;104:士兵证;105:港澳居民往来内地通行证;106:台湾同胞往来大陆通行证;109:警官证
        /// </summary>
        [XmlElement("cert_type")]
        [JsonProperty("cert_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CertType { get; set; }

        /// <summary>
        ///     渠道账号对应的uid;如果证件类型字段没填则必填
        /// </summary>
        [XmlElement("channel_user_id")]
        [JsonProperty("channel_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelUserId { get; set; }

        /// <summary>
        ///     渠道账号来源;1:支付宝账号 2:淘宝账号;如果证件类型字段没填则必填
        /// </summary>
        [XmlElement("channel_user_source")]
        [JsonProperty("channel_user_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelUserSource { get; set; }

        /// <summary>
        ///     邮箱
        /// </summary>
        [XmlElement("email")]
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        ///     性别;M:男 F:女
        /// </summary>
        [XmlElement("gender")]
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public string Gender { get; set; }

        /// <summary>
        ///     电话号码
        /// </summary>
        [XmlElement("phone")]
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        ///     支付宝会员ID;如果是投保人则必填
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}