using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessLicenceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessLicenceInfo : AopObject
    {
        /// <summary>
        /// 营业执照授权函图片，个体工商户如果使用总公司或其他公司的营业执照认证需上传该授权函图片
        /// </summary>
        [XmlElement("business_license_auth_pic")]
		[JsonProperty("business_license_auth_pic", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// 营业执照所在城市，使用国家行政区划代码，可参考http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/
        /// </summary>
        [XmlElement("business_license_city")]
		[JsonProperty("business_license_city", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessLicenseCity { get; set; }

        /// <summary>
        /// 营业执照有效期，传入营业执照上营业期限到期日，格式为YYYY-MM-DD，如为长期则传入9999-12-31
        /// </summary>
        [XmlElement("business_license_indate")]
		[JsonProperty("business_license_indate", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessLicenseIndate { get; set; }

        /// <summary>
        /// 营业执照是否为三证合一，个体工商户可忽略该字段，企业级商户的营业执照如为三证合一的新营业执照则传true
        /// </summary>
        [XmlElement("business_license_is_three_in_one")]
		[JsonProperty("business_license_is_three_in_one", NullValueHandling = NullValueHandling.Ignore)]
        public bool BusinessLicenseIsThreeInOne { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        [XmlElement("business_license_no")]
		[JsonProperty("business_license_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片
        /// </summary>
        [XmlElement("business_license_pic")]
		[JsonProperty("business_license_pic", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessLicensePic { get; set; }

        /// <summary>
        /// 营业执照所在地省份，使用国家行政区划代码，可参考http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/
        /// </summary>
        [XmlElement("business_license_province")]
		[JsonProperty("business_license_province", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessLicenseProvince { get; set; }

        /// <summary>
        /// 营业执照上的企业经营范围
        /// </summary>
        [XmlElement("business_scope")]
		[JsonProperty("business_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 营业执照上的企业联系地址
        /// </summary>
        [XmlElement("company_address")]
		[JsonProperty("company_address", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyAddress { get; set; }

        /// <summary>
        /// 营业执照上的企业名称
        /// </summary>
        [XmlElement("company_name")]
		[JsonProperty("company_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        /// <summary>
        /// 组织机构代码证号码，个体工商户忽略该字段，企业级商户如营业执照非三证合一需要传入该字段否则预校验会不通过
        /// </summary>
        [XmlElement("org_code_certificate_no")]
		[JsonProperty("org_code_certificate_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgCodeCertificateNo { get; set; }

        /// <summary>
        /// 组织机构代码证图片，个体工商户忽略该字段，企业级商户如营业执照非三证合一需要传入该字段否则预校验会不通过
        /// </summary>
        [XmlElement("org_code_certificate_pic")]
		[JsonProperty("org_code_certificate_pic", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgCodeCertificatePic { get; set; }
    }
}
