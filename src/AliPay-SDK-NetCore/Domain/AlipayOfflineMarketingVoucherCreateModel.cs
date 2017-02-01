using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineMarketingVoucherCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherCreateModel : AopObject
    {
        /// <summary>
        ///     预算信息
        /// </summary>
        [XmlElement("budget_info")]
        [JsonProperty("budget_info", NullValueHandling = NullValueHandling.Ignore)]
        public BudgetInfo BudgetInfo { get; set; }

        /// <summary>
        ///     券码池编号。该值调用：alipay.offline.marketing.voucher.code.upload接口生成
        /// </summary>
        [XmlElement("code_inventory_id")]
        [JsonProperty("code_inventory_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeInventoryId { get; set; }

        /// <summary>
        ///     扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        ///     发放规则信息
        /// </summary>
        [XmlElement("get_rule")]
        [JsonProperty("get_rule", NullValueHandling = NullValueHandling.Ignore)]
        public GetRuleInfo GetRule { get; set; }

        /// <summary>
        ///     外部流水号.需商家自己生成并保证每次请求的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
        [JsonProperty("out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutBizNo { get; set; }

        /// <summary>
        ///     券模板信息
        /// </summary>
        [XmlElement("voucher_info")]
        [JsonProperty("voucher_info", NullValueHandling = NullValueHandling.Ignore)]
        public VoucherInfo VoucherInfo { get; set; }
    }
}