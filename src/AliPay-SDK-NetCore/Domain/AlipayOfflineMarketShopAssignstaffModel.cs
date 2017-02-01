using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopAssignstaffModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketShopAssignstaffModel : AopObject
    {
        /// <summary>
        /// 员工支付宝卡号ID
        /// </summary>
        [XmlElement("allocated_staff_id")]
		[JsonProperty("allocated_staff_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AllocatedStaffId { get; set; }

        /// <summary>
        /// 操作人PID
        /// </summary>
        [XmlElement("ope_pid")]
		[JsonProperty("ope_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string OpePid { get; set; }

        /// <summary>
        /// 请求流水id
        /// </summary>
        [XmlElement("request_id")]
		[JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 门店id,可以多个，“，”分隔
        /// </summary>
        [XmlElement("shop_id")]
		[JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}
