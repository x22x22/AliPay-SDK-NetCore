using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditAntifraudVerifyResponse.
    /// </summary>
    public class ZhimaCreditAntifraudVerifyResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
		[JsonProperty("biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizNo { get; set; }

        /// <summary>
        /// 风险因素code列表
        /// </summary>
        [XmlArray("verify_code")]
        [XmlArrayItem("string")]
        public List<string> VerifyCode { get; set; }
    }
}
