using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayPassTemplateUpdateResponse.
    /// </summary>
    public class AlipayPassTemplateUpdateResponse : AopResponse
    {
        /// <summary>
        ///     接口调用返回结果信息
        /// </summary>
        [XmlElement("result")]
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        ///     操作成功标识【true：成功；false：失败】
        /// </summary>
        [XmlElement("success")]
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public string Success { get; set; }
    }
}