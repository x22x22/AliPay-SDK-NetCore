using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopAssignstaffResponse.
    /// </summary>
    public class AlipayOfflineMarketShopAssignstaffResponse : AopResponse
    {
        /// <summary>
        /// 如果失败，存放原因
        /// </summary>
        [XmlElement("error_msg")]
		[JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("result")]
		[JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 分配失败的门店id
        /// </summary>
        [XmlElement("shop_id")]
		[JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }
    }
}
