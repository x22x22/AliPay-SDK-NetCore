using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsApplication Data Structure.
    /// </summary>
    [Serializable]
    public class InsApplication : AopObject
    {
        /// <summary>
        ///     投保参数 ,每个产品特有的投保参数,如航空险的航班信息;标准json格式
        /// </summary>
        [XmlElement("biz_data")]
        [JsonProperty("biz_data", NullValueHandling = NullValueHandling.Ignore)]
        public string BizData { get; set; }

        /// <summary>
        ///     份数
        /// </summary>
        [XmlElement("copies")]
        [JsonProperty("copies", NullValueHandling = NullValueHandling.Ignore)]
        public long Copies { get; set; }

        /// <summary>
        ///     失效时间
        /// </summary>
        [XmlElement("effect_end_time")]
        [JsonProperty("effect_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectEndTime { get; set; }

        /// <summary>
        ///     生效时间
        /// </summary>
        [XmlElement("effect_start_time")]
        [JsonProperty("effect_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectStartTime { get; set; }

        /// <summary>
        ///     保险标的
        /// </summary>
        [XmlElement("ins_object")]
        [JsonProperty("ins_object", NullValueHandling = NullValueHandling.Ignore)]
        public InsObject InsObject { get; set; }

        /// <summary>
        ///     被保险人
        /// </summary>
        [XmlElement("insured")]
        [JsonProperty("insured", NullValueHandling = NullValueHandling.Ignore)]
        public InsPerson Insured { get; set; }

        /// <summary>
        ///     险种保障期限,数字+"Y/M/D"结尾,非固定期限险种或多固定期限险种必填
        /// </summary>
        [XmlElement("period")]
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        ///     保费
        /// </summary>
        [XmlElement("premium")]
        [JsonProperty("premium", NullValueHandling = NullValueHandling.Ignore)]
        public long Premium { get; set; }

        /// <summary>
        ///     保额
        /// </summary>
        [XmlElement("sum_insured")]
        [JsonProperty("sum_insured", NullValueHandling = NullValueHandling.Ignore)]
        public long SumInsured { get; set; }
    }
}