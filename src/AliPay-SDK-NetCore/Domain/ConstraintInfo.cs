using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ConstraintInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConstraintInfo : AopObject
    {
        /// <summary>
        ///     人群规则组ID  仅直发奖类型活动设置有效，通过调用营销活动人群组规则创建接口参数返回
        /// </summary>
        [XmlElement("crowd_group_id")]
        [JsonProperty("crowd_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdGroupId { get; set; }

        /// <summary>
        ///     针对指定人群的约束条件
        /// </summary>
        [XmlElement("crowd_restriction")]
        [JsonProperty("crowd_restriction", NullValueHandling = NullValueHandling.Ignore)]
        public string CrowdRestriction { get; set; }

        /// <summary>
        ///     单品码列表  仅在创建消费单品送活动时设置，最多设置500个单品码,由商户根据自己的商品管理自定义，一般为国标码
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        ///     最低消费金额，单位元  仅在创建消费送礼包活动时设置
        /// </summary>
        [XmlElement("min_cost")]
        [JsonProperty("min_cost", NullValueHandling = NullValueHandling.Ignore)]
        public string MinCost { get; set; }

        /// <summary>
        ///     活动适用的门店列表  仅品牌商发起的招商活动可为空  最多支持10w家门店
        /// </summary>
        [XmlArray("suit_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitShops { get; set; }

        /// <summary>
        ///     活动期间用户能够参与的次数限制  如果不设置则不限制参与次数
        /// </summary>
        [XmlElement("user_win_count")]
        [JsonProperty("user_win_count", NullValueHandling = NullValueHandling.Ignore)]
        public string UserWinCount { get; set; }

        /// <summary>
        ///     活动期间用户能够参与的频率限制  如果不设置则不限制参与频率  每日中奖1次: D||1   每周中奖2次: W||2   每月中奖3次: M||3
        /// </summary>
        [XmlElement("user_win_frequency")]
        [JsonProperty("user_win_frequency", NullValueHandling = NullValueHandling.Ignore)]
        public string UserWinFrequency { get; set; }
    }
}