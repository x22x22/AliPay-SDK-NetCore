using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayZdatafrontDatatransferedFileuploadResponse.
    /// </summary>
    public class AlipayZdatafrontDatatransferedFileuploadResponse : AopResponse
    {
        /// <summary>
        ///     返回用户数据推送产生的结果数据，如picPath为文件上传后返回文件内部存储的位置信息
        /// </summary>
        [XmlElement("result_data")]
        [JsonProperty("result_data", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultData { get; set; }

        /// <summary>
        ///     数据上传结果，true/false
        /// </summary>
        [XmlElement("success")]
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public string Success { get; set; }
    }
}