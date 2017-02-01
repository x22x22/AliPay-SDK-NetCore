using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ConsumeRecordAOPModel Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumeRecordAOPModel : AopObject
    {
        /// <summary>
        ///     接入渠道
        /// </summary>
        [XmlElement("access_channel")]
        [JsonProperty("access_channel", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessChannel { get; set; }

        /// <summary>
        ///     扩展状态
        /// </summary>
        [XmlElement("additional_status")]
        [JsonProperty("additional_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalStatus { get; set; }

        /// <summary>
        ///     用户下一步动作
        /// </summary>
        [XmlArray("biz_actions")]
        [XmlArrayItem("string")]
        public List<string> BizActions { get; set; }

        /// <summary>
        ///     业务扩展流水号
        /// </summary>
        [XmlElement("biz_extra_no")]
        [JsonProperty("biz_extra_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizExtraNo { get; set; }

        /// <summary>
        ///     业务流水号
        /// </summary>
        [XmlElement("biz_in_no")]
        [JsonProperty("biz_in_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizInNo { get; set; }

        /// <summary>
        ///     业务备注
        /// </summary>
        [XmlElement("biz_memo")]
        [JsonProperty("biz_memo", NullValueHandling = NullValueHandling.Ignore)]
        public string BizMemo { get; set; }

        /// <summary>
        ///     业务发起方
        /// </summary>
        [XmlElement("biz_orig")]
        [JsonProperty("biz_orig", NullValueHandling = NullValueHandling.Ignore)]
        public string BizOrig { get; set; }

        /// <summary>
        ///     业务外部流水号
        /// </summary>
        [XmlElement("biz_out_no")]
        [JsonProperty("biz_out_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizOutNo { get; set; }

        /// <summary>
        ///     业务状态
        /// </summary>
        [XmlElement("biz_state")]
        [JsonProperty("biz_state", NullValueHandling = NullValueHandling.Ignore)]
        public string BizState { get; set; }

        /// <summary>
        ///     业务子类型
        /// </summary>
        [XmlElement("biz_sub_type")]
        [JsonProperty("biz_sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizSubType { get; set; }

        /// <summary>
        ///     业务类型
        /// </summary>
        [XmlElement("biz_type")]
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        ///     自定义分类Id
        /// </summary>
        [XmlElement("category_id")]
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }

        /// <summary>
        ///     总费用
        /// </summary>
        [XmlElement("consume_fee")]
        [JsonProperty("consume_fee", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeFee { get; set; }

        /// <summary>
        ///     消费记录退款状态
        /// </summary>
        [XmlElement("consume_refund_status")]
        [JsonProperty("consume_refund_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeRefundStatus { get; set; }

        /// <summary>
        ///     来源
        /// </summary>
        [XmlElement("consume_site")]
        [JsonProperty("consume_site", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeSite { get; set; }

        /// <summary>
        ///     消费记录状态
        /// </summary>
        [XmlElement("consume_status")]
        [JsonProperty("consume_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeStatus { get; set; }

        /// <summary>
        ///     标题
        /// </summary>
        [XmlElement("consume_title")]
        [JsonProperty("consume_title", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeTitle { get; set; }

        /// <summary>
        ///     消费记录类型
        /// </summary>
        [XmlElement("consume_type")]
        [JsonProperty("consume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeType { get; set; }

        /// <summary>
        ///     货币币种
        /// </summary>
        [XmlElement("currency")]
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        ///     消费记录永久删除时间
        /// </summary>
        [XmlElement("delete_over_time")]
        [JsonProperty("delete_over_time", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteOverTime { get; set; }

        /// <summary>
        ///     消费记录删除时间
        /// </summary>
        [XmlElement("delete_time")]
        [JsonProperty("delete_time", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteTime { get; set; }

        /// <summary>
        ///     消费记录删除标记
        /// </summary>
        [XmlElement("delete_type")]
        [JsonProperty("delete_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteType { get; set; }

        /// <summary>
        ///     充退状态，可能为空，目前只针对交易业务有效
        /// </summary>
        [XmlElement("depositback_status")]
        [JsonProperty("depositback_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DepositbackStatus { get; set; }

        /// <summary>
        ///     是否锁定标记
        /// </summary>
        [XmlElement("flag_locked")]
        [JsonProperty("flag_locked", NullValueHandling = NullValueHandling.Ignore)]
        public string FlagLocked { get; set; }

        /// <summary>
        ///     退款标记
        /// </summary>
        [XmlElement("flag_refund")]
        [JsonProperty("flag_refund", NullValueHandling = NullValueHandling.Ignore)]
        public string FlagRefund { get; set; }

        /// <summary>
        ///     业务数据创建时间
        /// </summary>
        [XmlElement("gmt_biz_create")]
        [JsonProperty("gmt_biz_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtBizCreate { get; set; }

        /// <summary>
        ///     业务数据最后更新时间
        /// </summary>
        [XmlElement("gmt_biz_modified")]
        [JsonProperty("gmt_biz_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtBizModified { get; set; }

        /// <summary>
        ///     消费记录创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        ///     消费记录最后更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        [JsonProperty("gmt_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtModified { get; set; }

        /// <summary>
        ///     收到付款时间（买家付款时间）
        /// </summary>
        [XmlElement("gmt_receive_pay")]
        [JsonProperty("gmt_receive_pay", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtReceivePay { get; set; }

        /// <summary>
        ///     打款给卖家时间（卖家收款时间）
        /// </summary>
        [XmlElement("gmt_send_pay")]
        [JsonProperty("gmt_send_pay", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtSendPay { get; set; }

        /// <summary>
        ///     是否有资金明细
        /// </summary>
        [XmlElement("has_fund_item")]
        [JsonProperty("has_fund_item", NullValueHandling = NullValueHandling.Ignore)]
        public bool HasFundItem { get; set; }

        /// <summary>
        ///     是否有新资金明细(落地新流程交易的消费记录)
        /// </summary>
        [XmlElement("has_new_fund_item")]
        [JsonProperty("has_new_fund_item", NullValueHandling = NullValueHandling.Ignore)]
        public bool HasNewFundItem { get; set; }

        /// <summary>
        ///     收入/支出
        /// </summary>
        [XmlElement("in_out")]
        [JsonProperty("in_out", NullValueHandling = NullValueHandling.Ignore)]
        public string InOut { get; set; }

        /// <summary>
        ///     对方卡号
        /// </summary>
        [XmlElement("opposite_card_no")]
        [JsonProperty("opposite_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeCardNo { get; set; }

        /// <summary>
        ///     对方登录ID
        /// </summary>
        [XmlElement("opposite_login_id")]
        [JsonProperty("opposite_login_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeLoginId { get; set; }

        /// <summary>
        ///     对方名称
        /// </summary>
        [XmlElement("opposite_name")]
        [JsonProperty("opposite_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeName { get; set; }

        /// <summary>
        ///     对方昵称
        /// </summary>
        [XmlElement("opposite_nick_name")]
        [JsonProperty("opposite_nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeNickName { get; set; }

        /// <summary>
        ///     消费记录原标题
        /// </summary>
        [XmlElement("orig_consume_title")]
        [JsonProperty("orig_consume_title", NullValueHandling = NullValueHandling.Ignore)]
        public string OrigConsumeTitle { get; set; }

        /// <summary>
        ///     本方卡号
        /// </summary>
        [XmlElement("owner_card_no")]
        [JsonProperty("owner_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerCardNo { get; set; }

        /// <summary>
        ///     本方客户ID
        /// </summary>
        [XmlElement("owner_customer_id")]
        [JsonProperty("owner_customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerCustomerId { get; set; }

        /// <summary>
        ///     本方登录ID
        /// </summary>
        [XmlElement("owner_login_id")]
        [JsonProperty("owner_login_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerLoginId { get; set; }

        /// <summary>
        ///     本方名称
        /// </summary>
        [XmlElement("owner_name")]
        [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        ///     本方昵称
        /// </summary>
        [XmlElement("owner_nick")]
        [JsonProperty("owner_nick", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerNick { get; set; }

        /// <summary>
        ///     合作伙伴ID
        /// </summary>
        [XmlElement("partner_id")]
        [JsonProperty("partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerId { get; set; }

        /// <summary>
        ///     创建渠道
        /// </summary>
        [XmlElement("pay_channel")]
        [JsonProperty("pay_channel", NullValueHandling = NullValueHandling.Ignore)]
        public string PayChannel { get; set; }

        /// <summary>
        ///     代付人&亲密付人姓名
        /// </summary>
        [XmlElement("peerpayer_real_name")]
        [JsonProperty("peerpayer_real_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PeerpayerRealName { get; set; }

        /// <summary>
        ///     产品码
        /// </summary>
        [XmlElement("product")]
        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public string Product { get; set; }

        /// <summary>
        ///     最后一次退款金额
        /// </summary>
        [XmlElement("refund_fee")]
        [JsonProperty("refund_fee", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundFee { get; set; }

        /// <summary>
        ///     服务费
        /// </summary>
        [XmlElement("service_fee")]
        [JsonProperty("service_fee", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceFee { get; set; }

        /// <summary>
        ///     多次成功退款总金额
        /// </summary>
        [XmlElement("total_refund_fee")]
        [JsonProperty("total_refund_fee", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalRefundFee { get; set; }

        /// <summary>
        ///     交易来源
        /// </summary>
        [XmlElement("trade_from")]
        [JsonProperty("trade_from", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeFrom { get; set; }
    }
}