using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarMaintainOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMaintainOrderCreateModel : AopObject
    {
        /// <summary>
        ///     业务订单状态
        /// </summary>
        [XmlElement("biz_status")]
        [JsonProperty("biz_status", NullValueHandling = NullValueHandling.Ignore)]
        public string BizStatus { get; set; }

        /// <summary>
        ///     状态描述
        /// </summary>
        [XmlElement("biz_status_txt")]
        [JsonProperty("biz_status_txt", NullValueHandling = NullValueHandling.Ignore)]
        public string BizStatusTxt { get; set; }

        /// <summary>
        ///     拓展参数，区分4S厂商  {”remark”:”DFRC”}  日产- DFRC,  北现- BJXD
        /// </summary>
        [XmlElement("ext_param")]
        [JsonProperty("ext_param", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtParam { get; set; }

        /// <summary>
        ///     业务订单编号
        /// </summary>
        [XmlElement("out_order_no")]
        [JsonProperty("out_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutOrderNo { get; set; }

        /// <summary>
        ///     交易主题
        /// </summary>
        [XmlElement("subject")]
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        ///     交易摘要
        /// </summary>
        [XmlElement("summary")]
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        /// <summary>
        ///     交易金额，单位：分
        /// </summary>
        [XmlElement("total_fee")]
        [JsonProperty("total_fee", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalFee { get; set; }

        /// <summary>
        ///     支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}