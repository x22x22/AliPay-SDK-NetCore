using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAuthOperationDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAuthOperationDetailQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝授权资金订单号，与商户的授权资金订单号不能同时为空，二者都存在时，以支付宝资金授权订单号为准，该参数与支付宝授权资金操作流水号配对使用。
        /// </summary>
        [XmlElement("auth_no")]
		[JsonProperty("auth_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthNo { get; set; }

        /// <summary>
        /// 支付宝的授权资金操作流水号，与商户的授权资金操作流水号不能同时为空，二者都存在时，以支付宝的授权资金操作流水号为准，该参数与支付宝授权资金订单号配对使用。
        /// </summary>
        [XmlElement("operation_id")]
		[JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户的授权资金订单号，与支付宝的授权资金订单号不能同时为空，二者都存在时，以支付宝的授权资金订单号为准，该参数与商户的授权资金操作流水号配对使用。
        /// </summary>
        [XmlElement("out_order_no")]
		[JsonProperty("out_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户的授权资金操作流水号，与支付宝的授权资金操作流水号不能同时为空，二者都存在时，以支付宝的授权资金操作流水号为准，该参数与商户的授权资金订单号配对使用。
        /// </summary>
        [XmlElement("out_request_no")]
		[JsonProperty("out_request_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRequestNo { get; set; }
    }
}
