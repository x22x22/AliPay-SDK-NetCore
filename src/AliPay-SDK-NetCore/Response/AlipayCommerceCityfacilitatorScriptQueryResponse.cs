using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayCommerceCityfacilitatorScriptQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorScriptQueryResponse : AopResponse
    {
        /// <summary>
        ///     脚本内容，智能卡中心自定义的脚本格式内容
        /// </summary>
        [XmlElement("content")]
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        ///     脚本更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        [JsonProperty("gmt_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtModified { get; set; }
    }
}