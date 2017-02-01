using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ShopSummaryQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ShopSummaryQueryResponse : AopObject
    {
        /// <summary>
        ///     门店地址
        /// </summary>
        [XmlElement("address")]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        ///     分店名
        /// </summary>
        [XmlElement("branch_shop_name")]
        [JsonProperty("branch_shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchShopName { get; set; }

        /// <summary>
        ///     品牌名，不填写则默认为其它品牌
        /// </summary>
        [XmlElement("brand_name")]
        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        ///     经营时间
        /// </summary>
        [XmlElement("business_time")]
        [JsonProperty("business_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessTime { get; set; }

        /// <summary>
        ///     门店类目列表
        /// </summary>
        [XmlArray("category_infos")]
        [XmlArrayItem("shop_category_info")]
        public List<ShopCategoryInfo> CategoryInfos { get; set; }

        /// <summary>
        ///     城市编码，国标码，详见国家统计局数据
        ///     <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>
        /// </summary>
        [XmlElement("city_code")]
        [JsonProperty("city_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CityCode { get; set; }

        /// <summary>
        ///     区县编码，国标码，详见国家统计局数据
        ///     <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>
        /// </summary>
        [XmlElement("district_code")]
        [JsonProperty("district_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DistrictCode { get; set; }

        /// <summary>
        ///     创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        ///     门店是否在客户端显示，T表示显示，F表示隐藏
        /// </summary>
        [XmlElement("is_show")]
        [JsonProperty("is_show", NullValueHandling = NullValueHandling.Ignore)]
        public string IsShow { get; set; }

        /// <summary>
        ///     门店首图
        /// </summary>
        [XmlElement("main_image")]
        [JsonProperty("main_image", NullValueHandling = NullValueHandling.Ignore)]
        public string MainImage { get; set; }

        /// <summary>
        ///     主门店名
        /// </summary>
        [XmlElement("main_shop_name")]
        [JsonProperty("main_shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MainShopName { get; set; }

        /// <summary>
        ///     图片集，是map转化成的json串，key是图片id,value是图片url
        /// </summary>
        [XmlElement("pic_coll")]
        [JsonProperty("pic_coll", NullValueHandling = NullValueHandling.Ignore)]
        public string PicColl { get; set; }

        /// <summary>
        ///     省份编码，国标码，详见国家统计局数据
        ///     <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>
        /// </summary>
        [XmlElement("province_code")]
        [JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceCode { get; set; }

        /// <summary>
        ///     门店评论信息
        /// </summary>
        [XmlElement("shop_comment_info")]
        [JsonProperty("shop_comment_info", NullValueHandling = NullValueHandling.Ignore)]
        public ShopCommentInfo ShopCommentInfo { get; set; }

        /// <summary>
        ///     门店ID
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }

        /// <summary>
        ///     COMMON（普通门店）、MALL（商圈）
        /// </summary>
        [XmlElement("shop_type")]
        [JsonProperty("shop_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopType { get; set; }

        /// <summary>
        ///     门店状态，OPEN：营业中、PAUSE：暂停营业、FREEZE：已冻结、CLOSE:门店已关闭
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}