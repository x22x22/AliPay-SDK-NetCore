using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ZhimaCustomerCertificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerCertificationQueryModel : AopObject
    {
        /// <summary>
        ///     一次认证的唯一标识,在商户调用认证初始化接口的时候获取
        /// </summary>
        [XmlElement("biz_no")]
        [JsonProperty("biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizNo { get; set; }
    }
}