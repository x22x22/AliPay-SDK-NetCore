using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     BatchFundItemAOPModel Data Structure.
    /// </summary>
    [Serializable]
    public class BatchFundItemAOPModel : AopObject
    {
        /// <summary>
        ///     批次号
        /// </summary>
        [XmlElement("batch_no")]
        [JsonProperty("batch_no", NullValueHandling = NullValueHandling.Ignore)]
        public long BatchNo { get; set; }

        /// <summary>
        ///     退款到银行卡处理中的总金额
        /// </summary>
        [XmlElement("dback_refundtobank_processing_batch_amount")]
        [JsonProperty("dback_refundtobank_processing_batch_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DbackRefundtobankProcessingBatchAmount { get; set; }

        /// <summary>
        ///     退款到银行卡成功的总金额
        /// </summary>
        [XmlElement("dback_refundtobank_success_batch_amount")]
        [JsonProperty("dback_refundtobank_success_batch_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DbackRefundtobankSuccessBatchAmount { get; set; }

        /// <summary>
        ///     资金明细列表
        /// </summary>
        [XmlArray("fund_item_list")]
        [XmlArrayItem("fund_item_a_o_p_model")]
        public List<FundItemAOPModel> FundItemList { get; set; }

        /// <summary>
        ///     批次创建时间
        /// </summary>
        [XmlElement("gmt_biz_create_date")]
        [JsonProperty("gmt_biz_create_date", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtBizCreateDate { get; set; }

        /// <summary>
        ///     资金单ID
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        ///     总金额
        /// </summary>
        [XmlElement("total_amount")]
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        ///     包含服务费的总金额
        /// </summary>
        [XmlElement("total_amount_with_service_fee")]
        [JsonProperty("total_amount_with_service_fee", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmountWithServiceFee { get; set; }
    }
}