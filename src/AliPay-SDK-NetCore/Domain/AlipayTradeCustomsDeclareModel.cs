using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayTradeCustomsDeclareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCustomsDeclareModel : AopObject
    {
        /// <summary>
        ///     报关金额，单位为人民币“元”，精确到小数点后2位。
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     订购人身份信息
        /// </summary>
        [XmlElement("buyer_info")]
        [JsonProperty("buyer_info", NullValueHandling = NullValueHandling.Ignore)]
        public CustomsDeclareBuyerInfo BuyerInfo { get; set; }

        /// <summary>
        ///     海关编号（大小写皆可）。参见“ <a href="https://doc.open.alipay.com/docs/doc.htm?treeId=267&articleId=105883&docType=1">海关编号</a>”。
        /// </summary>
        [XmlElement("customs_place")]
        [JsonProperty("customs_place", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomsPlace { get; set; }

        /// <summary>
        ///     商户控制本单是否拆单的报关参数。  仅当该参数传值为T或者t时，才会触发拆单。
        /// </summary>
        [XmlElement("is_split")]
        [JsonProperty("is_split", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSplit { get; set; }

        /// <summary>
        ///     商户在海关备案的编号。
        /// </summary>
        [XmlElement("merchant_customs_code")]
        [JsonProperty("merchant_customs_code", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantCustomsCode { get; set; }

        /// <summary>
        ///     商户海关备案名称。
        /// </summary>
        [XmlElement("merchant_customs_name")]
        [JsonProperty("merchant_customs_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantCustomsName { get; set; }

        /// <summary>
        ///     报关流水号。商户生成的用于唯一标识一次报关操作的业务编号。  建议生成规则：yyyymmdd型8位日期拼接4位序列号。每个报关请求号仅允许传入：数字、英文字母、下划线”_”、短横线”－” 。长度6-32位前后不能有空格
        /// </summary>
        [XmlElement("out_request_no")]
        [JsonProperty("out_request_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRequestNo { get; set; }

        /// <summary>
        ///     拆单报关的商户子订单号。 用于区别拆单时不同子单。拆单时必须传入，否则会报INVALID_PARAMETER错误码。
        /// </summary>
        [XmlElement("sub_out_biz_no")]
        [JsonProperty("sub_out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string SubOutBizNo { get; set; }

        /// <summary>
        ///     支付宝交易号。该交易在支付宝系统中的交易流水号，最长64位。
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}