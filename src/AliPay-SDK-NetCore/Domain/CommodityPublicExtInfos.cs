using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommodityPublicExtInfos Data Structure.
    /// </summary>
    [Serializable]
    public class CommodityPublicExtInfos : AopObject
    {
        /// <summary>
        /// 前置url
        /// </summary>
        [XmlElement("action_url")]
		[JsonProperty("action_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 应用展台id
        /// </summary>
        [XmlElement("app_id")]
		[JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [XmlElement("category_name")]
		[JsonProperty("category_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
		[JsonProperty("city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CityName { get; set; }

        /// <summary>
        /// 服务插件ID
        /// </summary>
        [XmlElement("commodity_id")]
		[JsonProperty("commodity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityId { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [XmlElement("create_user_id")]
		[JsonProperty("create_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 挂载ID，用于确认唯一记录的主键对象
        /// </summary>
        [XmlElement("displayapp_id")]
		[JsonProperty("displayapp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayappId { get; set; }

        /// <summary>
        /// 城市服务说明
        /// </summary>
        [XmlElement("displayapp_memo")]
		[JsonProperty("displayapp_memo", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayappMemo { get; set; }

        /// <summary>
        /// 服务别名
        /// </summary>
        [XmlElement("displayapp_name")]
		[JsonProperty("displayapp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayappName { get; set; }

        /// <summary>
        /// 状态 1:上架；0：下架；2:维护中
        /// </summary>
        [XmlElement("displayapp_status")]
		[JsonProperty("displayapp_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayappStatus { get; set; }

        /// <summary>
        /// 用户访问地址
        /// </summary>
        [XmlElement("displayapp_url")]
		[JsonProperty("displayapp_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayappUrl { get; set; }

        /// <summary>
        /// 外部展示地址
        /// </summary>
        [XmlElement("export_url")]
		[JsonProperty("export_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ExportUrl { get; set; }

        /// <summary>
        /// 属性ID
        /// </summary>
        [XmlElement("property_id")]
		[JsonProperty("property_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyId { get; set; }
    }
}
