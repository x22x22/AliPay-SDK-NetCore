using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiMarketingDataTradeHabbitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataTradeHabbitQueryModel : AopObject
    {
        /// <summary>
        ///     业务日期
        /// </summary>
        [XmlElement("biz_date")]
        [JsonProperty("biz_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BizDate { get; set; }

        /// <summary>
        ///     门店列表,门店用逗号分割，最多支持10个门店。  不填时,则为商户维度汇总数据
        /// </summary>
        [XmlElement("store_ids")]
        [JsonProperty("store_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreIds { get; set; }
    }
}