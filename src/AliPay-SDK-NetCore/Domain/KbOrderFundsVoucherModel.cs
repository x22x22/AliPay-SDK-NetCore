using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbOrderFundsVoucherModel Data Structure.
    /// </summary>
    [Serializable]
    public class KbOrderFundsVoucherModel : AopObject
    {
        /// <summary>
        /// 资金流入账户,打款动作存在该字段
        /// </summary>
        [XmlElement("account")]
		[JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
		[JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 资金凭证ID
        /// </summary>
        [XmlElement("funds_voucher_no")]
		[JsonProperty("funds_voucher_no", NullValueHandling = NullValueHandling.Ignore)]
        public string FundsVoucherNo { get; set; }

        /// <summary>
        /// 资金流转发生时间
        /// </summary>
        [XmlElement("gmt_create")]
		[JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 门店ID，打款动作存在该字段
        /// </summary>
        [XmlElement("shop_id")]
		[JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }

        /// <summary>
        /// 资金流入外部门店ID，打款时存在该字段
        /// </summary>
        [XmlElement("store_id")]
		[JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreId { get; set; }

        /// <summary>
        /// 资金类型  PAY/SETTLE/REFUND 对应 支付／打款／退款
        /// </summary>
        [XmlElement("trans_type")]
		[JsonProperty("trans_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TransType { get; set; }
    }
}
