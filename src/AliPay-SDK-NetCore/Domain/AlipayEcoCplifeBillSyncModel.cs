using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCplifeBillSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeBillSyncModel : AopObject
    {
        /// <summary>
        /// 待同步的物业费账单应收明细条目ID
        /// </summary>
        [XmlElement("bill_entry_id")]
		[JsonProperty("bill_entry_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BillEntryId { get; set; }

        /// <summary>
        /// 支付宝社区物业平台小区ID，用户通过支付宝社区物业平台物业查询获取。
        /// </summary>
        [XmlElement("community_id")]
		[JsonProperty("community_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommunityId { get; set; }

        /// <summary>
        /// 指定条目待更新的缴费截止日期  若operate_type为update，该参数选填；  若operate_type为delete，该参数不用填。
        /// </summary>
        [XmlElement("new_deadline")]
		[JsonProperty("new_deadline", NullValueHandling = NullValueHandling.Ignore)]
        public string NewDeadline { get; set; }

        /// <summary>
        /// 指定条目待更新的应收金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]  若operate_type为update，该参数选填；  若operate_type为delete，该参数不用填。
        /// </summary>
        [XmlElement("new_entry_amount")]
		[JsonProperty("new_entry_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string NewEntryAmount { get; set; }

        /// <summary>
        /// 同步类型：  delete：删除  update：更改
        /// </summary>
        [XmlElement("operate_type")]
		[JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }
    }
}
