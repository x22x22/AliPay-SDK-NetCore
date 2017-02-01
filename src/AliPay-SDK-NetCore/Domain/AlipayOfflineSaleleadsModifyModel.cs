using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSaleleadsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSaleleadsModifyModel : AopObject
    {
        /// <summary>
        /// 联系地址
        /// </summary>
        [XmlElement("address")]
		[JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 商户品牌名称
        /// </summary>
        [XmlElement("brand_name")]
		[JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        /// 行业大类
        /// </summary>
        [XmlElement("category_id")]
		[JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }

        /// <summary>
        /// 市编码
        /// </summary>
        [XmlElement("city_code")]
		[JsonProperty("city_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CityCode { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("contact_mobile")]
		[JsonProperty("contact_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact_name")]
		[JsonProperty("contact_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("description")]
		[JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 行业三级分类
        /// </summary>
        [XmlElement("detail_category_id")]
		[JsonProperty("detail_category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailCategoryId { get; set; }

        /// <summary>
        /// 区编码
        /// </summary>
        [XmlElement("district_code")]
		[JsonProperty("district_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 需要修改leadsID
        /// </summary>
        [XmlElement("leads_id")]
		[JsonProperty("leads_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsId { get; set; }

        /// <summary>
        /// 商户营业执照名称
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 操作人PID
        /// </summary>
        [XmlElement("ope_pid")]
		[JsonProperty("ope_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string OpePid { get; set; }

        /// <summary>
        /// 其他联系方式
        /// </summary>
        [XmlElement("other_contact_info")]
		[JsonProperty("other_contact_info", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherContactInfo { get; set; }

        /// <summary>
        /// 省编码
        /// </summary>
        [XmlElement("province_code")]
		[JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 全局唯一的流水号
        /// </summary>
        [XmlElement("request_id")]
		[JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 门店数
        /// </summary>
        [XmlElement("scale")]
		[JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public string Scale { get; set; }

        /// <summary>
        /// 门店信息json字符串
        /// </summary>
        [XmlElement("shop_info")]
		[JsonProperty("shop_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopInfo { get; set; }

        /// <summary>
        /// 行业小类
        /// </summary>
        [XmlElement("sub_category_id")]
		[JsonProperty("sub_category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCategoryId { get; set; }
    }
}
