using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineTrade Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineTrade : AopObject
    {
        /// <summary>
        ///     交易实际发生时间
        /// </summary>
        [XmlElement("actual_order_time")]
        [JsonProperty("actual_order_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualOrderTime { get; set; }

        /// <summary>
        ///     交易金额
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     交易扩展信息,json格式字符串。
        /// </summary>
        [XmlElement("order_biz_context")]
        [JsonProperty("order_biz_context", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderBizContext { get; set; }

        /// <summary>
        ///     支付宝外部交易号，唯一表示一笔商户支付宝交易。商户必须保证唯一。
        /// </summary>
        [XmlElement("out_trade_no")]
        [JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        ///     原始脱机操作记录
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("string")]
        public List<string> Records { get; set; }

        /// <summary>
        ///     如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [XmlElement("seller_login_name")]
        [JsonProperty("seller_login_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerLoginName { get; set; }

        /// <summary>
        ///     脱机交易标题
        /// </summary>
        [XmlElement("subject")]
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        ///     用户id
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}