using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPassInstanceAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPassInstanceAddModel : AopObject
    {
        /// <summary>
        /// 支付宝用户识别信息：  包括partner_id（商户的签约账号）和out_trade_no
        /// </summary>
        [XmlElement("recognition_info")]
		[JsonProperty("recognition_info", NullValueHandling = NullValueHandling.Ignore)]
        public string RecognitionInfo { get; set; }

        /// <summary>
        /// Alipass添加对象识别类型：1–订单信息
        /// </summary>
        [XmlElement("recognition_type")]
		[JsonProperty("recognition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RecognitionType { get; set; }

        /// <summary>
        /// 支付宝pass模版ID
        /// </summary>
        [XmlElement("tpl_id")]
		[JsonProperty("tpl_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TplId { get; set; }

        /// <summary>
        /// 模版动态参数信息【支付宝pass模版参数键值对JSON字符串】。
        /// </summary>
        [XmlElement("tpl_params")]
		[JsonProperty("tpl_params", NullValueHandling = NullValueHandling.Ignore)]
        public string TplParams { get; set; }
    }
}
