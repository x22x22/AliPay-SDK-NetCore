using System;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCardOpenResponse.
    /// </summary>
    public class AlipayMarketingCardOpenResponse : AopResponse
    {
        /// <summary>
        /// 商户卡信息（包括支付宝分配的业务卡号）
        /// </summary>
        [XmlElement("card_info")]
		[JsonProperty("card_info", NullValueHandling = NullValueHandling.Ignore)]
        public MerchantCard CardInfo { get; set; }
    }
}
