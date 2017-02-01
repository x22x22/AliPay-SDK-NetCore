using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerCertificationCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerCertificationCertifyModel : AopObject
    {
        /// <summary>
        /// 一次认证的唯一标识,在完成芝麻认证初始化后可以获取
        /// </summary>
        [XmlElement("biz_no")]
		[JsonProperty("biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizNo { get; set; }
    }
}
