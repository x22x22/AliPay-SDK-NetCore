using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AntMerchantExpandMapplyorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMapplyorderQueryModel : AopObject
    {
        /// <summary>
        ///     支付宝端商户入驻申请单据号
        /// </summary>
        [XmlElement("order_no")]
        [JsonProperty("order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNo { get; set; }
    }
}