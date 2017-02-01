using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperatorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorInfo : AopObject
    {
        /// <summary>
        /// 个体工商户经营者证件到期日，格式为YYYY-MM-DD
        /// </summary>
        [XmlElement("operator_cert_indate")]
		[JsonProperty("operator_cert_indate", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorCertIndate { get; set; }

        /// <summary>
        /// 个体工商户经营者证件号码
        /// </summary>
        [XmlElement("operator_cert_no")]
		[JsonProperty("operator_cert_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorCertNo { get; set; }

        /// <summary>
        /// 个体工商户经营者证件照片背面图片（如证件类型为身份证则上传国徽面图片）
        /// </summary>
        [XmlElement("operator_cert_pic_back")]
		[JsonProperty("operator_cert_pic_back", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorCertPicBack { get; set; }

        /// <summary>
        /// 个体工商户经营者证件正面照片（如证件类型为身份证则需要上传头像面图片）
        /// </summary>
        [XmlElement("operator_cert_pic_front")]
		[JsonProperty("operator_cert_pic_front", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorCertPicFront { get; set; }

        /// <summary>
        /// 个体工商户经营者证件类型，支持传入的类型为：RESIDENT(居民身份证)括号中为每种类型的释义，不需要将括号中的内容当参数内容传入。
        /// </summary>
        [XmlElement("operator_cert_type")]
		[JsonProperty("operator_cert_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorCertType { get; set; }

        /// <summary>
        /// 张三
        /// </summary>
        [XmlElement("operator_name")]
		[JsonProperty("operator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorName { get; set; }
    }
}
