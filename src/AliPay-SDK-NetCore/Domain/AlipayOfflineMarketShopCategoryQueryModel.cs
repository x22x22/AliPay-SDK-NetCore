using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineMarketShopCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketShopCategoryQueryModel : AopObject
    {
        /// <summary>
        ///     类目ID，如果为空则查询全部类目。
        /// </summary>
        [XmlElement("category_id")]
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }

        /// <summary>
        ///     表示接口业务的调用方身份,默认不填标识为ISV。
        /// </summary>
        [XmlElement("op_role")]
        [JsonProperty("op_role", NullValueHandling = NullValueHandling.Ignore)]
        public string OpRole { get; set; }
    }
}