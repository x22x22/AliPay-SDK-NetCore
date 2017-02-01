using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayCommerceCityfacilitatorDepositConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorDepositConfirmModel : AopObject
    {
        /// <summary>
        ///     传递确认的终端信息，终端编号等
        /// </summary>
        [XmlElement("biz_info_ext")]
        [JsonProperty("biz_info_ext", NullValueHandling = NullValueHandling.Ignore)]
        public string BizInfoExt { get; set; }

        /// <summary>
        ///     交通卡号
        /// </summary>
        [XmlElement("card_no")]
        [JsonProperty("card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CardNo { get; set; }

        /// <summary>
        ///     交通卡卡类型，一个城市只有一个固定的值
        /// </summary>
        [XmlElement("card_type")]
        [JsonProperty("card_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CardType { get; set; }

        /// <summary>
        ///     核销时间
        /// </summary>
        [XmlElement("operate_time")]
        [JsonProperty("operate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateTime { get; set; }

        /// <summary>
        ///     商户的交易号
        /// </summary>
        [XmlElement("out_biz_no")]
        [JsonProperty("out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutBizNo { get; set; }

        /// <summary>
        ///     该笔请求的唯一编号，强校验，控制幂等性
        /// </summary>
        [XmlElement("request_id")]
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        ///     支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}