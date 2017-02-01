using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryInstBillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class QueryInstBillInfo : AopObject
    {
        /// <summary>
        /// 账单金额
        /// </summary>
        [XmlElement("amount")]
		[JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [XmlElement("balance")]
		[JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public string Balance { get; set; }

        /// <summary>
        /// 账单日期
        /// </summary>
        [XmlElement("bill_date")]
		[JsonProperty("bill_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BillDate { get; set; }

        /// <summary>
        /// 明细说明
        /// </summary>
        [XmlArray("bill_detail")]
        [XmlArrayItem("query_inst_bill_detail")]
        public List<QueryInstBillDetail> BillDetail { get; set; }

        /// <summary>
        /// 滞纳金
        /// </summary>
        [XmlElement("bill_fines")]
		[JsonProperty("bill_fines", NullValueHandling = NullValueHandling.Ignore)]
        public string BillFines { get; set; }

        /// <summary>
        /// 账单流水
        /// </summary>
        [XmlElement("bill_key")]
		[JsonProperty("bill_key", NullValueHandling = NullValueHandling.Ignore)]
        public string BillKey { get; set; }

        /// <summary>
        /// 户名
        /// </summary>
        [XmlElement("bill_user_name")]
		[JsonProperty("bill_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BillUserName { get; set; }

        /// <summary>
        /// JDBXINHUI
        /// </summary>
        [XmlElement("charge_inst")]
		[JsonProperty("charge_inst", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 查询欠费单的惟一标识
        /// </summary>
        [XmlElement("charge_uniq_id")]
		[JsonProperty("charge_uniq_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeUniqId { get; set; }

        /// <summary>
        /// 销账机构
        /// </summary>
        [XmlElement("chargeoff_inst")]
		[JsonProperty("chargeoff_inst", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 销账机构给出账机构分配的ID
        /// </summary>
        [XmlElement("company_id")]
		[JsonProperty("company_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyId { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlElement("extend")]
		[JsonProperty("extend", NullValueHandling = NullValueHandling.Ignore)]
        public string Extend { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("order_type")]
		[JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_id")]
		[JsonProperty("out_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OutId { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("return_message")]
		[JsonProperty("return_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnMessage { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [XmlElement("sub_order_type")]
		[JsonProperty("sub_order_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubOrderType { get; set; }
    }
}
