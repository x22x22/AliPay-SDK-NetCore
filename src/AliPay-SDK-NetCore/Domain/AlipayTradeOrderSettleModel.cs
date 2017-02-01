using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeOrderSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeOrderSettleModel : AopObject
    {
        /// <summary>
        /// 操作员id
        /// </summary>
        [XmlElement("operator_id")]
		[JsonProperty("operator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 结算请求流水号 开发者自行生成并保证唯一性
        /// </summary>
        [XmlElement("out_request_no")]
		[JsonProperty("out_request_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账明细信息
        /// </summary>
        [XmlArray("royalty_parameters")]
        [XmlArrayItem("open_api_royalty_detail_info_pojo")]
        public List<OpenApiRoyaltyDetailInfoPojo> RoyaltyParameters { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("trade_no")]
		[JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}
