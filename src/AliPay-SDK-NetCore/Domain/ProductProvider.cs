using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductProvider Data Structure.
    /// </summary>
    [Serializable]
    public class ProductProvider : AopObject
    {
        /// <summary>
        /// 卡代英文名称 备注:淘宝交易为空
        /// </summary>
        [XmlElement("agency")]
		[JsonProperty("agency", NullValueHandling = NullValueHandling.Ignore)]
        public string Agency { get; set; }

        /// <summary>
        /// 卡代中文名称 备注：淘宝交易为空
        /// </summary>
        [XmlElement("agency_name")]
		[JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }

        /// <summary>
        /// 业务 类型
        /// </summary>
        [XmlElement("biz_type")]
		[JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        /// 充值产品主表ID
        /// </summary>
        [XmlElement("id")]
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [XmlElement("sub_biz_type")]
		[JsonProperty("sub_biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubBizType { get; set; }

        /// <summary>
        /// 子运营商英文名称 备注:淘宝交易为空
        /// </summary>
        [XmlElement("sub_operator")]
		[JsonProperty("sub_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string SubOperator { get; set; }

        /// <summary>
        /// 子运营商中文名称 ,如浙江移动
        /// </summary>
        [XmlElement("sub_operator_name")]
		[JsonProperty("sub_operator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubOperatorName { get; set; }
    }
}
