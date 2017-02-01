using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherCodeUploadResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherCodeUploadResponse : AopResponse
    {
        /// <summary>
        /// 码库id
        /// </summary>
        [XmlElement("code_inventory_id")]
		[JsonProperty("code_inventory_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeInventoryId { get; set; }
    }
}
