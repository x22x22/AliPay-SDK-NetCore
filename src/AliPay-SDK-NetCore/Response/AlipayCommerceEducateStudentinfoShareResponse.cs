using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayCommerceEducateStudentinfoShareResponse.
    /// </summary>
    public class AlipayCommerceEducateStudentinfoShareResponse : AopResponse
    {
        /// <summary>
        ///     学生信息
        /// </summary>
        [XmlElement("student_info_share_result")]
        [JsonProperty("student_info_share_result", NullValueHandling = NullValueHandling.Ignore)]
        public EduStudentInfoShareResult StudentInfoShareResult { get; set; }
    }
}