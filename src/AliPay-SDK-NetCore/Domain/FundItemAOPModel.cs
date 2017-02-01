using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     FundItemAOPModel Data Structure.
    /// </summary>
    [Serializable]
    public class FundItemAOPModel : AopObject
    {
        /// <summary>
        ///     财务外部单据号
        /// </summary>
        [XmlElement("acctrans_out_biz_no")]
        [JsonProperty("acctrans_out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AcctransOutBizNo { get; set; }

        /// <summary>
        ///     资金变动金额
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     资产类型编码
        /// </summary>
        [XmlElement("assert_type_code")]
        [JsonProperty("assert_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AssertTypeCode { get; set; }

        /// <summary>
        ///     银行卡支付工具类型
        /// </summary>
        [XmlElement("bank_card_pay_type")]
        [JsonProperty("bank_card_pay_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BankCardPayType { get; set; }

        /// <summary>
        ///     银行卡类型
        /// </summary>
        [XmlElement("bank_card_type")]
        [JsonProperty("bank_card_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BankCardType { get; set; }

        /// <summary>
        ///     业务ID
        /// </summary>
        [XmlElement("biz_id")]
        [JsonProperty("biz_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BizId { get; set; }

        /// <summary>
        ///     业务号
        /// </summary>
        [XmlElement("biz_in_no")]
        [JsonProperty("biz_in_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizInNo { get; set; }

        /// <summary>
        ///     业务外部流水号
        /// </summary>
        [XmlElement("biz_out_no")]
        [JsonProperty("biz_out_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizOutNo { get; set; }

        /// <summary>
        ///     业务类型（枚举值对应的code）
        /// </summary>
        [XmlElement("biz_type")]
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        ///     币种（数字形式）
        /// </summary>
        [XmlElement("currency")]
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        ///     充退金额
        /// </summary>
        [XmlElement("dback_amount")]
        [JsonProperty("dback_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DbackAmount { get; set; }

        /// <summary>
        ///     退款申请时间
        /// </summary>
        [XmlElement("dback_gmt_create")]
        [JsonProperty("dback_gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string DbackGmtCreate { get; set; }

        /// <summary>
        ///     实际/预估银行响应时间
        /// </summary>
        [XmlElement("dback_gmt_est_bk_ack")]
        [JsonProperty("dback_gmt_est_bk_ack", NullValueHandling = NullValueHandling.Ignore)]
        public string DbackGmtEstBkAck { get; set; }

        /// <summary>
        ///     预估银行入账时间
        /// </summary>
        [XmlElement("dback_gmt_est_bk_into")]
        [JsonProperty("dback_gmt_est_bk_into", NullValueHandling = NullValueHandling.Ignore)]
        public string DbackGmtEstBkInto { get; set; }

        /// <summary>
        ///     充值账户名
        /// </summary>
        [XmlElement("dback_inst_account_name")]
        [JsonProperty("dback_inst_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbackInstAccountName { get; set; }

        /// <summary>
        ///     充值卡号（后四位）
        /// </summary>
        [XmlElement("dback_inst_account_no")]
        [JsonProperty("dback_inst_account_no", NullValueHandling = NullValueHandling.Ignore)]
        public string DbackInstAccountNo { get; set; }

        /// <summary>
        ///     机构ID
        /// </summary>
        [XmlElement("dback_inst_id")]
        [JsonProperty("dback_inst_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbackInstId { get; set; }

        /// <summary>
        ///     机构名称
        /// </summary>
        [XmlElement("dback_inst_name")]
        [JsonProperty("dback_inst_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbackInstName { get; set; }

        /// <summary>
        ///     统一支付资金条目ID
        /// </summary>
        [XmlElement("fid")]
        [JsonProperty("fid", NullValueHandling = NullValueHandling.Ignore)]
        public string Fid { get; set; }

        /// <summary>
        ///     面向系统的资金工具接入类型
        /// </summary>
        [XmlElement("fund_access_type")]
        [JsonProperty("fund_access_type", NullValueHandling = NullValueHandling.Ignore)]
        public long FundAccessType { get; set; }

        /// <summary>
        ///     资金账号。可以是支付宝主卡账号，子卡账号，银行卡号等等。
        /// </summary>
        [XmlElement("fund_account_no")]
        [JsonProperty("fund_account_no", NullValueHandling = NullValueHandling.Ignore)]
        public string FundAccountNo { get; set; }

        /// <summary>
        ///     资金业务类型枚举
        /// </summary>
        [XmlElement("fund_biz_type")]
        [JsonProperty("fund_biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public long FundBizType { get; set; }

        /// <summary>
        ///     资金明细创建时间
        /// </summary>
        [XmlElement("fund_create_time")]
        [JsonProperty("fund_create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FundCreateTime { get; set; }

        /// <summary>
        ///     资金变动完成时间
        /// </summary>
        [XmlElement("fund_finish_time")]
        [JsonProperty("fund_finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FundFinishTime { get; set; }

        /// <summary>
        ///     资金流向枚举
        /// </summary>
        [XmlElement("fund_in_out")]
        [JsonProperty("fund_in_out", NullValueHandling = NullValueHandling.Ignore)]
        public long FundInOut { get; set; }

        /// <summary>
        ///     资金工具机构
        /// </summary>
        [XmlElement("fund_inst_id")]
        [JsonProperty("fund_inst_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FundInstId { get; set; }

        /// <summary>
        ///     资金明细最后修改时间
        /// </summary>
        [XmlElement("fund_modify_time")]
        [JsonProperty("fund_modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FundModifyTime { get; set; }

        /// <summary>
        ///     资金状态
        /// </summary>
        [XmlElement("fund_status")]
        [JsonProperty("fund_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FundStatus { get; set; }

        /// <summary>
        ///     该资金变动的资金工具是否为ownerCardNo所拥有
        /// </summary>
        [XmlElement("fund_tool_belong_to_crowner")]
        [JsonProperty("fund_tool_belong_to_crowner", NullValueHandling = NullValueHandling.Ignore)]
        public bool FundToolBelongToCrowner { get; set; }

        /// <summary>
        ///     fundToolBelongToCROwner为false时，该字段记录资金工具的实际拥有者
        /// </summary>
        [XmlElement("fund_tool_owner_card_no")]
        [JsonProperty("fund_tool_owner_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string FundToolOwnerCardNo { get; set; }

        /// <summary>
        ///     面向用户的资金工具类型
        /// </summary>
        [XmlElement("fund_tool_type_for_crowner")]
        [JsonProperty("fund_tool_type_for_crowner", NullValueHandling = NullValueHandling.Ignore)]
        public string FundToolTypeForCrowner { get; set; }

        /// <summary>
        ///     面向系统的资金工具类型
        /// </summary>
        [XmlElement("fund_tool_type_for_system")]
        [JsonProperty("fund_tool_type_for_system", NullValueHandling = NullValueHandling.Ignore)]
        public string FundToolTypeForSystem { get; set; }

        /// <summary>
        ///     资金工具名字（中文），供外部直接展示用。
        /// </summary>
        [XmlElement("fund_tool_type_name")]
        [JsonProperty("fund_tool_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FundToolTypeName { get; set; }

        /// <summary>
        ///     业务创建时间
        /// </summary>
        [XmlElement("gmt_biz_create")]
        [JsonProperty("gmt_biz_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtBizCreate { get; set; }

        /// <summary>
        ///     导致该资金变动在业务上的另一方的卡别名
        /// </summary>
        [XmlElement("opposite_biz_card_alias")]
        [JsonProperty("opposite_biz_card_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeBizCardAlias { get; set; }

        /// <summary>
        ///     导致该资金变动在业务上的另一方的卡别名。
        /// </summary>
        [XmlElement("opposite_biz_card_no")]
        [JsonProperty("opposite_biz_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeBizCardNo { get; set; }

        /// <summary>
        ///     导致该资金变动在资金上的另一方的卡别名。
        /// </summary>
        [XmlElement("opposite_fund_card_no")]
        [JsonProperty("opposite_fund_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeFundCardNo { get; set; }

        /// <summary>
        ///     外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        [JsonProperty("out_request_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRequestNo { get; set; }

        /// <summary>
        ///     本方卡号
        /// </summary>
        [XmlElement("owner_card_no")]
        [JsonProperty("owner_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerCardNo { get; set; }

        /// <summary>
        ///     银行卡退款进度状态
        /// </summary>
        [XmlElement("refund_bank_status")]
        [JsonProperty("refund_bank_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundBankStatus { get; set; }

        /// <summary>
        ///     预付子卡类型
        /// </summary>
        [XmlElement("sub_prepaid_card_type")]
        [JsonProperty("sub_prepaid_card_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubPrepaidCardType { get; set; }

        /// <summary>
        ///     统一支付ID
        /// </summary>
        [XmlElement("uid")]
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }
    }
}