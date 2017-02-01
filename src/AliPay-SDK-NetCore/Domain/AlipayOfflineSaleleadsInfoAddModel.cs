using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSaleleadsInfoAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSaleleadsInfoAddModel : AopObject
    {
        /// <summary>
        /// 联系地址
        /// </summary>
        [XmlElement("address")]
		[JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 品牌名称
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
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
		[JsonProperty("city_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CityCode { get; set; }

        /// <summary>
        /// 11位数字手机号
        /// </summary>
        [XmlElement("contact_mobile")]
		[JsonProperty("contact_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
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
        /// 区域编码
        /// </summary>
        [XmlElement("district_code")]
		[JsonProperty("district_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 操作用户的支付账号id
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
        /// 省份编码，国家统一编码
        /// </summary>
        [XmlElement("province_code")]
		[JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 请求流水id
        /// </summary>
        [XmlElement("request_id")]
		[JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 1-99999999的数字
        /// </summary>
        [XmlElement("scale")]
		[JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public long Scale { get; set; }

        /// <summary>
        /// json数组的字符串
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
