using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     LeadsQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class LeadsQueryResponse : AopObject
    {
        /// <summary>
        ///     联系地址
        /// </summary>
        [XmlElement("address")]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        ///     门店授权函,营业执照与签约账号主体不一致时需要
        /// </summary>
        [XmlElement("auth_letter")]
        [JsonProperty("auth_letter", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthLetter { get; set; }

        /// <summary>
        ///     授权函url
        /// </summary>
        [XmlElement("auth_letter_url")]
        [JsonProperty("auth_letter_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthLetterUrl { get; set; }

        /// <summary>
        ///     人均消费价格
        /// </summary>
        [XmlElement("avg_price")]
        [JsonProperty("avg_price", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgPrice { get; set; }

        /// <summary>
        ///     门店是否有包厢，T表示有，F表示没有
        /// </summary>
        [XmlElement("box")]
        [JsonProperty("box", NullValueHandling = NullValueHandling.Ignore)]
        public string Box { get; set; }

        /// <summary>
        ///     分店名
        /// </summary>
        [XmlElement("branch_shop_name")]
        [JsonProperty("branch_shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchShopName { get; set; }

        /// <summary>
        ///     品牌LOGO; 图片ID。
        /// </summary>
        [XmlElement("brand_logo")]
        [JsonProperty("brand_logo", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandLogo { get; set; }

        /// <summary>
        ///     logo图片url
        /// </summary>
        [XmlElement("brand_logo_url")]
        [JsonProperty("brand_logo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandLogoUrl { get; set; }

        /// <summary>
        ///     品牌名，不填写则默认为“其它品牌”
        /// </summary>
        [XmlElement("brand_name")]
        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        ///     经营许可证
        /// </summary>
        [XmlElement("business_certificate")]
        [JsonProperty("business_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessCertificate { get; set; }

        /// <summary>
        ///     经营许可证有效期，格式：2020-03-20，只有餐饮类目需要
        /// </summary>
        [XmlElement("business_certificate_expires")]
        [JsonProperty("business_certificate_expires", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessCertificateExpires { get; set; }

        /// <summary>
        ///     许可证图片url
        /// </summary>
        [XmlElement("business_certificate_url")]
        [JsonProperty("business_certificate_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessCertificateUrl { get; set; }

        /// <summary>
        ///     营业时间，支持分段营业时间，以英文逗号分隔
        /// </summary>
        [XmlElement("business_time")]
        [JsonProperty("business_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessTime { get; set; }

        /// <summary>
        ///     最细的类目编号
        /// </summary>
        [XmlElement("category_id")]
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }

        /// <summary>
        ///     城市编码。  国标码，详见国家统计局数据。
        /// </summary>
        [XmlElement("city_code")]
        [JsonProperty("city_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CityCode { get; set; }

        /// <summary>
        ///     leads认领时间
        /// </summary>
        [XmlElement("claim_time")]
        [JsonProperty("claim_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ClaimTime { get; set; }

        /// <summary>
        ///     公司名称
        /// </summary>
        [XmlElement("company_name")]
        [JsonProperty("company_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        /// <summary>
        ///     联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        [JsonProperty("contact_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        /// <summary>
        ///     联系人手机号
        /// </summary>
        [XmlElement("contact_number")]
        [JsonProperty("contact_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactNumber { get; set; }

        /// <summary>
        ///     leads创建时间
        /// </summary>
        [XmlElement("create_time")]
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        ///     门店内景图。  建议上传3-10张，尺寸在2000px＊1500px以上，格式为bmp、png、jpg、gif，不超过10M。
        /// </summary>
        [XmlArray("detail_images")]
        [XmlArrayItem("string")]
        public List<string> DetailImages { get; set; }

        /// <summary>
        ///     门店内景图名称列表
        /// </summary>
        [XmlArray("detail_images_name")]
        [XmlArrayItem("string")]
        public List<string> DetailImagesName { get; set; }

        /// <summary>
        ///     门店内景图URL列表
        /// </summary>
        [XmlArray("detail_images_url")]
        [XmlArrayItem("string")]
        public List<string> DetailImagesUrl { get; set; }

        /// <summary>
        ///     区县编码。  国标码，详见国家统计局数据。
        /// </summary>
        [XmlElement("district_code")]
        [JsonProperty("district_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DistrictCode { get; set; }

        /// <summary>
        ///     扩展属性，JSON格式：keyMerchant-是否重点商户（T/F）
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        ///     机具号，多个之间以英文逗号分隔
        /// </summary>
        [XmlElement("implement_id")]
        [JsonProperty("implement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImplementId { get; set; }

        /// <summary>
        ///     是否已补全信息，如果为T，表示leads已经补全信息，可以开店
        /// </summary>
        [XmlElement("is_complete")]
        [JsonProperty("is_complete", NullValueHandling = NullValueHandling.Ignore)]
        public string IsComplete { get; set; }

        /// <summary>
        ///     是否隐藏：T-是，F-否。
        /// </summary>
        [XmlElement("is_hidden")]
        [JsonProperty("is_hidden", NullValueHandling = NullValueHandling.Ignore)]
        public string IsHidden { get; set; }

        /// <summary>
        ///     是否在其他平台开店，T表示有开店，F表示未开店，用于证明其开店资质，如无营业执照必须有在其他平台的开店资质才能入住口碑平台，其他平台主要包括美团、点评。
        /// </summary>
        [XmlElement("is_operating_online")]
        [JsonProperty("is_operating_online", NullValueHandling = NullValueHandling.Ignore)]
        public string IsOperatingOnline { get; set; }

        /// <summary>
        ///     是否系统导入leads：T-是，F-否。
        /// </summary>
        [XmlElement("is_system_import")]
        [JsonProperty("is_system_import", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSystemImport { get; set; }

        /// <summary>
        ///     纬度，注：高德坐标系，需要服务商引导用户校准经纬度
        /// </summary>
        [XmlElement("latitude")]
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public long Latitude { get; set; }

        /// <summary>
        ///     支付宝leads ID，后续的增删改查接口都使用该ID作为主键
        /// </summary>
        [XmlElement("leads_id")]
        [JsonProperty("leads_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsId { get; set; }

        /// <summary>
        ///     PUBLIC：公海 PRIVATE：私海
        /// </summary>
        [XmlElement("leads_range")]
        [JsonProperty("leads_range", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsRange { get; set; }

        /// <summary>
        ///     门店营业执照图片
        /// </summary>
        [XmlElement("licence")]
        [JsonProperty("licence", NullValueHandling = NullValueHandling.Ignore)]
        public string Licence { get; set; }

        /// <summary>
        ///     门店营业执照编号
        /// </summary>
        [XmlElement("licence_code")]
        [JsonProperty("licence_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenceCode { get; set; }

        /// <summary>
        ///     营业执照过期时间
        /// </summary>
        [XmlElement("licence_expires")]
        [JsonProperty("licence_expires", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenceExpires { get; set; }

        /// <summary>
        ///     门店营业执照名称
        /// </summary>
        [XmlElement("licence_name")]
        [JsonProperty("licence_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenceName { get; set; }

        /// <summary>
        ///     证照图片url
        /// </summary>
        [XmlElement("licence_url")]
        [JsonProperty("licence_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenceUrl { get; set; }

        /// <summary>
        ///     经度，注：高德坐标系，需要服务商引导用户校准经纬度
        /// </summary>
        [XmlElement("longitude")]
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public long Longitude { get; set; }

        /// <summary>
        ///     门店首图。  建议尺寸在2000px＊1500px以上，格式为bmp、png、jpg、gif，不超过10M。
        /// </summary>
        [XmlElement("main_image")]
        [JsonProperty("main_image", NullValueHandling = NullValueHandling.Ignore)]
        public string MainImage { get; set; }

        /// <summary>
        ///     门店首图名称
        /// </summary>
        [XmlElement("main_image_name")]
        [JsonProperty("main_image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MainImageName { get; set; }

        /// <summary>
        ///     门店首图URL
        /// </summary>
        [XmlElement("main_image_url")]
        [JsonProperty("main_image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string MainImageUrl { get; set; }

        /// <summary>
        ///     主门店名
        /// </summary>
        [XmlElement("main_shop_name")]
        [JsonProperty("main_shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MainShopName { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        [XmlElement("memo")]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        ///     是否有无烟区，T表示有无烟区，F表示没有无烟区
        /// </summary>
        [XmlElement("no_smoking")]
        [JsonProperty("no_smoking", NullValueHandling = NullValueHandling.Ignore)]
        public string NoSmoking { get; set; }

        /// <summary>
        ///     其他平台开店竞对图片url，多个url使用英文逗号隔开,isv迁移到新接口使用此字段，与is_operating_online=T配套使用。online_image升级到version=2.0版本后将废弃，使用online_url替代。
        /// </summary>
        [XmlElement("online_url")]
        [JsonProperty("online_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OnlineUrl { get; set; }

        /// <summary>
        ///     操作用户的支付账号id
        /// </summary>
        [XmlElement("op_id")]
        [JsonProperty("op_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OpId { get; set; }

        /// <summary>
        ///     支付宝内部使用，外部商户不需要填写此字段。其他资质
        /// </summary>
        [XmlElement("other_authorization")]
        [JsonProperty("other_authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherAuthorization { get; set; }

        /// <summary>
        ///     其他资质url列表，逗号分隔
        /// </summary>
        [XmlElement("other_authorization_url")]
        [JsonProperty("other_authorization_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherAuthorizationUrl { get; set; }

        /// <summary>
        ///     其他联系方式
        /// </summary>
        [XmlElement("other_contact_info")]
        [JsonProperty("other_contact_info", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherContactInfo { get; set; }

        /// <summary>
        ///     门店是否支持停车，T表示支持，F表示不支持
        /// </summary>
        [XmlElement("parking")]
        [JsonProperty("parking", NullValueHandling = NullValueHandling.Ignore)]
        public string Parking { get; set; }

        /// <summary>
        ///     付款方式：code_scanned_pay：付款码  online_pay：在线买单
        /// </summary>
        [XmlElement("pay_type")]
        [JsonProperty("pay_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PayType { get; set; }

        /// <summary>
        ///     省份编码。  国标码，详见国家统计局数据。
        /// </summary>
        [XmlElement("province_code")]
        [JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceCode { get; set; }

        /// <summary>
        ///     请求ID，标识本次创建请求
        /// </summary>
        [XmlElement("request_id")]
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        ///     leads状态。  INIT：未认领，CLAIMED：已认领，CONFIRMING：待商户确认，RELATED：已关联商户，OPENING：开店中，OPENED：已开店。
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        ///     外部门店编号；
        /// </summary>
        [XmlElement("store_id")]
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreId { get; set; }

        /// <summary>
        ///     门店其他的服务，门店与用户线下兑现
        /// </summary>
        [XmlElement("value_added")]
        [JsonProperty("value_added", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueAdded { get; set; }

        /// <summary>
        ///     门店是否支持WIFI，T表示支持，F表示不支持，不传在客户端不作展示
        /// </summary>
        [XmlElement("wifi")]
        [JsonProperty("wifi", NullValueHandling = NullValueHandling.Ignore)]
        public string Wifi { get; set; }
    }
}