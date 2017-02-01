using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSaleleadsMerchantEquipmentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSaleleadsMerchantEquipmentQueryModel : AopObject
    {
        /// <summary>
        /// 商户PID（merchant_pid和shop_id必填其一）
        /// </summary>
        [XmlElement("merchant_pid")]
		[JsonProperty("merchant_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 操作用户的支付账号id
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
        /// 商户下的门店ID（merchant_pid和shop_id必填其一）
        /// </summary>
        [XmlElement("shop_id")]
		[JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}
