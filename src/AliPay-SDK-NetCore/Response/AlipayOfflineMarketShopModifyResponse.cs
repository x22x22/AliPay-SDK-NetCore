using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopModifyResponse.
    /// </summary>
    public class AlipayOfflineMarketShopModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改门店请求受理成功后返回的支付宝流水ID，根据此ID调用接口  alipay.offline.market.applyorder.batchquery，能够获取当前修改店铺请求审核状态、驳回原因等信息。
        /// </summary>
        [XmlElement("apply_id")]
		[JsonProperty("apply_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 废弃字段。
        /// </summary>
        [XmlElement("audit_desc")]
		[JsonProperty("audit_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 同步请求如果支付宝受理成功，将返回AUDITING状态。
        /// </summary>
        [XmlElement("audit_status")]
		[JsonProperty("audit_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 废弃字段，T表示上架,F表示未上架。
        /// </summary>
        [XmlElement("is_online")]
		[JsonProperty("is_online", NullValueHandling = NullValueHandling.Ignore)]
        public string IsOnline { get; set; }

        /// <summary>
        /// 废弃字段，T表示显示，F表示隐藏。
        /// </summary>
        [XmlElement("is_show")]
		[JsonProperty("is_show", NullValueHandling = NullValueHandling.Ignore)]
        public string IsShow { get; set; }
    }
}
