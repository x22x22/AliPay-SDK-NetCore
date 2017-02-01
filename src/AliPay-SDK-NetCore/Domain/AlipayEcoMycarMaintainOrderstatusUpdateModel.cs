using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainOrderstatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMaintainOrderstatusUpdateModel : AopObject
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_param")]
		[JsonProperty("ext_param", NullValueHandling = NullValueHandling.Ignore)]
        public MaintainOrderStatusExtParams ExtParam { get; set; }

        /// <summary>
        /// 洗车-015；保养-016；4S-020
        /// </summary>
        [XmlElement("industry_code")]
		[JsonProperty("industry_code", NullValueHandling = NullValueHandling.Ignore)]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_no")]
		[JsonProperty("order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 55-已核销；7-已出库；8-已收货
        /// </summary>
        [XmlElement("order_status")]
		[JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 废弃
        /// </summary>
        [XmlElement("type")]
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
