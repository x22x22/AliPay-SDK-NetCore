using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSaleleadsInfoQuerybypageModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSaleleadsInfoQuerybypageModel : AopObject
    {
        /// <summary>
        /// 分配主体----服务商小二
        /// </summary>
        [XmlElement("assign_principal_id")]
		[JsonProperty("assign_principal_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignPrincipalId { get; set; }

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
        /// 三级分类
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
        /// 查询截止时间，如果是公海查询表示创建时间，私海查询表示认领时间
        /// </summary>
        [XmlElement("end_time")]
		[JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// leads名称
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("ope_type")]
		[JsonProperty("ope_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeType { get; set; }

        /// <summary>
        /// 当前页，***注意页数从1开始***
        /// </summary>
        [XmlElement("page_num")]
		[JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页容量：最小1，最大100
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }

        /// <summary>
        /// 省编码
        /// </summary>
        [XmlElement("province_code")]
		[JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 查询时间
        /// </summary>
        [XmlElement("query_time")]
		[JsonProperty("query_time", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryTime { get; set; }

        /// <summary>
        /// 门店标签，注意传多个分店信息无法匹配
        /// </summary>
        [XmlElement("shop_name")]
		[JsonProperty("shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopName { get; set; }

        /// <summary>
        /// 签约确认状态
        /// </summary>
        [XmlElement("sign_status")]
		[JsonProperty("sign_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SignStatus { get; set; }

        /// <summary>
        /// 查询起始时间，如果是公海查询表示创建时间，私海查询表示认领时间
        /// </summary>
        [XmlElement("start_time")]
		[JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 行业小类
        /// </summary>
        [XmlElement("sub_category_id")]
		[JsonProperty("sub_category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCategoryId { get; set; }
    }
}
