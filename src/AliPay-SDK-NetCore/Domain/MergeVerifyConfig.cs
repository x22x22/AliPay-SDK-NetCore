using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     MergeVerifyConfig Data Structure.
    /// </summary>
    [Serializable]
    public class MergeVerifyConfig : AopObject
    {
        /// <summary>
        ///     可以与任意其他券叠加
        /// </summary>
        [XmlElement("general_merge_others")]
        [JsonProperty("general_merge_others", NullValueHandling = NullValueHandling.Ignore)]
        public bool GeneralMergeOthers { get; set; }

        /// <summary>
        ///     全场和单品叠加标识
        /// </summary>
        [XmlElement("general_merge_single")]
        [JsonProperty("general_merge_single", NullValueHandling = NullValueHandling.Ignore)]
        public bool GeneralMergeSingle { get; set; }
    }
}