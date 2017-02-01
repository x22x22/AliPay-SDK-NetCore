using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayOfflineMarketReportGetResponse.
    /// </summary>
    public class AlipayOfflineMarketReportGetResponse : AopResponse
    {
        /// <summary>
        ///     街道
        /// </summary>
        [XmlElement("address")]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        ///     近30日交易金额
        /// </summary>
        [XmlElement("amount_in_30_days")]
        [JsonProperty("amount_in_30_days", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountIn30Days { get; set; }

        /// <summary>
        ///     近7日交易金额
        /// </summary>
        [XmlElement("amount_in_7_days")]
        [JsonProperty("amount_in_7_days", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountIn7Days { get; set; }

        /// <summary>
        ///     人均消费金额(单位:分,下同)
        /// </summary>
        [XmlElement("amount_per_capita")]
        [JsonProperty("amount_per_capita", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountPerCapita { get; set; }

        /// <summary>
        ///     昨日交易金额
        /// </summary>
        [XmlElement("amount_yesterday")]
        [JsonProperty("amount_yesterday", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountYesterday { get; set; }

        /// <summary>
        ///     大区
        /// </summary>
        [XmlElement("area")]
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        ///     WAITING_ASSIGN(待分配)、确认中(CONFIRMING)、已分配(ASSIGNED)
        /// </summary>
        [XmlElement("assign_status")]
        [JsonProperty("assign_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignStatus { get; set; }

        /// <summary>
        ///     后台小二的UID
        /// </summary>
        [XmlElement("bd_staff_uid")]
        [JsonProperty("bd_staff_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string BdStaffUid { get; set; }

        /// <summary>
        ///     品牌
        /// </summary>
        [XmlElement("brand_name")]
        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        ///     城市
        /// </summary>
        [XmlElement("city")]
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        ///     市代码
        /// </summary>
        [XmlElement("city_code")]
        [JsonProperty("city_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CityCode { get; set; }

        /// <summary>
        ///     城市经理
        /// </summary>
        [XmlElement("city_manager_name")]
        [JsonProperty("city_manager_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CityManagerName { get; set; }

        /// <summary>
        ///     城市经理uid
        /// </summary>
        [XmlElement("city_manager_uid")]
        [JsonProperty("city_manager_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string CityManagerUid { get; set; }

        /// <summary>
        ///     竞对最低折扣值
        /// </summary>
        [XmlElement("competitor_lowest_discount")]
        [JsonProperty("competitor_lowest_discount", NullValueHandling = NullValueHandling.Ignore)]
        public string CompetitorLowestDiscount { get; set; }

        /// <summary>
        ///     1：全民开店的数据开店类型显示为全民开店；0：非全民开店的数据开店类型显示为非全民开店；
        /// </summary>
        [XmlElement("create_channel")]
        [JsonProperty("create_channel", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateChannel { get; set; }

        /// <summary>
        ///     三级行业
        /// </summary>
        [XmlElement("detail_category")]
        [JsonProperty("detail_category", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailCategory { get; set; }

        /// <summary>
        ///     三级行业编号
        /// </summary>
        [XmlElement("detail_category_code")]
        [JsonProperty("detail_category_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailCategoryCode { get; set; }

        /// <summary>
        ///     折扣id
        /// </summary>
        [XmlElement("discount_id")]
        [JsonProperty("discount_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountId { get; set; }

        /// <summary>
        ///     区(县)
        /// </summary>
        [XmlElement("district")]
        [JsonProperty("district", NullValueHandling = NullValueHandling.Ignore)]
        public string District { get; set; }

        /// <summary>
        ///     区县代码
        /// </summary>
        [XmlElement("district_code")]
        [JsonProperty("district_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DistrictCode { get; set; }

        /// <summary>
        ///     当面付审核状态
        /// </summary>
        [XmlElement("f2f_audit_status")]
        [JsonProperty("f2f_audit_status", NullValueHandling = NullValueHandling.Ignore)]
        public string F2fAuditStatus { get; set; }

        /// <summary>
        ///     当面付生效时间
        /// </summary>
        [XmlElement("f2f_online")]
        [JsonProperty("f2f_online", NullValueHandling = NullValueHandling.Ignore)]
        public string F2fOnline { get; set; }

        /// <summary>
        ///     当面付签约次数
        /// </summary>
        [XmlElement("f2f_sign_count")]
        [JsonProperty("f2f_sign_count", NullValueHandling = NullValueHandling.Ignore)]
        public string F2fSignCount { get; set; }

        /// <summary>
        ///     当面付状态
        /// </summary>
        [XmlElement("f2f_status")]
        [JsonProperty("f2f_status", NullValueHandling = NullValueHandling.Ignore)]
        public string F2fStatus { get; set; }

        /// <summary>
        ///     当面付签约情况-版本
        /// </summary>
        [XmlElement("f2f_version")]
        [JsonProperty("f2f_version", NullValueHandling = NullValueHandling.Ignore)]
        public string F2fVersion { get; set; }

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
        ///     当面付签约次数
        /// </summary>
        [XmlElement("ff_sign_count")]
        [JsonProperty("ff_sign_count", NullValueHandling = NullValueHandling.Ignore)]
        public string FfSignCount { get; set; }

        /// <summary>
        ///     当面付状态
        /// </summary>
        [XmlElement("ff_status")]
        [JsonProperty("ff_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FfStatus { get; set; }

        /// <summary>
        ///     当面付签约情况-版本
        /// </summary>
        [XmlElement("ff_version")]
        [JsonProperty("ff_version", NullValueHandling = NullValueHandling.Ignore)]
        public string FfVersion { get; set; }

        /// <summary>
        ///     门店创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        ///     门店修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        [JsonProperty("gmt_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtModified { get; set; }

        /// <summary>
        ///     有无折扣
        /// </summary>
        [XmlElement("has_discount")]
        [JsonProperty("has_discount", NullValueHandling = NullValueHandling.Ignore)]
        public string HasDiscount { get; set; }

        /// <summary>
        ///     是否享受立减(0:否；1:是)
        /// </summary>
        [XmlElement("has_discount_privilege")]
        [JsonProperty("has_discount_privilege", NullValueHandling = NullValueHandling.Ignore)]
        public string HasDiscountPrivilege { get; set; }

        /// <summary>
        ///     是否有机具
        /// </summary>
        [XmlElement("has_equipment")]
        [JsonProperty("has_equipment", NullValueHandling = NullValueHandling.Ignore)]
        public string HasEquipment { get; set; }

        /// <summary>
        ///     有无双证
        /// </summary>
        [XmlElement("has_shuangzheng")]
        [JsonProperty("has_shuangzheng", NullValueHandling = NullValueHandling.Ignore)]
        public string HasShuangzheng { get; set; }

        /// <summary>
        ///     是否有全民折扣(0:否；1:是)
        /// </summary>
        [XmlElement("has_whole_people_discount")]
        [JsonProperty("has_whole_people_discount", NullValueHandling = NullValueHandling.Ignore)]
        public string HasWholePeopleDiscount { get; set; }

        /// <summary>
        ///     流水号
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        ///     是否在黑名单(0:否；1:是)
        /// </summary>
        [XmlElement("in_blacklist")]
        [JsonProperty("in_blacklist", NullValueHandling = NullValueHandling.Ignore)]
        public string InBlacklist { get; set; }

        /// <summary>
        ///     有效期30天以上折扣是否核销
        /// </summary>
        [XmlElement("item_consumed_30")]
        [JsonProperty("item_consumed_30", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemConsumed30 { get; set; }

        /// <summary>
        ///     有效期30天以上折扣数
        /// </summary>
        [XmlElement("item_count_30")]
        [JsonProperty("item_count_30", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemCount30 { get; set; }

        /// <summary>
        ///     是否ka
        /// </summary>
        [XmlElement("ka")]
        [JsonProperty("ka", NullValueHandling = NullValueHandling.Ignore)]
        public string Ka { get; set; }

        /// <summary>
        ///     leads商户名称
        /// </summary>
        [XmlElement("leads_name")]
        [JsonProperty("leads_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsName { get; set; }

        /// <summary>
        ///     城市经理或超级管理员确认门店分配的时间
        /// </summary>
        [XmlElement("manual_confirm_assign_time")]
        [JsonProperty("manual_confirm_assign_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ManualConfirmAssignTime { get; set; }

        /// <summary>
        ///     商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        [JsonProperty("merchant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantName { get; set; }

        /// <summary>
        ///     商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        [JsonProperty("merchant_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantPid { get; set; }

        /// <summary>
        ///     电话
        /// </summary>
        [XmlElement("mobile")]
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }

        /// <summary>
        ///     近30天大于2元订单量
        /// </summary>
        [XmlElement("order_1")]
        [JsonProperty("order_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Order1 { get; set; }

        /// <summary>
        ///     近1天大于2元订单量
        /// </summary>
        [XmlElement("order_in_1_day")]
        [JsonProperty("order_in_1_day", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderIn1Day { get; set; }

        /// <summary>
        ///     近7天内大于2元订单量
        /// </summary>
        [XmlElement("order_in_7_days")]
        [JsonProperty("order_in_7_days", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderIn7Days { get; set; }

        /// <summary>
        ///     一级行业
        /// </summary>
        [XmlElement("pri_category")]
        [JsonProperty("pri_category", NullValueHandling = NullValueHandling.Ignore)]
        public string PriCategory { get; set; }

        /// <summary>
        ///     一级行业编号
        /// </summary>
        [XmlElement("pri_category_code")]
        [JsonProperty("pri_category_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PriCategoryCode { get; set; }

        /// <summary>
        ///     省代码
        /// </summary>
        [XmlElement("prov_code")]
        [JsonProperty("prov_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvCode { get; set; }

        /// <summary>
        ///     服务商名称
        /// </summary>
        [XmlElement("provider_name")]
        [JsonProperty("provider_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderName { get; set; }

        /// <summary>
        ///     服务商Pid
        /// </summary>
        [XmlElement("provider_pid")]
        [JsonProperty("provider_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderPid { get; set; }

        /// <summary>
        ///     服务商小二
        /// </summary>
        [XmlElement("provider_staff_name")]
        [JsonProperty("provider_staff_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderStaffName { get; set; }

        /// <summary>
        ///     服务商小二uid
        /// </summary>
        [XmlElement("provider_staff_uid")]
        [JsonProperty("provider_staff_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderStaffUid { get; set; }

        /// <summary>
        ///     省
        /// </summary>
        [XmlElement("province")]
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        ///     全民开店类型的推荐人,体现为归属人
        /// </summary>
        [XmlElement("recommender")]
        [JsonProperty("recommender", NullValueHandling = NullValueHandling.Ignore)]
        public string Recommender { get; set; }

        /// <summary>
        ///     推荐人类型
        /// </summary>
        [XmlElement("recommender_type")]
        [JsonProperty("recommender_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RecommenderType { get; set; }

        /// <summary>
        ///     门店审核状态(审核中|审核通过|审核失败)
        /// </summary>
        [XmlElement("shop_audit_status")]
        [JsonProperty("shop_audit_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopAuditStatus { get; set; }

        /// <summary>
        ///     门店编号
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }

        /// <summary>
        ///     店铺运营等级，0：全国KA，1：城市重点，2：中小，3：长尾
        /// </summary>
        [XmlElement("shop_level")]
        [JsonProperty("shop_level", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopLevel { get; set; }

        /// <summary>
        ///     店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        [JsonProperty("shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopName { get; set; }

        /// <summary>
        ///     门店首次上架时间
        /// </summary>
        [XmlElement("shop_online")]
        [JsonProperty("shop_online", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopOnline { get; set; }

        /// <summary>
        ///     开店来源。有服务商开店，商家自主开店，全民个人开店等
        /// </summary>
        [XmlElement("shop_source")]
        [JsonProperty("shop_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopSource { get; set; }

        /// <summary>
        ///     门店标签,多个以逗号分隔
        /// </summary>
        [XmlElement("shop_tag")]
        [JsonProperty("shop_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopTag { get; set; }

        /// <summary>
        ///     二级行业
        /// </summary>
        [XmlElement("sub_category")]
        [JsonProperty("sub_category", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCategory { get; set; }

        /// <summary>
        ///     二级行业编号
        /// </summary>
        [XmlElement("sub_category_code")]
        [JsonProperty("sub_category_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCategoryCode { get; set; }

        /// <summary>
        ///     电话
        /// </summary>
        [XmlElement("telephone")]
        [JsonProperty("telephone", NullValueHandling = NullValueHandling.Ignore)]
        public string Telephone { get; set; }

        /// <summary>
        ///     近30天大于2元用户数
        /// </summary>
        [XmlElement("user_1")]
        [JsonProperty("user_1", NullValueHandling = NullValueHandling.Ignore)]
        public string User1 { get; set; }

        /// <summary>
        ///     user_in_1_day
        /// </summary>
        [XmlElement("user_in_1_day")]
        [JsonProperty("user_in_1_day", NullValueHandling = NullValueHandling.Ignore)]
        public string UserIn1Day { get; set; }

        /// <summary>
        ///     近7天内大于2元的用户数
        /// </summary>
        [XmlElement("user_in_7_days")]
        [JsonProperty("user_in_7_days", NullValueHandling = NullValueHandling.Ignore)]
        public string UserIn7Days { get; set; }

        /// <summary>
        ///     近1天核销笔数
        /// </summary>
        [XmlElement("verification_in_1_day")]
        [JsonProperty("verification_in_1_day", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationIn1Day { get; set; }

        /// <summary>
        ///     近30天内核销笔数
        /// </summary>
        [XmlElement("verification_in_30_days")]
        [JsonProperty("verification_in_30_days", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationIn30Days { get; set; }

        /// <summary>
        ///     近7天内核销笔数
        /// </summary>
        [XmlElement("verification_in_7_days")]
        [JsonProperty("verification_in_7_days", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationIn7Days { get; set; }

        /// <summary>
        ///     全民最低折扣值
        /// </summary>
        [XmlElement("whole_people_lowest_discount")]
        [JsonProperty("whole_people_lowest_discount", NullValueHandling = NullValueHandling.Ignore)]
        public string WholePeopleLowestDiscount { get; set; }
    }
}