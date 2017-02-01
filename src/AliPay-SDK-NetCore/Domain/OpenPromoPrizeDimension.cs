using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     OpenPromoPrizeDimension Data Structure.
    /// </summary>
    [Serializable]
    public class OpenPromoPrizeDimension : AopObject
    {
        /// <summary>
        ///     时间维度,  W：表示 周[1,4,5]  MIOD：表示 每天X分钟[0,1439]
        /// </summary>
        [XmlElement("dimension")]
        [JsonProperty("dimension", NullValueHandling = NullValueHandling.Ignore)]
        public string Dimension { get; set; }

        /// <summary>
        ///     参考dimension 后面的值
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("number")]
        public List<long> Values { get; set; }
    }
}