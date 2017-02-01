using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarPromoTicketSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarPromoTicketSyncModel : AopObject
    {
        /// <summary>
        ///     营销活动ID
        /// </summary>
        [XmlElement("active_id")]
        [JsonProperty("active_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveId { get; set; }

        /// <summary>
        ///     需要同步的卡券信息
        /// </summary>
        [XmlArray("code_no_list")]
        [XmlArrayItem("code_n_o_list")]
        public List<CodeNOList> CodeNoList { get; set; }

        /// <summary>
        ///     卡券来源
        /// </summary>
        [XmlElement("source_type")]
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceType { get; set; }
    }
}