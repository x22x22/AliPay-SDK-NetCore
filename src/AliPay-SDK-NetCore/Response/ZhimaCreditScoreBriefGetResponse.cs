using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     ZhimaCreditScoreBriefGetResponse.
    /// </summary>
    public class ZhimaCreditScoreBriefGetResponse : AopResponse
    {
        /// <summary>
        ///     芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        [JsonProperty("biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizNo { get; set; }

        /// <summary>
        ///     准入判断结果  Y=准入,N=不准入,N/A=无法评估该用户的信用
        /// </summary>
        [XmlElement("is_admittance")]
        [JsonProperty("is_admittance", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAdmittance { get; set; }
    }
}