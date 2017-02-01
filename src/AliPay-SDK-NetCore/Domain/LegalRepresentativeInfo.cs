using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LegalRepresentativeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LegalRepresentativeInfo : AopObject
    {
        /// <summary>
        /// 法人证件有效期，YYYY-MM-DD格式
        /// </summary>
        [XmlElement("legal_representative_cert_indate")]
		[JsonProperty("legal_representative_cert_indate", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalRepresentativeCertIndate { get; set; }

        /// <summary>
        /// 法人证件号码
        /// </summary>
        [XmlElement("legal_representative_cert_no")]
		[JsonProperty("legal_representative_cert_no", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalRepresentativeCertNo { get; set; }

        /// <summary>
        /// 法人证件背面照片（如证件为身份证则上传身份证国徽面图片）
        /// </summary>
        [XmlElement("legal_representative_cert_pic_back")]
		[JsonProperty("legal_representative_cert_pic_back", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalRepresentativeCertPicBack { get; set; }

        /// <summary>
        /// 法人证件正面照片（如证件为身份证则上传身份证头像面图片）
        /// </summary>
        [XmlElement("legal_representative_cert_pic_front")]
		[JsonProperty("legal_representative_cert_pic_front", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalRepresentativeCertPicFront { get; set; }

        /// <summary>
        /// 法人证件类型，支持传入的类型为：RESIDENT(居民身份证)括号中为每种类型的释义，不需要将括号中的内容当参数内容传入。
        /// </summary>
        [XmlElement("legal_representative_cert_type")]
		[JsonProperty("legal_representative_cert_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalRepresentativeCertType { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("legal_representative_name")]
		[JsonProperty("legal_representative_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalRepresentativeName { get; set; }
    }
}
