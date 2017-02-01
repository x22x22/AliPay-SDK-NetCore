using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobileDeviceinfoDynamicinfoAddResponse.
    /// </summary>
    public class AlipayMobileDeviceinfoDynamicinfoAddResponse : AopResponse
    {
        /// <summary>
        ///     同步处理结果
        /// </summary>
        [XmlElement("operateresult")]
        [JsonProperty("operateresult", NullValueHandling = NullValueHandling.Ignore)]
        public bool Operateresult { get; set; }
    }
}