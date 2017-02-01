using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherModifyModel : AopObject
    {
        /// <summary>
        /// 预算信息
        /// </summary>
        [XmlElement("budget_info")]
		[JsonProperty("budget_info", NullValueHandling = NullValueHandling.Ignore)]
        public BudgetInfo BudgetInfo { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_info")]
		[JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 发放次数限制
        /// </summary>
        [XmlElement("get_count_limit")]
		[JsonProperty("get_count_limit", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodInfo GetCountLimit { get; set; }

        /// <summary>
        /// 外部流水号.需商家自己生成并保证每次请求的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
		[JsonProperty("out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券信息
        /// </summary>
        [XmlElement("voucher_info")]
		[JsonProperty("voucher_info", NullValueHandling = NullValueHandling.Ignore)]
        public VoucherModifyInfo VoucherInfo { get; set; }
    }
}
