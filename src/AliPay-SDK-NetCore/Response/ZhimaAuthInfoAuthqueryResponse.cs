using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     ZhimaAuthInfoAuthqueryResponse.
    /// </summary>
    public class ZhimaAuthInfoAuthqueryResponse : AopResponse
    {
        /// <summary>
        ///     是否已经授权,已授权:true,未授权:false
        /// </summary>
        [XmlElement("authorized")]
        [JsonProperty("authorized", NullValueHandling = NullValueHandling.Ignore)]
        public bool Authorized { get; set; }
    }
}