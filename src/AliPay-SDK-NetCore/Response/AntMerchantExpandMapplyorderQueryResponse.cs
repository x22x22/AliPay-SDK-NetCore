using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AntMerchantExpandMapplyorderQueryResponse.
    /// </summary>
    public class AntMerchantExpandMapplyorderQueryResponse : AopResponse
    {
        /// <summary>
        ///     支付宝端商户入驻申请单据号
        /// </summary>
        [XmlElement("order_no")]
        [JsonProperty("order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNo { get; set; }

        /// <summary>
        ///     支付宝商户入驻申请单状态
        /// </summary>
        [XmlElement("order_status")]
        [JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        ///     外部入驻申请单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        [JsonProperty("out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutBizNo { get; set; }

        /// <summary>
        ///     入驻申请单认证审核、签约审核详情
        /// </summary>
        [XmlArray("result_info")]
        [XmlArrayItem("merchant_apply_result_record")]
        public List<MerchantApplyResultRecord> ResultInfo { get; set; }
    }
}