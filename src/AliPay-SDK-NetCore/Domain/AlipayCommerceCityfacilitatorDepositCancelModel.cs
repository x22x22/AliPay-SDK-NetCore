using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayCommerceCityfacilitatorDepositCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorDepositCancelModel : AopObject
    {
        /// <summary>
        ///     扩展字段，传递撤销的终端信息，原因等
        /// </summary>
        [XmlElement("biz_info_ext")]
        [JsonProperty("biz_info_ext", NullValueHandling = NullValueHandling.Ignore)]
        public string BizInfoExt { get; set; }

        /// <summary>
        ///     充值卡号
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
        ///     撤销时间
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
        ///     交易号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}