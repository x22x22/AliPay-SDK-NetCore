using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarViolationInfoPushModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarViolationInfoPushModel : AopObject
    {
        /// <summary>
        ///     1:可在线处理, 2:不可在线处理, 3:需查询确定
        /// </summary>
        [XmlElement("deal_type")]
        [JsonProperty("deal_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DealType { get; set; }

        /// <summary>
        ///     暂无
        /// </summary>
        [XmlElement("push_type")]
        [JsonProperty("push_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PushType { get; set; }

        /// <summary>
        ///     违章地点
        /// </summary>
        [XmlElement("vi_address")]
        [JsonProperty("vi_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ViAddress { get; set; }

        /// <summary>
        ///     违章罚款金额
        /// </summary>
        [XmlElement("vi_fine")]
        [JsonProperty("vi_fine", NullValueHandling = NullValueHandling.Ignore)]
        public string ViFine { get; set; }

        /// <summary>
        ///     是否已处理, 0:已处理，1:未处理
        /// </summary>
        [XmlElement("vi_handled")]
        [JsonProperty("vi_handled", NullValueHandling = NullValueHandling.Ignore)]
        public string ViHandled { get; set; }

        /// <summary>
        ///     车牌号
        /// </summary>
        [XmlElement("vi_number")]
        [JsonProperty("vi_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ViNumber { get; set; }

        /// <summary>
        ///     违章扣分
        /// </summary>
        [XmlElement("vi_point")]
        [JsonProperty("vi_point", NullValueHandling = NullValueHandling.Ignore)]
        public string ViPoint { get; set; }

        /// <summary>
        ///     违章时间(yyyyMMddhhmmss)
        /// </summary>
        [XmlElement("vi_time")]
        [JsonProperty("vi_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ViTime { get; set; }

        /// <summary>
        ///     违章行为
        /// </summary>
        [XmlElement("vi_type")]
        [JsonProperty("vi_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ViType { get; set; }
    }
}