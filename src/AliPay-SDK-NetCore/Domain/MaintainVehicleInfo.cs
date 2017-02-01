using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     MaintainVehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MaintainVehicleInfo : AopObject
    {
        /// <summary>
        ///     背景图片
        /// </summary>
        [XmlElement("bg_url")]
        [JsonProperty("bg_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BgUrl { get; set; }

        /// <summary>
        ///     发动机编号
        /// </summary>
        [XmlElement("engine_no")]
        [JsonProperty("engine_no", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineNo { get; set; }

        /// <summary>
        ///     发动机类型
        /// </summary>
        [XmlElement("engine_type")]
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineType { get; set; }

        /// <summary>
        ///     生产厂商
        /// </summary>
        [XmlElement("manufacturer")]
        [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        public string Manufacturer { get; set; }

        /// <summary>
        ///     生产年份
        /// </summary>
        [XmlElement("production_year")]
        [JsonProperty("production_year", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductionYear { get; set; }

        /// <summary>
        ///     发动机排量
        /// </summary>
        [XmlArray("swept_volume")]
        [XmlArrayItem("string")]
        public List<string> SweptVolume { get; set; }

        /// <summary>
        ///     品牌Logo
        /// </summary>
        [XmlElement("vi_brand_logo")]
        [JsonProperty("vi_brand_logo", NullValueHandling = NullValueHandling.Ignore)]
        public string ViBrandLogo { get; set; }

        /// <summary>
        ///     品牌名称
        /// </summary>
        [XmlElement("vi_brand_name")]
        [JsonProperty("vi_brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ViBrandName { get; set; }

        /// <summary>
        ///     车辆归属地id
        /// </summary>
        [XmlElement("vi_city_id")]
        [JsonProperty("vi_city_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ViCityId { get; set; }

        /// <summary>
        ///     城市名称
        /// </summary>
        [XmlElement("vi_city_name")]
        [JsonProperty("vi_city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ViCityName { get; set; }

        /// <summary>
        ///     车辆图标URL
        /// </summary>
        [XmlElement("vi_logo_url")]
        [JsonProperty("vi_logo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ViLogoUrl { get; set; }

        /// <summary>
        ///     行驶里程
        /// </summary>
        [XmlElement("vi_mileage")]
        [JsonProperty("vi_mileage", NullValueHandling = NullValueHandling.Ignore)]
        public string ViMileage { get; set; }

        /// <summary>
        ///     车型名称
        /// </summary>
        [XmlElement("vi_model_name")]
        [JsonProperty("vi_model_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ViModelName { get; set; }

        /// <summary>
        ///     车牌号
        /// </summary>
        [XmlElement("vi_number")]
        [JsonProperty("vi_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ViNumber { get; set; }

        /// <summary>
        ///     车系名称
        /// </summary>
        [XmlElement("vi_series_name")]
        [JsonProperty("vi_series_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ViSeriesName { get; set; }

        /// <summary>
        ///     上路日期
        /// </summary>
        [XmlElement("vi_start_time")]
        [JsonProperty("vi_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ViStartTime { get; set; }

        /// <summary>
        ///     年款
        /// </summary>
        [XmlElement("vi_style_name")]
        [JsonProperty("vi_style_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ViStyleName { get; set; }

        /// <summary>
        ///     行驶里程
        /// </summary>
        [XmlArray("vi_vin")]
        [XmlArrayItem("string")]
        public List<string> ViVin { get; set; }
    }
}