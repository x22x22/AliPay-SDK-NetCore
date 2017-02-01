using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     MerchantSaleLeadsQueryBypageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSaleLeadsQueryBypageDTO : AopObject
    {
        /// <summary>
        ///     地址
        /// </summary>
        [XmlElement("address")]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        ///     认领Leads的服务商支付宝卡号
        /// </summary>
        [XmlElement("agent_alipay_card_no")]
        [JsonProperty("agent_alipay_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentAlipayCardNo { get; set; }

        /// <summary>
        ///     商户支付宝卡号
        /// </summary>
        [XmlElement("alipay_card_no")]
        [JsonProperty("alipay_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayCardNo { get; set; }

        /// <summary>
        ///     所属区域
        /// </summary>
        [XmlElement("area")]
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        ///     所属支付宝小二
        /// </summary>
        [XmlElement("assign_alipay_staff_id")]
        [JsonProperty("assign_alipay_staff_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignAlipayStaffId { get; set; }

        /// <summary>
        ///     分配主体----服务商小二
        /// </summary>
        [XmlElement("assign_principal_id")]
        [JsonProperty("assign_principal_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignPrincipalId { get; set; }

        /// <summary>
        ///     品牌名称
        /// </summary>
        [XmlElement("brand")]
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        ///     品牌编码
        /// </summary>
        [XmlElement("brand_code")]
        [JsonProperty("brand_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandCode { get; set; }

        /// <summary>
        ///     分类说明
        /// </summary>
        [XmlElement("category")]
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        ///     商户认领状态
        /// </summary>
        [XmlElement("claim_status")]
        [JsonProperty("claim_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ClaimStatus { get; set; }

        /// <summary>
        ///     联系人手机号
        /// </summary>
        [XmlElement("contact_mobile")]
        [JsonProperty("contact_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactMobile { get; set; }

        /// <summary>
        ///     联系人
        /// </summary>
        [XmlElement("contact_name")]
        [JsonProperty("contact_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        /// <summary>
        ///     备注信息
        /// </summary>
        [XmlElement("description")]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        ///     扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        ///     当面付审核状态
        /// </summary>
        [XmlElement("ff_audit_status")]
        [JsonProperty("ff_audit_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FfAuditStatus { get; set; }

        /// <summary>
        ///     当面付生效时间
        /// </summary>
        [XmlElement("ff_online")]
        [JsonProperty("ff_online", NullValueHandling = NullValueHandling.Ignore)]
        public string FfOnline { get; set; }

        /// <summary>
        ///     leads创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        ///     是否开店
        /// </summary>
        [XmlElement("is_open_shop")]
        [JsonProperty("is_open_shop", NullValueHandling = NullValueHandling.Ignore)]
        public string IsOpenShop { get; set; }

        /// <summary>
        ///     leadsId
        /// </summary>
        [XmlElement("leands_id")]
        [JsonProperty("leands_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeandsId { get; set; }

        /// <summary>
        ///     leads名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///     其它联系方式
        /// </summary>
        [XmlElement("other_contact_info")]
        [JsonProperty("other_contact_info", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherContactInfo { get; set; }

        /// <summary>
        ///     门店数
        /// </summary>
        [XmlElement("scale")]
        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public string Scale { get; set; }

        /// <summary>
        ///     商户外部标识，来源于支付宝体系外
        /// </summary>
        [XmlElement("seller_id")]
        [JsonProperty("seller_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerId { get; set; }

        /// <summary>
        ///     商户外部标识类型，来源于支付宝体系外
        /// </summary>
        [XmlElement("seller_id_type")]
        [JsonProperty("seller_id_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerIdType { get; set; }

        /// <summary>
        ///     门店信息
        /// </summary>
        [XmlElement("shop_info")]
        [JsonProperty("shop_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopInfo { get; set; }

        /// <summary>
        ///     当leads签约的pid是非云纵pid，且leads是被签约的leads信息说明
        /// </summary>
        [XmlElement("show_info")]
        [JsonProperty("show_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ShowInfo { get; set; }

        /// <summary>
        ///     签约审核状态
        /// </summary>
        [XmlElement("sign_audit_status")]
        [JsonProperty("sign_audit_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SignAuditStatus { get; set; }

        /// <summary>
        ///     签约状态
        /// </summary>
        [XmlElement("sign_status")]
        [JsonProperty("sign_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SignStatus { get; set; }
    }
}