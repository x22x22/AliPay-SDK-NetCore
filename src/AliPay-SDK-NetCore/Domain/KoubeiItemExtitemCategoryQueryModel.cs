using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiItemExtitemCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemCategoryQueryModel : AopObject
    {
        /// <summary>
        ///     父品类编码. (查询顶级类目时值传0)
        /// </summary>
        [XmlElement("parent_id")]
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }
    }
}