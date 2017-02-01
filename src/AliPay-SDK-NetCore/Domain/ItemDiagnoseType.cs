using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ItemDiagnoseType Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDiagnoseType : AopObject
    {
        /// <summary>
        ///     类型
        /// </summary>
        [XmlElement("item_diagnose")]
        [JsonProperty("item_diagnose", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemDiagnose { get; set; }

        /// <summary>
        ///     对类型的描述
        /// </summary>
        [XmlElement("item_diagnose_desc")]
        [JsonProperty("item_diagnose_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemDiagnoseDesc { get; set; }
    }
}