using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DrawndnVo Data Structure.
    /// </summary>
    [Serializable]
    public class DrawndnVo : AopObject
    {
        /// <summary>
        /// 实收利息，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("actual_collected_interest")]
		[JsonProperty("actual_collected_interest", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualCollectedInterest { get; set; }

        /// <summary>
        /// 贷款余额(本金余额)
        /// </summary>
        [XmlElement("balance")]
		[JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public string Balance { get; set; }

        /// <summary>
        /// 已收本息，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("collected_principal_and_interest")]
		[JsonProperty("collected_principal_and_interest", NullValueHandling = NullValueHandling.Ignore)]
        public string CollectedPrincipalAndInterest { get; set; }

        /// <summary>
        /// 授信编号
        /// </summary>
        [XmlElement("credit_no")]
		[JsonProperty("credit_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CreditNo { get; set; }

        /// <summary>
        /// 支用日,这里代表的是客户这笔支用放款成功日期，如果支用还在放款中或者支用放款失败等，则该值为空
        /// </summary>
        [XmlElement("drawndn_date")]
		[JsonProperty("drawndn_date", NullValueHandling = NullValueHandling.Ignore)]
        public string DrawndnDate { get; set; }

        /// <summary>
        /// 支用编号，代表一笔支用的唯一编号
        /// </summary>
        [XmlElement("drawndn_no")]
		[JsonProperty("drawndn_no", NullValueHandling = NullValueHandling.Ignore)]
        public string DrawndnNo { get; set; }

        /// <summary>
        /// 到期日
        /// </summary>
        [XmlElement("due_date")]
		[JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public string DueDate { get; set; }

        /// <summary>
        /// 五级分类，值类型：NORMAL（正常）、ATTENTION（关注）、SUBPRIME（次级）、DOUBTFUL（可疑）、LOSSES（损失）
        /// </summary>
        [XmlElement("five_tier_classification")]
		[JsonProperty("five_tier_classification", NullValueHandling = NullValueHandling.Ignore)]
        public string FiveTierClassification { get; set; }

        /// <summary>
        /// 正常利息，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("interest")]
		[JsonProperty("interest", NullValueHandling = NullValueHandling.Ignore)]
        public string Interest { get; set; }

        /// <summary>
        /// 年利率，小数点保留2位
        /// </summary>
        [XmlElement("interest_rate")]
		[JsonProperty("interest_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string InterestRate { get; set; }

        /// <summary>
        /// 贷款发放额，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("lending_amount")]
		[JsonProperty("lending_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string LendingAmount { get; set; }

        /// <summary>
        /// 当前逾期期次
        /// </summary>
        [XmlElement("overduce_terms")]
		[JsonProperty("overduce_terms", NullValueHandling = NullValueHandling.Ignore)]
        public long OverduceTerms { get; set; }

        /// <summary>
        /// 当前逾期天数
        /// </summary>
        [XmlElement("overdue_days")]
		[JsonProperty("overdue_days", NullValueHandling = NullValueHandling.Ignore)]
        public long OverdueDays { get; set; }

        /// <summary>
        /// 逾期利息，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("overdue_interest")]
		[JsonProperty("overdue_interest", NullValueHandling = NullValueHandling.Ignore)]
        public string OverdueInterest { get; set; }

        /// <summary>
        /// 逾期利息罚息，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("overdue_interest_penalty")]
		[JsonProperty("overdue_interest_penalty", NullValueHandling = NullValueHandling.Ignore)]
        public string OverdueInterestPenalty { get; set; }

        /// <summary>
        /// 逾期本金，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("overdue_principal")]
		[JsonProperty("overdue_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string OverduePrincipal { get; set; }

        /// <summary>
        /// 逾期本金罚息，单位为元，小数点保留2位
        /// </summary>
        [XmlElement("overdue_principal_penalty")]
		[JsonProperty("overdue_principal_penalty", NullValueHandling = NullValueHandling.Ignore)]
        public string OverduePrincipalPenalty { get; set; }

        /// <summary>
        /// 支用状态 ,值类型：INIT(初始),LENDING(发放中),NORMAL(正常),OVD(逾期), CLEAR(结清),OFF(核销), LENDFAIL(发放失败)
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}
