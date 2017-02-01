using System;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankFinanceYulibaoAccountQueryResponse.
    /// </summary>
    public class MybankFinanceYulibaoAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 可用份额，单位为元
        /// </summary>
        [XmlElement("available_amount")]
		[JsonProperty("available_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 业务冻结份额，单位为元
        /// </summary>
        [XmlElement("freeze_amount")]
		[JsonProperty("freeze_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 系统冻结份额，单位为元（建议不展示给用户）
        /// </summary>
        [XmlElement("sys_freeze_amount")]
		[JsonProperty("sys_freeze_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string SysFreezeAmount { get; set; }

        /// <summary>
        /// 余利宝总余额，单位为元
        /// </summary>
        [XmlElement("total_amount")]
		[JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 余利宝收益详情
        /// </summary>
        [XmlElement("ylb_profit_detail_info")]
		[JsonProperty("ylb_profit_detail_info", NullValueHandling = NullValueHandling.Ignore)]
        public YLBProfitDetailInfo YlbProfitDetailInfo { get; set; }
    }
}
