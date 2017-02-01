using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketLeadsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketLeadsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
		[JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        /// 最细的类目编号
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
        /// 区域编码
        /// </summary>
        [XmlElement("district_code")]
		[JsonProperty("district_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 筛选记录创建时间的结束时间
        /// </summary>
        [XmlElement("end_time")]
		[JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 支付宝leads ID列表，最多一次查询100个leads详情。
        /// </summary>
        [XmlArray("leads_ids")]
        [XmlArrayItem("string")]
        public List<string> LeadsIds { get; set; }

        /// <summary>
        /// 若不以request_ids或者leads_ids查询，则此参数必填。PUBLIC：公海查询 PRIVATE：私海查询
        /// </summary>
        [XmlElement("leads_range")]
		[JsonProperty("leads_range", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsRange { get; set; }

        /// <summary>
        /// 操作用户的支付账号id
        /// </summary>
        [XmlElement("op_id")]
		[JsonProperty("op_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OpId { get; set; }

        /// <summary>
        /// 页码，留空标示第一页，默认20个结果为一页
        /// </summary>
        [XmlElement("page_no")]
		[JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页记录数，默认20，最大100
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long PageSize { get; set; }

        /// <summary>
        /// 省编码
        /// </summary>
        [XmlElement("province_code")]
		[JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 请求ID，根据请求ID精确查询，最多一次查询100个leads详情。
        /// </summary>
        [XmlArray("request_ids")]
        [XmlArrayItem("string")]
        public List<string> RequestIds { get; set; }

        /// <summary>
        /// 门店标签，注意传多个分店信息无法匹配
        /// </summary>
        [XmlElement("shop_name")]
		[JsonProperty("shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopName { get; set; }

        /// <summary>
        /// 筛选记录创建时间的起始时间
        /// </summary>
        [XmlElement("start_time")]
		[JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// Leads状态。INIT：未认领，CLAIMED：已认领，CONFIRMING：待商户确认，RELATED：已关联商户，OPENING：开店中，OPENED：已开店
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}
