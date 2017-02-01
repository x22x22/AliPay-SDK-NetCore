using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     ZhimaDataFeedbackurlQueryResponse.
    /// </summary>
    public class ZhimaDataFeedbackurlQueryResponse : AopResponse
    {
        /// <summary>
        ///     反馈模板地址
        /// </summary>
        [XmlElement("feedback_url")]
        [JsonProperty("feedback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FeedbackUrl { get; set; }
    }
}