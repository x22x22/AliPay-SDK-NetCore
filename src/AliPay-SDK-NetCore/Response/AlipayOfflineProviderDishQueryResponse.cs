using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderDishQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderDishQueryResponse : AopResponse
    {
        /// <summary>
        /// 总共有多少条菜品信息。可用于计算分页。
        /// </summary>
        [XmlElement("items")]
		[JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public long Items { get; set; }

        /// <summary>
        /// 菜品列表信息
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("isv_shop_dish_model")]
        public List<IsvShopDishModel> List { get; set; }

        /// <summary>
        /// 当前数据所在的页码数
        /// </summary>
        [XmlElement("page")]
		[JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public long Page { get; set; }

        /// <summary>
        /// 当前查询结果分页的条数，可用于计算分页
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long PageSize { get; set; }

        /// <summary>
        /// 当前条件下查询结果总的页码数
        /// </summary>
        [XmlElement("pages")]
		[JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public long Pages { get; set; }
    }
}
