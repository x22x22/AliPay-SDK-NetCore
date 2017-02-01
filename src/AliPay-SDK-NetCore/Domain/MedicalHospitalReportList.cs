using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalHospitalReportList Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHospitalReportList : AopObject
    {
        /// <summary>
        /// 报告产出日期 格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("report_date")]
		[JsonProperty("report_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportDate { get; set; }

        /// <summary>
        /// 报告说明
        /// </summary>
        [XmlElement("report_desc")]
		[JsonProperty("report_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportDesc { get; set; }

        /// <summary>
        /// 报告详情连接
        /// </summary>
        [XmlElement("report_link")]
		[JsonProperty("report_link", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportLink { get; set; }

        /// <summary>
        /// 报告名称
        /// </summary>
        [XmlElement("report_name")]
		[JsonProperty("report_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportName { get; set; }

        /// <summary>
        /// 报告类型:  CHECK_REPORT 检查报告  EXAM_REPORT检验报告
        /// </summary>
        [XmlElement("report_type")]
		[JsonProperty("report_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportType { get; set; }
    }
}
