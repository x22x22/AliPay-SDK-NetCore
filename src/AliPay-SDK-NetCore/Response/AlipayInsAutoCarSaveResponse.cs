using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayInsAutoCarSaveResponse.
    /// </summary>
    public class AlipayInsAutoCarSaveResponse : AopResponse
    {
        /// <summary>
        ///     车牌号
        /// </summary>
        [XmlElement("car_no")]
        [JsonProperty("car_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CarNo { get; set; }
    }
}