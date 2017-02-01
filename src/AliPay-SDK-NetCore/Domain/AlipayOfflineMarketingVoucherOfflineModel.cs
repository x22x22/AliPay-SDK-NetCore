using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherOfflineModel : AopObject
    {
        /// <summary>
        /// 下架描述
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 外部流水号.需商家自己生成并保证每次请求的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
		[JsonProperty("out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券模板编号
        /// </summary>
        [XmlElement("voucher_id")]
		[JsonProperty("voucher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherId { get; set; }
    }
}
