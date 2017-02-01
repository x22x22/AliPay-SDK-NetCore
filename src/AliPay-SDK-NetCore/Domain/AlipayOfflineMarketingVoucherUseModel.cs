using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherUseModel : AopObject
    {
        /// <summary>
        /// 约定的扩展参数
        /// </summary>
        [XmlElement("extend_params")]
		[JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 外部活动id
        /// </summary>
        [XmlElement("external_id")]
		[JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// 外部交易信息
        /// </summary>
        [XmlElement("external_trade_info")]
		[JsonProperty("external_trade_info", NullValueHandling = NullValueHandling.Ignore)]
        public VoucherUserExternalTradeInfo ExternalTradeInfo { get; set; }

        /// <summary>
        /// 外部券码
        /// </summary>
        [XmlElement("external_voucher_code")]
		[JsonProperty("external_voucher_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalVoucherCode { get; set; }
    }
}
