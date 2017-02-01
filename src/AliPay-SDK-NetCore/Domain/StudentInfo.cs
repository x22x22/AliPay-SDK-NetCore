using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StudentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StudentInfo : AopObject
    {
        /// <summary>
        /// 学校所在行政区域编码
        /// </summary>
        [XmlElement("city_no")]
		[JsonProperty("city_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CityNo { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        [XmlElement("class_name")]
		[JsonProperty("class_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassName { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("college_name")]
		[JsonProperty("college_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CollegeName { get; set; }

        /// <summary>
        /// 学校机构编号
        /// </summary>
        [XmlElement("college_no")]
		[JsonProperty("college_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CollegeNo { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        [XmlElement("degree")]
		[JsonProperty("degree", NullValueHandling = NullValueHandling.Ignore)]
        public string Degree { get; set; }

        /// <summary>
        /// 院系
        /// </summary>
        [XmlElement("departments")]
		[JsonProperty("departments", NullValueHandling = NullValueHandling.Ignore)]
        public string Departments { get; set; }

        /// <summary>
        /// 入校时间
        /// </summary>
        [XmlElement("gmt_enrollment")]
		[JsonProperty("gmt_enrollment", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtEnrollment { get; set; }

        /// <summary>
        /// 毕业时间
        /// </summary>
        [XmlElement("gmt_graduation")]
		[JsonProperty("gmt_graduation", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtGraduation { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        [XmlElement("major")]
		[JsonProperty("major", NullValueHandling = NullValueHandling.Ignore)]
        public string Major { get; set; }

        /// <summary>
        /// 学生证号
        /// </summary>
        [XmlElement("student_id")]
		[JsonProperty("student_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StudentId { get; set; }
    }
}
