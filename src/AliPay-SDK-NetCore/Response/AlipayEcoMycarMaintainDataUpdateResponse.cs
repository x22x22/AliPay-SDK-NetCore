using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainDataUpdateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainDataUpdateResponse : AopResponse
    {
        /// <summary>
        /// 具体返回的处理结果
        /// </summary>
        [XmlElement("info")]
		[JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public string Info { get; set; }
    }
}
