using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     ZhimaMerchantTestPracticeResponse.
    /// </summary>
    public class ZhimaMerchantTestPracticeResponse : AopResponse
    {
        /// <summary>
        ///     xxxx
        /// </summary>
        [XmlElement("dddd")]
        [JsonProperty("dddd", NullValueHandling = NullValueHandling.Ignore)]
        public XXXXsdasdasd Dddd { get; set; }

        /// <summary>
        ///     ccc
        /// </summary>
        [XmlElement("sss")]
        [JsonProperty("sss", NullValueHandling = NullValueHandling.Ignore)]
        public string Sss { get; set; }
    }
}