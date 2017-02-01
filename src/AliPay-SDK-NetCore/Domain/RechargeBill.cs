using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RechargeBill Data Structure.
    /// </summary>
    [Serializable]
    public class RechargeBill : AopObject
    {
        /// <summary>
        /// 用户充值金额，单位为元
        /// </summary>
        [XmlElement("amount")]
		[JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 充值时间：YYYY-MM-DD hh:mm:ss
        /// </summary>
        [XmlElement("deposit_time")]
		[JsonProperty("deposit_time", NullValueHandling = NullValueHandling.Ignore)]
        public string DepositTime { get; set; }

        /// <summary>
        /// Transfer：待圈存  Success：圈存成功  Fail：圈存失败
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("trade_no")]
		[JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}
