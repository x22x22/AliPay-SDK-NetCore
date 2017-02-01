using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSaleLeadsQueryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSaleLeadsQueryDTO : AopObject
    {
        /// <summary>
        /// 联系地址
        /// </summary>
        [XmlElement("address")]
		[JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 所在区域
        /// </summary>
        [XmlElement("area")]
		[JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        /// 归属人支付宝PID
        /// </summary>
        [XmlElement("assign_alipay_staff_id")]
		[JsonProperty("assign_alipay_staff_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignAlipayStaffId { get; set; }

        /// <summary>
        /// 归属人
        /// </summary>
        [XmlElement("assign_person")]
		[JsonProperty("assign_person", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignPerson { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand")]
		[JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// 行业分类
        /// </summary>
        [XmlElement("category")]
		[JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 认领时间
        /// </summary>
        [XmlElement("claim_date")]
		[JsonProperty("claim_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ClaimDate { get; set; }

        /// <summary>
        /// 认领状态
        /// </summary>
        [XmlElement("claim_status")]
		[JsonProperty("claim_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("contact_mobile")]
		[JsonProperty("contact_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人姓名
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
        /// leadsid
        /// </summary>
        [XmlElement("leads_id")]
		[JsonProperty("leads_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsId { get; set; }

        /// <summary>
        /// 商户名称（公司名称）
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 其他联系方式
        /// </summary>
        [XmlElement("other_contact_info")]
		[JsonProperty("other_contact_info", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherContactInfo { get; set; }

        /// <summary>
        /// 门店数
        /// </summary>
        [XmlElement("scale")]
		[JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public string Scale { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlElement("shop_info")]
		[JsonProperty("shop_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopInfo { get; set; }
    }
}
